
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class VenusaurFamily : Pokemon
    {
        public VenusaurFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Grass.Instance, Poison.Instance)
        { }
    }

    internal class Bulbasaur : VenusaurFamily
    {
        public Bulbasaur(string nickname = "Bulbasaur", int? level = null) : base(1, nickname, nickname, level)
        { }
    }

    internal class Ivysaur : VenusaurFamily
    {
        public Ivysaur(string nickname = "Ivysaur", int? level = null) : base(2, nickname, nickname, level)
        { }
    }

    internal class Venusaur : VenusaurFamily
    {
        public Venusaur(string nickname = "Venusaur", int? level = null) : base(3, nickname, "Venusaur", level)
        { }
    }
}
