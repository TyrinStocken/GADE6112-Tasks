using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeTask17607849
{
    abstract class Building
    {
        public Building()
        {

        }
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected string faction;
        protected string symbol;


        public abstract bool isActive();
        public abstract string toString();
        public abstract void save();

        #region Constructor
        public Building(int xPosition, int yPosition, int health, string faction, string symbol)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.faction = faction;
            this.symbol = symbol;
        }
        #endregion

        #region Accessors

        public int XPosition
        {
            get { return xPosition; }
            set { xPosition = value; }
        }
        public int YPosition
        {
            get { return yPosition; }
            set { yPosition = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }
        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        #endregion
    }
}

