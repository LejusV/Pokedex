namespace Pokedex.Models
{
    internal abstract class PokemonType
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

        public PokemonType(string name, string color)
        {
            this.p_name = name;
            this.p_color = color;
        }
    }
}
