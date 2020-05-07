namespace TicTacToeV2
{
    public class Board
    {
        private State[,] state;
        private int turn;

        public State NextTurn
        {
            get
            {
                if (Finished)
                {
                    return State.Undecided;
                }
                else if (turn % 2 == 0)
                {
                    return State.X;
                }
                else
                {
                    return State.O;
                }
            }
        }

        public bool Finished
        {
            get
            {
                // Verificar se ha uma vitoria do X ou do O ou se
                // ha empate
                return IsDraw || Winner != State.Undecided;
            }
        }

        public bool IsDraw
        {
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (state[i, j] == State.Undecided)
                            return false;
                    }
                }
                return true;
            }
        }

        public State Winner
        {
            get
            {
                if (CheckWinner(State.X)) return State.X;
                if (CheckWinner(State.O)) return State.O;
                return State.Undecided;
            }
        }

        public Board()
        {
            state = new State[3, 3];
            turn = 0;
        }

        public State GetState(Position pos)
        {
            return state[pos.Row, pos.Col];
        }

        public bool MakeMove(Position pos)
        {
            if (pos == null)
                return false;
            if (pos.Row < 0 || pos.Row > 2 || pos.Col < 0 || pos.Col > 2)
                return false;
            if (state[pos.Row, pos.Col] != State.Undecided)
                return false;
            state[pos.Row, pos.Col] = NextTurn;
            turn++;
            return true;
        }

        private bool CheckWinner(State player)
        {
            Position[][] winSequences = new Position[][]
            {
                new Position[] { new Position(0, 0), new Position(0, 1), new Position(0, 2) },
                new Position[] { new Position(1, 0), new Position(1, 1), new Position(1, 2) },
                new Position[] { new Position(2, 0), new Position(2, 1), new Position(2, 2) },
                new Position[] { new Position(0, 0), new Position(1, 0), new Position(2, 0) },
                new Position[] { new Position(0, 1), new Position(1, 1), new Position(2, 1) },
                new Position[] { new Position(0, 2), new Position(1, 2), new Position(2, 2) },
                new Position[] { new Position(0, 0), new Position(1, 1), new Position(2, 2) },
                new Position[] { new Position(0, 2), new Position(1, 1), new Position(2, 0) }
            };

            foreach (Position[] positions in winSequences)
            {
                bool win = true;
                foreach (Position pos in positions)
                {
                    if (state[pos.Row, pos.Col] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            return false;
        }

    }
}