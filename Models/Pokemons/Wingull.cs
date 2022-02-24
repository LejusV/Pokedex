using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wingull Specie to store common natural stats of every {'abilities': ['keen-eye', 'hydration', 'rain-dish'], 'base_experience': 54, 'height': 6, 'id': 278, 'moves': ['gust', 'wing-attack', 'fly', 'double-edge', 'growl', 'supersonic', 'mist', 'water-gun', 'ice-beam', 'blizzard', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'uproar', 'hail', 'facade', 'knock-off', 'secret-power', 'air-cutter', 'aerial-ace', 'water-sport', 'shock-wave', 'water-pulse', 'roost', 'brine', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'aqua-ring', 'air-slash', 'defog', 'captivate', 'ominous-wind', 'wide-guard', 'soak', 'round', 'echoed-voice', 'scald', 'hurricane', 'confide'], 'name': 'wingull', 'stats': {'hp': 40, 'attack': 30, 'defense': 30, 'special-attack': 55, 'special-defense': 30, 'speed': 85}, 'types': ['water', 'flying'], 'weight': 95, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'wings', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'flying'], 'names': {'ja-Hrkt': 'キャモメ', 'roomaji': 'Camome', 'ko': '갈모매', 'zh-Hant': '長翅鷗', 'fr': 'Goélise', 'de': 'Wingull', 'es': 'Wingull', 'it': 'Wingull', 'en': 'Wingull', 'ja': 'キャモメ', 'zh-Hans': '长翅鸥'}, 'genera': {'ja-Hrkt': 'うみねこポケモン', 'ko': '괭이갈매기포켓몬', 'zh-Hant': '海鷗寶可夢', 'fr': 'Pokémon Mouette', 'de': 'Seemöwe', 'es': 'Pokémon Gaviota', 'it': 'Pokémon Gabbiano', 'en': 'Seagull Pokémon', 'ja': 'うみねこポケモン', 'zh-Hans': '海鸥宝可梦'}}
	public class SpecieWingull : PokemonSpecie
	{
#nullable enable
		private static SpecieWingull? _instance = null;
#nullable restore
        public static SpecieWingull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWingull();
                }
                return _instance;
            }
        }

		public SpecieWingull() : base(
			"Wingull",
			40, // HPs
			30, 30, // Attack & Defense
			55, 30, // Special Attack & Defense
			85			
		) {}
	}


	//Wingull Pokemon Class
	public class Wingull : Pokemon
	{

		public Wingull(string nickname, int level)
		: base(
				278,
				SpecieWingull.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wingull() : base(
			278,
			SpecieWingull.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}