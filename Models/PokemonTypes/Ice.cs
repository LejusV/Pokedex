namespace Pokedex.Models.PokemonTypes
{
    public class Ice : PokemonType
    {
#nullable enable
        private static Ice? _instance = null;
#nullable disable
        public static Ice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ice();
                }
                return _instance;
            }
        }
        private Ice() : base("Ice", "Sky Blue")
        {
        }
    }
}