namespace Pokedex.Models.Pokemons
{
    internal class Venusaur : VenusaurFamily
    {
        public Venusaur(string nickname = "Venusaur", int? level = null) : base(3, nickname, "Venusaur", level)
        {
            this._base_stats = new PokemonStats(80, 82, 83, 100, 100, 80);
            CalculateStats();
        }
    }
}
