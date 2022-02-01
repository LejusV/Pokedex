
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class ButterfreeFamily : Pokemon
    {
        public ButterfreeFamily(int id, string nickname, string cry, int? level, params PokemonType[] types)
            : base(id, nickname, cry, level, types)
        { }
    }

    class Caterpie : ButterfreeFamily
    {
        public Caterpie(string nickname = "Caterpie", int? level = null) : base(10, nickname, nickname, level, Bug.Instance)
        { }
    }

    class Metapod : ButterfreeFamily
    {
        public Metapod(string nickname = "Metapod", int? level = null) : base(11, nickname, nickname, level, Bug.Instance)
        { }
    }

    class Butterfree : ButterfreeFamily
    {
        public Butterfree(string nickname = "Butterfree", int? level = null) : base(12, nickname, nickname, level, Bug.Instance, Flying.Instance)
        { }
    }
}
