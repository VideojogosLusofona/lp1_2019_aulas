using System;
namespace TicTacToeV2
{
    public class UserInterface
    {

        public void RenderBoard(Board board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (board.GetState(new Position(i, j)))
                    {
                        case State.X:
                            Console.Write(" X ");
                            break;
                        case State.O:
                            Console.Write(" O ");
                            break;
                        case State.Undecided:
                            Console.Write("   ");
                            break;
                    }
                    if (j < 2) Console.Write("|");
                }
                if (i < 2) Console.WriteLine("\n---+---+---");
            }
            Console.WriteLine();
        }

        public int GetMoveForPlayer(State nextPlayer)
        {
            string aux;
            int move;
            Console.Write($"Jogador {nextPlayer}, qual a jogada: ");
            aux = Console.ReadLine();
            move = int.Parse(aux);
            return move;
        }

        public void RenderMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        public void RenderResult(Board board)
        {
            // Verificar se é empate
            if (board.IsDraw)
            {
                Console.WriteLine("Jogo termina com empate");
            }
            else
            {
                Console.WriteLine($"{board.Winner} vence o jogo!");
            }
        }
    }
}