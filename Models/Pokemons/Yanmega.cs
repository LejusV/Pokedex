using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yanmega Specie to store common natural stats of every {'abilities': ['speed-boost', 'tinted-lens', 'frisk'], 'base_experience': 180, 'height': 19, 'id': 469, 'moves': ['headbutt', 'tackle', 'supersonic', 'sonic-boom', 'hyper-beam', 'solar-beam', 'string-shot', 'toxic', 'psychic', 'quick-attack', 'screech', 'double-team', 'swift', 'dream-eater', 'leech-life', 'flash', 'rest', 'slash', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'foresight', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'shadow-ball', 'uproar', 'facade', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'feint', 'tailwind', 'u-turn', 'night-slash', 'air-slash', 'bug-buzz', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'round', 'struggle-bug', 'confide'], 'name': 'yanmega', 'stats': {'hp': 86, 'attack': 76, 'defense': 86, 'special-attack': 116, 'special-defense': 56, 'speed': 95}, 'types': ['bug', 'flying'], 'weight': 515, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'green', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'メガヤンマ', 'roomaji': 'Megayanma', 'ko': '메가자리', 'zh-Hant': '遠古巨蜓', 'fr': 'Yanmega', 'de': 'Yanmega', 'es': 'Yanmega', 'it': 'Yanmega', 'en': 'Yanmega', 'ja': 'メガヤンマ', 'zh-Hans': '远古巨蜓'}, 'genera': {'ja-Hrkt': 'オニトンボポケモン', 'ko': '깨비잠자리포켓몬', 'zh-Hant': '勾蜓寶可夢', 'fr': 'Pokémon Libellogre', 'de': 'Agrion', 'es': 'Pokémon Libélula', 'it': 'Pokémon Libellorco', 'en': 'Ogre Darner Pokémon', 'ja': 'オニトンボポケモン', 'zh-Hans': '勾蜓宝可梦'}}
	public class SpecieYanmega : PokemonSpecie
	{
#nullable enable
		private static SpecieYanmega? _instance = null;
#nullable restore
        public static SpecieYanmega Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYanmega();
                }
                return _instance;
            }
        }

		public SpecieYanmega() : base(
			"Yanmega",
			86, // HPs
			76, 86, // Attack & Defense
			116, 56, // Special Attack & Defense
			95			
		) {}
	}


	//Yanmega Pokemon Class
	public class Yanmega : Pokemon
	{

		public Yanmega(string nickname, int level)
		: base(
				469,
				SpecieYanmega.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Yanmega() : base(
			469,
			SpecieYanmega.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}