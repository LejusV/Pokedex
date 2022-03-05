namespace Pokedex.Models.PokemonTypes
{
    public class Bug : PokemonType
    {
        #nullable enable
        private static Bug? _instance = null;
        #nullable restore
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