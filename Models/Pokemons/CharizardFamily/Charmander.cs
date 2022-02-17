
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class Charmander : CharizardFamily
    {
        public Charmander(string nickname = "Charmander", int? level= null) : base(4, nickname, nickname, level, Fire.Instance)
        {
            this._base_stats = new PokemonStats(39, 52, 43, 60, 50, 65);
            CalculateStats();
        }
    }
}
