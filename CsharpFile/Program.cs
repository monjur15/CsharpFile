using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"D:\Temp\Demos\FileSystem";
            string[] dirs = Directory.GetDirectories(rootPath);
            

            foreach (var dir in dirs)
            {
                Console.WriteLine(dir);

            }
            Console.ReadLine();
        }
    }
}
