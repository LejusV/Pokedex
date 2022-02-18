using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Metapod : ButterfreeFamily
    {
        public Metapod(string nickname = "Metapod", int? level = null) : base(11, nickname, nickname, level, Bug.Instance)
        {
            this._natural_fixed_stats = new PokemonStats(50, 20, 55, 25, 25, 30);
            CalculateStats();
        }
    }
}
