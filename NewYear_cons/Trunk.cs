namespace NewYear_cons;

public class Trunk
{
    public static void PrintTrunk(Int32 height)
    {
        String trunk = "BFO";
        Int32 center = Console.WindowWidth / 2;
        for (Int32 j = 0; j < height; j++)
        {
            for (Int32 i = 0; i < center; i++)
            {
                Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(trunk);
            Console.ResetColor();
        }

    }

    public static void BfOwish()
    {
        String[] wishes = new String[]
        {
            "Brain Fuck organisation wishes you to:", "write code like crazy","take part in the inhuman experiments","and have fun with coding"
        };
        Console.ForegroundColor = ConsoleColor.Green;
        Int32 center = Console.WindowWidth / 2;
        foreach (var wish in wishes)
        {
            for (Int32 i = 0; i < center; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(wish);
        }
    }
}