namespace Pokedex.Models.Pokemons
{
    internal class Pikachu : RaichuFamily
    {
        public Pikachu(string nickname = "Pikachu", int? level = null) : base(25, nickname, "Pikachu", level)
        {
            this._natural_fixed_stats = new PokemonStats(35, 55, 40, 50, 50, 90);
            CalculateStats();
        }
    }
}
