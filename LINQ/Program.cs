namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("string list of games");
            var games = new string[]
                { "MLB The Show 24", "Red Dead 2", "John Madden 24", "NCAA Football 24", "Undisputed WBC" };
            
            //Filtering with LINQ
            var orderNames = games.OrderByDescending(x => x.Length);

            foreach (var game in orderNames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
