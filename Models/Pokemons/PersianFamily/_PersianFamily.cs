
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class PersianFamily : Pokemon
    {
        public PersianFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Normal.Instance)
        { }
    }
}
