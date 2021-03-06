using System;

namespace BulletProof
{
    class Program
    {
        static void Main(string[] args)
        {

           int  number1 = checkInt();
           double number2=  checkDouble();
            //Console.WriteLine($"you typed {number1}");
            //Console.WriteLine($"you typed {number2}");

        }

        static int checkInt()
        {
            int number1 = 0;
            bool parsedNumber = true;

            while (parsedNumber == true)
            {

                try
                {
                    Console.WriteLine("Enter an int number");
                    number1 = int.Parse(Console.ReadLine());
                    parsedNumber = false;
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
            return number1;
        }

        static double checkDouble()
        {
            double number2 = 0;
            bool parsedNumber = false;

            while (parsedNumber == false)
            {

                Console.WriteLine(" Enter a double");
                number2 = double.Parse(Console.ReadLine());
                parsedNumber = true;

            }
            return number2;
        }


   


    }
}
