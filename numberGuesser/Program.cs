using System;

namespace numberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            GetAppInfo();//Getting App Info From A Function
            GreetUser();
            do
            {
                //Init a num
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Init  guessNum

                int guess = 0;

                //Ask to enter a number
                Console.WriteLine("Enter a number Between 1 and 10");

                //Loop until correct number is found 
                while (guess != correctNumber)
                {
                    //taking the number
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please Enter a Number");

                        //Keep going
                        continue;
                    }


                    //parse input guess
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number,Please Try again");
  
                    }
                }
                PrintColorMessage(ConsoleColor.Green, "Hooray,You are Correct!!!");
                //ask does player wants to play the game again
                Console.WriteLine("Do You want play again,is so press 'y'");
                string v = Console.ReadLine();
                answer = v;
            } while (answer=="y");
             

        }

        static void GetAppInfo()
        {  
            //Application details
            string appName = "Number Guesser";
            string appVersion = "1.0.";
            string appDeveloper = "SUbbU";
            //Changing the console color 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} : {1} by {2}", appName, appVersion, appDeveloper);
            //Reset Text Color
            Console.ResetColor();
        }
        static void GreetUser()
        {

            //Asking the user name

            Console.WriteLine("What is you name");
            // taking user input

            String name = Console.ReadLine();
            Console.WriteLine("Hello {0},Lets play a game", name);

        }

        static void PrintColorMessage(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            //Reset Text Color
            Console.ResetColor();
        }
    }
}
