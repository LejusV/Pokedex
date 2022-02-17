
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class Charmeleon : CharizardFamily
    {
        public Charmeleon(string nickname = "Charmeleon", int? level = null) : base(5, nickname, nickname, level, Fire.Instance)
        {
            this._base_stats = new PokemonStats(58, 64, 58, 80, 65, 80);
            CalculateStats();
        }
    }
}
