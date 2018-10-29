using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson7
{
    class Udvoitel
    {
        public int finish, current, turns, minTurns, turnsA;
        public List<int> turnsArray = new List<int>();

        public Udvoitel(int min,int max)
        {
            Random rnd = new Random();
            this.finish = rnd.Next(min,max+1);
            minTurnsCalc(finish);
            current = 1;
            //turnsArray.Add(1);
        }

        public void minTurnsCalc(int fin) {
            while (fin != 1) {
                minTurns++;
                if (fin % 2 == 0)
                {
                    fin = fin / 2;
                }
                else if (fin % 2 == 1) {
                    fin--;
                }
            }
        }

        public void Plus()
        {
            current++;
            turnsArray.Add(current);
            turns++;
        }

        public void Multi()
        {
            current *= 2;
            turnsArray.Add(current);
            turns++;
        }

        public void Reset()
        {
            current = 1;
            turnsArray.Clear();
            turns = 0;
        }

        public void Back()
        {
            if (turns != 1)
            {
                turns--;
                current = turnsArray[turns - 1];
            }
            else {
                current = 1;
                turns = 0;
            }
        }

        public int Current
        {
            get { return current; }
        }

        public int Finish
        {
            get { return finish; }
        }

        public int Turns
        {
            get { return turns; }
        }

        public int MinTurns
        {
            get { return minTurns; }
        }
        //1=>25 +1 x2
    }
}
