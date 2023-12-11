
using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    internal class GamesPrinter : IGamesPrinter
    {
        public void PrintGames(List<Game> games)
        {
            foreach (var game in games)
            {
                Console.WriteLine(game.ToString());
            }
        }
    }
}
