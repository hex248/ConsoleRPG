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
        public int speed;
        public string[] moveset = new string[5];
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
                    speed = 80;
                    moveset[0] = "Firebolt";
                    moveset[1] = "None";
                    moveset[2] = "None";
                    moveset[3] = "None";
                    moveset[4] = "Run";
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
                    speed = 110;
                    moveset[0] = "Piercing Arrow";
                    moveset[1] = "None";
                    moveset[2] = "None";
                    moveset[3] = "None";
                    moveset[4] = "Run";
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
                    speed = 150;
                    moveset[0] = "Punch";
                    moveset[1] = "None";
                    moveset[2] = "None";
                    moveset[3] = "None";
                    moveset[4] = "Run";
                    balance = 100;
                    critchance = 35;
                    evaschance = 20;
                    break;

                case "Admin":
                    level = 1;
                    targetXp = 999999;
                    health = 1000000;
                    attack = 1000000;
                    speed = 1000000;
                    moveset[0] = "Punch";
                    moveset[1] = "None";
                    moveset[2] = "None";
                    moveset[3] = "None";
                    moveset[4] = "Fly";
                    balance = 1000000;
                    critchance = 100;
                    evaschance = 100;
                    break;
            }
        }
    }
    class Enemy
    {
        public string name;
        public string app; // app = Appearance
        public int health;
        public int attack;
        public int speed;
        public string[,] enemynames =
        {
            {"Gremlin", "Goblin"},
            {"Orc", "Griffin" }
        };
        public string[,] enemyapps =
        {
            {"Red, small", "Blue, ambidextrous" },
            {"Red, moderately large", "Blue, wise" }
        };
        public string[,] moveset =
        {
            {"Scratch", "Small Heal"},
            {"Punch", "Small Heal"}
        };
        public Enemy(int plevel)
        {
            Random rnd = new Random();
            name = enemynames[plevel - 1, rnd.Next(0, 2)];
            app = enemyapps[plevel - 1, rnd.Next(0, 2)];

            switch (name)
            {
                case "Gremlin":
                    health = 60;
                    attack = 70;
                    speed = 50;
                    return;
                case "Goblin":
                    health = 70;
                    attack = 60;
                    speed = 80;
                    return;
                case "Orc":
                    health = 120;
                    attack = 90;
                    speed = 20;
                    return;
                case "Griffin":
                    health = 60;
                    attack = 60;
                    speed = 100;
                    return;
            }

            
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
                    Console.Write("\nYes(y) / No(n)\n");
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
                    Console.Write("\nYes(y) / No(n)\n");
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
                    Console.Write("\nYes(y) / No(n)\n");
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
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Style: {user.style}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Level: {user.level}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | XP: {user.currentXp}/{user.targetXp}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Health: {user.health}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Attack: {user.attack}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Speed: {user.speed}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Moveset: {user.moveset[0]}, {user.moveset[1]}, {user.moveset[2]}, {user.moveset[3]}, {user.moveset[4]}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Balance: ${user.balance}");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Critical Hit Chance: {user.critchance}%");
            System.Threading.Thread.Sleep(70);
            Console.WriteLine($" | Attack Evasion Chance: {user.evaschance}%\n");

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
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Style: {user.style}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Level: {user.level}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | XP: {user.currentXp}/{user.targetXp}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Health: {user.health}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Attack: {user.attack}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Speed: {user.speed}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Moveset: {user.moveset[0]}, {user.moveset[1]}, {user.moveset[2]}, {user.moveset[3]}, {user.moveset[4]}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Balance: ${user.balance}");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Critical Hit Chance: {user.critchance}%");
                    System.Threading.Thread.Sleep(70);
                    Console.WriteLine($" | Attack Evasion Chance: {user.evaschance}%\n");
                }

                else if (userInput == "play")
                {
                    home = false;
                    play();
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
                    user.targetXp += user.targetXp / 10; // increments target by 10% of the previous level's target
                    Console.Write("LEVEL UP!");
                    Console.Write($"\nYou are now level {user.level}!\n");
                }
            }

            void play()
            {
                Console.WriteLine("\nStarting game... ");
                Enemy enemy = new Enemy(user.level);
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("\nAn enemy has appeared!\n");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Here is some information about it:\n");
                System.Threading.Thread.Sleep(200);
                Console.WriteLine($" | Name: {enemy.name}");
                Console.WriteLine($" | Appearance: {enemy.app}");
                Console.WriteLine($" | Health: {enemy.health}");
                Console.WriteLine($" | Attack: {enemy.attack}");
                Console.WriteLine($" | Speed: {enemy.speed}");

                int phealth = user.health;
                int eohealth = enemy.health;
                int xpGained;
                int moneyGained;
                bool inFight = true;

                while (phealth > 0 && enemy.health > 0 && inFight)
                {
                    Console.WriteLine($"\nWhat will you do?");
                    Console.WriteLine($"Your Moves:\n");
                    Console.WriteLine($"{user.moveset[0]}");
                    Console.WriteLine($"{user.moveset[1]}");
                    Console.WriteLine($"{user.moveset[2]}");
                    Console.WriteLine($"{user.moveset[3]}");
                    Console.WriteLine($"{user.moveset[4]}\n");
                    string move = Console.ReadLine();

                    switch (move)
                    {
                        case "Firebolt": case "firebolt": case "FireBolt": case "fireBolt":
                            move = "Firebolt";
                            if (user.moveset.Contains(move))
                            {
                                if (user.speed >= enemy.speed)
                                {
                                    Random rnd = new Random();
                                    enemy.health -= user.attack / 4; // 25%
                                    if (enemy.health > 0)
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} now has {enemy.health} health.");
                                        string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                        switch (enemymove)
                                        {
                                            case "Scratch":
                                                phealth -= enemy.attack / 5;
                                                Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                                break;
                                            case "Small Heal":
                                                int healthchange = enemy.health / 5;
                                                enemy.health += healthchange;
                                                Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} was defeated!");
                                        xpGained = eohealth / 3;
                                        moneyGained = (eohealth / 10) * 3;
                                        user.balance += moneyGained;
                                        Console.WriteLine($"Congratulations! You gained {xpGained} XP and ${moneyGained}! You now have ${user.balance}.");
                                        addXp(xpGained);
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                }
                                else
                                {
                                    Random rnd = new Random();
                                    string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                    switch (enemymove)
                                    {
                                        case "Scratch":
                                            phealth -= enemy.attack / 5;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                            break;
                                        case "Small Heal":
                                            int healthchange = enemy.health / 5;
                                            enemy.health += healthchange;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                            break;
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                    else
                                    {
                                        enemy.health -= user.attack / 4; // 25%
                                    }
                                    if (enemy.health <= 0)
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} was defeated!");
                                        xpGained = eohealth / 3;
                                        moneyGained = (eohealth / 10) * 3;
                                        user.balance += moneyGained;
                                        Console.WriteLine($"Congratulations! You gained {xpGained} XP and ${moneyGained}! You now have ${user.balance}.");
                                        addXp(xpGained);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} now has {enemy.health} health.");
                                    }
                                }
                            }
                            break;
                        
                        case "Piercing Arrow": case "piercing arrow": case "Piercing arrow": case "piercing Arrow":
                            move = "Piercing Arrow";
                            if (user.moveset.Contains(move))
                            {
                                if (user.speed >= enemy.speed)
                                {
                                    Random rnd = new Random();
                                    enemy.health -= user.attack / 4; // 25%
                                    if (enemy.health > 0)
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} now has {enemy.health} health.");
                                        string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                        switch (enemymove)
                                        {
                                            case "Scratch":
                                                phealth -= enemy.attack / 5;
                                                Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                                break;
                                            case "Small Heal":
                                                int healthchange = enemy.health / 5;
                                                enemy.health += healthchange;
                                                Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} was defeated!");
                                        xpGained = eohealth / 3;
                                        moneyGained = (eohealth / 10) * 3;
                                        user.balance += moneyGained;
                                        Console.WriteLine($"Congratulations! You gained {xpGained} XP and ${moneyGained}! You now have ${user.balance}.");
                                        addXp(xpGained);
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                }
                                else
                                {
                                    Random rnd = new Random();
                                    string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                    switch (enemymove)
                                    {
                                        case "Scratch":
                                            phealth -= enemy.attack / 5;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                            break;
                                        case "Small Heal":
                                            int healthchange = enemy.health / 5;
                                            enemy.health += healthchange;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                            break;
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                    else
                                    {
                                        enemy.health -= user.attack / 4; // 25%
                                    }
                                    if (enemy.health <= 0)
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} was defeated!");
                                        xpGained = eohealth / 3;
                                        moneyGained = (eohealth / 10) * 3;
                                        user.balance += moneyGained;
                                        Console.WriteLine($"Congratulations! You gained {xpGained} XP and ${moneyGained}! You now have ${user.balance}.");
                                        addXp(xpGained);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} now has {enemy.health} health.");
                                    }
                                }
                            }
                            break;
                        case "Punch": case "punch":
                            move = "Punch";
                            if (user.moveset.Contains(move))
                            {
                                if (user.speed >= enemy.speed)
                                {
                                    Random rnd = new Random();
                                    enemy.health -= user.attack / 4;
                                    if (enemy.health > 0)
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} now has {enemy.health} health.");
                                        string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                        switch (enemymove)
                                        {
                                            case "Scratch":
                                                phealth -= enemy.attack / 5;
                                                Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                                break;
                                            case "Small Heal":
                                                int healthchange = enemy.health / 5;
                                                enemy.health += healthchange;
                                                Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} was defeated!");
                                        xpGained = eohealth / 3;
                                        moneyGained = (eohealth / 10) * 3;
                                        user.balance += moneyGained;
                                        Console.WriteLine($"Congratulations! You gained {xpGained} XP and ${moneyGained}! You now have ${user.balance}.");
                                        addXp(xpGained);
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                }
                                else
                                {
                                    Random rnd = new Random();
                                    string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                    switch (enemymove)
                                    {
                                        case "Scratch":
                                            phealth -= enemy.attack / 5;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                            break;
                                        case "Small Heal":
                                            int healthchange = enemy.health / 5;
                                            enemy.health += healthchange;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                            break;
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                    else
                                    {
                                        enemy.health -= user.attack / 4;
                                    }
                                    if (enemy.health <= 0)
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} was defeated!");
                                        xpGained = eohealth / 3;
                                        moneyGained = (eohealth / 10) * 3;
                                        user.balance += moneyGained;
                                        Console.WriteLine($"Congratulations! You gained {xpGained} XP and ${moneyGained}! You now have ${user.balance}.");
                                        addXp(xpGained);
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Your {move} did {user.attack / 4} damage! The {enemy.name} now has {enemy.health} health.");
                                    }
                                }
                            }
                            break;
                        case "Run": case "run":
                            move = "Run";
                            if (user.moveset.Contains(move))
                            {
                                Random rnd = new Random();
                                double chance = rnd.Next(1, 101);
                                if (chance <= 10) // 75% chance of getting away
                                {
                                    Console.WriteLine($"You used {move}, and got away!");
                                    inFight = false;
                                }
                                else
                                {
                                    Console.WriteLine($"You used {move}, but it was not successful!");
                                    string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                    switch (enemymove)
                                    {
                                        case "Scratch":
                                            phealth -= enemy.attack / 5;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                            break;
                                        case "Small Heal":
                                            int healthchange = enemy.health / 5;
                                            enemy.health += healthchange;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                            break;
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                }
                            }
                            break;
                        case "Fly": case "fly":
                            move = "Fly";
                            if (user.moveset.Contains(move))
                            {
                                Random rnd = new Random();
                                double chance = rnd.Next(1, 101);
                                if (chance <= 90) // 90% chance of getting away
                                {
                                    Console.WriteLine($"You used {move}, and got away!");
                                    inFight = false;
                                }
                                else
                                {
                                    Console.WriteLine($"You used {move}, but it was not successful!");
                                    string enemymove = enemy.moveset[user.level - 1, rnd.Next(0, 2)];
                                    switch (enemymove)
                                    {
                                        case "Scratch":
                                            phealth -= enemy.attack / 5;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, dealing {enemy.attack / 5} damage! You now have {phealth} health.");
                                            break;
                                        case "Small Heal":
                                            int healthchange = enemy.health / 5;
                                            enemy.health += healthchange;
                                            Console.WriteLine($"The {enemy.name} used {enemymove}, healing by {healthchange}. They now have {enemy.health} health.");
                                            break;
                                    }
                                    if (phealth <= 0)
                                    {
                                        Console.WriteLine($"You Died! Returning home...");
                                    }
                                }
                            }
                            break;
                    }
                }
                enemy = null;
                home = true;
            }
        }
    }
}