namespace Pokedex.Models.PokeTypes
{
    public class Electric : PokeType
    {
#nullable enable
        private static Electric? _instance = null;
#nullable disable
        public static Electric Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Electric();
                }
                return _instance;
            }
        }
        private Electric() : base("Electric", "Yellow")
        {
        }
    }
}