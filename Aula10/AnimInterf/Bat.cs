namespace AnimInterf
{
    public class Bat : Animal, IMammal, ICanFly
    {
        public int NumberOfNipples => 4;
        public int NumberOfWings => 2;

        public override string Sound()
        {
            return "screeeee";
        }
    }
}