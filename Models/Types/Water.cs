using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Water : PokemonType
    {
        private static Water? _instance = null;
        public static Water Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Water();
                }
                return _instance;
            }
        }
        private Water() : base ("Water", "Blue")
        {

        }

        protected override void DeclareStrength()
        {
            this.p_strength = new List<PokemonType>();
            this.p_strength.Add(Fire.Instance);
            this.p_strength.Add(Ground.Instance);
            this.p_strength.Add(Rock.Instance);
        }
    }
}
