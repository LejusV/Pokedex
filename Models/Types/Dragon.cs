namespace Pokedex.Models.Types
{
    public class Dragon : PokemonType
    {
#nullable enable
        private static Dragon? _instance = null;
#nullable disable
        public static Dragon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dragon();
                }
                return _instance;
            }
        }
        private Dragon() : base("Dragon", "Lavanda")
        { }
    }
}