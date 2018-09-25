using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeTask17607849
{
    class FactoryBuilding : Building
    {
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected string faction;
        protected string symbol;
        protected int unitsToProduce;
        protected int ticsPerProduction;
        protected int spawnPointX;
        protected int spawnPointY;

        public FactoryBuilding()
        {
            xPosition = 0;
            yPosition = 0;
            health = 100;
            faction = "Y";
            symbol = "#";
        }

        public FactoryBuilding(int xPosition, int yPosition, int health, string faction, string symbol, int unitsToProduce, int ticsPerProdustion, int spawnPointX, int spawnPointY)
        : base(xPosition, yPosition, health, faction, symbol)
        {
            this.unitsToProduce = unitsToProduce;
            this.ticsPerProduction = ticsPerProdustion;
            this.spawnPointX = spawnPointX;
            this.spawnPointY = spawnPointY;
        }

        override public bool isActive()
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

        override public string toString()
        {
            string output = Convert.ToString(xPosition);
            output += Convert.ToString(yPosition);
            output += Convert.ToString(health);
            output += faction;
            output += symbol;

            return output;
        }

        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(@"Files\factoryBuilding.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(xPosition);
                writer.WriteLine(yPosition);
                writer.WriteLine(health);
                writer.WriteLine(faction);
                writer.WriteLine(symbol);
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

        public  Unit spawnUnits(int tic)
        {
            Random rnd = new Random();
            int amount = rnd.Next(1, 21);
            Unit temp = null;
            if (rnd.Next(1, 3) % 2 == 0)
            {
                temp = new RangedUnit(spawnPointX, spawnPointY, 100, 1, 30, 3, faction, "R", "Archer");
            }
            else
            {
                temp = new MeleeUnit(spawnPointX, spawnPointY, 100, 1, 50, 1, faction, "M", "Knight");
            }
             return temp;
            }
        }
    }