using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VocabularyEnhancer
{
    class HintUtilityClass2
    {
        public static int ReadWordsFromHintFile(string[] Hintwords)
        {
            //Set the guess file location path 
            string guessfilename = "C:\\Users\\youraccount\\Desktop\\guess2.txt";

            if (File.Exists(guessfilename) == false)
                return -1;
            //reading the text file words   
            StreamReader guessRead = new StreamReader(guessfilename);

            int cguessount = 0;

            for (int i = 0; i < 50; i++)
            {

                if (guessRead.EndOfStream == true)
                    break;
                Hintwords[cguessount++] = guessRead.ReadLine();


            }
            guessRead.Close();
            return cguessount;

        }

        public static string GetHints()
        {
            string[] Hintwords = new string[50];
            int count = ReadWordsFromHintFile(Hintwords);
            Random r = new Random();//for getting the random words from text files   
            int guessX = (int)(r.Next(count));
            String secretWord = Hintwords[guessX];

            return secretWord; //returning the random words   
        }
    }
}