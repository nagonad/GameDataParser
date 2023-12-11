

namespace GameDataParser.UserInteraction
{
    public interface IUserInteraction
    {
        string GetFileNameFromUser();
        void PrintMessage(string message);

        void PrintError(string fileName, string FileContent);
    }
}
