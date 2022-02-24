using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Crobat Specie to store common natural stats of every {'abilities': ['inner-focus', 'infiltrator'], 'base_experience': 241, 'height': 18, 'id': 169, 'moves': ['wing-attack', 'fly', 'double-edge', 'bite', 'supersonic', 'hyper-beam', 'absorb', 'toxic', 'mimic', 'screech', 'double-team', 'confuse-ray', 'haze', 'swift', 'leech-life', 'sky-attack', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'snatch', 'secret-power', 'poison-fang', 'astonish', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'payback', 'dark-pulse', 'air-slash', 'x-scissor', 'giga-impact', 'zen-headbutt', 'defog', 'cross-poison', 'captivate', 'ominous-wind', 'venoshock', 'round', 'quick-guard', 'acrobatics', 'confide'], 'name': 'crobat', 'stats': {'hp': 85, 'attack': 90, 'defense': 80, 'special-attack': 70, 'special-defense': 80, 'speed': 130}, 'types': ['poison', 'flying'], 'weight': 750, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'purple', 'shape': 'bug-wings', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'クロバット', 'roomaji': 'Crobat', 'ko': '크로뱃', 'zh-Hant': '叉字蝠', 'fr': 'Nostenfer', 'de': 'Iksbat', 'es': 'Crobat', 'it': 'Crobat', 'en': 'Crobat', 'ja': 'クロバット', 'zh-Hans': '叉字蝠'}, 'genera': {'ja-Hrkt': 'こうもりポケモン', 'ko': '박쥐포켓몬', 'zh-Hant': '蝙蝠寶可夢', 'fr': 'Pokémon Chovsouris', 'de': 'Fledermaus', 'es': 'Pokémon Murciélago', 'it': 'Pokémon Pipistrello', 'en': 'Bat Pokémon', 'ja': 'こうもりポケモン', 'zh-Hans': '蝙蝠宝可梦'}}
	public class SpecieCrobat : PokemonSpecie
	{
#nullable enable
		private static SpecieCrobat? _instance = null;
#nullable restore
        public static SpecieCrobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCrobat();
                }
                return _instance;
            }
        }

		public SpecieCrobat() : base(
			"Crobat",
			85, // HPs
			90, 80, // Attack & Defense
			70, 80, // Special Attack & Defense
			130			
		) {}
	}


	//Crobat Pokemon Class
	public class Crobat : Pokemon
	{

		public Crobat(string nickname, int level)
		: base(
				169,
				SpecieCrobat.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crobat(int level)
		: base(
				169,
				SpecieCrobat.Instance, // Pokemon Specie
				"Crobat", level,
				Poison.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Crobat() : base(
			169,
			SpecieCrobat.Instance, // Pokemon Specie
			Poison.Instance, Flying.Instance			
		) {}
	}
}