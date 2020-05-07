using System;

namespace TicTacToeV2
{
    public class Game
    {
        private Board board;
        private UserInterface ui;

        public Game()
        {
            board = new Board();
            ui = new UserInterface();
        }

        public void Play()
        {
            do
            {
                int nextMove;
                Position nextMovePos;

                // Mostra board
                ui.RenderBoard(board);

                // Pede input ao jogador
                nextMove = ui.GetMoveForPlayer(board.NextTurn);
                nextMovePos = MoveToPosition(nextMove);

                // Fazemos jogada
                if (!board.MakeMove(nextMovePos))
                {
                    // Mostra msg de erro
                    ui.RenderMessage("This is not a legal move");
                }

            } while (!board.Finished);

            // Mostra board
            ui.RenderBoard(board);

            // Indica resultado final
            ui.RenderResult(board);
        }

        private Position MoveToPosition(int move)
        {
            switch (move)
            {
                case 1: return new Position(2, 0);
                case 2: return new Position(2, 1);
                case 3: return new Position(2, 2);
                case 4: return new Position(1, 0);
                case 5: return new Position(1, 1);
                case 6: return new Position(1, 2);
                case 7: return new Position(0, 0);
                case 8: return new Position(0, 1);
                case 9: return new Position(0, 2);
                default: return null;
            }
        }
    }
}