using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Charmander : Pokemon
    {
        public Charmander(string name, int level) : base(4, name, "Charmander", level, Fire.Instance)
        {
        }
    }
}
