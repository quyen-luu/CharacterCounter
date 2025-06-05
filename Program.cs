public class Program
{
    public static int CharacterCounter(string inputString, char character)
    {
        int count = 0;
        foreach (char c in inputString)
        {
            if (c == character)
            {
                count++;
            }
        }
        return count;
    }

    public static bool nullorEmpty(string inputString)
    {
        if (string.IsNullOrEmpty(inputString))
        {
            Console.WriteLine("No character entered!");
            return false;
        }
        return true;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string? inputString = Console.ReadLine();
        if (!nullorEmpty(inputString))
            return;

        Console.WriteLine("------");
        Console.Write("Enter the character to count: ");
        string? characterInput = Console.ReadLine();
        if (!nullorEmpty(characterInput))
            return;

        Console.WriteLine("------");
        char character = characterInput[0];
        int result = CharacterCounter(inputString, character);
        Console.Write($"Character '{character}' appears {result} times.");



    }
}