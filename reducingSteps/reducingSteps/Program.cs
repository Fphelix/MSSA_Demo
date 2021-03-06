using System;

namespace reducingSteps
{
    class Program
    {
        static void Main(string[] args)
        {

           NumberOfSteps(8);
           


        }
        static  int NumberOfSteps(int num)
        {
        
            int count = 0;

            while (num !=0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    count++;
                   
                }  
                else if ( num %2== 1)
                {
                    num -= 1;
                    count++;
                }
                
            }
            return count;
            Console.WriteLine($" Amount of Steps : {count}");






        }
    }
}

        
        
    

