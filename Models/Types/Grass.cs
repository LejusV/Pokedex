
using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Grass : PokemonType
    {
        private static Grass? _instance = null;
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
        protected override void DeclareStrength()
        {
            this.p_strength = new List<PokemonType>();
            this.p_strength.Add(Water.Instance);
            this.p_strength.Add(Flying.Instance);
        }
    }
}
