
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Ground : PokemonType
    {
        private static Ground? _instance = null;
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
        protected override void DeclareStrength()
        {
            this.p_strength = new List<PokemonType>();
            this.p_strength.Add(Water.Instance);
            this.p_strength.Add(Flying.Instance);
        }
    }
}
