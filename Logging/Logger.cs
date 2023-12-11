

namespace GameDataParser.Logging
{
    internal class Logger
    {
        private readonly string _fileName;
        public Logger(string fileName)
        {
            _fileName = fileName;
        }
        public void Log(Exception ex)
        {
            var errorMessage = $@"[{DateTime.Now}]
Exception message:{ex.Message}
Stack trace: {ex.StackTrace}

";
            File.AppendAllText(_fileName, errorMessage);
        }
    }
}
