namespace Pokedex.Models.Types
{
    public class Bug : PokemonType
    {
        private static Bug? _instance = null;
        public static Bug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bug();
                }
                return _instance;
            }
        }
        private Bug() : base("Bug", "Kaki")
        { }
    }
}