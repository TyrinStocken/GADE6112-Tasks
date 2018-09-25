using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeTask17607849
{
    class MeleeUnit  : Unit
    {
        Map grid = new Map();

        public MeleeUnit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string faction, string symbol)
        : base(xPosition, yPosition, health, speed, attack, attackRange, faction, symbol)
        {

        }
        public override void combat(int v)
        {
        }
        public override void moveUnit()
        {

        }
        public override bool isAlive()
        {
            if (Health < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override int closestUnit(int v)
        {
            double Distance, xSqr, ySqr;
            int integerDistance, lowest;
            int count = 0;
            lowest = 400;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if(grid.map[i, j] != ".")
                    {
                        xSqr = Math.Pow((i - grid.mU[v].XPosition), 2);
                        ySqr = Math.Pow((j - grid.mU[v].YPosition), 2);
                        Distance = Math.Sqrt((xSqr + ySqr));
                        integerDistance = Convert.ToInt32(Math.Round(Distance));
                        if(integerDistance < lowest)
                        {
                            lowest = integerDistance;
                            count++;
                        }
                    }
                }
            }
            return count;
        }
        public override string ToString()
        {
            string output = Convert.ToString(XPosition);
            output += Convert.ToString(YPosition);
            output += Convert.ToString(Health);
            output += Convert.ToString(Speed);
            output += Convert.ToString(Attack);
            output += Convert.ToString(AttackRange);
            output += Faction;
            output += Symbol;

            return output;
        }
       /* public void placeMeleeUnit(int x, int y, string melee)
        {
            map[x, y] = melee;
        }

        public void fillMapWithMeleeUnits(string melee, int num = 20)
        {
            Random rnd = new Random();
            int x, y;
            for (int i = 0; i < num; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                placeMeleeUnit(x, y, melee);
            }
        }*/
    }
}
