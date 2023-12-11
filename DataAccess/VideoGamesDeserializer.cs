
using GameDataParser.Model;
using GameDataParser.UserInteraction;
using System.Text.Json;

namespace GameDataParser.DataAccess
{
    internal class VideoGamesDeserializer : IVideoGamesDeserializer
    {
        IUserInteraction _userInteraction;
        public VideoGamesDeserializer(IUserInteraction userInteraction)
        {
            _userInteraction = userInteraction;
        }
        public List<Game> DeserializeFrom(string fileName, string fileContent)
        {
            try
            {
                return JsonSerializer.Deserialize<List<Game>>(fileContent);

            }
            catch (JsonException ex)
            {
                Console.WriteLine("json parse exception");
                _userInteraction.PrintError(fileName, fileContent);
                throw new JsonException($"{ex.Message} The file is: {fileName}", ex);
            }

        }
    }
}
