using System;
using System.Collections.Generic;
using System.Text;

namespace HashingForKids
{
    class PrintByteArray
    {
        //Printes out the Hashed key
        public void Print(byte[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:X2}");
                if ((i % 4) == 3) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
