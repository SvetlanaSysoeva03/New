class Program
{
    static void Main()
    {
        string[] originalArray = { "Hello", "2", "world", ":-)" };
        string[] newArray = FilterArray(originalArray);
        
        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);
        
        Console.WriteLine("\nНовый массив:");
        PrintArray(newArray);
    }

    static string[] FilterArray(string[] array)
    {
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

    static void PrintArray(string[] array)
    {
        foreach (string str in array)
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }
}