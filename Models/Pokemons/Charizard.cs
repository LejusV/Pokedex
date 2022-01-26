
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Charizard : Pokemon
    {
        public Charizard(string name, int level) : base(6, name, "Charizard", level, Fire.Instance)
        {
        }
    }
}
