namespace Pokedex.Models.Pokemons
{
    internal class Raichu : RaichuFamily
    {
        public Raichu(string nickname = "Raichu", int? level = null) : base(26, nickname, "Raichu", level)
        {
            this._natural_fixed_stats = new PokemonStats(60, 90, 55, 90, 80, 110);
            CalculateStats();
        }
    }
}
