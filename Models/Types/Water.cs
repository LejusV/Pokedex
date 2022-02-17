namespace Pokedex.Models.Types
{
    internal class Water : PokemonType
    {
#nullable enable
        private static Water? _instance = null;
#nullable disable
        public static Water Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Water();
                }
                return _instance;
            }
        }
        private Water() : base ("Water", "Blue")
        {

        }
    }
}
