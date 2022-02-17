namespace Pokedex.Models.Pokemons
{
    internal class Golem : GolemFamily
    {
        public Golem(string nickname = "Golem", int? level = null) : base(76, nickname, nickname, level)
        {
            this._base_stats = new PokemonStats(80, 120, 130, 85, 65, 45);
            CalculateStats();
        }
    }
}
