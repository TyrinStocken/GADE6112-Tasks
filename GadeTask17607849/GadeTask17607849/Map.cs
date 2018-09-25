using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeTask17607849
{
    class Map
    {
        public MeleeUnit[] mU = new MeleeUnit[50];
        public RangedUnit[] rU = new RangedUnit[50];
        public string[,] map = new string[20, 20];
       
        Random rnd = new Random();

        public string draw()
        {
            string display;
            display = "";
            fillMapWithMeleeUnits();
            fillMapWithRangedUnits();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    display += map[i, j] + " ";
                }
                display += Environment.NewLine;
            }
            return display;
        }

        public string reDraw()
        {
            string display;
            display = "";
            
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    display += map[i, j] + " ";
                }
                display += Environment.NewLine;
            }
            return display;
        }
        public void initialiseMap()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i, j] = ".";
                }
            }
        }
        public void fillMapWithRangedUnits(int num = 0)
        {
            int amount = rnd.Next(1, 21);
            int x, y;
            for (int i = 0; i < amount; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                rU[i] = new RangedUnit(0, 0, 100, 1, 30, 3, "$", "R");
                map[x, y] = rU[i].Symbol;
            }
        }
        public void fillMapWithMeleeUnits(int num = 0)
        {
            int amount = rnd.Next(1, 21);
            int x, y;
            for (int i = 0; i < amount; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                mU[i] = new MeleeUnit(0, 0, 100, 1, 50, 1, "#", "M");
                map[x, y] = mU[i].Symbol;
            }
        }
    }
}

