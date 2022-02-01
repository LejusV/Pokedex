
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
    internal class PersianFamily : Pokemon
    {
        public PersianFamily(int id, string nickname, string cry, int? level) : base (id, nickname, cry, level, Normal.Instance)
        { }
    }

    internal class Meowth : PersianFamily
    {
        public Meowth(string nickname = "Meowth", int? level = null) : base(52, nickname, nickname, level)
        { }
    }

    internal class Persian : PersianFamily
    {
        public Persian(string nickname = "Persian", int? level = null) : base(53, nickname, nickname, level)
        { }
    }
}
