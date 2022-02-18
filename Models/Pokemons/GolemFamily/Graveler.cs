namespace Pokedex.Models.Pokemons
{
    internal class Graveler : GolemFamily
    {
        public Graveler(string nickname = "Graveler", int? level = null) : base(75, nickname, nickname, level)
        {
            this._natural_fixed_stats = new PokemonStats(55, 95, 115, 45, 45, 35);
            CalculateStats();
        }
    }
}
