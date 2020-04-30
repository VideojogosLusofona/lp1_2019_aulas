namespace TicTacToe
{
    public class Board
    {
        private State[,] state;
        public State NextTurn { get; private set; }

        public Board()
        {
            state = new State[3, 3];
            NextTurn = State.X;
        }

        // Public methods

        public State GetState(Position position)
        {
            return state[position.Row, position.Column];
        }

        public bool SetState(Position position, State newState)
        {
            if (newState != NextTurn) return false;
            if (position == null) return false;
            if (state[position.Row, position.Column] != State.Undecided)
                return false;

            state[position.Row, position.Column] = newState;
            SwitchNextTurn();
            return true;
        }

        public State CheckWinner()
        {
            if (CheckIfPlayerWins(State.X)) return State.X;
            if (CheckIfPlayerWins(State.O)) return State.O;
            return State.Undecided;
        }


        public bool IsDraw()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    if (GetState(new Position(row, column)) == State.Undecided)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // Private methods

        private bool CheckIfPlayerWins(State player)
        {
            for (int row = 0; row < 3; row++)
                if (AreAll(new Position[] {
                        new Position(row, 0),
                        new Position(row, 1),
                        new Position(row, 2) }, player))
                    return true;

            for (int column = 0; column < 3; column++)
                if (AreAll(new Position[] {
                        new Position(0, column),
                        new Position(1, column),
                        new Position(2, column) }, player))
                    return true;

            if (AreAll(new Position[] {
                    new Position(0, 0),
                    new Position(1, 1),
                    new Position(2, 2) }, player))
                return true;

            if (AreAll(new Position[] {
                    new Position(2, 0),
                    new Position(1, 1),
                    new Position(0, 2) }, player))
                return true;

            return false;
        }

        private bool AreAll(Position[] positions, State state)
        {
            foreach (Position position in positions)
                if (GetState(position) != state) return false;

            return true;
        }

        private void SwitchNextTurn()
        {
            if (NextTurn == State.X) NextTurn = State.O;
            else NextTurn = State.X;
        }
    }

}
