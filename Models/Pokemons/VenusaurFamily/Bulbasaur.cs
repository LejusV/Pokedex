namespace Pokedex.Models.Pokemons
{
    internal class Bulbasaur : VenusaurFamily
    {
        public Bulbasaur(string nickname = "Bulbasaur", int? level = null) : base(1, nickname, nickname, level)
        {
            this._base_stats = new PokemonStats(45, 49, 49, 65, 65, 45);
            CalculateStats();
        }
    }
}
