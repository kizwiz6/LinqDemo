using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    // make test scores
    static int[] scores = { 50, 66, 90, 81, 77, 45, 0, 100, 99, 74, 85, 82, 80, 88, 89, 23, 43, 11, 15, 98 };

    private static void Main(string[] args)
    {


        // print the scores
        foreach (var item in scores)
        {
            Console.WriteLine("One of the scores was {0}", item);
        }

        // pause statement to see the output
        Console.ReadLine();

        // use LINQ to filter the list
        var theBestStudents =
            from item in scores
            where item > 90
            select item;

        // print only the best scores
        foreach (var item in theBestStudents)
        {
            Console.WriteLine("One of the highest scores was {0}", item);
        }

        // Pause to see the output
        Console.ReadLine();

        // show a sorted list
        var sortedScores =
            from item in scores
            orderby item descending
            select item;

        // print only the best scores
        foreach (var item in sortedScores)
        {
            Console.WriteLine("One of the highest scores was {0}", item);
        }

        Console.ReadLine();

        bStudents();
    }


    public static void bStudents()
    {
        // use LINQ to filter the list
        var theBStudents =
            from item in scores
            where item > 80 && item < 90
            orderby item descending
            select item;

        // print only the best scores
        foreach (var item in theBStudents)
        {
            Console.WriteLine("List of B student scores: {0}", item);
        }

        Console.WriteLine(theBStudents);

        // Pause to see the output
        Console.ReadLine();
    }
}