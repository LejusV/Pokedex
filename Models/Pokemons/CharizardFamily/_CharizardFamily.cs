namespace Pokedex.Models.Pokemons
{
    internal class CharizardFamily : Pokemon
    {
        public CharizardFamily(int id, string nickname, string cry, int? level, params PokemonType[] types) : base (id, nickname, cry, level, types)
        { }
    }
}
