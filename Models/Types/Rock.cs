using System.Collections.Generic;

namespace Pokedex.Models.Types
{
    internal class Rock : PokemonType
    {
        private static Rock? _instance = null;
        public static Rock Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Rock();
                }
                return _instance;
            }
        }
        private Rock() : base("Rock", "Gray")
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
