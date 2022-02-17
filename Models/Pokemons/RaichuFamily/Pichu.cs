namespace Pokedex.Models.Pokemons
{
    internal class Pichu : RaichuFamily
    {
        public Pichu(string nickname = "Pichu", int? level = null) : base(172, nickname, "Pichu",level)
        {
            this._base_stats = new PokemonStats(20, 40, 15, 35, 35, 60);
            CalculateStats();
        }
    }
}
