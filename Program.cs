internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Application Console pour voir le fonctionnement du LINQ");
        Console.WriteLine("Grouper des nombres par parité :");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var groups = from n in numbers
                     group n by n % 2 into g
                     select new { key = g.Key, numbers = g };

        foreach (var group in groups)
        {
            Console.WriteLine(group.key == 0 ? "Even:" : "Odd");
            foreach (var num in group.numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}