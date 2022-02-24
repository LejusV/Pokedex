using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Woobat Specie to store common natural stats of every {'abilities': ['unaware', 'klutz', 'simple'], 'base_experience': 65, 'height': 4, 'id': 527, 'moves': ['gust', 'fly', 'supersonic', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'amnesia', 'dream-eater', 'flash', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'protect', 'giga-drain', 'charm', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'heat-wave', 'torment', 'flatter', 'facade', 'taunt', 'helping-hand', 'trick', 'magic-coat', 'knock-off', 'endeavor', 'skill-swap', 'imprison', 'secret-power', 'fake-tears', 'air-cutter', 'odor-sleuth', 'signal-beam', 'aerial-ace', 'calm-mind', 'shock-wave', 'roost', 'gyro-ball', 'pluck', 'tailwind', 'u-turn', 'assurance', 'embargo', 'psycho-shift', 'air-slash', 'energy-ball', 'zen-headbutt', 'trick-room', 'captivate', 'charge-beam', 'psyshock', 'telekinesis', 'synchronoise', 'after-you', 'round', 'stored-power', 'acrobatics', 'heart-stamp', 'confide', 'venom-drench'], 'name': 'woobat', 'stats': {'hp': 65, 'attack': 45, 'defense': 43, 'special-attack': 55, 'special-defense': 43, 'speed': 72}, 'types': ['psychic', 'flying'], 'weight': 21, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['flying', 'ground'], 'names': {'ja-Hrkt': 'コロモリ', 'ko': '또르박쥐', 'zh-Hant': '滾滾蝙蝠', 'fr': 'Chovsourir', 'de': 'Fleknoil', 'es': 'Woobat', 'it': 'Woobat', 'en': 'Woobat', 'ja': 'コロモリ', 'zh-Hans': '滚滚蝙蝠'}, 'genera': {'ja-Hrkt': 'こうもりポケモン', 'ko': '박쥐포켓몬', 'zh-Hant': '蝙蝠寶可夢', 'fr': 'Pokémon Chovsouris', 'de': 'Fledermaus', 'es': 'Pokémon Murciélago', 'it': 'Pokémon Pipistrello', 'en': 'Bat Pokémon', 'ja': 'こうもりポケモン', 'zh-Hans': '蝙蝠宝可梦'}}
	public class SpecieWoobat : PokemonSpecie
	{
#nullable enable
		private static SpecieWoobat? _instance = null;
#nullable restore
        public static SpecieWoobat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWoobat();
                }
                return _instance;
            }
        }

		public SpecieWoobat() : base(
			"Woobat",
			65, // HPs
			45, 43, // Attack & Defense
			55, 43, // Special Attack & Defense
			72			
		) {}
	}


	//Woobat Pokemon Class
	public class Woobat : Pokemon
	{

		public Woobat(string nickname, int level)
		: base(
				527,
				SpecieWoobat.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Woobat(int level)
		: base(
				527,
				SpecieWoobat.Instance, // Pokemon Specie
				"Woobat", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Woobat() : base(
			527,
			SpecieWoobat.Instance, // Pokemon Specie
			Psychic.Instance, Flying.Instance			
		) {}
	}
}