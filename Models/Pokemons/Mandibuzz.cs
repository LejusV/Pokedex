using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mandibuzz Specie to store common natural stats of every {'abilities': ['big-pecks', 'overcoat', 'weak-armor'], 'base_experience': 179, 'height': 12, 'id': 630, 'moves': ['cut', 'gust', 'whirlwind', 'fly', 'fury-attack', 'leer', 'hyper-beam', 'toxic', 'double-team', 'mirror-move', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'bone-rush', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'heat-wave', 'torment', 'flatter', 'facade', 'taunt', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'roost', 'pluck', 'tailwind', 'u-turn', 'payback', 'embargo', 'punishment', 'dark-pulse', 'air-slash', 'brave-bird', 'giga-impact', 'nasty-plot', 'defog', 'foul-play', 'round', 'incinerate', 'retaliate', 'snarl', 'confide'], 'name': 'mandibuzz', 'stats': {'hp': 110, 'attack': 65, 'defense': 105, 'special-attack': 55, 'special-defense': 95, 'speed': 80}, 'types': ['dark', 'flying'], 'weight': 395, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 60, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'バルジーナ', 'ko': '버랜지나', 'zh-Hant': '禿鷹娜', 'fr': 'Vaututrice', 'de': 'Grypheldis', 'es': 'Mandibuzz', 'it': 'Mandibuzz', 'en': 'Mandibuzz', 'ja': 'バルジーナ', 'zh-Hans': '秃鹰娜'}, 'genera': {'ja-Hrkt': 'ほねわしポケモン', 'ko': '뼈독수리포켓몬', 'zh-Hant': '骨鷹寶可夢', 'fr': 'Pokémon Vostour', 'de': 'Knochenadler', 'es': 'Pokémon Águila Hueso', 'it': 'Pokémon Ossaquila', 'en': 'Bone Vulture Pokémon', 'ja': 'ほねわしポケモン', 'zh-Hans': '骨鹰宝可梦'}}
	public class SpecieMandibuzz : PokemonSpecie
	{
#nullable enable
		private static SpecieMandibuzz? _instance = null;
#nullable restore
        public static SpecieMandibuzz Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMandibuzz();
                }
                return _instance;
            }
        }

		public SpecieMandibuzz() : base(
			"Mandibuzz",
			110, // HPs
			65, 105, // Attack & Defense
			55, 95, // Special Attack & Defense
			80			
		) {}
	}


	//Mandibuzz Pokemon Class
	public class Mandibuzz : Pokemon
	{

		public Mandibuzz(string nickname, int level)
		: base(
				630,
				SpecieMandibuzz.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mandibuzz(int level)
		: base(
				630,
				SpecieMandibuzz.Instance, // Pokemon Specie
				"Mandibuzz", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mandibuzz() : base(
			630,
			SpecieMandibuzz.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
	}
}