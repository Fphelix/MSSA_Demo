using System;

namespace Mathematical_Formulas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
             // Partially worked example
             Console.WriteLine("\nPart 1, circumference and area of a circle.");
             Console.Write("Enter an integer for the radius: ");
             string strradius = Console.ReadLine();
             int intradius = int.Parse(strradius);
             double circumference = Math.Round((2 * Math.PI * intradius),2);
             Console.WriteLine($"The circumference is {circumference}");

             // Implementation for area here
             double area = Math.Round ( (intradius * intradius * Math.PI),2);

             Console.WriteLine($"The area is {area}");
            
            
 
            //// Part 2
            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an integer for the radius: ");
            string strH_Rad = Console.ReadLine();
            int H_Rad = int.Parse(strH_Rad);
            double cubic = MathF.Pow(H_Rad, 3);
            //Console.WriteLine(cubic);
            double volume = Math.Round(((4 * Math.PI * cubic) /6),2);
            
            // Implementation here
            Console.WriteLine($"The volume is {volume}");
           
            
             // Part 3
             Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.WriteLine(" Enter the length of a");
            string Str_a = Console.ReadLine();
            int a = int.Parse(Str_a);
            Console.WriteLine(" Enter the length of b");
            string Str_b = Console.ReadLine();
            int b = int.Parse(Str_b);
            Console.WriteLine(" Enter the length of c");
            string Str_c = Console.ReadLine();
            int c = int.Parse(Str_c);
            // Implementation here

            double p = (double)(a + b + c)/2;
            Console.WriteLine(" The half circumference of the Triangle is " +p);
            double Triangle = p * ((p - a) * (p - b) * (p - c));
            double Triangle_Area = Math.Sqrt(Triangle);

            Console.WriteLine($"The area is {Triangle_Area}");
            
                  


             // Part 4

            // Getting coefficients

             Console.WriteLine("\nPart 4, solving a quadratic equation.");
            Console.WriteLine(" Enter the coefficient of a");
            string Str_a = Console.ReadLine();
            int a = int.Parse(Str_a);
            Console.WriteLine(" Enter the coefficient of b");
            string Str_b = Console.ReadLine();
            int b = int.Parse(Str_b);
            Console.WriteLine(" Enter the coefficient of c");
            string Str_c = Console.ReadLine();
            int c = int.Parse(Str_c);

            // Calculations

            double b_Squared = MathF.Pow(b, 2);
            double Sqr_rt = Math.Sqrt(b_Squared - 4*(a * c));
            Console.WriteLine("The square root is " +Sqr_rt);
            double positive_num = (-b + Sqr_rt);
            double negative_num = (-b - Sqr_rt);
            double denominator = 2 * a;
            //Console.WriteLine(denominator);
            Console.WriteLine(positive_num);
            Console.WriteLine(negative_num);                  

            // Implementation here
             Console.WriteLine($"The positive solution is {positive_num / denominator}");
             Console.WriteLine($"The negative solution is {negative_num / denominator}");
           
        }


    }
}
