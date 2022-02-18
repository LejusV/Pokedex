namespace Pokedex.Models.Pokemons
{
    internal class MimeJr : MrMimeFamily
    {
        public MimeJr(string nickname = "MimeJr", int? level = null) : base(439, nickname, "[...]", level)
        {
            this._natural_fixed_stats = new PokemonStats(20, 25, 45, 70, 90, 60);
            CalculateStats();
        }
    }
}
