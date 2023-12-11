
using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    internal interface IGamesPrinter
    {
        void PrintGames(List<Game> games);
    }
}
