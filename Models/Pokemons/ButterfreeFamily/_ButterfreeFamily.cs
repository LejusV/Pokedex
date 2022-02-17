namespace Pokedex.Models.Pokemons
{
    internal class ButterfreeFamily : Pokemon
    {
        public ButterfreeFamily(int id, string nickname, string cry, int? level, params PokemonType[] types)
            : base(id, nickname, cry, level, types)
        { }
    }
}
