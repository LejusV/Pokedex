
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class BlastoiseFamily : Pokemon
    {
        public BlastoiseFamily(int id, string nickname, string cry, int? level) : base(id, nickname, cry, level, Water.Instance)
        { }
    }

    class Squirtle : BlastoiseFamily
    {
        public Squirtle(string nickname = "Squirtle", int? level = null) : base(7, nickname, "Squirtle", level)
        { }
    }

    class Wartortle : BlastoiseFamily
    {
        public Wartortle(string nickname = "Wartortle", int? level = null) : base(8, nickname, "Wartortle", level)
        { }
    }

    class Blastoise : BlastoiseFamily
    {
        public Blastoise(string nickname = "Blastoise", int? level = null) : base(9, nickname, "Blastoise", level)
        { }
    }
}
