using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.Types
{
    internal class Fire : PokemonType
    {
#nullable enable
        private static Fire? _instance = null;
#nullable disable
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
    }
}
