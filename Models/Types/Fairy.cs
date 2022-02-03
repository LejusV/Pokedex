
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Fairy : PokemonType
    {
        private static Fairy? _instance = null;
        public static Fairy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fairy();
                }
                return _instance;
            }
        }
        private Fairy() : base("Fairy", "Salmon")
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
