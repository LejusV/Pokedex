using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grookey Specie to store common natural stats of every {'abilities': ['overgrow', 'grassy-surge'], 'base_experience': 62, 'height': 3, 'id': 810, 'moves': [], 'name': 'grookey', 'stats': {'hp': 50, 'attack': 65, 'defense': 50, 'special-attack': 40, 'special-defense': 40, 'speed': 65}, 'types': ['grass'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'サルノリ', 'ko': '흥나숭', 'zh-Hant': '敲音猴', 'fr': 'Ouistempo', 'de': 'Chimpep', 'es': 'Grookey', 'it': 'Grookey', 'en': 'Grookey', 'ja': 'サルノリ', 'zh-Hans': '敲音猴'}, 'genera': {'ja-Hrkt': 'こざるポケモン', 'ko': '꼬마원숭이포켓몬', 'zh-Hant': '小猴寶可夢', 'fr': 'Pokémon Chimpanzé', 'de': 'Schimpanse', 'es': 'Pokémon Chimpancé', 'it': 'Pokémon Scimpanzé', 'en': 'Chimp Pokémon', 'ja': 'こざるポケモン', 'zh-Hans': '小猴宝可梦'}}
	public class SpecieGrookey : PokemonSpecie
	{
#nullable enable
		private static SpecieGrookey? _instance = null;
#nullable restore
        public static SpecieGrookey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrookey();
                }
                return _instance;
            }
        }

		public SpecieGrookey() : base(
			"Grookey",
			50, // HPs
			65, 50, // Attack & Defense
			40, 40, // Special Attack & Defense
			65			
		) {}
	}


	//Grookey Pokemon Class
	public class Grookey : Pokemon
	{

		public Grookey(string nickname, int level)
		: base(
				810,
				SpecieGrookey.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grookey() : base(
			810,
			SpecieGrookey.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}