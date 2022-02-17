using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Caterpie : ButterfreeFamily
    {
        public Caterpie(string nickname = "Caterpie", int? level = null) : base(10, nickname, nickname, level, Bug.Instance)
        {
            this._base_stats = new PokemonStats(45, 30, 35, 20, 20, 45);
            CalculateStats();
        }
    }
}
