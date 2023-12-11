using GameDataParser.App;
using GameDataParser.DataAccess;
using GameDataParser.Logging;
using GameDataParser.UserInteraction;

ConsoleUserInteraction userInteraction = new ConsoleUserInteraction();
LocalFileReader localFileReader = new LocalFileReader();
VideoGamesDeserializer videoGamesDeserializer = new VideoGamesDeserializer(userInteraction);
GamesPrinter gamesPrinter = new GamesPrinter();
Logger logger = new Logger("log.txt");

var app = new Application(userInteraction, localFileReader, videoGamesDeserializer, gamesPrinter);
try
{
    app.Run();

}
catch (Exception ex)
{
    Console.WriteLine("Sorry! The applicaton has experienced an unexpected" +
        "error abd will have to be closed.");
    logger.Log(ex);

}

Console.WriteLine("Press any key to close.");
Console.ReadKey();