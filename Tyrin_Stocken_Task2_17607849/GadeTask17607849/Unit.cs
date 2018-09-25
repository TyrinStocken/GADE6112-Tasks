using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadeTask17607849
{
    abstract class Unit
    {
        public Unit()
        {

        }
        protected int xPosition;
        protected int yPosition;
        protected int health;
        protected int speed;
        protected int attack;
        protected int attackRange;
        protected string faction;
        protected string symbol;
        protected string name;


        public abstract void combat(int v);
        public abstract void moveUnit();
        public abstract int closestUnit(int v);
        public abstract bool isAlive();
        public abstract void save();
        public virtual string toString()
        {
            string output = Convert.ToString(xPosition);
            output += Convert.ToString(yPosition);
            output += Convert.ToString(health);
            output += Convert.ToString(speed);
            output += Convert.ToString(attack);
            output += Convert.ToString(attackRange);
            output += faction;
            output += symbol;
            output += name;

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
        public Unit(int xPosition, int yPosition, int health, int speed, int attack, int attackRange, string faction, string symbol, string name)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
            this.name = name;
        }
        #endregion

    }
}
