using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name, int level) : base(1, name, "Bulbasaur", level, Grass.Instance)
        {
        }
    }
}
