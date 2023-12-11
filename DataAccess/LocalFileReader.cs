
namespace GameDataParser.DataAccess
{
    internal class LocalFileReader : IFileReader
    {
        public string Read(string fileName)
        {
            return File.ReadAllText(fileName);
        }
    }
}
