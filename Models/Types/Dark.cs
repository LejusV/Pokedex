namespace Pokedex.Models.Types
{
    public class Dark : PokemonType
    {
#nullable enable
        private static Dark? _instance = null;
#nullable disable
        public static Dark Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dark();
                }
                return _instance;
            }
        }
        private Dark() : base("Dark", "Dark gray")
        {
        }
    }
}