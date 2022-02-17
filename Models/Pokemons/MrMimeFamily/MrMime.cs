namespace Pokedex.Models.Pokemons
{
    internal class MrMime : MrMimeFamily
    {
        public MrMime(string nickname = "MrMime", int? level = null) : base(122, nickname, "[...]", level)
        {
            this._base_stats = new PokemonStats(40, 45, 65, 100, 120, 90);
            CalculateStats();
        }
    }
}
