namespace ArraysAndLists;

class Program
{
    static void Main(string[] args)
    {
        #region simple array
        // create array
        int[] numbers = new int[5];

        // fill with 11-15
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i + 11;
        }

        // print array
        Console.WriteLine("Printing int array");
        foreach (int number in numbers)
        {
            Console.WriteLine($"\t{number}");
        }
        Console.WriteLine();
        #endregion

        #region list
        // create list
        List<int> numberList = new List<int>();

        // fill with 21-25
        for (int i = 21; i <= 25; i++)
        {
            numberList.Add(i);
        }

        // print list
        Console.WriteLine("Printing int list");
        foreach (int number in numberList)
        {
            Console.WriteLine($"\t{number}");
        }
        Console.WriteLine();

        // update to 31-35
        for (int i = 0; i < numberList.Count; i++)
        {
            numberList[i] = i + 31;
        }

        // print updated list
        Console.WriteLine("Printing updated list");
        for (int i = 0; i < numberList.Count; i++)
        {
            Console.WriteLine($"\t{numberList[i]}");
        }
        #endregion
    }
}
