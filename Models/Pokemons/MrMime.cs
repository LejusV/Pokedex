
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    class MrMime : Pokemon
    {
        public MrMime(string name, int level) : base(122,
                                                     name,
                                                     "[...]",
                                                     level,
                                                     Psychic.Instance,
                                                     Fairy.Instance)
        {

        }
    }
}
