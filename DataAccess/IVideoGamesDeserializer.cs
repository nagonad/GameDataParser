
using GameDataParser.Model;

namespace GameDataParser.DataAccess
{
    internal interface IVideoGamesDeserializer
    {
        List<Game> DeserializeFrom(string fileName, string fileContent);
    }
}
