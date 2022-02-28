namespace Pokedex.Models.Types
{
    public class Fighting : PokemonType
    {
#nullable enable
        private static Fighting? _instance = null;
#nullable disable
        public static Fighting Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fighting();
                }
                return _instance;
            }
        }
        private Fighting() : base("Fighting", "Terracota")
        {
        }
    }
}