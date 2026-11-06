namespace StacksAndQueues;

class Program
{
    static void Main(string[] args)
    {
        #region stack
        // create stack
        int[] initialValues = { 1, 2, 3, 4, 5 };
        Stack<int> stack = new Stack<int>(initialValues);

        // print stack
        Console.WriteLine("Printing the stack");
        foreach (int number in stack)
        {
            Console.WriteLine($"\t{number}");
        }
        Console.WriteLine();

        // peek
        Console.WriteLine($"Top of Stack: {stack.Peek()}");
        Console.WriteLine();

        // pop and print
        Console.WriteLine("Printing the stack");
        while (stack.Count > 0)
        {
            Console.WriteLine($"\t{stack.Pop()}");
        }
        Console.WriteLine();
        #endregion

        #region queue
        // create queue
        Queue<int> queue = new Queue<int>();

        // fill with 1-5
        for (int i = 1; i <= 5; i++)
        {
            queue.Enqueue(i);
        }

        // print queue
        Console.WriteLine("Print the queue");
        foreach (int number in queue)
        {
            Console.WriteLine($"\t{number}");
        }
        Console.WriteLine();

        // peek
        Console.WriteLine($"Top of queue: {queue.Peek()}");
        Console.WriteLine();

        // dequeue and print
        Console.WriteLine("Dequeue and print values");
        while (queue.Count > 0)
        {
            Console.WriteLine($"\t{queue.Dequeue()}");
        }
        #endregion
    }
}
