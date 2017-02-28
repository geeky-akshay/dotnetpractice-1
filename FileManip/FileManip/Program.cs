
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManip
{
    class Program
    {
        private const string READ_TAG = "-r";
        private const string WRITE_TAG = "-w";
        private const string COUNT_TAG = "-n";
        private const string TEXT_TAG = "-t";

        static void Main(string[] args)
        {
            IFileOperator fileOp = new FileOperator();
            ActBasedOnTag(args, fileOp);
        }

        private static void ActBasedOnTag(string[] args, IFileOperator fileOp)
        {
            string inputText = null;
            for (int i = 0; i < args.Length - 1; i++)
            {
                switch (args[i])
                {
                    case READ_TAG:
                        {
                            Console.WriteLine($"File Text : {fileOp.ReadFile(args[i + 1])}");
                            break;
                        }
                    case COUNT_TAG:
                        {
                            Console.WriteLine($"Characters in file : {fileOp.GetNumberOfCharacters(args[i+1])}");
                            break;
                        }
                    case TEXT_TAG:
                        {
                            inputText = args[i + 1];
                            break;
                        }
                    case WRITE_TAG:
                        {
                            fileOp.WriteToFile(args[i + 1], inputText);
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
