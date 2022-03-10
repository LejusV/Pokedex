namespace Pokedex.Models.PokeTypes
{
    public class Ground : PokeType
    {
#nullable enable
        private static Ground? _instance = null;
#nullable disable
        public static Ground Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Ground();
                }
                return _instance;
            }
        }
        private Ground() : base("Ground", "Beige")
        {

        }
    }
}
