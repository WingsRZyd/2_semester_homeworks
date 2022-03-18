using System;
using System.Runtime.CompilerServices;


namespace ConfrontationOfRaces
{
    public class BattlePvP                                                       //Бой Игрока против Игрока
    {
        public int NumberOfPlayer()
        {
            int numberOfPlayer;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out numberOfPlayer))
                {
                    if ((int)numberOfPlayer >= 1 && (int)numberOfPlayer <= 15)
                    {
                        return numberOfPlayer;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число.");
                    continue;
                }
            }
        }
        
        public int ButtonOfPlayer()
        {
            int buttonOfPlayer;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out buttonOfPlayer))
                {
                    if ((int)buttonOfPlayer == 1 || (int)buttonOfPlayer == 2)
                    {
                        return buttonOfPlayer;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число.");
                    continue;
                }
            }
        }
        
        public int TypeOfGame()
        {
            int typeOfGame;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out typeOfGame))
                {
                    if ((int)typeOfGame == 1 || (int)typeOfGame == 2 || (int)typeOfGame == 3)
                    {
                        return typeOfGame;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода! Введите целое число.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число.");
                    continue;
                }
            }
        }

        public void BattlePlayers()
        {
            var start = new Start();
            Console.WriteLine("\nИгрок 1, введите соответствующий номер");

            int numberPlayer1 = NumberOfPlayer();                                //Выбор игроком 1 персонажа
                
            var player1 = start.ChooseCharacter(numberPlayer1);          //Присвоение Игроку 1 персонажа
            Console.WriteLine($"Игрок 1 выбрал персонажа {player1.Name} ");
            Console.WriteLine($"{player1.Name} имеет {player1.Health} здоровья, {player1.Damage} урона, {player1.Armour} брони, {player1.DodgeChance}% вероятностью уклонения и {player1.Mana} маны.");
                
            Console.WriteLine("\nИгрок 2, введите соответствующий номер");
            int numberPlayer2 = NumberOfPlayer();                 //Выбор игроком 2 персонажа
            var player2 = start.ChooseCharacter(numberPlayer2);          //Присвоение Игроку 2 персонажа
            Console.WriteLine($"Игрок 2 выбрал персонажа {player2.Name} ");
            Console.WriteLine($"{player2.Name} имеет {player2.Health} здоровья, {player2.Damage} урона, {player2.Armour} брони, {player2.DodgeChance}% вероятностью уклонения и {player2.Mana} маны.");
            
            while ((player1.Health != 0) || (player2.Health != 0))      //Бой
            {
                Console.WriteLine($"\n{player1.Name} имеет {player1.Health} здоровья, {player1.Damage} урона, {player1.Armour} брони, {player1.DodgeChance}% вероятностью уклонения и {player1.Mana} маны.");
                Console.WriteLine("Ход игрока 1:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer1 = ButtonOfPlayer();             //Выбор вида атаки
                switch (buttonPlayer1)
                {
                    case 1:
                        player1.Hit(player2);
                        break;
                    case 2:
                        player1.Ability(player2);
                        break;
                }

                if (player2.Health <= 0)
                {
                    player2.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 1");
                    break;
                }

                Console.WriteLine($"\n{player2.Name} имеет {player2.Health} здоровья, {player2.Damage} урона, {player2.Armour} брони, {player2.DodgeChance}% вероятностью уклонения и {player2.Mana} маны.");
                Console.WriteLine("Ход игрока 2:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer2 = ButtonOfPlayer();
                switch (buttonPlayer2)                                           //Выбор вида атаки
                {
                    case 1:
                        player2.Hit(player1);
                        break;
                    case 2:
                        player2.Ability(player1);
                        break;
                }

                if (player1.Health <= 0)
                {
                    player1.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 2");
                    break;
                }
            }
        }
    }

    public class BattlePvAI     //Бой игрока против ИИ
    {
        public void BattlePlayerVsAI()
        {
            var start = new Start();
            var battle = new BattlePvP();
            Console.WriteLine("\nИгрок 1, введите соответствующий номер");       
            var numberPlayer1 = battle.NumberOfPlayer();
                
            var player1 = start.ChooseCharacter(numberPlayer1);         //Присвоение игроку персонажа
            Console.WriteLine($"Игрок 1 выбрал персонажа {player1.Name} ");
            Console.WriteLine($"{player1.Name} имеет {player1.Health} здоровья, {player1.Damage} урона, {player1.Armour} брони, {player1.DodgeChance}% вероятностью уклонения и {player1.Mana} маны.");

            Random random = new Random();                                        
            int numberPlayer2 = random.Next(1, 15);     
            var player2 = start.ChooseCharacter(numberPlayer2);         //Присвоение боту рандомного персонажа
            Console.WriteLine($"Бот выбрал персонажа {player2.Name} ");          
            Console.WriteLine($"{player2.Name} имеет {player2.Health} здоровья, {player2.Damage} урона, {player2.Armour} брони, {player2.DodgeChance}% вероятностью уклонения и {player2.Mana} маны.");
            
            while ((player1.Health != 0) || (player2.Health != 0))               //Бой
            {
                Console.WriteLine($"\n{player1.Name} имеет {player1.Health} здоровья, {player1.Damage} урона, {player1.Armour} брони, {player1.DodgeChance}% вероятностью уклонения и {player1.Mana} маны.");
                Console.WriteLine("Ход игрока 1:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                var buttonPlayer1 = battle.ButtonOfPlayer();
                switch (buttonPlayer1)
                {
                    case 1:
                        player1.Hit(player2);
                        break;
                    case 2:
                        player1.Ability(player2);
                        break;
                }

                if (player2.Health <= 0)
                {
                    player2.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 1");
                    break;
                }

                Console.WriteLine($"\n{player2.Name} имеет {player2.Health} здоровья, {player2.Damage} урона, {player2.Armour} брони, {player2.DodgeChance}% вероятностью уклонения и {player2.Mana} маны.");
                Console.WriteLine("Ход бота 2:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                var buttonPlayer2 = random.Next(1,3);
                switch (buttonPlayer2)
                {
                    case 1:
                        player2.Hit(player1);
                        break;
                    case 2:
                        player2.Ability(player1);
                        break;
                }

                if (player1.Health <= 0)
                {
                    player1.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 2");
                    break;
                }
            }
        }
    }

    public class BattleAIvAI //Бой ИИ против ИИ
    {
        public void BattleAIVsAI()
        {
            Start start = new Start();
            Random random = new Random();
            Console.WriteLine("\nИгрок 1, введите соответствующий номер");
            var numberPlayer1 = random.Next(1, 15);

            var player1 = start.ChooseCharacter(numberPlayer1); //Присвоение боту 1 рандомного персонажа
            Console.WriteLine($"Бот 1 выбрал персонажа {player1.Name} ");
            Console.WriteLine(
                $"{player1.Name} имеет {player1.Health} здоровья, {player1.Damage} урона, {player1.Armour} брони, {player1.DodgeChance}% вероятностью уклонения и {player1.Mana} маны.");

            var numberPlayer2 = random.Next(1, 15);
            var player2 = start.ChooseCharacter(numberPlayer2); //Присвоение боту 2 рандомного персонажа
            Console.WriteLine($"Бот 2 выбрал персонажа {player2.Name} ");
            Console.WriteLine(
                $"{player2.Name} имеет {player2.Health} здоровья, {player2.Damage} урона, {player2.Armour} брони, {player2.DodgeChance}% вероятностью уклонения и {player2.Mana} маны.");

            while ((player1.Health != 0) || (player2.Health != 0)) //Бой
            {
                Console.WriteLine(
                    $"\n{player1.Name} имеет {player1.Health} здоровья, {player1.Damage} урона, {player1.Armour} брони, {player1.DodgeChance}% вероятностью уклонения и {player1.Mana} маны.");
                Console.WriteLine("Ход бота 1:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                var buttonPlayer1 = random.Next(1, 3);
                switch (buttonPlayer1)
                {
                    case 1:
                        player1.Hit(player2);
                        break;
                    case 2:
                        player1.Ability(player2);
                        break;
                }

                if (player2.Health <= 0)
                {
                    player2.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 1");
                    break;
                }

                Console.WriteLine(
                    $"\n{player2.Name} имеет {player2.Health} здоровья, {player2.Damage} урона, {player2.Armour} брони, {player2.DodgeChance}% вероятностью уклонения и {player2.Mana} маны.");
                Console.WriteLine("Ход бота 2:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                var buttonPlayer2 = random.Next(1, 3);
                switch (buttonPlayer2)
                {
                    case 1:
                        player2.Hit(player1);
                        break;
                    case 2:
                        player2.Ability(player1);
                        break;
                }

                if (player1.Health <= 0)
                {
                    player1.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 2");
                    break;
                }
            }
        }
    }
}
