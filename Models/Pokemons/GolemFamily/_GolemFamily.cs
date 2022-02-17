
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class GolemFamily : Pokemon
    {
        public GolemFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Rock.Instance, Ground.Instance)
        { }
    }
}
