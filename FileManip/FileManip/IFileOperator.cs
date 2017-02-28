using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManip
{
    interface IFileOperator
    {
        string ReadFile(string filepath);
        int GetNumberOfCharacters(string filepath);
        void WriteToFile(string filepath, string text = null);
    }
}
