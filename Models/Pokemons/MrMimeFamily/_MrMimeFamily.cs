
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class MrMimeFamily : Pokemon
    {
        public MrMimeFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Psychic.Instance, Fairy.Instance)
        { }
    }
}
