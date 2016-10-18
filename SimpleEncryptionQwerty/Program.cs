using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryptionQwerty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Encrypt("F dvp dBi| aKkvQe{ xxebtef", 328));
            //Console.WriteLine(Decrypt("F dvp dBi| aKkvQe{ xxebtef", 328));
            Console.WriteLine(Decrypt("B", 328));
            Console.ReadKey();

        }


        public static string Encrypt(string text, int key)
        {
            string firstLine = "qwertyuiopqwertyuiop";
            string firstLineUpper = firstLine.ToUpper();
            string secondLine = "asdfghjklasdfghjkl";
            string secondLineUpper = secondLine.ToUpper();
            string thirdLine = "zxcvbnm,.zxcvbnm,.";
            string thirdLineUpper = "ZXCVBNM<>ZXCVBNM<>";


            
            int firstMove = key / 100;
            int secondMove = (key - 100 * firstMove) / 10;
            int thirdMove = (key - 100 * firstMove - 10 * secondMove);


            string[] array = text.Split(' ');
            string[] encrypted = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                string lol = string.Empty;
                string word = array[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (char.IsLetter(word[j]) || word[j] == '<' || word[j] == '>' || word[j] == ',' || word[j] == '.')
                    {
                        if (firstLine.Contains(word[j]) || firstLineUpper.Contains(word[j]))
                        {
                            int charPos = firstLine.IndexOf(char.ToLower(word[j]));
                            lol += char.IsUpper(word[j]) ? firstLineUpper[charPos + firstMove] : firstLine[charPos + firstMove];
                        }

                        if (secondLine.Contains(word[j]) || secondLineUpper.Contains(word[j]))
                        {
                            int charPos = secondLine.IndexOf(char.ToLower(word[j]));
                            lol += char.IsUpper(word[j]) ? secondLineUpper[charPos + secondMove] : secondLine[charPos + secondMove];
                        }

                        if (thirdLine.Contains(word[j]))
                        {
                            int charPos = thirdLine.IndexOf(word[j]);
                            lol += thirdLine[charPos + thirdMove];
                        }
                        if (thirdLineUpper.Contains(word[j]))
                        {
                            int charPos = thirdLineUpper.IndexOf(word[j]);
                            lol += thirdLineUpper[charPos + thirdMove];
                        }
                    }
                    else
                    {
                        lol += word[j];
                    }

                    

                }
                encrypted[i] = lol;
            }



            return string.Join(" ", encrypted);
        }

        public static string Decrypt(string encryptedText, int key)
        {
            string firstLine = Reverse("qwertyuiopqwertyuiop");
            string firstLineUpper = firstLine.ToUpper();
            string secondLine = Reverse("asdfghjklasdfghjkl");
            string secondLineUpper = secondLine.ToUpper();
            string thirdLine = Reverse("zxcvbnm,.zxcvbnm,.");
            string thirdLineUpper = Reverse("ZXCVBNM<>ZXCVBNM<>");



            int firstMove = key / 100;
            int secondMove = (key - 100 * firstMove) / 10;
            int thirdMove = (key - 100 * firstMove - 10 * secondMove);


            string[] array = encryptedText.Split(' ');
            string[] encrypted = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                string lol = string.Empty;
                string word = array[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (char.IsLetter(word[j]) || word[j] == '<' || word[j] == '>' || word[j] == ',' || word[j] == '.')
                    {
                        if (firstLine.Contains(word[j]) || firstLineUpper.Contains(word[j]))
                        {
                            int charPos = firstLine.IndexOf(char.ToLower(word[j]));
                            lol += char.IsUpper(word[j]) ? firstLineUpper[charPos + firstMove] : firstLine[charPos + firstMove];
                        }

                        if (secondLine.Contains(word[j]) || secondLineUpper.Contains(word[j]))
                        {
                            int charPos = secondLine.IndexOf(char.ToLower(word[j]));
                            lol += char.IsUpper(word[j]) ? secondLineUpper[charPos + secondMove] : secondLine[charPos + secondMove];
                        }


                        if (thirdLine.Contains(word[j]))
                        {
                            int charPos = thirdLine.IndexOf(word[j]);
                            lol += thirdLine[charPos + thirdMove];
                        }
                        if (thirdLineUpper.Contains(word[j]))
                        {
                            int charPos = thirdLineUpper.IndexOf(word[j]);
                            lol += thirdLineUpper[charPos + thirdMove];
                        }
                    }
                    else
                    {
                        lol += word[j];
                    }
                }
                encrypted[i] = lol;
            }



            return string.Join(" ", encrypted);
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



    }
}
