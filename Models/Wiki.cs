
using Pokedex.Models.Pokemons;
using System.Collections.Generic;

namespace Pokedex.Models
{
    internal class Wiki
    {
        private static Dictionary<int, Pokemon> _pokemons;

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

        public Dictionary<int, Pokemon> Pokemons
        { get { return _pokemons; } }

        public Wiki()
        {

            _pokemons = new Dictionary<int, Pokemon>()
            {
                {1, new Bulbasaur() },
                {2, new Ivysaur() },
                {3, new Venusaur() },
                {4, new Charmander() },
                {5, new Charmeleon() },
                {6, new Charizard() },
                {7, new Squirtle() },
                {8, new Wartortle() },
                {9, new Blastoise() },
                {10, new Caterpie() },
                {11, new Metapod() },
                {12, new Butterfree() },

                {25, new Pikachu() },
                {26, new Raichu() },

                {52, new Meowth() },
                {53, new Persian() },

                {74, new Geodude() },
                {75, new Graveler() },
                {76, new Golem() }

            };

        }

        public string Display()
        {
            string res = "";
            foreach (KeyValuePair<int, Pokemon> entry in this.Pokemons) res += string.Format("id " + entry.Key + "\n" +
                                                                            entry.Value.Nickname + "\n" +
                                                                            entry.Value.Shout + "\n" +
                                                                            "Type" + entry.Value.TypesDisplay + "\n\n");
            return res;
        }
    }
}
