
namespace Pokedex.Models.PokeTypes
{
    public class Psychic : PokeType
    {        
#nullable enable
        private static Psychic? _instance = null;
#nullable disable
        public static Psychic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Psychic();
                }
                return _instance;
            }
        }
        private Psychic() : base("Psychic", "Pink")
        {

        }
    }
}
