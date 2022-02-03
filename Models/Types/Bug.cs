
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Bug : PokemonType
    {
        private static Bug? _instance = null;
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
