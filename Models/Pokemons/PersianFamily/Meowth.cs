namespace Pokedex.Models.Pokemons
{
    internal class Meowth : PersianFamily
    {
        public Meowth(string nickname = "Meowth", int? level = null) : base(52, nickname, nickname, level)
        {
            this._natural_fixed_stats = new PokemonStats(40, 45, 35, 40, 40, 90);
            CalculateStats();
        }
    }
}
