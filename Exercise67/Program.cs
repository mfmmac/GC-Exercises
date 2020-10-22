using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise67
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = "NumberFile";
            FileUtility.CreateFile(fileName);
            FileUtility.WriteToFile(fileName);
            FileUtility.ReadFromfile(fileName);
        }
    }
}
 