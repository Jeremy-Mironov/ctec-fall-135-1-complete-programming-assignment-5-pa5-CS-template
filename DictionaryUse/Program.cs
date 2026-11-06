namespace DictionaryUse;

class Program
{
    static void Main(string[] args)
    {
        // create dictionary
        Dictionary<int, string> numbers = new Dictionary<int, string>
        {
            { 1, "one" },
            { 2, "two" },
            { 3, "three" }
        };

        // add 99
        numbers.Add(99, "ninety-nine");

        // print with keyvaluepair
        Console.WriteLine("Printing the dictionary using KeyValuePair type");
        foreach (KeyValuePair<int, string> entry in numbers)
        {
            Console.WriteLine($"\tkey: {entry.Key,-2} value: {entry.Value}");
        }
        Console.WriteLine();

        // print with var
        Console.WriteLine("Printing the dictionary using implicit type");
        foreach (var entry in numbers)
        {
            Console.WriteLine($"\tkey: {entry.Key,-2} value: {entry.Value}");
        }
        Console.WriteLine();

        // update 99
        numbers[99] = "99";

        // print 99
        Console.WriteLine("Printing value of 99");
        Console.WriteLine($"\t{numbers[99]}");
        Console.WriteLine();

        // remove 2
        numbers.Remove(2);

        // print updated dictionary
        Console.WriteLine("Printing the updated dictionary");
        foreach (var entry in numbers)
        {
            Console.WriteLine($"\tkey: {entry.Key,-2} value: {entry.Value}");
        }
    }
}
