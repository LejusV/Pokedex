
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class VenusaurFamily : Pokemon
    {
        public VenusaurFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Grass.Instance, Poison.Instance)
        { }
    }
}
