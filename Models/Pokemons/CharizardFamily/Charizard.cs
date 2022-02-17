
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class Charizard : CharizardFamily
    {
        public Charizard(string nickname = "Charizard", int? level = null) : base(6, nickname, nickname, level, Fire.Instance, Flying.Instance)
        {
            this._base_stats = new PokemonStats(78, 84, 78, 109, 85, 100);
            CalculateStats();
        }
    }
}
