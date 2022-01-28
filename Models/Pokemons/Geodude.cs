using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class Geodude : Pokemon
    {
        public Geodude(string name, int level) : base(74,
                                                      name,
                                                      "Geodude",
                                                      level,
                                                      Rock.Instance,
                                                      Ground.Instance)
        {
        }
    }
}
