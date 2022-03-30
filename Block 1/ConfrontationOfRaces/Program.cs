using System;

namespace ConfrontationOfRaces
{
    class Program
    {
        public static void Main()
        {
            var battlePvP = new BattlePvP();
            var battlePvAI = new BattlePvAI();
            var battleAIvAI = new BattleAIvAI();
            var start = new Start();
            Console.WriteLine("Нажмите: \n1, чтобы играть Игрок против Игрока \n2, чтобы играть Игрок против ИИ" +
                              "\n3, чтобы играть ИИ против ИИ");
            int typeOfGame = battlePvP.TypeOfGame();
            switch (typeOfGame)
            {
                case 1:
                    start.DefineClassesAndStartGame();                       //Реализация боя Игрока против Игрока
                    battlePvP.BattlePlayers();
                    break;
                case 2:
                    start.DefineClassesAndStartGame();                       //Реализация боя Игрока против Бота
                    battlePvAI.BattlePlayerVsAI();
                    break;
                case 3:
                    start.DefineClassesAndStartGame();                       //Реализация боя Бот против Бота
                    battleAIvAI.BattleAIVsAI();
                    break;
            }
        }
    }
}
