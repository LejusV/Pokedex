
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class RaichuFamily : Pokemon
    {
        public RaichuFamily(int id, string nickname, string cry, int? level = null) : base (id, nickname, cry, level, Electric.Instance)
        { }
    }

    internal class Pichu : RaichuFamily
    {
        public Pichu(string nickname = "Pichu", int? level = null) : base(172, nickname, "Pichu",level)
        { }
    }

    internal class Pikachu : RaichuFamily
    {
        public Pikachu(string nickname = "Pikachu", int? level = null) : base(25, nickname, "Pikachu", level)
        { }
    }

    internal class Raichu : RaichuFamily
    {
        public Raichu(string nickname = "Raichu", int? level = null) : base(26, nickname, "Raichu", level)
        { }
    }
}
