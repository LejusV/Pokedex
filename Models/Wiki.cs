using Pokedex.Models.Pokemons;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Wiki
    {
        #nullable enable
        private static Dictionary<int, Pokemon?>
        #nullable restore
         _pokemons;
        #nullable enable
        private static Wiki? _instance = null;
        public static Wiki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Wiki();
                }
                return _instance;
            }
        }

        public Dictionary<int, Pokemon?> Pokemons
        { get { return _pokemons; } } 

        public Wiki()
        {

            _pokemons = new Dictionary<int, Pokemon?>()
            {
                {   1,      new Bulbasaur() },
                {   2,      new Ivysaur() },
                {   3,      new Venusaur() },
                {   4,      new Charmander() },
                {   5,      new Charmeleon() },
                {   6,      new Charizard() },
                {   7,      new Squirtle() },
                {   8,      new Wartortle() },
                {   9,      new Blastoise() },
                {   10,     new Caterpie() },
                {   11,     new Metapod() },
                {   12,     new Butterfree() },
                {   13,     null },
                {   14,     null },
                {   15,     null },
                {   16,     null },
                {   17,     null },
                {   18,     null },
                {   19,     null },
                {   20,     null },
                {   21,     null },
                {   22,     null },
                {   23,     null },
                {   24,     null },
                {   25,     new Pikachu() },
                {   26,     new Raichu() },
                {   27,     null },
                {   28,     null },
                {   29,     null },
                {   30,     null },
                {   31,     null },
                {   32,     null },
                {   33,     null },
                {   34,     null },
                {   35,     null },
                {   36,     null },
                {   37,     null },
                {   38,     null },
                {   39,     null },
                {   40,     null },
                {   41,     null },
                {   42,     null },
                {   43,     null },
                {   44,     null },
                {   45,     null },
                {   46,     null },
                {   47,     null },
                {   48,     null },
                {   49,     null },
                {   50,     null },
                {   51,     null },
                {   52,     new Meowth() },
                {   53,     new Persian() },
                {   54,     null },
                {   55,     null },
                {   56,     null },
                {   57,     null },
                {   58,     null },
                {   59,     null },
                {   60,     null },
                {   61,     null },
                {   62,     null },
                {   63,     null },
                {   64,     null },
                {   65,     null },
                {   66,     null },
                {   67,     null },
                {   68,     null },
                {   69,     null },
                {   70,     null },
                {   71,     null },
                {   72,     null },
                {   73,     null },
                {   74,     new Geodude() },
                {   75,     new Graveler() },
                {   76,     new Golem() },
                {   77,     null },
                {   78,     null },
                {   79,     null },
                {   80,     null },
                {   81,     null },
                {   82,     null },
                {   83,     null },
                {   84,     null },
                {   85,     null },
                {   86,     null },
                {   87,     null },
                {   88,     null },
                {   89,     null },
                {   90,     null },
                {   91,     null },
                {   92,     null },
                {   93,     null },
                {   94,     null },
                {   95,     null },
                {   96,     null },
                {   97,     null },
                {   98,     null },
                {   99,     null }

            };

        }

        public string Display()
        {
            string res = "";
            foreach (KeyValuePair<int, Pokemon?> entry in this.Pokemons) 
            {
                if (entry.Value != null)
                {
                    res += string.Format("id " + entry.Key + "\n" +
                    entry.Value.Nickname + "\n" +
                    entry.Value.Shout + "\n" +
                    "Type" + entry.Value.TypesDisplay + "\n\n");
                }
            }
            return res;
        }
    }
}
#nullable restore