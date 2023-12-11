

namespace GameDataParser.UserInteraction
{
    public class ConsoleUserInteraction : IUserInteraction
    {
        public string GetFileNameFromUser()
        {
            bool IsFileNameNotValid = true;
            string userInput;

            do
            {
                Console.WriteLine("Enter the name of the file you want to read:");
                userInput = Console.ReadLine();
                if (userInput is null)
                {
                    Console.WriteLine("File name cannot be null.");
                }
                else if (userInput.Length < 1)
                {
                    Console.WriteLine("File name cannot be empty.");
                }
                else if (!File.Exists(userInput))
                {
                    Console.WriteLine("File not found.");
                }
                else
                {
                    IsFileNameNotValid = false;
                }
            } while (IsFileNameNotValid);
            return userInput;
        }

        public void PrintError(string fileName, string FileContent)
        {
            Console.WriteLine($"JSON in the {fileName} was now in a valid format.");
            Console.WriteLine("JSON body: ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(FileContent);
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }


    }

}

