namespace Pokedex.Models.Pokemons
{
    class Squirtle : BlastoiseFamily
    {
        public Squirtle(string nickname = "Squirtle", int? level = null) : base(7, nickname, "Squirtle", level)
        {
            this._base_stats = new PokemonStats(44, 48, 65, 50, 64, 43);
            CalculateStats();
        }
    }
}
