using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Butterfree : ButterfreeFamily
    {
        public Butterfree(string nickname = "Butterfree", int? level = null) : base(12, nickname, nickname, level, Bug.Instance, Flying.Instance)
        {
            this._base_stats = new PokemonStats(60, 45, 50, 90, 80, 70);
            CalculateStats();
        }
    }
}
