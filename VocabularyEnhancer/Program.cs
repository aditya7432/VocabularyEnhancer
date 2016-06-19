using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace VocabularyEnhancer
{
    class Program
    {
        public static string NewLine = Environment.NewLine;
        public static string Space = "\t" + "\t" + "\t" + "\t";
        public static int Chances, Marks;


        static int ReadWordsFromFile1(string[] words)
        {
            //getting path of Level1 words from the following location   
            string filename = "C:\\Users\\username\\Desktop\\Level1words.txt";


            if (File.Exists(filename) == false)

                return -1;
            //reading the words from  file   
            StreamReader s = new StreamReader(filename);

            int count = 0;

            for (int i = 0; i < 50; i++)
            {

                if (s.EndOfStream == true)

                    break;

                words[count++] = s.ReadLine();


            }

            s.Close();

            return count;

        }
        static int ReadWordsFromFile2(string[] words)
        {
            //getting path of Level2 words from the following location   
            string filename = "C:\\Users\\username\\Desktop\\Level2words.txt";


            if (File.Exists(filename) == false)

                return -1;
            //reading the words from  file   
            StreamReader s = new StreamReader(filename);

            int count = 0;

            for (int i = 0; i < 50; i++)
            {

                if (s.EndOfStream == true)

                    break;

                words[count++] = s.ReadLine();


            }

            s.Close();

            return count;

        }
        static int ReadWordsFromFile3(string[] words)
        {
            //getting path of Level3 words from the following location   
            string filename = "C:\\Users\\username\\Desktop\\Level3words.txt";


            if (File.Exists(filename) == false)

                return -1;
            //reading the words from  file   
            StreamReader s = new StreamReader(filename);

            int count = 0;

            for (int i = 0; i < 50; i++)
            {

                if (s.EndOfStream == true)

                    break;

                words[count++] = s.ReadLine();


            }

            s.Close();

            return count;

        }
        static void Main(string[] args)
        {

            GameMode();


        }

        private static void Level1Mode()
        {

            Chances = CountUtility.SetChances;
            Marks = CountUtility.Setmarks; ;

            Console.WriteLine("Chances:" + " " + Chances + "\t" + "\t" + " Marks:" + " " + Marks + "\t" + "\t" + "\t" + "Time Elapsed:");
            Console.WriteLine(NewLine + Space + "Welcome to VocEnhancer" + NewLine + NewLine + NewLine);
            if (Chances == 0)
            {
                Console.Clear();
                Console.WriteLine("Number of Chances Over,Please Press P to Play again or Press Q to Quit");
                string Option = Console.ReadLine();
                if (Option == "P" || Option == "p")
                {
                    Console.Clear();
                    GameMode();

                }


            }
            string[] words = new string[50];

            int count = ReadWordsFromFile1(words);
            Random r = new Random();

            string hint = HintUtilityClass1.GetHints();
            int guessX = (int)(r.Next(count));
            //getting guess words   
            String secretWord = words[guessX];
            //getting the length of guess word   
            int numChars = secretWord.Length;
            Console.Write(Space + hint + NewLine + NewLine + NewLine + NewLine + NewLine + NewLine);
            Console.Write("\t" + "Total Charcters:" + " " + numChars + NewLine);
            Console.WriteLine();
            bool bGuessedCorrectly = false;

            Console.WriteLine("\t" + "Write flip for Next word: " + NewLine + NewLine + "\t" + "Guess:");
            while (true & Chances > 0)
            {
                //for changing  word by wrtting flip   
                string choice = Console.ReadLine();
                if (choice == "flip")
                {
                    Console.Clear();
                    Level1Mode();

                }

                if (choice == secretWord)
                {

                    bGuessedCorrectly = true;

                    break;

                }
                else
                {

                    bGuessedCorrectly = false;

                    break;

                }

            }

            if (bGuessedCorrectly == false)
            {
                Chances--; //decreasing chances on every wrong attempt   
                CountUtility.SetChances = Chances;
                Console.WriteLine(" your Guess Is Not correct" + NewLine);
                Console.WriteLine("Please Enter to stay Playing");
            }


            else
            {
                Marks++; //counting marks for each correct answer   
                CountUtility.Setmarks = Marks;
                Console.WriteLine(NewLine + "Congrats!" + NewLine);
                Console.WriteLine("Please Enter to stay Playing....");

            }
            Console.ReadLine();

            Console.Clear();

            Level1Mode();


        }
        private static void Level2Mode()
        {
            //Level2 game mode logic or as same you can do it for Level2 and Level2   
            Chances = CountUtility.SetChances;
            Marks = CountUtility.Setmarks; ;

            Console.WriteLine("Chances:" + " " + Chances + "\t" + "\t" + " Marks:" + " " + Marks + "\t" + "\t" + "\t" + "Time Elapsed:");
            Console.WriteLine(NewLine + Space + "Welcome to VocEnhancer" + NewLine + NewLine + NewLine);
            if (Chances == 0)
            {
                Console.Clear();
                Console.WriteLine("Number of Chances Over,Please Press P to Play again or Press Q to Quit");
                string Option = Console.ReadLine();
                if (Option == "P" || Option == "p")
                {
                    Console.Clear();
                    GameMode();

                }


            }
            string[] words = new string[50];

            int count = ReadWordsFromFile2(words);
            Random r = new Random();

            string hint = HintUtilityClass2.GetHints();
            int guessX = (int)(r.Next(count));
            //getting guess words   
            String secretWord = words[guessX];
            //getting the length of guess word   
            int numChars = secretWord.Length;
            Console.Write(Space + hint + NewLine + NewLine + NewLine + NewLine + NewLine + NewLine);
            Console.Write("\t" + "Total Charcters:" + " " + numChars + NewLine);
            Console.WriteLine();
            bool bGuessedCorrectly = false;

            Console.WriteLine("\t" + "Write flip for Next word: " + NewLine + NewLine + "\t" + "Guess:");
            while (true & Chances > 0)
            {
                //for changing  word by wrtting flip   
                string choice = Console.ReadLine();
                if (choice == "flip")
                {
                    Console.Clear();
                    Level2Mode();

                }

                if (choice == secretWord)
                {

                    bGuessedCorrectly = true;

                    break;

                }
                else
                {

                    bGuessedCorrectly = false;

                    break;

                }

            }

            if (bGuessedCorrectly == false)
            {
                Chances--; //decreasing chances on every wrong attempt   
                CountUtility.SetChances = Chances;
                Console.WriteLine(" your Guess Is Not correct" + NewLine);
                Console.WriteLine("Please Enter to stay Playing");
            }


            else
            {
                Marks++; //counting marks for each correct answer   
                CountUtility.Setmarks = Marks;
                Console.WriteLine(NewLine + "Congrats!" + NewLine);
                Console.WriteLine("Please Enter to stay Playing....");

            }
            Console.ReadLine();

            Console.Clear();

            Level2Mode();
        }



        private static void Level3Mode()
        {
            //Level3 game mode logic or as same you can do it for Level3 and Level3   
            Chances = CountUtility.SetChances;
            Marks = CountUtility.Setmarks; ;

            Console.WriteLine("Chances:" + " " + Chances + "\t" + "\t" + " Marks:" + " " + Marks + "\t" + "\t" + "\t" + "Time Elapsed:");
            Console.WriteLine(NewLine + Space + "Welcome to VocEnhancer" + NewLine + NewLine + NewLine);
            if (Chances == 0)
            {
                Console.Clear();
                Console.WriteLine("Number of Chances Over,Please Press P to Play again or Press Q to Quit");
                string Option = Console.ReadLine();
                if (Option == "P" || Option == "p")
                {
                    Console.Clear();
                    GameMode();

                }


            }
            string[] words = new string[50];

            int count = ReadWordsFromFile3(words);
            Random r = new Random();

            string hint = HintUtilityClass3.GetHints();
            int guessX = (int)(r.Next(count));
            //getting guess words   
            String secretWord = words[guessX];
            //getting the length of guess word   
            int numChars = secretWord.Length;
            Console.Write(Space + hint + NewLine + NewLine + NewLine + NewLine + NewLine + NewLine);
            Console.Write("\t" + "Total Charcters:" + " " + numChars + NewLine);
            Console.WriteLine();
            bool bGuessedCorrectly = false;

            Console.WriteLine("\t" + "Write flip for Next word: " + NewLine + NewLine + "\t" + "Guess:");
            while (true & Chances > 0)
            {
                //for changing  word by wrtting flip   
                string choice = Console.ReadLine();
                if (choice == "flip")
                {
                    Console.Clear();
                    Level3Mode();

                }

                if (choice == secretWord)
                {

                    bGuessedCorrectly = true;

                    break;

                }
                else
                {

                    bGuessedCorrectly = false;

                    break;

                }

            }

            if (bGuessedCorrectly == false)
            {
                Chances--; //decreasing chances on every wrong attempt   
                CountUtility.SetChances = Chances;
                Console.WriteLine(" your Guess Is Not correct" + NewLine);
                Console.WriteLine("Please Enter to stay Playing");
            }


            else
            {
                Marks++; //counting marks for each correct answer   
                CountUtility.Setmarks = Marks;
                Console.WriteLine(NewLine + "Congrats!" + NewLine);
                Console.WriteLine("Please Enter to stay Playing....");

            }
            Console.ReadLine();

            Console.Clear();

            Level3Mode();
        }


        public static void GameMode()
        {

            Console.WriteLine(Space + "NIIT GFE SEM 1 Project");
            Console.WriteLine(Space + "Welcome to VocEnhancer" + NewLine + NewLine + NewLine);
            Console.WriteLine("Please Select Game Mode" + NewLine);
            Console.WriteLine("\t" + "1) Press 1 for Level 1- Beginner" + NewLine);
            Console.WriteLine("\t" + "2) Press 2 for Level 2-Average" + NewLine);
            Console.WriteLine("\t" + "3) Press 3 for Level 3-Expert" + NewLine);
            int Mode = int.Parse(Console.ReadLine());
            //for selecting the modes   
            switch (Mode)
            {
                case 1:
                    Console.Clear();
                    // Level1 Mode   
                    Level1Mode();
                    break;
                case 2:
                    Console.Clear();
                    // Level2 Mode   
                    Level2Mode();
                    break;
                case 3:
                    Console.Clear();
                    // Level3 Mode   
                    Level3Mode();
                    break;
                default:
                    Console.WriteLine("Please Select Game Mode between 1 to 3");
                    Console.ReadLine();
                    Console.Clear();
                    GameMode();
                    break;
            }
        }

        //end of class   
    }
}
