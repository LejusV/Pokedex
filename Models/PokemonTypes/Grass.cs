namespace Pokedex.Models.PokeTypes
{
    public class Grass : PokeType
    {
#nullable enable
        private static Grass? _instance = null;
#nullable disable
        public static Grass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Grass();
                }
                return _instance;
            }
        }
        private Grass() : base("Grass", "Green")
        {

        }
    }
}
