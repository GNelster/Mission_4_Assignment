public class GameTools
{
    public GameTools(sbyte[,] board) { }

    public void PrintBoard(sbyte[,] board)
    {
        Console.WriteLine("\n     1   2   3");
        Console.WriteLine("   +---+---+---+");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($" {i + 1} ");

            for (int j = 0; j < 3; j++)
            {
                string content = board[i, j] == 1 ? "X" : (board[i, j] == -1 ? "O" : " ");
                Console.Write($"| {content} ");
            }

            Console.WriteLine("|");
            Console.WriteLine("   +---+---+---+");
        }
        Console.WriteLine();
    }

    public bool GameOverCheck(sbyte[,] board)
    {
        int sum;

        // Row check
        for (int i = 0; i < 3; i++)
        {
            sum = board[i, 0] + board[i, 1] + board[i, 2];
            if (Math.Abs(sum) == 3) { return true; }
        }

        // Column check
        for (int i = 0; i < 3; i++)
        {
            sum = board[0, i] + board[1, i] + board[2, i];
            if (Math.Abs(sum) == 3) { return true; }
        }

        // Diagonal: top left to bottom right
        sum = board[0, 0] + board[1, 1] + board[2, 2];
        if (Math.Abs(sum) == 3) { return true; }

        // Diagonal: bottom left to top right
        sum = board[0, 2] + board[1, 1] + board[2, 0];
        if (Math.Abs(sum) == 3) { return true; }

        return false;
    }
}
