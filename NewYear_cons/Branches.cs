namespace NewYear_cons;

public class Branches
{
    private static ConsoleColor[] _adequateColors = {ConsoleColor.Magenta,ConsoleColor.Cyan,ConsoleColor.Blue,ConsoleColor.Yellow, ConsoleColor.Red };
    private static Char[] _balls = {'⪋','⨁','⨖','ℼ' };
    public static void PrintBranches(Char leaf, Byte heigh, Byte ballPercent)
    {
        Random rnd = new Random();
        for (int i = 0; i < heigh; i++)
        {
            Console.Write(new String(' ', Console.WindowWidth / 2 - i));
            for (int j = 0; j < 1 + 2 * i; j++)
            {
                if (rnd.Next(0, 100) < ballPercent)
                {
                    Console.ForegroundColor = _adequateColors[rnd.Next(0, _adequateColors.Length)];
                    Console.Write(_balls[rnd.Next(0, _balls.Length)]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(leaf);
                }
            }
        }
        Console.ResetColor();
    }
}