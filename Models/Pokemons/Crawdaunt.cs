using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crawdaunt Specie to store common natural stats of every {'abilities': ['hyper-cutter', 'shell-armor', 'adaptability'], 'base_experience': 164, 'height': 11, 'id': 342, 'moves': ['vice-grip', 'guillotine', 'swords-dance', 'cut', 'body-slam', 'double-edge', 'leer', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'counter', 'strength', 'dig', 'toxic', 'mimic', 'double-team', 'harden', 'waterfall', 'swift', 'bubble', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'snore', 'spite', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'hail', 'facade', 'nature-power', 'taunt', 'superpower', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'dive', 'rock-tomb', 'aerial-ace', 'iron-defense', 'water-pulse', 'natural-gift', 'payback', 'fling', 'dark-pulse', 'night-slash', 'x-scissor', 'giga-impact', 'avalanche', 'captivate', 'double-hit', 'hone-claws', 'sludge-wave', 'round', 'scald', 'retaliate', 'razor-shell', 'snarl', 'confide'], 'name': 'crawdaunt', 'stats': {'hp': 63, 'attack': 120, 'defense': 85, 'special-attack': 90, 'special-defense': 55, 'speed': 55}, 'types': ['water', 'dark'], 'weight': 328, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 155, 'color': 'red', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'シザリガー', 'roomaji': 'Shizariger', 'ko': '가재장군', 'zh-Hant': '鐵螯龍蝦', 'fr': 'Colhomard', 'de': 'Krebutack', 'es': 'Crawdaunt', 'it': 'Crawdaunt', 'en': 'Crawdaunt', 'ja': 'シザリガー', 'zh-Hans': '铁螯龙虾'}, 'genera': {'ja-Hrkt': 'ならずものポケモン', 'ko': '불량배포켓몬', 'zh-Hant': '流氓寶可夢', 'fr': 'Pokémon Crapule', 'de': 'Schlingel', 'es': 'Pokémon Granuja', 'it': 'Pokémon Canaglia', 'en': 'Rogue Pokémon', 'ja': 'ならずものポケモン', 'zh-Hans': '流氓宝可梦'}}
	public class SpecieCrawdaunt : PokemonSpecie
	{
#nullable enable
		private static SpecieCrawdaunt? _instance = null;
#nullable restore
        public static SpecieCrawdaunt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrawdaunt();
                }
                return _instance;
            }
        }

		public SpecieCrawdaunt() : base(
			"Crawdaunt",
			63, // HPs
			120, 85, // Attack & Defense
			90, 55, // Special Attack & Defense
			55			
		) {}
	}


	//Crawdaunt Pokemon Class
	public class Crawdaunt : Pokemon
	{

		public Crawdaunt(string nickname, int level)
		: base(
				342,
				SpecieCrawdaunt.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crawdaunt(int level)
		: base(
				342,
				SpecieCrawdaunt.Instance, // Pokemon Specie
				"Crawdaunt", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crawdaunt() : base(
			342,
			SpecieCrawdaunt.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
	}
}