using System;
using System.IO;
using System.Linq;

namespace LinqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Func
            //this tells me that f is a function that takes an int and returns an int
            Func<int, int> Square = x => x * x;
            //this function takes 2 integers value as parameters and returns a int as a result
            Func<int, int, int> Prod = (x, y) => (x * y);

            Console.WriteLine(Square(2));
            Console.WriteLine(Prod(2, 5));
            Console.WriteLine("*******************");
            #endregion
            string path = @"C:\windows";
            ShowFilesWithoutLinq(path);
            Console.WriteLine("******************");
            ShowFilesWithLinq(path);
            Console.ReadLine();
        }

        private static void ShowFilesWithLinq(string path)
        {
            //var query = from file in new DirectoryInfo(path).GetFiles()
            //            orderby file.Length descending
            //            select file;
            //foreach(var file in query.Take(5))
            //{
            //    Console.WriteLine($"{file.Name} : {file.Length}");
            //}
            var query = new DirectoryInfo(path).GetFiles().OrderByDescending(f => f.Length).Take(5);

            foreach(var file in query)
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
