namespace Exercicio5
{
    public class Player
    {
        public PlayerType Type { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            return Type.GetHashCode() ^ Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Player other = obj as Player;
            if (other == null) return false;
            return Type == other.Type && Name == other.Name;
        }
    }
}
