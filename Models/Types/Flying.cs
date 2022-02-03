
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Flying : PokemonType
    {
        private static Flying? _instance = null;
        public static Flying Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Flying();
                }
                return _instance;
            }
        }
        private Flying() : base("Flying", "Violet")
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
