using System;

namespace ConfrontationOfRaces
{
    class Program
    {
        public static void Main()
        {
            var battlePvp = new BattlePvP();
            var battlePvAI = new BattlePvAI();
            var battleAIvAI = new BattleAIvAI();
            var start = new Start();
            Console.WriteLine("Нажмите: \n1, чтобы играть Игрок против Игрока \n2, чтобы играть Игрок против ИИ" +
                              "\n3, чтобы играть ИИ против ИИ");
            int typeOfGame = Int32.Parse(Console.ReadLine());
            switch (typeOfGame)
            {
                case 1:
                    start.defineClassesAndStartGame();                       //Реализация боя Игрока против Игрока
                    battlePvp.BattlePlayers();
                    break;
                case 2:
                    start.defineClassesAndStartGame();                       //Реализация боя Игрока против Бота
                    battlePvAI.BattlePlayerVsAI();
                    break;
                case 3:
                    start.defineClassesAndStartGame();                       //Реализация боя Бот против Бота
                    battleAIvAI.BattleAIVsAI();
                    break;
            }
        }
    }
}
