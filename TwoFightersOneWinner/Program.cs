using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFightersOneWinner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(declareWinner(new Fighter("Jerry", 30, 3), new Fighter("Harald", 20, 5), "Jerry"));
            Console.ReadKey();
        }

        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            // Your code goes here. Have fun!

            Fighter first;
            Fighter second;

            if (firstAttacker == fighter1.Name)
            {
                first = fighter1;
                second = fighter2;
            }
            else
            {
                first = fighter2;
                second = fighter1;
            }

            int remainHealthFirst = first.Health;
            int remainHealthSecond = second.Health;

            while (true)
            {
                remainHealthSecond = remainHealthSecond - first.DamagePerAttack;
                if (remainHealthSecond <= 0) break;
                remainHealthFirst = remainHealthFirst - second.DamagePerAttack;
                if (remainHealthFirst <= 0) break;
            }

            string winner = remainHealthFirst > 0 ? first.Name : second.Name;
            

            return winner;
        }
    }

    
}
