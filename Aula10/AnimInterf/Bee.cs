namespace AnimInterf
{
    public class Bee : Animal, ICanFly
    {
        public int NumberOfWings => 6;
        public override string Sound()
        {
            return "Bzzzz";
        }
    }
}