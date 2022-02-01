
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class GolemFamily : Pokemon
    {
        public GolemFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Rock.Instance, Ground.Instance)
        { }
    }

    internal class Geodude : GolemFamily
    {
        public Geodude(string nickname = "Geodude", int? level = null) : base(74, nickname, nickname, level)
        { }
    }

    internal class Graveler : GolemFamily
    {
        public Graveler(string nickname = "Graveler", int? level = null) : base(75, nickname, nickname, level)
        { }
    }

    internal class Golem : GolemFamily
    {
        public Golem(string nickname = "Golem", int? level = null) : base(76, nickname, nickname, level)
        { }
    }
}
