namespace IterationStatements
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            //CountDown();
            //CountByThree();
            //CheckIfEqual(6, 6);
            //CheckEvenOrOdd(2);
            //CheckPositiveNegative(7);
            //CheckIfVote(19);
            //Console.WriteLine("Enter a number:");
            //var input = Console.ReadLine();
            //var number = int.Parse(input);
            //CheckRange(number);
            //Console.WriteLine("Enter a number (1-12) to display its multiplication table:");
            //var input = Console.ReadLine();
            //var number = int.Parse(input);
            //MultiplicationTable(number);
        }


        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void CountDown()
        {
            for (int i = 1000; i >= -1000; i--)
                Console.WriteLine(i);
        }
            
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void CountByThree()
        {
            for (int i = 3; i <=999; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void CheckIfEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void CheckEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void CheckPositiveNegative(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative.");
            }
            else
            {
                Console.WriteLine($"{num} is zero.");
            }
        } 
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void CheckIfVote(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Can vote");
            }
            else
            {
                Console.WriteLine("Can not vote");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void CheckRange(int num)
        {
            var message = (num >= -10 && num <= 10)
                ? $"{num} is in the range of -10 to 10." : $"{num} is not in the range of -10 to 10.";

            Console.WriteLine(message);
        }
            //Write a method to display the multiplication table(from 1 to 12) of a given integer
            public static void MultiplicationTable(int num)
        {
            for (var i =1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        //below this line is a new conept for me and stored it here. 
        public static string UserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;

        }


    }


}
