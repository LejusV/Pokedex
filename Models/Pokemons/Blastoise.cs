using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Blastoise : Pokemon
    {
        public Blastoise(string name, int level) : base(9, name, "Blastoise", level, Water.Instance)
        {
        }
    }
}
