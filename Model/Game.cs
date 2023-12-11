
namespace GameDataParser.Model
{
    public class Game
    {
        public string Title { get; init; }
        public int ReleaseYear { get; init; }
        public decimal Rating { get; init; }

        public override string ToString()
        {
            return $"{this.Title}, released in {this.ReleaseYear}, rating: {this.Rating}";
        }
    }

}
