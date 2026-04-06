using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Assignment_6
{

    class ReadWrite_files
    {
        public static FileStream fs;
        public void WriteStream()
        {
            FileInfo f = new FileInfo("temp.txt");
            if(f.Exists)
            {
                Console.WriteLine("File already exists");
            }
            fs = new FileStream("temp.txt",FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public void ReadStream()
        {
            fs = new FileStream("temp.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.ReadToEnd();
            sr.Close();
            fs.Close ();
        }

        public void CountLines()
        {
            int LineCount = File.ReadLines("temp.txt").Count();
            Console.WriteLine("The number of lines in the given file is " + LineCount);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadWrite_files rw = new ReadWrite_files();
            rw.WriteStream();
            rw.ReadStream();
            rw.CountLines();
        }
    }
}
