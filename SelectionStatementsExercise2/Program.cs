namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whst is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;
                case "science":
                    Console.WriteLine("Science is a hard subject!");
                    break;
                case "english":
                    Console.WriteLine("English is a interesting subject!");
                    break;
                default:
                    Console.WriteLine($"Nice!, I haven't taken that subject before. {subject} sounds fun!");
                    break;
            }
        }
    }
}