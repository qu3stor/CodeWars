using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DirectionsReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] a = new string[] { "EAST", "SOUTH", "EAST", "NORTH", "NORTH", "NORTH", "NORTH", "NORTH", "SOUTH", "SOUTH", "NORTH", "EAST", "SOUTH", "EAST", "SOUTH" };
            string[] a = new String[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            dirReduc(a);
            Console.ReadKey();
        }

        public static string[] dirReduc(String[] arr)
        {

            string path = String.Join(" ", arr);

            for (int i = 0; i < arr.Length; i++)
            {
                path = Regex.Replace(path, @"\s*NORTH\s*SOUTH\s*", " ");
                path = Regex.Replace(path, @"\s*SOUTH\s*NORTH\s*", " ");
                path = Regex.Replace(path, @"\s*EAST\s*WEST\s*", " ");
                path = Regex.Replace(path, @"\s*WEST\s*EAST\s*", " ");
            }

            string[] array = path.Trim().Split(' ');


            //lol = Regex.Replace(lol, @"\s*NORTH\s*SOUTH\s*", "");
            //lol = Regex.Replace(lol, @"\s*SOUTH\s*NORTH\s*", "");
            //lol = Regex.Replace(lol, @"\s*EAST\s*WEST\s*", "");
            //lol = Regex.Replace(lol, @"\s*WEST\s*EAST\s*", "");
            //lol = Regex.Replace(lol, @"\s*SOUTH\s*NORTH\s*", "");
            //lol = Regex.Replace(lol, @"\s*SOUTH\s*NORTH\s*", "");





            //lol = lol.Replace("NORTH SOUTH", "");
            //lol = lol.Replace("SOUTH NORTH", "");
            //lol = lol.Replace("EAST WEST", "");
            //lol = lol.Replace("WEST EAST", "");


            //List<string> list = arr.ToList();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] == "NORTH" && list[i + 1] == "SOUTH")
            //    {
            //        list.Remove(list[i]);
            //        list.Remove(list[i + 1]);
            //    }
            //    else if (list[i] == "SOUTH" && list[i + 1] == "NORTH")
            //    {
            //        list.Remove(list[i]);
            //        list.Remove(list[i + 1]);
            //    }
            //    else if (list[i] == "EAST" && list[i + 1] == "WEST")
            //    {
            //        list.Remove(list[i]);
            //        list.Remove(list[i + 1]);
            //    }
            //    else if ((list[i] == "WEST" && list[i + 1] == "EAST"))
            //    {
            //        list.Remove(list[i]);
            //        list.Remove(list[i + 1]);
            //    }
            //}

            return array;
        }



    }
}
