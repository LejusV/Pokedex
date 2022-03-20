namespace Pokedex.Models.PokemonTypes
{
    public class Fire : PokemonType
    {
#nullable enable
        private static Fire? _instance = null;
#nullable disable
        public static Fire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fire();
                }
                return _instance;
            }
        }
        private Fire() : base("Fire", "Red")
        {

        }
    }
}
