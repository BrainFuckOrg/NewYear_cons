namespace NewYear_cons;

public class Trunk
{
    public static void printTrunk(Int32 height)
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
        }

    }
}