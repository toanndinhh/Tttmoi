using System;

namespace TICTACTOEnewapp
{
    class Board
    {

        public char[,] cells = new char[3, 3]
        {
                {'0' ,'1', '2'},
                {'3', '4', '5'},
                {'6' ,'7', '8'},

        };

        public bool checkDraw = false;
        public void DrawBoard()
        {
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", cells[0, 0], cells[0, 1], cells[0, 2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", cells[1, 0], cells[1, 1], cells[1, 2]);
            Console.WriteLine("-------------");
            Console.WriteLine("| {0} | {1} | {2} |", cells[2, 0], cells[2, 1], cells[2, 2]);
            Console.WriteLine("-------------");
            Console.ReadLine();
        }
        public bool validWinnerX = true;
        public bool validWinnerO = true;
        public void WinnerX(Game game)
        {
            if (((cells[0, 0] == game.choiceX) && (cells[1, 1] == game.choiceX) && (cells[2, 2] == game.choiceX))
                || ((cells[0, 2] == game.choiceX) && (cells[1, 1] == game.choiceX) && (cells[2, 0] == game.choiceX))
                || ((cells[0, 0] == game.choiceX) && (cells[0, 1] == game.choiceX) && (cells[0, 2] == game.choiceX))
                || ((cells[1, 0] == game.choiceX) && (cells[1, 1] == game.choiceX) && (cells[1, 0] == game.choiceX))
                || ((cells[2, 0] == game.choiceX) && (cells[2, 1] == game.choiceX) && (cells[2, 2] == game.choiceX))
                || ((cells[0, 0] == game.choiceX) && (cells[1, 0] == game.choiceX) && (cells[2, 0] == game.choiceX))
                || ((cells[0, 1] == game.choiceX) && (cells[1, 1] == game.choiceX) && (cells[2, 1] == game.choiceX))
                || ((cells[0, 2] == game.choiceX) && (cells[1, 2] == game.choiceX) && (cells[2, 2] == game.choiceX)))
            {
                Console.WriteLine("!!!!!!!!!! Congratulation X is the WINNER !!!!!!!!!");
                checkDraw = true;                
            }
            validWinnerX= false;
        }
        public void WinnerO(Game game) { 
            if (((cells[0, 0] == game.choiceO) && (cells[1, 1] == game.choiceO) && (cells[2, 2] == game.choiceO))
                || ((cells[0, 2] == game.choiceO) && (cells[1, 1] == game.choiceO) && (cells[2, 0] == game.choiceO))
                || ((cells[0, 0] == game.choiceO) && (cells[0, 1] == game.choiceO) && (cells[0, 2] == game.choiceO))
                || ((cells[1, 0] == game.choiceO) && (cells[1, 1] == game.choiceO) && (cells[1, 0] == game.choiceO))
                || ((cells[2, 0] == game.choiceO) && (cells[2, 1] == game.choiceO) && (cells[2, 2] == game.choiceO))
                || ((cells[0, 0] == game.choiceO) && (cells[1, 0] == game.choiceO) && (cells[2, 0] == game.choiceO))
                || ((cells[0, 1] == game.choiceO) && (cells[1, 1] == game.choiceO) && (cells[2, 1] == game.choiceO))
                || ((cells[0, 2] == game.choiceO) && (cells[1, 2] == game.choiceO) && (cells[2, 2] == game.choiceO)))
            {
                Console.WriteLine("!!!!!!!!! Congratulation O is the WINNER !!!!!!!!!");
                checkDraw = true;
            }
            validWinnerO = false;
        }

        public void Draw()
        {
            if (!checkDraw)
            {
                Console.WriteLine("----------------DRAW----------------");
            }
        }
         public bool validcheck = false;
        public void Check(Game game)
        {
            if (((cells[0, 0] == game.choiceX) && (cells[0, 0] == game.choiceO))
                 || (cells[0, 1] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[0, 2] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[1, 0] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[1, 1] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[1, 2] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[2, 0] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[2, 1] == game.choiceX) && (cells[0, 0] == game.choiceO)
                 || (cells[2, 2] == game.choiceX) && (cells[0, 0] == game.choiceO))
            {
                validcheck = true;
            }
        }

        public void ResetBoard()
        {
            char[,] aircells = new char[3, 3]
            {
                    { '0', '1', '2' },
                    { '3', '4', '5' },
                    { '6', '7', '8' }
            };
            cells = aircells;
            DrawBoard();
        }
    }


    class Game
    { 
        public Game() {  }
        public char choiceX = 'X';
        public char choiceO = 'O';

        public void PlayerX(Board board,int inputX)
        {
            bool validX = false;
            Console.WriteLine(" Player X is your choice : \n");
            while (!validX)
            {
                validX = int.TryParse(Console.ReadLine(), out inputX);
                if (!validX)
                {
                    Console.WriteLine(" \n Give Another Choice ");
                }
            }
            switch (inputX)
            {
                case 0:
                    board.cells[0, 0] = choiceX; break;
                case 1:
                    board.cells[0, 1] = choiceX; break;
                case 2:
                    board.cells[0, 2] = choiceX; break;
                case 3:
                    board.cells[1, 0] = choiceX; break;
                case 4:
                    board.cells[1, 1] = choiceX; break;
                case 5:
                    board.cells[1, 2] = choiceX; break;
                case 6:
                    board.cells[2, 0] = choiceX; break;
                case 7:
                    board.cells[2, 1] = choiceX; break;
                case 8:
                    board.cells[2, 2] = choiceX; break;
            }
            board.DrawBoard();
        }
        public void PlayerO(Board board ,int inputO)
        {
            bool validO = false;
            Console.WriteLine(" Player O is your choice : \n");
            while (!validO)
            {
                validO = int.TryParse(Console.ReadLine(), out inputO);
                if (!validO)
                {
                    Console.WriteLine(" \n Give Another Choice ");
                }
            }
            switch (inputO)
            {
                case 0:
                    board.cells[0, 0] = choiceO; break;
                case 1:
                    board.cells[0, 1] = choiceO; break;
                case 2:
                    board.cells[0, 2] = choiceO; break;
                case 3:
                    board.cells[1, 0] = choiceO; break;
                case 4:
                    board.cells[1, 1] = choiceO; break;
                case 5:
                    board.cells[1, 2] = choiceO; break;
                case 6:
                    board.cells[2, 0] = choiceO; break;
                case 7:
                    board.cells[2, 1] = choiceO; break;
                case 8:
                    board.cells[2, 2] = choiceO; break;
            }
            board.DrawBoard();
        }
        //public int ScoreCount(int score, int depth)
        //{
        //    if (!board.validWinnerX)
        //    {
        //        return 10 - depth;
        //    }
        //    else if (!board.validWinnerO)
        //    {
        //        return depth - 10;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        //public int Minimax(int score ,  int depth)
        //{
        //    if (board.validWinnerX==false && board.checkDraw==true)
        //    {
        //        return score;
        //    }
        //    depth += 1;
        //    int[] scores = { };
        //    int[] moves = { };
        //    if()
        //    return 0;
        //}

        static void Main(string[] args)
        {
            bool GameEnd = false;
            int inputX = 0;
            int inputO = 0;
            Game game = new Game();
            Board board = new Board();
            while (!GameEnd)
            {
                board.DrawBoard();
                game.PlayerX(board, inputX);
                board.WinnerX(game);
                game.PlayerO(board, inputO);
                board.WinnerO(game);
            }
        }
    }
}