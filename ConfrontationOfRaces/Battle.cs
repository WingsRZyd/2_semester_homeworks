namespace ConfrontationOfRaces
{
    
    public class BattlePvP                                                       //Бой Игрока против Игрока
    {
        public void BattlePlayers()
        {
            Start start = new Start();
            Console.WriteLine("\nИгрок 1, введите соответствующий номер");       
            int numberPlayer1 = Int32.Parse(Console.ReadLine());                 //Выбор игроком 1 персонажа
                
            var Player1 = start.ChooseCharacter(numberPlayer1);          //Присвоение Игроку 1 персонажа
            Console.WriteLine($"Игрок 1 выбрал персонажа {Player1.Name} ");
            Console.WriteLine($"{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");
                
            Console.WriteLine("\nИгрок 2, введите соответствующий номер");
            int numberPlayer2 = Int32.Parse(Console.ReadLine());                 //Выбор игроком 2 персонажа
            var Player2 = start.ChooseCharacter(numberPlayer2);          //Присвоение Игроку 2 персонажа
            Console.WriteLine($"Игрок 2 выбрал персонажа {Player2.Name} ");
            Console.WriteLine($"{Player2.Name} имеет {Player2.Health} здоровья, {Player2.Damage} урона, {Player2.Armour} брони, {Player2.DodgeChance}% вероятностью уклонения и {Player2.Mana} маны.");
            
            while ((Player1.Health != 0) || (Player2.Health != 0))      //Бой
            {
                Console.WriteLine($"\n{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");
                Console.WriteLine("Ход игрока 1:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer1 = Int32.Parse(Console.ReadLine());             //Выбор вида атаки
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
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer2 = Int32.Parse(Console.ReadLine());
                switch (buttonPlayer2)                                           //Выбор вида атаки
                {
                    case 1:
                        Player2.Hit(Player1);
                        break;
                    case 2:
                        Player2.Ability(Player1);
                        break;
                }

                if (Player1.Health <= 0)
                {
                    Player1.Health = 0;
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
            Start start = new Start();
            Console.WriteLine("\nИгрок 1, введите соответствующий номер");       
            int numberPlayer1 = Int32.Parse(Console.ReadLine());
                
            var Player1 = start.ChooseCharacter(numberPlayer1);         //Присвоение игроку персонажа
            Console.WriteLine($"Игрок 1 выбрал персонажа {Player1.Name} ");
            Console.WriteLine($"{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");

            Random random = new Random();                                        
            int numberPlayer2 = random.Next(1, 15);     
            var Player2 = start.ChooseCharacter(numberPlayer2);         //Присвоение боту рандомного персонажа
            Console.WriteLine($"Бот выбрал персонажа {Player2.Name} ");          
            Console.WriteLine($"{Player2.Name} имеет {Player2.Health} здоровья, {Player2.Damage} урона, {Player2.Armour} брони, {Player2.DodgeChance}% вероятностью уклонения и {Player2.Mana} маны.");
            
            while ((Player1.Health != 0) || (Player2.Health != 0))               //Бой
            {
                Console.WriteLine($"\n{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");
                Console.WriteLine("Ход игрока 1:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
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
                Console.WriteLine("Ход бота 2:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer2 = random.Next(1,3);
                switch (buttonPlayer2)
                {
                    case 1:
                        Player2.Hit(Player1);
                        break;
                    case 2:
                        Player2.Ability(Player1);
                        break;
                }

                if (Player1.Health <= 0)
                {
                    Player1.Health = 0;
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
            int numberPlayer1 = random.Next(1, 15);

            var Player1 = start.ChooseCharacter(numberPlayer1); //Присвоение боту 1 рандомного персонажа
            Console.WriteLine($"Бот 1 выбрал персонажа {Player1.Name} ");
            Console.WriteLine(
                $"{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");

            int numberPlayer2 = random.Next(1, 15);
            var Player2 = start.ChooseCharacter(numberPlayer2); //Присвоение боту 2 рандомного персонажа
            Console.WriteLine($"Бот 2 выбрал персонажа {Player2.Name} ");
            Console.WriteLine(
                $"{Player2.Name} имеет {Player2.Health} здоровья, {Player2.Damage} урона, {Player2.Armour} брони, {Player2.DodgeChance}% вероятностью уклонения и {Player2.Mana} маны.");

            while ((Player1.Health != 0) || (Player2.Health != 0)) //Бой
            {
                Console.WriteLine(
                    $"\n{Player1.Name} имеет {Player1.Health} здоровья, {Player1.Damage} урона, {Player1.Armour} брони, {Player1.DodgeChance}% вероятностью уклонения и {Player1.Mana} маны.");
                Console.WriteLine("Ход бота 1:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer1 = random.Next(1, 3);
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

                Console.WriteLine(
                    $"\n{Player2.Name} имеет {Player2.Health} здоровья, {Player2.Damage} урона, {Player2.Armour} брони, {Player2.DodgeChance}% вероятностью уклонения и {Player2.Mana} маны.");
                Console.WriteLine("Ход бота 2:");
                Console.WriteLine("Нажмите: \n1, чтобы нанести атаку    \n2, чтобы использовать способность");
                int buttonPlayer2 = random.Next(1, 3);
                switch (buttonPlayer2)
                {
                    case 1:
                        Player2.Hit(Player1);
                        break;
                    case 2:
                        Player2.Ability(Player1);
                        break;
                }

                if (Player1.Health <= 0)
                {
                    Player1.Health = 0;
                    Console.WriteLine("Игра закончилась, победил игрок 2");
                    break;
                }
            }
        }
    }
}
