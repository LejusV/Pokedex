
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class CharizardFamily : Pokemon
    {
        public CharizardFamily(int id, string nickname, string cry, int? level, params PokemonType[] types) : base (id, nickname, cry, level, types)
        { }
    }

    internal class Charmander : CharizardFamily
    {
        public Charmander(string nickname = "Charmander", int? level= null) : base(4, nickname, nickname, level, Fire.Instance)
        { }
    }

    internal class Charmeleon : CharizardFamily
    {
        public Charmeleon(string nickname = "Charmeleon", int? level = null) : base(5, nickname, nickname, level, Fire.Instance)
        { }
    }

    internal class Charizard : CharizardFamily
    {
        public Charizard(string nickname = "Charizard", int? level = null) : base(6, nickname, nickname, level, Fire.Instance, Flying.Instance)
        { }
    }
}
