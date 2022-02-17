namespace Pokedex.Models.Types
{
    internal class Rock : PokemonType
    {
#nullable enable
        private static Rock? _instance = null;
#nullable disable
        public static Rock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Rock();
                }
                return _instance;
            }
        }
        private Rock() : base("Rock", "Gray")
        {

        }

    }
}
