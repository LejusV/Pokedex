using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Corphish Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'shell-armor', 'adaptability'], 'base_experience': 62, 'height': 6, 'id': 341, 'moves': ['vice-grip', 'guillotine', 'swords-dance', 'cut', 'body-slam', 'double-edge', 'leer', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'counter', 'strength', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'waterfall', 'bubble', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'snore', 'spite', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'taunt', 'superpower', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'mud-sport', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-dance', 'water-pulse', 'natural-gift', 'payback', 'fling', 'trump-card', 'night-slash', 'x-scissor', 'switcheroo', 'captivate', 'aqua-jet', 'double-hit', 'hone-claws', 'round', 'chip-away', 'scald', 'razor-shell', 'confide'], 'name': 'corphish', 'stats': {'hp': 43, 'attack': 80, 'defense': 65, 'special-attack': 50, 'special-defense': 35, 'speed': 35}, 'types': ['water'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 205, 'color': 'red', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'ヘイガニ', 'roomaji': 'Heigani', 'ko': '가재군', 'zh-Hant': '龍蝦小兵', 'fr': 'Écrapince', 'de': 'Krebscorps', 'es': 'Corphish', 'it': 'Corphish', 'en': 'Corphish', 'ja': 'ヘイガニ', 'zh-Hans': '龙虾小兵'}, 'genera': {'ja-Hrkt': 'ごろつきポケモン', 'ko': '건달포켓몬', 'zh-Hant': '無賴寶可夢', 'fr': 'Pokémon Brute', 'de': 'Grobian', 'es': 'Pokémon Rufián', 'it': 'Pokémon Birbone', 'en': 'Ruffian Pokémon', 'ja': 'ごろつきポケモン', 'zh-Hans': '无赖宝可梦'}}
	public class SpecieCorphish : PokemonSpecie
	{
#nullable enable
		private static SpecieCorphish? _instance = null;
#nullable restore
        public static SpecieCorphish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorphish();
                }
                return _instance;
            }
        }

		public SpecieCorphish() : base(
			"Corphish",
			43, // HPs
			80, 65, // Attack & Defense
			50, 35, // Special Attack & Defense
			35			
		) {}
	}


	//Corphish Pokemon Class
	public class Corphish : Pokemon
	{

		public Corphish(string nickname, int level)
		: base(
				341,
				SpecieCorphish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Corphish(int level)
		: base(
				341,
				SpecieCorphish.Instance, // Pokemon Specie
				"Corphish", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Corphish() : base(
			341,
			SpecieCorphish.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}