using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge_3
{
    internal class File_Class
    {
        static void Main()
        {
            FileStream fs;
            
                string filepath = "Challenge3.txt";
                fs = new FileStream(filepath, FileMode.Append, FileAccess.Write);
            try
            {
                StreamWriter sw = new StreamWriter(fs);
                Console.WriteLine("Enter the text to add in the file");
                string input = Console.ReadLine();
                sw.Write(input);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured : " + ex.Message);
            }
            
        }
    }
}
