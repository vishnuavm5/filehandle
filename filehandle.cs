using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FILELL
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\project\hi.txt";
            if (!File.Exists(path))
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter you name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your id");
                    string id = Console.ReadLine();
                    sw.WriteLine("name:{0}"  , name);

                    sw.WriteLine("Id:{0}",   id);
                    // sw.Flush();
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            // string path = @"D:\DS\hi.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("Enter some text");
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine("deleting file");
            File.Delete(path);
        }
    }
}
