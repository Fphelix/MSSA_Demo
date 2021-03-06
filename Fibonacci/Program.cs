using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            int i2 = 1;

        for (int i = 0; i < 20; i++)
            {
                int i3 = i1 + i2;
                Console.WriteLine(i1);
                i1 = i2;
                i2 = i3;
          
            }
           

        }
    }     
}
