namespace Pokedex.Models.PokeTypes
{
    public class Steel : PokeType
    {
#nullable enable
        private static Steel? _instance = null;
#nullable disable
        public static Steel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Steel();
                }
                return _instance;
            }
        }
        private Steel() : base("Steel", "Blueish gray")
        {
        }
    }
}