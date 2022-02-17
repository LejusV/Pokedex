
namespace Pokedex.Models.Types
{
    internal class Flying : PokemonType
    {
#nullable enable
        private static Flying? _instance = null;
#nullable disable
        public static Flying Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Flying();
                }
                return _instance;
            }
        }
        private Flying() : base("Flying", "Violet")
        {

        }
    }
}
