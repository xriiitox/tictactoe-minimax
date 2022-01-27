public class Minimax {
  public static int minimax(char[,] board, int depth, bool isMaximizing, Game game, char player, char ai) {
    bool scoreXhuman = game.CheckForWin(player, board);
    bool scoreOAI = game.CheckForWin(ai, board);
    if (scoreXhuman) {
      return -10;
    } else if (scoreOAI) {
      return 10;
    } else if (game.CheckForDraw(board)) {
      return 0;
    }

    if (isMaximizing) {
      int bestScore = -1000;
      for (int i = 0; i < game.SIZE; i++) {
        for (int j = 0; j < game.SIZE; j++) {
          if (board[i,j] == (char)0) {
            board[i,j] = ai;
            bestScore = Math.Max(bestScore, minimax(board, depth + 1, !isMaximizing, game, 'X', 'O'));
            board[i,j] = (char)0;
          }
        }
      }
      return bestScore;
    } else {
      int bestScore = 1000;
      for (int i = 0; i < game.SIZE; i++) {
        for (int j = 0; j < game.SIZE; j++) {
          if (board[i,j] == (char)0) {
            board[i,j] = player;
            bestScore = Math.Min(bestScore, minimax(board, depth + 1, !isMaximizing, game, 'X', 'O'));
            board[i,j] = (char)0;

          }
        }
      }
      return bestScore;
    }
  }
}