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

        public PokemonType(string name, string color)
        {
            this.p_name = name;
            this.p_color = color;
        }
    }
}
