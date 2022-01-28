
namespace Pokedex.Models.Types
{
    internal class Ground : PokemonType
    {
        private static Ground? _instance = null;
        public static Ground Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ground();
                }
                return _instance;
            }
        }
        private Ground() : base("Ground", "Beige")
        {

        }
    }
}
