namespace Pokedex.Models.Types
{
    internal class Normal : PokemonType
    {
        private static Normal? _instance = null;
        public static Normal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Normal();
                }
                return _instance;
            
            }
        }
        private Normal() : base("Normal", "Brown")
        {

        }
    }
}
