
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Pikachu : Pokemon
    {
        public Pikachu(string name, int level) : base(25, name, "Pika Pika", level, Electric.Instance)
        {
        }
    }
}
