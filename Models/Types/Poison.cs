
namespace Pokedex.Models.Types
{
    public class Poison : PokemonType
    {
#nullable enable
        private static Poison? _instance = null;
#nullable disable
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
