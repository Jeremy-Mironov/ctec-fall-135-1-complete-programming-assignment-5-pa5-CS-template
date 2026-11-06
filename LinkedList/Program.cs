/*
 * name: Eremei Mironov
 * course: ctec 135
 * assignment: programming assignment 5, task 4
 * date: 11/06/2026
 */

namespace LinkedList;

class Program
{
    static void Main(string[] args)
    {
        // rhyme words
        string[] words = { "The", "wheels", "on", "the", "bus", "go", "round", "and", "round" };

        // create linked list
        LinkedList<string> rhyme = new LinkedList<string>(words);

        // print with foreach
        Console.WriteLine("Printing the list");
        Console.Write("\t");
        foreach (string word in rhyme)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // walk the list
        Console.WriteLine("Printing the list by walking it");
        Console.Write("\t");
        LinkedListNode<string>? node = rhyme.First;
        while (node != null)
        {
            Console.Write($"{node.Value} ");
            node = node.Next;
        }
        Console.WriteLine();
        Console.WriteLine();

        // remove word
        LinkedListNode<string> busNode = rhyme.Find("bus")!;
        LinkedListNode<string> nodeBeforeBus = busNode.Previous!;
        rhyme.Remove(busNode);

        // print updated list
        Console.WriteLine("Printing the updated list");
        Console.Write("\t");
        foreach (string word in rhyme)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
        Console.WriteLine();

        // add word back
        rhyme.AddAfter(nodeBeforeBus, "bus");

        // print updated list
        Console.WriteLine("Printing the updated list");
        Console.Write("\t");
        foreach (string word in rhyme)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine();
    }
}
