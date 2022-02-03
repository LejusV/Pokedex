
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Psychic : PokemonType
    {
        private static Psychic? _instance = null;
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
        protected override void DeclareStrength()
        {
            this.p_strength = new List<PokemonType>();
            this.p_strength.Add(Water.Instance);
            this.p_strength.Add(Flying.Instance);
        }
    }
}
