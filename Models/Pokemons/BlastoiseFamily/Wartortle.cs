namespace Pokedex.Models.Pokemons
{
    class Wartortle : BlastoiseFamily
    {
        public Wartortle(string nickname = "Wartortle", int? level = null) : base(8, nickname, "Wartortle", level)
        {
            this._natural_fixed_stats = new PokemonStats(59, 63, 80, 65, 80, 58);
            CalculateStats();
        }
    }
}
