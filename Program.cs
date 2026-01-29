// Defining and instantiating variables
bool gameOver = false;
sbyte[,] board = new sbyte[3, 3]; // 2D Array to make storing and retrieving game info easier (1 = X, -1 = O, 0 = empty)
GameTools gameTools = new GameTools(board);
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
    while (true)
    {
        gameTools.PrintBoard(board); // Prints board from method

        // Player 1 Input
        Console.Write("Player 1: Enter row (1 - 3): ");
        row1 = int.Parse(Console.ReadLine());
        row1 --; // Adjust for the index of the array (row)
        Console.Write("Player 1: Enter column (1 - 3): ");
        col1 = int.Parse(Console.ReadLine());
        col1--; // Adjust for the index of the array (col)


        if (col1 > 2 || col1 < 0 || row1 > 2 || row1 < 0)
        {
            Console.WriteLine("Oops. You chose an invalid spot on the board. Try again.");
            continue;
        }

        // Check to see if spot is open on game board
        if (board[row1, col1] == 0)
        {
            // Update the game board array
            board[row1, col1] = 1; // 1 = X
            break;
        }
        else
        {
            Console.WriteLine("Oops. You chose an already taken spot on the board. Try again.");
        }
    }

    // Check to see if there's a winner
    bool gameCheck1 = gameTools.GameOverCheck(board);

    // Logic for if Player 1 wins
    if (gameCheck1)
    {
        gameTools.PrintBoard(board); // Prints board from method
        break;
    }

    while (true)
    {
        gameTools.PrintBoard(board); // Prints board from method

        // Player 2 Input
        Console.Write("Player 2: Enter row (1 - 3): ");
        row2 = int.Parse(Console.ReadLine());
        row2 --; // Adjust for the index of the array (row)
        Console.Write("Player 2: Enter column (1 - 3): ");
        col2 = int.Parse(Console.ReadLine());
        col2--;

        if (col2 > 2 || col2 < 0 || row2 > 2 || row2 < 0){
            Console.WriteLine("Oops. You chose an invalid spot on the board. Try again.");
            continue;
        }

        // Check to see if spot is open on game board
        if (board[row2, col2] == 0)
        {
            // Update the game board array
            board[row2, col2] = -1; // -1 = O
            break;
        }
        else
        {
            Console.WriteLine("Oops. You chose an already taken spot on the board. Try again.");
        }
    }

    // Check to see if there's a winner
    bool gameCheck2 = gameTools.GameOverCheck(board);

    // Logic for if Player 2 wins
    if (gameCheck2)
    {
        gameTools.PrintBoard(board); // Prints board from method
        break;
    }
}

Console.WriteLine("Thanks for playing! Goodbye! :)"); // Departing message
