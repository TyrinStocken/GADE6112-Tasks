using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeTask17607849
{
    abstract class Unit
    {
        private int xPosition;
        private int yPosition;
        private int health;
        private int speed;
        private int attack;
        private int attackRange;
        private string faction;
        private string symbol;


        abstract public void combat(int v);
        abstract public void moveUnit();
        abstract public int closestUnit(int v);
        abstract public bool isAlive();
        virtual public string ToString()
        {
            string output = Convert.ToString(xPosition);
            output += Convert.ToString(yPosition);
            output += Convert.ToString(health);
            output += Convert.ToString(speed);
            output += Convert.ToString(attack);
            output += Convert.ToString(attackRange);
            output += faction;
            output += symbol;

            return output;
        }

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
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
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

        #region Constructor
        public Unit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string faction, string symbol)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol; 
        }
        #endregion

    }
}
