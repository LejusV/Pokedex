
namespace Pokedex.Models.Types
{
    internal class Grass : PokemonType
    {
        private static Grass? _instance = null;
        public static Grass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Grass();
                }
                return _instance;
            }
        }
        private Grass() : base("Grass", "Green")
        {

        }
    }
}
