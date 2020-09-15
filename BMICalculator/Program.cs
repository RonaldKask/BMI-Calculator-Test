using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();
            

            Console.WriteLine($"Hello {Name}, how old are you?");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age <= 20)
            {
                Console.WriteLine("You are too young for this test.");
            } else if (Age >= 60)
            {
                Console.WriteLine("You are too old for this test.");
            } else
            {
                Console.WriteLine("Enter your height (in meters): ");
            }
            double Height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight: ");

            double Weight = Double.Parse(Console.ReadLine());

            double BMI = Weight / (Height * Height);

            if(BMI < 19)
            {
                Console.WriteLine($"{Name}, your BMI scale is {BMI} and you are underweight.");
            }else if(BMI <= 24.9)
            {
                Console.WriteLine($"{Name}, your BMI scale is {BMI} and you have an average body weight.");
            }else if(BMI <= 29.9)
            {
                Console.WriteLine($"{Name}, your  BMI scale is {BMI} and you are overweight.");
            }else if(BMI >= 30)
            {
                Console.WriteLine($"{Name}, your BMI scale is {BMI} and you are obese.");
            }else
            {
                Console.WriteLine("Please make sure you followed the instructions correctly.");
            }
        }
    }
}
