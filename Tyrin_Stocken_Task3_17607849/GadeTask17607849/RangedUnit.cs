using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeTask17607849
{
    class RangedUnit : Unit
    {
        Map grid = new Map();

        public RangedUnit()
        {

        }

        public RangedUnit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string faction, string symbol, string name)
        : base(xPosition, yPosition, health, speed, attack, attackRange, faction, symbol, name)
        {
        }

        public override void combat(int v)
        {
        }
        public override void moveUnit()
        {
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
                    if (grid.map[i, j] != ".")
                    {
                        xSqr = Math.Pow((i - grid.rU[v].XPosition), 2);
                        ySqr = Math.Pow((j - grid.rU[v].YPosition), 2);
                        Distance = Math.Sqrt((xSqr + ySqr));
                        integerDistance = Convert.ToInt32(Math.Round(Distance));
                        if (integerDistance < lowest)
                        {
                            lowest = integerDistance;
                            count++;
                        }
                    } 
                }
            }
            return count;
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
        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(@"Files\rangedUnit.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(xPosition);
                writer.WriteLine(yPosition);
                writer.WriteLine(health);
                writer.WriteLine(speed);
                writer.WriteLine(attack);
                writer.WriteLine(attackRange);
                writer.WriteLine(faction);
                writer.WriteLine(symbol);
                writer.WriteLine(name);
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (outFile != null)
                {
                    writer.Close();
                    outFile.Close();
                }
            }
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
            output += name;

            return output;
        }
    }
}
