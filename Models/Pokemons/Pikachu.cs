using Pokedex.Models;

namespace Pokedex.Models.Pokemons
{
    class Pikachu : Pokemon
    {
        private static PokemonType ElecType = new PokemonType("elec", "yellow");
        public Pikachu(string name) : base(25, name, name, ElecType)
        {
        }
    }
}
