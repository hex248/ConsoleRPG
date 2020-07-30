using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleRPG
{

    class Player
    {
        public string name;
        public string style;
        public int level;
        public int targetXp;
        public int currentXp;
        public int health;
        public int attack;
        public int defence;
        public int speed;
        public int balance;
        public int critchance;
        public int evaschance;

        public Player(string pname, string pstyle)
        {
            name = pname;
            style = pstyle;
            switch (pstyle)
            {
                case "Mage":
                    level = 1;
                    targetXp = 100;
                    currentXp = 0;
                    health = 90;
                    attack = 140;
                    defence = 70;
                    speed = 80;
                    balance = 100;
                    critchance = 10;
                    evaschance = 10;
                    break;

                case "Hunter":
                    level = 1;
                    targetXp = 100;
                    currentXp = 0;
                    health = 130;
                    attack = 120;
                    defence = 80;
                    speed = 110;
                    balance = 100;
                    critchance = 20;
                    evaschance = 10;
                    break;

                case "Rogue":
                    level = 1;
                    targetXp = 100;
                    currentXp = 0;
                    health = 60;
                    attack = 145;
                    defence = 60;
                    speed = 150;
                    balance = 100;
                    critchance = 35;
                    evaschance = 20;
                    break;
                case "Admin":
                    level = 100000;
                    targetXp = 999999;
                    health = 1000000;
                    attack = 1000000;
                    defence = 1000000;
                    speed = 1000000;
                    balance = 1000000;
                    critchance = 100;
                    evaschance = 100;
                    break;
            }
        }
    }
    class Monster
    {
        public string name;
        public string app; // app = Appearance
        public int health;
        public int attack;
        public int defence;
        public int speed;

        public Monster(string mname, string mapp, int mhealth, int mattack, int mdefence, int mspeed)
        {
            name = mname;
            app = mapp;
            health = mhealth;
            attack = mattack;
            defence = mdefence;
            speed = mspeed;
            // Console.WriteLine($"Oh no! \nThere is a {app} {name} who has {health} health, {defence} defence and {speed} speed!");
            Console.WriteLine("A monster has appeared!\nHere is some information about it:\n\n");
            Console.WriteLine($"--{name}--\n\n" +
                $"Appearance: {app}\n" +
                $"Health: {health}\n" +
                $"Attack: {attack}\n" +
                $"Defence: {defence}\n" +
                $"Speed: {speed}\n");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to console RPG!\n\n");

            Console.WriteLine("Hello! I am game-master Jerry! Nice to meet you... uh, what should I call you?\n");
            string uname = Console.ReadLine();

            bool home = false;

            Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

            Console.WriteLine("Please choose your fighting style:\n");

            Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter just the number corresponding to the style to find out more.\n");

            string tempinput = Console.ReadLine();

            string confirmation;

            string ustyle = "none";
            
            while (ustyle == "none")
            {
                if (tempinput == "1")
                {
                    Console.Write("\nA magic using hero with average health and low defence. This hero deals immense damage without needing the speed which other heroes may possess.\n");
                    Console.Write("\nBack(b)");
                    confirmation = Console.ReadLine();
                    if (confirmation == "b")
                    {
                        Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                        Console.WriteLine("Please choose your fighting style:\n");

                        Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                        tempinput = Console.ReadLine();
                    }
                }
                else if (tempinput == "2")
                {
                    Console.Write("\nA moderately fast moving hero who seeks long range attacks due to their low chance of evading attacks. This hero has a large health advantage over the others, this allows them to take risks despite their low evasion chance.\n");
                    Console.Write("\nBack(b)");
                    confirmation = Console.ReadLine();
                    if (confirmation == "b")
                    {
                        Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                        Console.WriteLine("Please choose your fighting style:\n");

                        Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                        tempinput = Console.ReadLine();
                    }
                }
                else if (tempinput == "3")
                {
                    Console.Write("\nAn agile and strong attacker with light armour and low health. This hero throws themselves into battle, due to their high chance of getting a critical hit on their enemy.\n");
                    Console.Write("\nBack(b)");
                    confirmation = Console.ReadLine();
                    if (confirmation == "b")
                    {
                        Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                        Console.WriteLine("Please choose your fighting style:\n");

                        Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                        tempinput = Console.ReadLine();
                    }
                }
                else if (tempinput == "choose 1")
                {
                    Console.Write("\nSo you would like to be a Mage?");
                    Console.Write("\nYes(y) / No(n)");
                    confirmation = Console.ReadLine();
                    if (confirmation == "y")
                    {
                        ustyle = "Mage";
                    }
                    else
                    {
                        Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                        Console.WriteLine("Please choose your fighting style:\n");

                        Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                        tempinput = Console.ReadLine();
                    }
                }
                else if (tempinput == "choose 2")
                {
                    Console.Write("\nSo you would like to be a Hunter?");
                    Console.Write("\nYes(y) / No(n)");
                    confirmation = Console.ReadLine();
                    if (confirmation == "y")
                    {
                        ustyle = "Hunter";
                    }
                    else
                    {
                        Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                        Console.WriteLine("Please choose your fighting style:\n");

                        Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                        tempinput = Console.ReadLine();
                    }
                }
                else if (tempinput == "choose 3")
                {
                    Console.Write("\nSo you would like to be a Rogue?");
                    Console.Write("\nYes(y) / No(n)");
                    confirmation = Console.ReadLine();
                    if (confirmation == "y")
                    {
                        ustyle = "Rogue";
                    }
                    else
                    {
                        Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                        Console.WriteLine("Please choose your fighting style:\n");

                        Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                        tempinput = Console.ReadLine();
                    }
                }
                else if (tempinput == "Admin")
                {
                    ustyle = "Admin";
                }
                else
                {
                    Console.WriteLine("\nIn this world, there are many dangers. How will you fight?\n");

                    Console.WriteLine("Please choose your fighting style:\n");

                    Console.WriteLine("1. Mage \n2. Hunter \n3. Rogue \n\nType 'choose' followed by the number corresponding to the style you would like to choose.\nEnter the number corresponding to the style to find out more\n");

                    tempinput = Console.ReadLine();
                }
            }

            Player user = new Player(uname, ustyle); // Creates a new player.

            Console.WriteLine($"\n\nYou are a {user.style} named {user.name}.");
            Console.WriteLine($"\n\n | {user.name}'s Stats");
            Console.WriteLine($" | Style: {user.style}");
            Console.WriteLine($" | Level: {user.level}");
            Console.WriteLine($" | XP: {user.currentXp}/{user.targetXp}");
            Console.WriteLine($" | Health: {user.health}");
            Console.WriteLine($" | Attack: {user.attack}");
            Console.WriteLine($" | Defence: {user.defence}");
            Console.WriteLine($" | Speed: {user.speed}");
            Console.WriteLine($" | Balance: ${user.balance}");
            Console.WriteLine($" | Critical Hit Chance: {user.critchance}%");
            Console.WriteLine($" | Attack Evasion Chance: {user.evaschance}%");

            home = true;

            string userInput = Console.ReadLine();

            while (home)
            {
                if (userInput == "help")
                {
                    Console.WriteLine("List of commands:\n\n" +
                        "help - shows this list\n" +
                        "stats - shows the current player's stats\n" +
                        "play - starts the game\n");
                }

                else if (userInput == "stats")
                {
                    Console.WriteLine($"\n\n | {user.name}'s Stats");
                    Console.WriteLine($" | Style: {user.style}");
                    Console.WriteLine($" | Level: {user.level}");
                    Console.WriteLine($" | XP: {user.currentXp}/{user.targetXp}");
                    Console.WriteLine($" | Health: {user.health}");
                    Console.WriteLine($" | Attack: {user.attack}");
                    Console.WriteLine($" | Defence: {user.defence}");
                    Console.WriteLine($" | Speed: {user.speed}");
                    Console.WriteLine($" | Balance: ${user.balance}");
                    Console.WriteLine($" | Critical Hit Chance: {user.critchance}%");
                    Console.WriteLine($" | Attack Evasion Chance: {user.evaschance}%\n");
                }

                else if (userInput == "play")
                {
                    Console.WriteLine("Starting game... ");

                }

                else
                {
                    Console.WriteLine($"{userInput} is an unknown command.");
                }
                userInput = Console.ReadLine();

            }

            void addXp(int amount)
            {
                user.currentXp += amount;
                if (user.currentXp >= user.targetXp)
                {
                    user.currentXp -= user.targetXp;
                    user.level++;
                    user.targetXp += user.targetXp / 10;
                    Console.Write("LEVEL UP!");
                    Console.Write($"\nYou are now level {user.level}!");
                }
            }









            // Monster monster = new Monster("Beta Gremlin", "Big, blue and disc-shaped", 150, 80 80, 400); // Creates a monster

            while (Console.ReadKey().Key != ConsoleKey.Escape) ; // Closes the application on Escape key pressed
        }
    }
}
