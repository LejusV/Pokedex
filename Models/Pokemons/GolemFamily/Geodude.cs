namespace Pokedex.Models.Pokemons
{
    internal class Geodude : GolemFamily
    {
        public Geodude(string nickname = "Geodude", int? level = null) : base(74, nickname, nickname, level)
        {            
            this._natural_fixed_stats = new PokemonStats(40, 80, 100, 30, 30, 20);
            CalculateStats();
        }
    }
}
