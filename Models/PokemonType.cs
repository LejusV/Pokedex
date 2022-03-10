namespace Pokedex.Models
{
    public abstract class PokeType
    {
        private readonly string p_name,
                        p_color;

        public string Name
        {
            get { return p_name; }
        }

        public string Color
        {
            get { return p_color; }
        }

        public PokeType(string name, string color)
        {
            this.p_name = name;
            this.p_color = color;
        }
    }
}
