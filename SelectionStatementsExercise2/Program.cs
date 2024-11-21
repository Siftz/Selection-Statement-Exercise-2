namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is you favorite school subject?");
            string favSubject = Console.ReadLine();
            //switch added
            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is fun, but make sure to do your homework!");
                    break;
                case "science":
                    Console.WriteLine("Science is a blast, especially if you add the right compounds!");
                    break;
                case "History":
                    Console.WriteLine("History brings the worlds past to the present!");
                    break;
                case "geography":
                    Console.WriteLine("I don't prefer geography, but it's good to know where you are!");
                    break;
                case "art":
                    Console.WriteLine("Oh! A renaissance heart, that is a good subject!");
                    break;
                default:
                    Console.WriteLine("That's an interesting subject!");
                    break;
                        
            }
        }
    }
}