using CashCrusadersAssessmentConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a string:");
        var input = Console.ReadLine();

        Console.WriteLine("Please enter the character of which to find the count:");
        var character = Console.ReadKey();

        StringHelper.CountCharacterOccurance(character.KeyChar, input);
    }
}