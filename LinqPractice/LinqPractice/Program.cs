using System;
using System.IO;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowFilesWithoutLinq(path);
            Console.WriteLine("******************");
            ShowFilesWithLinq(path);
            Console.ReadLine();
        }

        private static void ShowFilesWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;
            foreach(var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }


        //search files without linq
        public static void ShowFilesWithoutLinq(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();

            Array.Sort(files, new FileInfoComparer()); //sort the array of files
            for(int i=0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }
    }


}
