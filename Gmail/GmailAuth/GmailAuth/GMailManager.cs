using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Util.Store;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailAuth
{
    public class GMailManager
    {
        static string[] Scopes = { GmailService.Scope.GmailReadonly };
        static string ApplicationName = "GMail API Test";
        UserCredential credential;
        public void Authenticate()
        {
            credential = GetCredentials();
            var service = GetService(credential);
            var request = service.Users.Labels.List("me");
            string labels = ListLabels(request);
            MessageBox.Show(labels);
        }

        public void SendEmail(string senderAddress, string address, string body, string attachmentPath)
        {
            credential = GetCredentials();
            var service = GetService(credential);
            System.Net.Mail.MailMessage message = CreateMimeMessage(senderAddress, address, body);
            var gmailMessage = new Google.Apis.Gmail.v1.Data.Message
            {
                Raw = Base64UrlEncode(message.ToString())
            };
            Google.Apis.Gmail.v1.UsersResource.MessagesResource.SendRequest request = service.Users.Messages.Send(gmailMessage, senderAddress);

           var result = request.Execute();

            MessageBox.Show($"Mail sent - {result.Id}");
        }
        private static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            // Special "url-safe" base64 encode.
            return Convert.ToBase64String(inputBytes)
              .Replace('+', '-')
              .Replace('/', '_')
              .Replace("=", "");
        }

        private MailMessage CreateMimeMessage(string senderAddress, string address, string body)
        {
            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new System.Net.Mail.MailAddress(senderAddress);
            mailMessage.To.Add(new System.Net.Mail.MailAddress(address));
            mailMessage.ReplyToList.Add(new System.Net.Mail.MailAddress(senderAddress));
            mailMessage.Subject = "Test Msg";
            mailMessage.IsBodyHtml = false;
            mailMessage.Body = body;
            return mailMessage;
        }

        private string ListLabels(UsersResource.LabelsResource.ListRequest request)
        {
            var labels = request.Execute().Labels;
            StringBuilder text = new StringBuilder("Labels : ");
            if(labels != null && labels.Count > 0)
            {
                foreach (var label in labels)
                {
                    text.Append($" {label}\n");
                }
            }
            else
            {
                text.Append("None!");
            }
            return text.ToString();
        }

        private GmailService GetService(UserCredential credential)
        {
            return new GmailService(
                new Google.Apis.Services.BaseClientService.Initializer
                {
                    HttpClientInitializer = credential,
                    ApplicationName = GMailManager.ApplicationName
                });
        }

        private UserCredential GetCredentials()
        {
            UserCredential credential;
            using(var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-api-test.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)
                    ).Result;

                MessageBox.Show($"Credential file saved to: {credPath}");
            }
            return credential;
        }

    }
}
