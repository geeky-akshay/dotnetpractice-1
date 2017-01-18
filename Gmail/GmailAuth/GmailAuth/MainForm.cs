using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmailAuth
{
    public partial class MainForm : Form
    {
        GMailManager mail;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mail = new GMailManager();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            mail.Authenticate();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mail.SendEmail(txtFrom.Text, txtTo.Text, txtMailBody.Text, txtAttachmentPath.Text);
        }
    }
}
