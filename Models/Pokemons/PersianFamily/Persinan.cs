namespace Pokedex.Models.Pokemons
{
    internal class Persian : PersianFamily
    {
        public Persian(string nickname = "Persian", int? level = null) : base(53, nickname, nickname, level)
        {
            this._base_stats = new PokemonStats(65, 70, 60, 65, 65, 115);
            CalculateStats();
        }
    }
}
