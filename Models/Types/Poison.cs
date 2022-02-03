
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Poison : PokemonType
    {
        private static Poison? _instance = null;
        public static Poison Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Poison();
                }
                return _instance;
            }
        }
        private Poison() : base("Poison", "Berry Purple")
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
