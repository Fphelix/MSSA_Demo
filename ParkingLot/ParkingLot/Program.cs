using System;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ParkingLot park = new ParkingLot(2, 2, 2);

            //Console.WriteLine("What size do you want to park ?");

            //string input = Console.ReadLine();
            //input = input.ToLower();

            Console.WriteLine(park.AddCar("Large"));
           
             
             
        }
    }
}
