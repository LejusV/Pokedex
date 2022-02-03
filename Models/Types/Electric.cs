
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Electric : PokemonType
    {
        private static Electric? _instance = null;
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

        protected override void DeclareStrength()
        {
            this.p_strength = new List<PokemonType>();
            this.p_strength.Add(Water.Instance);
            this.p_strength.Add(Flying.Instance);
        }
    }
}
