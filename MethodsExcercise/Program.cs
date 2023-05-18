using System;
using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        { 
            return num1 * num2 *num3;
        } 

        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

            //--Excercise 1
            //Name: Bryce
            //Favorite Color: Purple 
            //Favorite Animal: snake
            //Favorite Band:  The Velvet Underground 

            Console.WriteLine("Hello - what is your first name?");
                var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}. what is your favorite color?");
                var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
                var animal = Console.ReadLine();

            Console.WriteLine("Great! Now, what is your favorite band?");
                var band = Console.ReadLine();
            
            Console.WriteLine($"Thanks, {userName}! Here is your profile");
            Console.WriteLine("-------------------------------");     

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

            //-------------------------Excercise 2




        }
    }
}