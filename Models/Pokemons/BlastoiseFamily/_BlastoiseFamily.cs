
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class BlastoiseFamily : Pokemon
    {
        public BlastoiseFamily(int id, string nickname, string cry, int? level) : base(id, nickname, cry, level, Water.Instance)
        {
        }
    }
}
