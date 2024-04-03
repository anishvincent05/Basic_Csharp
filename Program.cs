using System;

namespace car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {   // Taking details of customer
            Console.WriteLine("What is your age?"); 
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            string stDUI = Console.ReadLine();
            bool dui = stDUI == "Yes"; 
            Console.WriteLine("How many speeding tickets do you have?");
            int speed = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Qualified?");
            Console.WriteLine(age>15 && dui==false && speed<=3);// checking conditions and giving output


        }
    }
}
