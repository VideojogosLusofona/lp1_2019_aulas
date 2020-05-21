namespace AnimInterf
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples => 6;

        public override string Sound()
        {
            return "Miau";
        }
    }
}