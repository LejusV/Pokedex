using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.Types
{
    internal class Fire : PokemonType
    {
        private static Fire? _instance = null;
        public static Fire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Fire();
                }
                return _instance;
            }
        }
        private Fire() : base("Fire", "Red")
        {

        }

        protected override void DeclareStrength()
        {
            this.p_strength = new List<PokemonType>();
            this.p_strength.Add(Grass.Instance);
            this.p_strength.Add(Bug.Instance);
        }
    }
}
