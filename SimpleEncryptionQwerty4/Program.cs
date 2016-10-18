using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionQwerty4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  LettersLanes a = new LettersLanes();
            // Console.WriteLine(a.firstLane);
            //Console.WriteLine(char.);
            Console.WriteLine(Encrypt("Do the kata Kobayashi Maru Test. Endless fun and excitement when finding a solution.", 583));
            Console.ReadKey();
        }

        public static string Encrypt(string text, int key)
        {
            string firstLane        = "qwertyuiopqwertyuiopqwertyuiop";
            string firstLaneUpper   = "QWERTYUIOPQWERTYUIOPQWERTYUIOP";
            string secondLane       = "asdfghjklasdfghjklasdfghjkl";
            string secondLaneUpper  = "ASDFGHJKLASDFGHJKLASDFGHJKL";
            string thirdLane        = "zxcvbnm,.zxcvbnm,.zxcvbnm,.";
            string thirdLaneUpper   = "ZXCVBNM<>ZXCVBNM<>ZXCVBNM<>";

            int firstLaneMove = key / 100;
            key -= firstLaneMove * 100;
            int secondLaneMove = key / 10;
            key -= secondLaneMove * 10;
            int thirdLaneMove = key;


            string[] array = text.Split(' ');
            string[] encryptedArray = new string[array.Length];

            for (int j = 0; j < array.Length; j++)
            {
                string lol = string.Empty;
                string word = array[j];

                for (int i = 0; i < word.Length; i++)
                {
                    if (firstLane.Contains(word[i]) || firstLaneUpper.Contains(word[i]))
                    {
                        int temp = firstLane.IndexOf(char.ToLower(word[i]));
                        lol += char.IsUpper(word[i]) ? char.ToUpper(firstLaneUpper[temp + firstLaneMove]) : firstLane[temp + firstLaneMove];
                    }

                    if (secondLane.Contains(word[i]) || secondLaneUpper.Contains(word[i]))
                    {
                        int temp = secondLane.IndexOf(char.ToLower(word[i]));
                        lol += char.IsUpper(word[i]) ? char.ToUpper(secondLaneUpper[temp + secondLaneMove]) : secondLane[temp + secondLaneMove];
                    }

                    if (thirdLane.Contains(word[i]) || thirdLaneUpper.Contains(word[i]))
                    {
                        int temp = thirdLane.IndexOf(char.ToLower(word[i]));
                        lol += char.IsUpper(word[i]) ? char.ToUpper(thirdLaneUpper[temp + thirdLaneMove]) : thirdLane[temp + thirdLaneMove];
                    }

                    encryptedArray[j] = lol;
                } 
            }

            return string.Join(" ", encryptedArray);
        }




        public static string Decrypt(string encryptedText, int key)
        {




            return encryptedText;
        }

    }


    

}
