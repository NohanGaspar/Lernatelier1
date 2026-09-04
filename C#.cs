// create a gambling app with a balance, saved in a file. The app will contain games like roulette or blackjack

// greet player
Console.WriteLine("Wellcome to the Gambling game !");
Console.WriteLine(" ");

//create a balance for the player that will be saved in a local file.
decimal balance = 1000.00m;

// runns the game if true
bool game = true;

// create arrays for the roulette game
int[] red = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
int[] black = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
int[] green = { 0 };


try
{
    do
    {
        //explain the rules
        Console.Clear();
        Console.WriteLine("you can check your balence by typing /b in the console");
        Console.WriteLine("you can play roulette by typing /r in the console");
        Console.WriteLine("you can quit by typing /q in the console");
        Console.WriteLine("you can claim money by typing /beg in the console");
        Console.WriteLine(" ");

        // the player chooses what to do
        string choice = (Console.ReadLine());

        // claim money with a random chance of getting more or less money
        if (choice == "/beg")
        { 
            Random rnd = new Random();
            int rnd_number = rnd.Next(4);

            if (rnd_number == 0)
            {
                Console.WriteLine(" (+2000)");
                balance += 2000;
                //continue;
            }

            else if (rnd_number == 1)
            {
                Console.WriteLine(" (+100)");
                balance += 100;
                //continue;
            }

            else if (rnd_number == 2)
            {
                Console.WriteLine(" (-300)");
                balance -= 300;
                //continue;
            }

            else if (rnd_number == 3)
            {
                Console.WriteLine(" (-500)");
                balance -= 500;
                //continue;
            }
        }

        // quit the game
        if (choice == "/q")
        {
            game = false;
        }

        // shows the balance of the player
        if (choice == "/b")
        {
            Console.Clear();
            Console.WriteLine("your balance is: " + balance);
            Console.WriteLine(" ");
        }

        //add roulette and change the balance:

        if (choice == "/r")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the roulette, choose the amount to bet:");
            Console.WriteLine(" ");
            
            decimal bet1 = decimal.Parse(Console.ReadLine());

            // check if the player has enough money to bet
            if (bet1 > balance)
            {
                Console.Clear();
                Console.WriteLine("not enough money !");
                Console.WriteLine(" ");
                Console.ReadLine();
                continue;
            }

            Console.Clear() ;
            Console.WriteLine("type r to bet on red or b to bet on black");
            Console.WriteLine("type a number between 0-36 to bet on a number");
            Console.WriteLine(" ");

            // the player chooses what to bet on
            string Roulette1 = (Console.ReadLine());

            // bet on red
            if (Roulette1 == "r")
            {
                Random rnd2 = new Random();
                int number2 = rnd2.Next(37);

                if (red.Contains(number2))
                {
                    Console.Clear();
                    Console.WriteLine("Red " + number2);
                    Console.WriteLine(" ");

                    balance = balance + bet1;
                }

                else if (black.Contains(number2))
                {
                    Console.Clear();
                    Console.WriteLine("Black " + number2);
                    Console.WriteLine(" ");
                    balance = balance - bet1;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Green " + number2);
                    Console.WriteLine(" ");
                    balance = balance - bet1;
                }
            }

            // bet on black
            else if (Roulette1 == "b")
            {
                Random rnd3 = new Random();
                int number3 = rnd3.Next(37);

                if (black.Contains(number3))
                {
                    Console.Clear();
                    Console.WriteLine("Black " + number3);
                    Console.WriteLine(" ");

                    balance = balance + bet1;
                }

                else if (red.Contains(number3))
                {
                    Console.Clear();
                    Console.WriteLine("Red " + number3);
                    Console.WriteLine(" ");
                    balance = balance - bet1;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Green " + number3);
                    Console.WriteLine(" ");
                    balance = balance - bet1;
                }
            }

            // bet on a number
            else
            {
                Random rnd1 = new Random();
                int number1 = rnd1.Next(37);

                int Roulette2 = Int32.Parse(Roulette1);

                if (red.Contains(Roulette2))
                {
                    Console.Clear();
                    Console.WriteLine("Red " + number1);
                    Console.WriteLine(" ");
                }

                if (black.Contains(Roulette2))
                {
                    Console.Clear();
                    Console.WriteLine("Black " + number1);
                    Console.WriteLine(" ");
                }

                if (green.Contains(Roulette2))
                {
                    Console.Clear();
                    Console.WriteLine("Green " + number1);
                    Console.WriteLine(" ");
                }

                if (Roulette2 != number1)
                {
                    balance -= bet1;
                }

                if (Roulette2 == number1)
                {
                    balance += bet1 * 35;
                }
            }
        }

        Console.WriteLine("type enter to contiue");
        Console.ReadLine();
    }
    while (game);
} 
catch
{
    Console.Clear();
    Console.WriteLine("type a Number/Command !");
    Console.WriteLine(" ");
}
