namespace Pokedex.Models.Pokemons
{
    class Blastoise : BlastoiseFamily
    {
        public Blastoise(string nickname = "Blastoise", int? level = null) : base(9, nickname, "Blastoise", level)
        {
            this._natural_fixed_stats = new PokemonStats(79, 83, 100, 85, 105, 78);
            CalculateStats();
        }
    }
}
