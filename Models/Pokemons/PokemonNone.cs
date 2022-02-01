using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.Pokemons
{
    internal class PokemonNone : Pokemon
    {
        public PokemonNone(int id, string name = "???", int? level = null) : base(id, name, name, level)
        { }
    }
}
