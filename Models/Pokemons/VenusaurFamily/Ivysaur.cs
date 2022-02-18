namespace Pokedex.Models.Pokemons
{
    internal class Ivysaur : VenusaurFamily
    {
        public Ivysaur(string nickname = "Ivysaur", int? level = null) : base(2, nickname, nickname, level)
        {
            this._natural_fixed_stats = new PokemonStats(60, 62, 63, 80, 80, 60);
            CalculateStats();
        }
    }
}
