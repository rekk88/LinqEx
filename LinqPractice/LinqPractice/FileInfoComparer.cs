using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y) //returns -1 if x < y || 0 if x == y || 1 if x > y
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
