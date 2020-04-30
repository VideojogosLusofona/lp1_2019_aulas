namespace Exercicio1
{
    public class Color
    {
        // Auto-implemented properties
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; } = 255;

        // Greyscale property - does not need support variable
        public byte Greyscale
        {
            get
            {
                return (byte)((Red + Green + Blue) / 3);
            }
        }

        // We don't need constructors since we're using objects
        // with properties initialization syntax (see Main())
        // We didn't do this in Aula 7, although this was
        // a requirement of Exercicio 1
    }
}
