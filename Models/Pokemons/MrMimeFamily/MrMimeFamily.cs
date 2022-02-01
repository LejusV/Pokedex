
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class MrMimeFamily : Pokemon
    {
        public MrMimeFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Psychic.Instance, Fairy.Instance)
        { }
    }

    internal class MimeJr : MrMimeFamily
    {
        public MimeJr(string nickname = "MimeJr", int? level = null) : base(439, nickname, "[...]", level)
        { }
    }

    internal class MrMime : MrMimeFamily
    {
        public MrMime(string nickname = "MrMime", int? level = null) : base(122, nickname, "[...]", level)
        { }
    }
}
