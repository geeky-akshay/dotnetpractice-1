using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManip
{
    class FileOperator : IFileOperator
    {
        public int GetNumberOfCharacters(string filepath)
        {
            return this.ReadFile(filepath).OfType<char>().Count();
        }

        public string ReadFile(string filepath)
        {
            if (string.IsNullOrEmpty(filepath))
                throw new ArgumentNullException(nameof(filepath));
            return System.IO.File.ReadAllText(filepath);
        }

        public void WriteToFile(string filepath, string text = null)
        {
            if (string.IsNullOrEmpty(filepath))
                throw new ArgumentNullException(nameof(filepath));
            if (text == null)
                text = string.Empty;
            System.IO.File.WriteAllText(filepath, text);
        }
    }
}
