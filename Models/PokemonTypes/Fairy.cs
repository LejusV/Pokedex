
namespace Pokedex.Models.Types
{
    public class Fairy : PokemonType
    {
#nullable enable
        private static Fairy? _instance = null;
#nullable disable
        public static Fairy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fairy();
                }
                return _instance;
            }
        }
        private Fairy() : base("Fairy", "Salmon")
        {

        }
    }
}
