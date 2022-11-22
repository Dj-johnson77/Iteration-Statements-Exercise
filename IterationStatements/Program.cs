using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {

            int number = 1001;
            PositivetoNeg(number);


            int threes = 3;
            ByThree(threes);

            Console.WriteLine("Tell me you're first number and we will see if it's equal with a follow up number.");
            var firstEqual = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the second number you would like to compare to the first?");
            var secondEqual = int.Parse(Console.ReadLine());    
            Equalto(firstEqual, secondEqual);


            Console.WriteLine("Input a number to see if it is odd or even.");
            var userInput = int.Parse(Console.ReadLine());
            OddOrEven(userInput); 

            Console.WriteLine("Input a number to see if it's positive or negative");
            userInput = int.Parse(Console.ReadLine());
            PositiveOrNegative(userInput);

            Console.WriteLine("how old are you?");
            userInput = int.Parse(Console.ReadLine());
            VotingAge(userInput);

            Console.WriteLine("Type a number between -10 and 10");
            userInput = int.Parse(Console.ReadLine());
            HeatingUp(userInput);

            int a = 1;
            Console.WriteLine("Input the number you want a muliplication table for.");
            var b = int.Parse(Console.ReadLine());
            MultiTable(a, b);










        }
        public static void ByThree(int threes)
        {
            //Write a method that will print to the console numbers 3 through 999 by 3 each time

            for (int i = 3; i < 999; i++)

                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
        }
        public static void PositivetoNeg(int number)
        {
            //Write a method that will print to the console all numbers 1000 through - 1000

            do
            {
                number--;
                Console.WriteLine(number);
            } while (number > -1000);

        }
        public static void Equalto(int a, int b)
        {
            //Write a method to accept two integers as parameterss and check whether they are equal or not

            if (a == b)
            {
                Console.WriteLine("They are equal");
            }
            else Console.WriteLine("They are not equal.");

        }
        public static void OddOrEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even.");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }



        }
        public static void PositiveOrNegative(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("That is a negative number.");
            }
            else
            {
                Console.WriteLine("That is a positive number.");
            }
        }
        public static void VotingAge(int a)
        {
            if (a > 17)
            {
                Console.WriteLine("You are old enough to vote!");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote");
            }
        }
        public static void HeatingUp(int a)
        {
            if (a > -11 && a < 11)
            {
                Console.WriteLine("You are within the range");
            }
            else
            {
                Console.WriteLine("Try again!");
            }
        }
        public static void MultiTable(int a, int b)
        {

            for (a = 1; a <= 12; a++)
            {
                Console.WriteLine("{0} X {1} = {2} \n", b, a, b * a);
            }



        }




    }
}
