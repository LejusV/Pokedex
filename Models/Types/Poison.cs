
namespace Pokedex.Models.Types
{
    internal class Poison : PokemonType
    {
        private static Poison? _instance = null;
        public static Poison Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Poison();
                }
                return _instance;
            }
        }
        private Poison() : base("Poison", "Berry Purple")
        {
        }
    }
}
