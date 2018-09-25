using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace GadeTask17607849
{
    class Map
    {
        public MeleeUnit[] mU = new MeleeUnit[50];
        public RangedUnit[] rU = new RangedUnit[50];
        public FactoryBuilding[] fB = new FactoryBuilding[1];
        public ResourceBuilding[] rB = new ResourceBuilding[1];
        List<RangedUnit> rangedUList = new List<RangedUnit>();
        List<MeleeUnit> meleeUList = new List<MeleeUnit>();
        List<FactoryBuilding> factoryBList = new List<FactoryBuilding>();
        List<ResourceBuilding> resourcesBList = new List<ResourceBuilding>();
        public string[,] map = new string[20, 20];
       
        Random rnd = new Random();

        public string draw()
        {
            string display;
            display = "";
            fillMapWithMeleeUnits();
            fillMapWithRangedUnits();
            fillMapWithFactoryBuildings();
            fillMapWithResourceBuildings();
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
                    display += map[i, j].PadRight(1) + " ";
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
                    map[0, 0] = "#";
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
                rU[i] = new RangedUnit(0, 0, 100, 1, 30, 3, "$", "R", "Archer");
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
                mU[i] = new MeleeUnit(0, 0, 100, 1, 50, 1, "#", "M", "Knight");
                map[x, y] = mU[i].Symbol;
            }
        }
        public void fillMapWithFactoryBuildings(int num = 0)
        {
            for (int i = 0; i < 1; i++)
            {
                int x, y;
                x = 0;
                y = 0;
                fB[i] = new FactoryBuilding(x, y, 100, "Y", "#", 20, 2, 1, 1);
                map[x, y] = fB[i].Symbol;
            }
        }
        public void fillMapWithResourceBuildings(int num = 0)
        {
            for (int i = 0; i < 1; i++)
            {
                int x, y;
                x = 0;
                y = 19;
                rB[i] = new ResourceBuilding(x, y, 100, "B", "$", "Food", 2, 100);
                map[x, y] = rB[i].Symbol;
            }
        }
        public void loadMap()
        {
            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int xPosition;
            int yPosition;
            int health;
            int speed;
            int attack;
            string faction;
            string symbol;
            try
            {
                inFile = new FileStream(@"Files\RangedUnit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(input);
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    RangedUnit e = new RangedUnit();
                    rangedUList.Add(e);
                    input = reader.ReadLine();
                    map[xPosition, yPosition] = symbol;
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            try
            {
                inFile = new FileStream(@"Files\MeleeUnit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(input);
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    MeleeUnit m = new MeleeUnit();
                    meleeUList.Add(m);
                    input = reader.ReadLine();
                    map[xPosition, yPosition] = symbol;
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            try
            {
                inFile = new FileStream(@"Files\FactoryBuilding.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(input);
                    health = int.Parse(reader.ReadLine());

                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    FactoryBuilding f = new FactoryBuilding();
                    factoryBList.Add(f);
                    input = reader.ReadLine();
                    map[xPosition, yPosition] = symbol;
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            try
            {
                inFile = new FileStream(@"Files\ResourceBuilding.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();
                while (input != null)
                {
                    xPosition = int.Parse(input);
                    yPosition = int.Parse(input);
                    health = int.Parse(reader.ReadLine());

                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    ResourceBuilding r = new ResourceBuilding();
                    resourcesBList.Add(r);
                    input = reader.ReadLine();
                    map[xPosition, yPosition] = symbol;
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
        }
    }
}

