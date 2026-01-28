public class GameTools()
{
    public static void PrintBoard(sbyte[,] board)
    {
        Console.WriteLine("\n  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + 1 + " ");
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == 1)
                    Console.Write("X ");
                else if (board[i, j] == -1)
                    Console.Write("O ");
                else
                    Console.Write(". ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public int GameOverCheck(sbyte[,] board)
    {
        int sum;

        // Row check
        for (int i = 0; i < 3; i++)
        {
            sum = board[i, 0] + board[i, 1] + board[i, 2];
            if (Math.Abs(sum) == 3) { return sum / 3; }
        }

        // Column check
        for (int i = 0; i < 3; i++)
        {
            sum = board[0, i] + board[1, i] + board[2, i];
            if (Math.Abs(sum) == 3) { return sum / 3; };
        }

        // Diagonal: top left to bottom right
        sum = board[0, 0] + board[1, 1] + board[2, 2];
        if (Math.Abs(sum) == 3) { return sum / 3; }

        // Diagonal: bottom left to top right
        sum = board[0, 2] + board[1, 1] + board[2, 0];
        if (Math.Abs(sum) == 3) { return sum / 3; }

        return 0;
    }
}
