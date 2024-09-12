namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>{"Satisfactory", "Heroes of the Storm", "Valheim"};
            videoGames = videoGames.OrderBy(x => x).ToList();

            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame);
            }
        }
    }
}
