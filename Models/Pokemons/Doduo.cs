using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Doduo Specie to store common natural stats of every {'abilities': ['run-away', 'early-bird', 'tangled-feet'], 'base_experience': 62, 'height': 14, 'id': 84, 'moves': ['swords-dance', 'whirlwind', 'fly', 'jump-kick', 'fury-attack', 'body-slam', 'take-down', 'thrash', 'double-edge', 'growl', 'supersonic', 'peck', 'drill-peck', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'haze', 'reflect', 'bide', 'mirror-move', 'swift', 'skull-bash', 'sky-attack', 'rest', 'tri-attack', 'substitute', 'thief', 'snore', 'curse', 'flail', 'protect', 'feint-attack', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'sunny-day', 'uproar', 'facade', 'knock-off', 'endeavor', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'acupressure', 'assurance', 'brave-bird', 'captivate', 'double-hit', 'round', 'echoed-voice', 'work-up', 'confide'], 'name': 'doduo', 'stats': {'hp': 35, 'attack': 85, 'defense': 45, 'special-attack': 35, 'special-defense': 35, 'speed': 75}, 'types': ['normal', 'flying'], 'weight': 392, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'brown', 'shape': 'legs', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ドードー', 'roomaji': 'Dodo', 'ko': '두두', 'zh-Hant': '嘟嘟', 'fr': 'Doduo', 'de': 'Dodu', 'es': 'Doduo', 'it': 'Doduo', 'en': 'Doduo', 'ja': 'ドードー', 'zh-Hans': '嘟嘟'}, 'genera': {'ja-Hrkt': 'ふたごどりポケモン', 'ko': '쌍둥이새포켓몬', 'zh-Hant': '兩頭鳥寶可夢', 'fr': 'Pokémon Duoiseau', 'de': 'Duovogel', 'es': 'Pokémon Ave Gemela', 'it': 'Pokémon Biuccello', 'en': 'Twin Bird Pokémon', 'ja': 'ふたごどりポケモン', 'zh-Hans': '两头鸟宝可梦'}}
	public class SpecieDoduo : PokemonSpecie
	{
#nullable enable
		private static SpecieDoduo? _instance = null;
#nullable restore
        public static SpecieDoduo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDoduo();
                }
                return _instance;
            }
        }

		public SpecieDoduo() : base(
			"Doduo",
			35, // HPs
			85, 45, // Attack & Defense
			35, 35, // Special Attack & Defense
			75			
		) {}
	}


	//Doduo Pokemon Class
	public class Doduo : Pokemon
	{

		public Doduo(string nickname, int level)
		: base(
				84,
				SpecieDoduo.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Doduo(int level)
		: base(
				84,
				SpecieDoduo.Instance, // Pokemon Specie
				"Doduo", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Doduo() : base(
			84,
			SpecieDoduo.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}