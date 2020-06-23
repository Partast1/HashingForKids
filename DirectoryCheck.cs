using System;
using System.Collections.Generic;
using System.Text;

namespace HashingForKids
{
    class DirectoryCheck
    {
        //Checks if directory is empty
        public void CheckDirectory(String path)
        {
            if (path.Length < 1)
            {
                Console.WriteLine("No directory selected.");
                return;
            }
        }
    }
}
