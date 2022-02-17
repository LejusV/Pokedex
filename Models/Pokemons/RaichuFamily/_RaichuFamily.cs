using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class RaichuFamily : Pokemon
    {
        public RaichuFamily(int id, string nickname, string cry, int? level = null) : base (id, nickname, cry, level, Electric.Instance)
        { }
    }
}