using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kingler Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'shell-armor', 'sheer-force'], 'base_experience': 166, 'height': 13, 'id': 99, 'moves': ['vice-grip', 'guillotine', 'swords-dance', 'cut', 'slam', 'stomp', 'body-slam', 'take-down', 'double-edge', 'leer', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'strength', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'harden', 'bide', 'bubble', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'icy-wind', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'dive', 'mud-sport', 'rock-tomb', 'iron-defense', 'mud-shot', 'water-pulse', 'brine', 'natural-gift', 'fling', 'x-scissor', 'giga-impact', 'captivate', 'hone-claws', 'wide-guard', 'round', 'scald', 'quash', 'confide'], 'name': 'kingler', 'stats': {'hp': 55, 'attack': 130, 'defense': 115, 'special-attack': 50, 'special-defense': 50, 'speed': 75}, 'types': ['water'], 'weight': 600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'red', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'キングラー', 'roomaji': 'Kingler', 'ko': '킹크랩', 'zh-Hant': '巨鉗蟹', 'fr': 'Krabboss', 'de': 'Kingler', 'es': 'Kingler', 'it': 'Kingler', 'en': 'Kingler', 'ja': 'キングラー', 'zh-Hans': '巨钳蟹'}, 'genera': {'ja-Hrkt': 'はさみポケモン', 'ko': '집게포켓몬', 'zh-Hant': '鉗子寶可夢', 'fr': 'Pokémon Pince', 'de': 'Kneifer', 'es': 'Pokémon Tenaza', 'it': 'Pokémon Chela', 'en': 'Pincer Pokémon', 'ja': 'はさみポケモン', 'zh-Hans': '钳子宝可梦'}}
	public class SpecieKingler : PokemonSpecie
	{
#nullable enable
		private static SpecieKingler? _instance = null;
#nullable restore
        public static SpecieKingler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKingler();
                }
                return _instance;
            }
        }

		public SpecieKingler() : base(
			"Kingler",
			55, // HPs
			130, 115, // Attack & Defense
			50, 50, // Special Attack & Defense
			75			
		) {}
	}


	//Kingler Pokemon Class
	public class Kingler : Pokemon
	{

		public Kingler(string nickname, int level)
		: base(
				99,
				SpecieKingler.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kingler(int level)
		: base(
				99,
				SpecieKingler.Instance, // Pokemon Specie
				"Kingler", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kingler() : base(
			99,
			SpecieKingler.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}