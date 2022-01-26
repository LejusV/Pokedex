using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    class PokemonType
    {
        private string  p_name,
                        p_color;

        public string Name
        {
            get { return p_name; }
        }

        public string Color
        {
            get { return p_color; }
        }

        public PokemonType(string n, string c)
        {
            this.p_name = n;
            this.p_color = c;
        }
    }
}
