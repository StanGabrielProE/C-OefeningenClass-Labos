namespace EscapeRooms

{

    public class EscapeRoom
    {
        private TimeSpan _span = new TimeSpan(0, 15, 0);
        private bool _firstGame = false;
        private bool _secondGame = false;
        private bool _thirdGame = false;


        private EscapeRoom()
        {
            Intro();
            ShowIntro();
            StartGame();
        }
        public static void StartTheGame()
        {
            EscapeRoom room = new EscapeRoom();
        }

        public void Intro()
        {
            Console.Clear();
            Console.WriteLine(@"
 ___                         ___
| __|___ __ __ _ _ __  ___  | _ \___  ___ _ __
| _|(_-</ _/ _` | '_ \/ -_) |   / _ \/ _ \ '  \
|___/__/\__\__,_| .__/\___| |_|_\___/\___/_|_|_|
                |_|
================================================
");

        }

        void ShowIntro()
        {
            Console.WriteLine("Solve the puzzles before time runs out!");
            Console.WriteLine("Press enter to start your adventure...");
            Console.ReadLine();
        }

        static void ShowColoredText(string text, ConsoleColor color, bool newLine)
        {
            Console.ForegroundColor = color;
            if (newLine)
                Console.WriteLine(text);
            else
                Console.Write(text);
            Console.ResetColor();
        }

        private void ShowMenu()
        {
            ShowColoredText("Choose an action:", ConsoleColor.White, true);
            ShowColoredText("  1) Try keypad", _firstGame ? ConsoleColor.Green : ConsoleColor.White, true);
            ShowColoredText("  2) Solve riddle", _secondGame ? ConsoleColor.Green : ConsoleColor.White, true);
            ShowColoredText("  3) Open final door", _thirdGame ? ConsoleColor.Green : ConsoleColor.White, true);
            ShowColoredText("  9) Give up", ConsoleColor.White, true);
            ShowColoredText("Your choice: ", ConsoleColor.White, false);



        }
        async Task Timer()
        {
            while (_span > TimeSpan.Zero)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write("Time Left: " + _span.ToString(@"mm\:ss") + "   ");
                _span = _span - TimeSpan.FromSeconds(1);
                await Task.Delay(1000);
            }

            Console.WriteLine("\nTime's up!");
        }

        static void Run()
        {
            EscapeRoom room = new EscapeRoom();

        }
        async void StartGame()
        {

            ShowMenu();

            var timerTask = Task.Run(() => Timer());


            do
            {
                int choice = userChoice();
                UserInputChoice(choice);

                if (_firstGame && _secondGame && _thirdGame)
                {
                    Console.Clear();
                 ShowColoredText("Congrats you won the game",ConsoleColor.Green,true);
                    break;
                }
                if (_span <= new TimeSpan(0, 0, 0))
                {

                    Console.WriteLine("Game Over");
                }
            } while (_span > new TimeSpan(0, 0, 0));
            await timerTask;
            Console.ReadKey();
        }





        int userChoice()
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                return choice;
            }
            return -1;
        }



        public void FirstGame(ref TimeSpan span, out bool firstGame)
        {
            Console.WriteLine("You have to enter a pincode (3 Numbers are required) ");

            Console.WriteLine("{0} minutes left", span);
            firstGame = false;
            Console.WriteLine("Een gehele getaal van 3 cijfers met de laatste tussen 2..5");

            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            LoopForGame(ref number, ref span, out firstGame);
        }

        void ThirdGame(ref TimeSpan span, out bool firstGame)
        {
            Console.WriteLine("You have to enter a number between 2...5 ");

            Console.WriteLine("{0} minutes left", span);
            firstGame = false;
            Console.WriteLine("Een gehele getaal  tussen 2..5");

            bool isValid = int.TryParse(Console.ReadLine(), out int number);
            LoopForGame3(ref number, ref span, out firstGame);
        }


        void LoopForGame3(ref int number, ref TimeSpan span, out bool isTrue)
        {
            Console.WriteLine("Guess the number , between 2..5");
            isTrue = false;
            int n = Random.Shared.Next(2, 6);
            Console.WriteLine("n");
            while (number != n && span > new TimeSpan(0, 0, 0))
            {
                ShowColoredText("Wrong Try Again", ConsoleColor.Red, true);


                Console.WriteLine("{0} minutes left", span);
                bool isValid = int.TryParse(Console.ReadLine(), out number);

                if (span <= new TimeSpan(0, 0, 0))
                {
                    span = new TimeSpan(0, 0, 0); break;
                }
                if (number != n)
                {


                    span -= TimeSpan.FromMinutes(2);
                    ShowColoredText("Penalty: -2 min", ConsoleColor.Red, true);

                }

            }
            if (span < new TimeSpan(0, 0, 1))
            {
                ShowColoredText("Game Over", ConsoleColor.Red, true);
            }
            else
            {
                Console.Clear();
                ShowColoredText("Congratulations", ConsoleColor.Green, true);
                isTrue = true;
                Intro();
                ShowMenu();

            }
        }


        void SecondGame(ref TimeSpan span, out bool secondGame)
        {
            ShowColoredText("You have to guess the word", ConsoleColor.Magenta, true);
           ShowColoredText("Its a progrogamming language that is objecoriented", ConsoleColor.Magenta, true);
            string input = Console.ReadLine();
            LoopForGame2(ref input, ref span, out secondGame);


        }
        void LoopForGame2(ref string language, ref TimeSpan span, out bool isTrue)
        {
            isTrue = false;

            while (language != "C#" && span > new TimeSpan(0, 0, 0))
            {
                ShowColoredText("Wrong Try Again", ConsoleColor.Red, true);

                language = Console.ReadLine();
                Console.WriteLine("{0} minutes left", span);


                if (span <= new TimeSpan(0, 0, 0))
                {
                    span = new TimeSpan(0, 0, 0); break;
                }
                if (language != "C#")
                {


                    span -= TimeSpan.FromMinutes(2);
                    ShowColoredText("Penalty: -2 min", ConsoleColor.Red, true);

                }

            }
            if (span < new TimeSpan(0, 0, 1))
            {
                ShowColoredText("Game Over", ConsoleColor.Red, true);
            }
            else
            {
                Console.Clear();
                ShowColoredText("Congratulations", ConsoleColor.Green, true);
                isTrue = true;
                Intro();
                ShowMenu();

            }
        }

        void LoopForGame(ref int number, ref TimeSpan span, out bool isTrue)
        {
            isTrue = false;
            while (number != 312 && span > new TimeSpan(0, 0, 0))
            {
                ShowColoredText("Wrong Try Again", ConsoleColor.Red, true);


                Console.WriteLine("{0} minutes left", span);
                bool isValid = int.TryParse(Console.ReadLine(), out number);

                if (span <= new TimeSpan(0, 0, 0))
                {
                    span = new TimeSpan(0, 0, 0); break;
                }
                if (number != 312)
                {


                    span -= TimeSpan.FromMinutes(2);
                    ShowColoredText("Penalty: -2 min", ConsoleColor.Red, true);

                }

            }
            if (span < new TimeSpan(0, 0, 1))
            {
                ShowColoredText("Game Over", ConsoleColor.Red, true);
            }
            else
            {
                Console.Clear();
                ShowColoredText("Congratulations", ConsoleColor.Green, true);
                isTrue = true;
                Intro();
                ShowMenu();

            }
        }



        void ShowHelp()
        {

            Console.WriteLine(" ESCAPE ROOM RULES");
            Console.WriteLine("---------------------");
            Console.WriteLine(" You have 15 minutes to escape.");
            Console.WriteLine(" Solve 3 puzzles:");
            Console.WriteLine("   1) Keypad → enter a 3-digit code 3**.");
            Console.WriteLine("   2) Riddle → guess the secret word.");
            Console.WriteLine("   3) Final door → guess a number (1–5).");
            Console.WriteLine();
            Console.WriteLine(" Penalties:");
            Console.WriteLine("   - Wrong keypad or riddle: -2 minutes.");
            Console.WriteLine("   - Wrong final door guess: -1 minute.");
            Console.WriteLine("   - Invalid menu choice: -2 minutes.");
            Console.WriteLine();
            Console.WriteLine(" You can only solve each puzzle once.");
            Console.WriteLine(" Final door only opens if both puzzles are solved.");
            Console.WriteLine(" Option 9 = give up.");
            Console.WriteLine();
            Console.WriteLine("Press enter to return to the game...");
            Console.ReadLine();
        }
        void UserInputChoice(int input)
        {
            switch (input)
            {
                case 1 when !_firstGame:
                    FirstGame(ref _span, out _firstGame); break;
                case 2 when !_secondGame:
                    if (!_firstGame)
                    {
                        _span -= TimeSpan.FromMinutes(1);
                        ShowColoredText("wrong imput -1 min", ConsoleColor.Red, true);
                        goto case 4;

                    }
                    SecondGame(ref _span, out _secondGame); break;
                case 3 when !_thirdGame:
                    if (!_secondGame)
                    {
                        _span -= TimeSpan.FromMinutes(1);
                        ShowColoredText("wrong imput -1 min", ConsoleColor.Red, true);
                        goto case 4;
                    }
                    ThirdGame(ref _span, out _thirdGame);
                    break;

                case 4:
                    ShowHelp();
                    break;
                case 9:
                    Console.Clear();
                    Console.WriteLine("Brave...");
                    _span = new TimeSpan(0, 0, 0);
                    break;
                default:

                    ShowColoredText("wrong imput -1 min", ConsoleColor.Red, true);

                    _span -= TimeSpan.FromMinutes(1);
                    break;
            }
        }

    }
}