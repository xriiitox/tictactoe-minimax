public class Game {
        public int SIZE;
        public char[,] board;
        public int userX, userY, AIX, AIY;
        public string? userMoveThree;
        

        public Game(int SIZE) {
            this.SIZE = SIZE;
            this.board = new char[SIZE, SIZE];
            this.userX = 0;
            this.userY = 0;
            this.AIX = 0;
            this.AIY = 0;
            this.userMoveThree = "";
        }
        public void SetUserMove(int x, int y) {
            this.userX = x;
            this.userY = y;
        }
        public void SetAIMove(int x, int y) {
            this.AIX = x;
            this.AIY = y;
        }
        public void SetBoard(char[,] board) {
            this.board = board;
        }
        public void Clear() {
            for (int x = 0; x < this.SIZE; x++) {
                for (int y = 0; y < this.SIZE; y++) {
                    this.board[x, y] = (char)0;
                }
            }
        }
        public void Display() {
            for (int y = 0; y < this.SIZE - 1; y++) {
                for (int x = 0; x < this.SIZE - 1; x++) {
                    Console.Write($"{this.board[x, y]}|");
                }
                Console.WriteLine(this.board[SIZE - 1, y]);
                for (int i = 0; i < this.SIZE - 1; i++) {
                    Console.Write("-+");
                }
                Console.WriteLine("-");
            }
            for (int x = 0; x < this.SIZE - 1; x++) {
                Console.Write($"{this.board[x, this.SIZE - 1]}|");
            }
            Console.WriteLine(this.board[this.SIZE - 1, this.SIZE - 1]);
            Console.WriteLine();
        }
        public bool CheckForWin(char player, char[,] board) {
            int row;
            int col;
            int diag;
            bool win;
            for (row = 0; row < this.SIZE; row++) {
                win = true;
                for (col = 0; col < this.SIZE; col++) {
                    if (board[row, col] != player) { win = false; }
                }
                if (win) { return win; }
            }
            for (col = 0; col < this.SIZE; col++) {
                win = true;
                for (row = 0; row < this.SIZE; row++) {
                    if (board[row, col] != player) { win = false; }
                }
                if (win) { return win; }
            }
            win = true;
            for (diag = 0; diag < this.SIZE; diag++) {
                if (board[diag, diag] != player) { win = false; }
            }
            if (win) { return win; }
            win = true;
            for (diag = 0; diag < this.SIZE; diag++) {
                if (board[diag, this.SIZE - 1 - diag] != player) { win = false; }
            }
            return win;
        }
        public void Move(char player, int x, int y) {
            this.board[x, y] = player;
        }
        public bool CheckIllegalMovesPlayer(int x, int y) {
            return ((x >= this.SIZE) || (y >= this.SIZE) || (this.board[x, y] == 'X') || (this.board[x, y] == 'O'));
        }
        public void UserMove(char player) {
            if (this.SIZE!=3) {
                Console.WriteLine("Input Legal X Coordinate: ");
                this.userX = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input Legal Y Coordinate: ");
                this.userY = Convert.ToInt32(Console.ReadLine());
                if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                    Console.WriteLine("\nIllegal move! Please try again. \n");
                    this.UserMove(player);
                }
                else {
                    this.Move(player, this.userX, this.userY);
                }
            } else {
                Console.WriteLine("Input Position (eg. topright, middle, bottomleft): ");
                this.userMoveThree = Console.ReadLine();
                switch (this.userMoveThree) {
                    case "topleft":
                        this.SetUserMove(0, 0);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "topmiddle":
                        this.SetUserMove(1, 0);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "topright":
                        this.SetUserMove(2, 0);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "middleleft":
                        this.SetUserMove(0, 1);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "middle":
                        this.SetUserMove(1, 1);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "middleright":
                        this.SetUserMove(2, 1);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "bottomleft":
                        this.SetUserMove(0, 2);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "bottommiddle":
                        this.SetUserMove(1, 2);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case "bottomright":
                        this.SetUserMove(2, 2);
                        if (this.CheckIllegalMovesPlayer(this.userX, this.userY)) {
                            Console.WriteLine("\nIllegal move! Please try again. \n");
                            this.UserMove(player);
                        }
                        else {
                            this.Move(player, this.userX, this.userY);
                        }
                        break;
                    case null:
                        Console.WriteLine("\nIllegal move! Please try again. \n");
                        this.UserMove(player);
                        break;
                    default:
                        Console.WriteLine("\nIllegal move! Please try again. \n");
                        this.UserMove(player);
                        break;
                }
            }
        }
        public bool CheckIllegalMovesAI() {
            return ((this.board[this.AIX, this.AIY] == 'X') || (this.board[this.AIX, this.AIY] == 'O'));
        }
        
        public void DoAIBestMove(Game game, char ai, char player) {
            int i, j, score;
            int bestScore = -1000;
            char[,] backupBoard = game.board;
            //char[,] this.board = this.board;
            for (i = 0; i < this.SIZE; i++) {
                for (j = 0; j < this.SIZE; j++) {
                    if (backupBoard[i, j] == (char)0) {
                        backupBoard[i,j] = ai;
                        score = Minimax.minimax(backupBoard, 0, true, game, player, ai, int.MinValue, int.MaxValue);
                        backupBoard[i, j] = (char)0;
                        if (score > bestScore) {
                            bestScore = score;
                            this.AIX = i;
                            this.AIY = j;
                            //goto LoopEnd;
                        }
                    }
                }
            }
            Console.WriteLine($"The best move is: {this.AIX}, {this.AIY}\n");
            this.Move(ai, this.AIX, this.AIY);
        }
        public bool CheckForDraw(char[,] board) {
            int row;
            int col;
            for (row = 0; row < this.SIZE; row++) {
                for (col = 0; col < this.SIZE; col++) {
                    if (board[row, col] == (char)0) { return false; }
                }
            }
            return true;
        }
    }
