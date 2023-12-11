
using GameDataParser.DataAccess;
using GameDataParser.UserInteraction;

namespace GameDataParser.App
{
    internal class Application
    {
        IUserInteraction _userInteraction;
        IFileReader _localFileReader;
        IVideoGamesDeserializer _videoGamesDeserializer;
        IGamesPrinter _gamesPrinter;

        public Application(IUserInteraction userInteraction, IFileReader localFileReader,
            IVideoGamesDeserializer videGamesDeserializer, IGamesPrinter gamesPrinter)
        {
            _userInteraction = userInteraction;
            _localFileReader = localFileReader;
            _videoGamesDeserializer = videGamesDeserializer;
            _gamesPrinter = gamesPrinter;

        }
        public void Run()
        {
            var fileName = _userInteraction.GetFileNameFromUser();
            var fileContent = _localFileReader.Read(fileName);
            var videoGames = _videoGamesDeserializer.DeserializeFrom(fileName, fileContent);
            _gamesPrinter.PrintGames(videoGames);
        }


    }
}
