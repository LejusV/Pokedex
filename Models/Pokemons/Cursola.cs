using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cursola Specie to store common natural stats of every {'abilities': ['weak-armor', 'perish-body'], 'base_experience': 179, 'height': 10, 'id': 864, 'moves': [], 'name': 'cursola', 'stats': {'hp': 60, 'attack': 95, 'defense': 50, 'special-attack': 145, 'special-defense': 130, 'speed': 30}, 'types': ['ghost'], 'weight': 4, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 30, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'サニゴーン', 'ko': '산호르곤', 'zh-Hant': '魔靈珊瑚', 'fr': 'Corayôme', 'de': 'Gorgasonn', 'es': 'Cursola', 'it': 'Cursola', 'en': 'Cursola', 'ja': 'サニゴーン', 'zh-Hans': '魔灵珊瑚'}, 'genera': {'ja-Hrkt': 'さんごポケモン', 'ko': '산호포켓몬', 'zh-Hant': '珊瑚寶可夢', 'fr': 'Pokémon Corail', 'de': 'Koralle', 'es': 'Pokémon Coral', 'it': 'Pokémon Corallo', 'en': 'Coral Pokémon', 'ja': 'さんごポケモン', 'zh-Hans': '珊瑚宝可梦'}}
	public class SpecieCursola : PokemonSpecie
	{
#nullable enable
		private static SpecieCursola? _instance = null;
#nullable restore
        public static SpecieCursola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCursola();
                }
                return _instance;
            }
        }

		public SpecieCursola() : base(
			"Cursola",
			60, // HPs
			95, 50, // Attack & Defense
			145, 130, // Special Attack & Defense
			30			
		) {}
	}


	//Cursola Pokemon Class
	public class Cursola : Pokemon
	{

		public Cursola(string nickname, int level)
		: base(
				864,
				SpecieCursola.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cursola() : base(
			864,
			SpecieCursola.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}