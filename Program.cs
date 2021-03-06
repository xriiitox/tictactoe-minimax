namespace tictactoe {

    class Program {
        public static void Main() {
            Console.Clear();
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            Console.WriteLine("1. Human vs. AI\n2. Human vs. Human\n3. Quit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 4) {
                return;
            }
            Console.Write("\nEnter board size: ");
            int SIZE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Game game = new(SIZE);
            if ((SIZE == 1) || (SIZE == 2)) {
                Console.WriteLine(@"      ████████                          
    ██▒▒▒▒▒▒▒▒▒▒██                      
  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒██                    
██▒▒▒▒▒▒▒▒    ▒▒▒▒▒▒██                  
██▒▒▒▒▒▒▒▒▒▒▒▒  ▒▒▒▒▒▒██                
██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████            
██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██        
██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██  
  ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
    ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
    ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
      ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██
          ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██  
              ████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██    
                  ████████████████  ");
            }

            //game.Clear();
            game.Display();
            bool gameEnd = false;
            do {
                if (game.CheckForDraw(game.board)) {
                    Console.WriteLine("Draw! ");
                    gameEnd = true;
                }
                else {
                    game.UserMove('X');
                    Console.Clear();
                    game.Display();
                }
                if (game.CheckForWin('X', game.board)) {
                    Console.WriteLine("X Wins! ");
                    gameEnd = true;
                }
                else if (game.CheckForDraw(game.board)) {
                    Console.WriteLine("Draw! ");
                    gameEnd = true;
                }
                else {
                    if ((choice == 1)) {
                        game.DoAIBestMove(game, 'O', 'X');
                    }
                    else {
                        game.UserMove('O');
                    }
                    game.Display();
                }
                if (game.CheckForWin('O', game.board)) {
                    Console.WriteLine("O Wins! ");
                    gameEnd = true;
                }
            } while (!gameEnd);
            Thread.Sleep(1000);
            Console.Write("\nWould you like to play again? (y/n): ");
            string? playAgain = Console.ReadLine();
            switch (playAgain) {
                case "y":
                    Main();
                    break;
                case "n":
                    return;
                default:
                    Console.WriteLine("Invalid input. Exiting...");
                    return;
            }
        }
    }
}