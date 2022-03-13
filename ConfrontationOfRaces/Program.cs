using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConfrontationOfRaces
{
    class Program
    {
        public static void Main()
        {
            Barbarian barbarian = new Barbarian();
            Warrior warrior = new Warrior();
            Paladin paladin = new Paladin();
            Knight knight = new Knight();
            Spearman spearman = new Spearman();
            Archer archer = new Archer();
            Hunter hunter = new Hunter();
            Catapult catapult = new Catapult();
            Crossbowman crossbowman = new Crossbowman();
            Centaur centaur = new Centaur();
            Wizard wizard = new Wizard();
            Sorcered sorcered = new Sorcered();
            Cleric cleric = new Cleric();
            Monk monk = new Monk();
            Warlock warlock = new Warlock();

            Console.WriteLine(
                "Однажды произошла великая война между расами. Многие погибли...\nВыберите свою расу (Для выбора введиет цифру соответствующего номера):");
            Console.Write("1. ");
            barbarian.PrintAboutCharacter();
            Console.Write("2. ");
            warrior.PrintAboutCharacter();
            Console.Write("3. ");
            paladin.PrintAboutCharacter();
            Console.Write("4. ");
            knight.PrintAboutCharacter();
            Console.Write("5. ");
            spearman.PrintAboutCharacter();
            Console.Write("6. ");
            archer.PrintAboutCharacter();
            Console.Write("7. ");
            hunter.PrintAboutCharacter();
            Console.Write("8. ");
            catapult.PrintAboutCharacter();
            Console.Write("9. ");
            crossbowman.PrintAboutCharacter();
            Console.Write("10. ");
            centaur.PrintAboutCharacter();
            Console.Write("11. ");
            wizard.PrintAboutCharacter();
            Console.Write("12. ");
            sorcered.PrintAboutCharacter();
            Console.Write("13. ");
            cleric.PrintAboutCharacter();
            Console.Write("14. ");
            monk.PrintAboutCharacter();
            Console.Write("15. ");
            warlock.PrintAboutCharacter();

            //Characters Player1 = new Characters("Player", 0, 0, "Type", 0, 0);
            //Characters Player2 = new Characters("Player", 0, 0, "Type", 0, 0);
            Console.WriteLine("\nИгрок 1, введите соответствующий номер");
            int numberPlayer1 = Int32.Parse(Console.ReadLine());
            var start = new Start();
            //var someList = new List<Characters>();
            //someList.Add(barbarian);  
            //Console.WriteLine("{0}", someList[0].Health);

            var Player1 = start.ChooseCharacter(numberPlayer1);
            Console.WriteLine($"Игрок 1 выбрал персонажа {Player1.Name} ");
            Console.WriteLine($"{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");
            
            Console.WriteLine("\nИгрок 2, введите соответствующий номер");
            int numberPlayer2 = Int32.Parse(Console.ReadLine());
            var Player2 = start.ChooseCharacter(numberPlayer2);
            Console.WriteLine($"Игрок 2 выбрал персонажа {Player2.Name} ");
            Console.WriteLine($"{Player2.Name} имеет {Player2.Health} здоровья, {Player2.Damage} урона, {Player2.Armour} брони, {Player2.DodgeChance}% вероятностью уклонения и {Player2.Mana} маны.");

            while ((Player1.Health != 0) || (Player2.Health != 0))
            {
                Console.WriteLine($"\n{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");
                Console.WriteLine("Ход игрока 1:");
                Console.WriteLine("Нажмите: 1, чтобы нанести атаку    2, чтобы использовать способность");
                int buttonPlayer1 = Int32.Parse(Console.ReadLine());
                switch (buttonPlayer1)
                {
                    case 1:
                        Player1.Hit(Player2);
                        break;
                    case 2:
                        Player1.Ability(Player2);
                        break;
                }

                if (Player2.Health <= 0)
                {
                    Player2.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 1");
                    break;
                }
                
                Console.WriteLine($"\n{Player2.Name} имеет {Player2.Health} здоровья, {Player2.Damage} урона, {Player2.Armour} брони, {Player2.DodgeChance}% вероятностью уклонения и {Player2.Mana} маны.");
                Console.WriteLine("Ход игрока 2:");
                Console.WriteLine("Нажмите: 1, чтобы нанести атаку    2, чтобы использовать способность");
                int buttonPlayer2 = Int32.Parse(Console.ReadLine());
                switch (buttonPlayer2)
                {
                    case 1:
                        Player2.Hit(Player1);
                        break;
                    case 2:
                        Player2.Ability(Player1);
                        break;
                }
            }

            if (Player1.Health == 0)
            {
                Console.WriteLine("Игра закончилась, победил игрок 2");
            }
            else
            {
                Console.WriteLine("Игра закончилась, победил игрок 1");
            }
            /*Player1.Ability(Player2);
            Console.WriteLine($"Health {Player2.Health}, Mana {Player2.Mana}");
            Player2.Ability(Player1);
            Console.WriteLine($"Health {Player1.Health}, Mana {Player1.Mana}");*/
            /*switch (numberPlayer1)
            {
                case 1:
                    var Player1 = new Barbarian();
                    break;
                case 2:
                    var Player1 = new Warrior();
                    break;
                case 3:
                    Player1 = new Paladin();
                    break;
                case 4:
                    Player1 = new Knight();
                    break;
                case 5:
                    Player1 = new Spearman();
                    break;
                case 6:
                    Player1 = new Archer();
                    break;
                case 7:
                    Player1 = new Hunter();
                    break;
                case 8:
                    Player1 = new Catapult();
                    break;
                case 9:
                    Player1 = new Crossbowman();
                    break;
                case 10:
                    Player1 = new Centaur();
                    break;
                case 11:
                    Player1 = new Wizard();
                    break;
                case 12:
                    Player1 = new Sorcered();
                    break;
                case 13:
                    Player1 = new Cleric();
                    break;
                case 14:
                    Player1 = new Monk();
                    break;
                case 15:
                    Player1 = new Warlock();
                    break;
            }*/

            










            //Players Player_1 = new Players();
                //Player_1.ChoosingCharacter(numberPlayer1, Player1);
                //Player_1.returnChoosedCharacter(numberPlayer1);

                /*Console.WriteLine($"The health of {Player1.Name}: {Player1.Health}");
                barbarian.Hit(Player1);
                Paladin Player11 = new Paladin();
                barbarian.Hit(Player11);
                Player11.PrintAboutCharacter();
                Console.WriteLine(Player1.Health);
                //Player1.PringAboutCharacter();
                paladin.PrintAboutCharacter();*/
                //Player_1.returnChoosedCharacter(numberPlayer1);
                //paladin.PrintAboutCharacter();



                /*Console.WriteLine("\n \nИгрок 2, введите соответствующий номер");
                int numberPlayer2 = Int32.Parse(Console.ReadLine());
                
                Players Player_2 = new Players();
                Player_2.ChoosingCharacter(numberPlayer2, Player2);
                Player_2.returnChoosedCharacter(numberPlayer2);
                
                Console.WriteLine($"Health: {Player_1.returnHealth(numberPlayer1)}");*/

                /*while ((Player_1.returnHealth(numberPlayer1) != 0) || (Player_2.returnHealth(numberPlayer2) != 0))
                {
                    Console.WriteLine("Игрок 1 ходит:");
                    if (numberPlayer1 > 10)
                    {
                        Console.WriteLine("Нажмите 1, чтобы ударить врага, нажмите 2, чтобы использовать свою спосбность");
                        
                    }
                    else
                    {
                        
                        Player_1.finishHit(numberPlayer1, 
                }*/
                //StartGame.ChoiceACharacter(numberPlayer1, Player1);
                //Console.WriteLine($"Игрок 1 выбрал персонажа: {Player1.Name}");
                //Console.WriteLine("\n \nВведите соответствующий номер");
                //int numberPlayer2 = Int32.Parse(Console.ReadLine());
                //StartGame.ChoiceACharacter(numberPlayer2, Player2);
                //Console.WriteLine($"Игрок 2 выбрал персонажа: {Player2.Name}");


                //Barbarian player1 = new Barbarian();
                //player1 = barbarian;
                //monk.Hit(Player1);
                //barbarian.PrintAboutCharacter();
                //Console.WriteLine(player1.Name);
                //Console.WriteLine(player1.Type);
        }
    }
}
