using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeTask17607849
{
    class MoneyBuilding : Building
    {
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected string faction;
        protected string symbol;
        public int money = 0;

        public MoneyBuilding()
        {
            xPosition = 19;
            yPosition = 0;
            health = 100;
            faction = "P";
            symbol = "$";
            money = 100;
        }

        public MoneyBuilding(int xPosition, int yPosition, int health, string faction, string symbol, int money)
        : base(xPosition, yPosition, health, faction, symbol)
        {
            this.money = money;
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
                outFile = new FileStream(@"Files\moneyBuilding.txt", FileMode.Create, FileAccess.Write);
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
    }
}
