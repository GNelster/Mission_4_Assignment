using GameTools;

// Defining and instantiating variables
bool gameOver = false;
// Note that -1 is O, 0 is empty, and 1 is X
sbyte[,] board = new sbyte[3, 3]; // 2D Array to make storing and retrieving game info easier
GameTools gameTools = new GameTools();
int row1, col1;
int row2, col2;

// Welcome the user to the game
Console.WriteLine("Welcome to our Tic Tac Toe Game! Hope you enjoy.");
Console.Write("Preparing the game board");
Thread.Sleep(300);
Console.Write(".");
Thread.Sleep(300);
Console.Write(".");
Thread.Sleep(300);
Console.Write(".");
Console.WriteLine("\nPlayer 1 is 'X', and Player 2 is 'O'.\n");

// Ensures the game continues until the game ends
while (!gameOver)
{
    // Print game board
    gameTools.PrintBoard(board);

    while (true)
    {
        // Player 1 Input
        Console.WriteLine("Player 1: Enter row (1 - 3): ");
        row1 = int.Parse(Console.ReadLine());
        row1 = row1 - 1; // Adjust for the index of the array (row)
        Console.WriteLine("Player 1: Enter column (1 - 3): ");
        col1 = int.Parse(Console.ReadLine());
        col1 = col1 - 1; // Adjust for the index of the array (col)

        // Check to see if spot is open on game board
        if (!(board[row1, col1] == 1 || board[row1, col1] == -1))
        {
            // Update the game board array
            board[row1, col1] = 1;
            break;
        }
        else
        {
            Console.WriteLine("Oops. You chose an already taken spot on the board. Try again.");
        }
    }

    // Check to see if there's a winner
    int gameCheck1 = gameTools.GameOverCheck(board);

    // Logic for if Player 1 wins
    if (gameCheck1 != 0)
    {
        gameTools.PrintBoard(board); // Prints board from method
        gameOver = true;
        break;
    }

    while (true)
    {
        // Player 2 Input
        Console.WriteLine("Player 2: Enter row (1 - 3): ");
        row2 = int.Parse(Console.ReadLine());
        row2 = row2 - 1; // Adjust for the index of the array (row)
        Console.WriteLine("Player 2: Enter column (1 - 3): ");
        col2 = int.Parse(Console.ReadLine());
        col2 = col2 - 1;

        // Check to see if spot is open on game board
        if (!(board[row2, col2] == 1 || board[row2, col2] == -1))
        {
            // Update the game board array
            board[row2, col2] = -1;
            break;
        }
        else
        {
            Console.WriteLine("Oops. You chose an already taken spot on the board. Try again.");
        }
    }

    // Check to see if there's a winner
    int gameCheck2 = gameTools.GameOverCheck(board);

    // Logic for if Player 2 wins
    if (gameCheck2 != 0)
    {
        gameTools.PrintBoard(board); // Prints board from method
        gameOver = true;
        break;
    }
}

Console.WriteLine("Thanks for playing! Goodbye! :)"); // Departing message
