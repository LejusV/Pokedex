using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pyukumuku Specie to store common natural stats of every {'abilities': ['innards-out', 'unaware'], 'base_experience': 144, 'height': 3, 'id': 771, 'moves': ['counter', 'toxic', 'double-team', 'recover', 'harden', 'light-screen', 'reflect', 'bide', 'rest', 'substitute', 'curse', 'spite', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'safeguard', 'pain-split', 'baton-pass', 'rain-dance', 'psych-up', 'hail', 'memento', 'taunt', 'helping-hand', 'mud-sport', 'tickle', 'water-sport', 'gastro-acid', 'soak', 'quash', 'bestow', 'confide', 'venom-drench', 'purify'], 'name': 'pyukumuku', 'stats': {'hp': 55, 'attack': 60, 'defense': 130, 'special-attack': 30, 'special-defense': 130, 'speed': 5}, 'types': ['water'], 'weight': 12, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 60, 'color': 'black', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'fast', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ナマコブシ', 'ko': '해무기', 'zh-Hant': '拳海參', 'fr': 'Concombaffe', 'de': 'Gufa', 'es': 'Pyukumuku', 'it': 'Pyukumuku', 'en': 'Pyukumuku', 'ja': 'ナマコブシ', 'zh-Hans': '拳海参'}, 'genera': {'ja-Hrkt': 'なまこポケモン', 'ko': '해삼포켓몬', 'zh-Hant': '海參寶可夢', 'fr': 'Pokémon Holothurie', 'de': 'Seegurke', 'es': 'Pokémon Pepino Mar', 'it': 'Pokémon Oloturia', 'en': 'Sea Cucumber Pokémon', 'ja': 'なまこポケモン', 'zh-Hans': '海参宝可梦'}}
	public class SpeciePyukumuku : PokemonSpecie
	{
#nullable enable
		private static SpeciePyukumuku? _instance = null;
#nullable restore
        public static SpeciePyukumuku Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePyukumuku();
                }
                return _instance;
            }
        }

		public SpeciePyukumuku() : base(
			"Pyukumuku",
			55, // HPs
			60, 130, // Attack & Defense
			30, 130, // Special Attack & Defense
			5			
		) {}
	}


	//Pyukumuku Pokemon Class
	public class Pyukumuku : Pokemon
	{

		public Pyukumuku(string nickname, int level)
		: base(
				771,
				SpeciePyukumuku.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pyukumuku(int level)
		: base(
				771,
				SpeciePyukumuku.Instance, // Pokemon Specie
				"Pyukumuku", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pyukumuku() : base(
			771,
			SpeciePyukumuku.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}