using System;
using System.Collections.Generic;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
            
        {

            OneThousand(1000,-1000);
            ThreeByThree();
            Console.WriteLine(IsEqual(2, 2));
            Console.WriteLine(IsEven(2));
            Console.WriteLine(PosOrNeg(-2));
            votingAge();
            Multiply();

        }

        //Write a method that will print to the console all numbers 1000 through -1000.
        public static void OneThousand(int max, int min)
        {
            for (int i = 1000;  i>= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time.
        public static void ThreeByThree()
        {

            for (int j = 3; j<= 999; j+= 3)
            {
                Console.WriteLine(j);
            }
        }
        //Write a method to accept two integers as parameters and check whether they are equal or not.
        public static bool IsEqual(int a,int b)
        {
            var match = a == b ?true :false;
            return match;
        }
        //Write a method to check whether a given number is even or odd.
        
        public static bool IsEven(int x)
        {
            var even = x % 2 == 0 ?true :false;
            return even;
        

        }
        //Write a method to check whether a given number is positive or negative.
        public static bool PosOrNeg(int k)
        {
            var positive =k>=0 ?true :false;
            return positive;
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void votingAge()
        {
            var age =int.Parse (Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"Go Ahead and cast your vote");
            }
            else
            {
                Console.WriteLine($"yournot old enough to vote");
            }
        }
        //Write a method to check if an integer (from the user) is in the range -10 to 10.

        public static void Tens()
        {
            var rangeCheck = int.Parse(Console.ReadLine());
            if (rangeCheck <= 10 && rangeCheck >= -10)
            {
                Console.WriteLine($"in range");
            }
            else
            {
                Console.WriteLine($" out of range");
            }


        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer.
        public static void Multiply()
        {
            var numbers = new List<int>();
            var num = 1;
            while (num < 12)
            { num++;
              numbers.Add(num);            
            }
            var input =int.Parse (Console.ReadLine());
            foreach (var item in numbers)
            {
                Console.WriteLine($"{input}*{item}={item * input}");
            }
            
        }
    }
}
