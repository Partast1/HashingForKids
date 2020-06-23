using System;
using System.IO;
using System.Security.Cryptography;

namespace HashingForKids
{
    public class Program
    {

        public static void Main(String[] args)
        {
            //Class instantiation  
            Path path = new Path();
            DirectoryCheck directoryCheck = new DirectoryCheck();
            HashingDirectory hashing = new HashingDirectory();
            StandardMessages standard = new StandardMessages();

            string pathLocation;
            Console.WriteLine(standard.FindDirectoryMessage());
            pathLocation = path.GetPath();
            directoryCheck.CheckDirectory(pathLocation);
            hashing.Hashing(pathLocation);
        }
    }
}