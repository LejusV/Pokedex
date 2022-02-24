using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cherrim Specie to store common natural stats of every {'abilities': ['flower-gift'], 'base_experience': 158, 'height': 5, 'id': 421, 'moves': ['swords-dance', 'tackle', 'take-down', 'hyper-beam', 'leech-seed', 'growth', 'solar-beam', 'petal-dance', 'toxic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'morning-sun', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'helping-hand', 'secret-power', 'bullet-seed', 'magical-leaf', 'natural-gift', 'lucky-chant', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'captivate', 'grass-knot', 'round', 'petal-blizzard', 'confide', 'dazzling-gleam'], 'name': 'cherrim', 'stats': {'hp': 70, 'attack': 60, 'defense': 70, 'special-attack': 87, 'special-defense': 78, 'speed': 85}, 'types': ['grass'], 'weight': 93, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'legs', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'チェリム', 'roomaji': 'Cherrim', 'ko': '체리꼬', 'zh-Hant': '櫻花兒', 'fr': 'Ceriflor', 'de': 'Kinoso', 'es': 'Cherrim', 'it': 'Cherrim', 'en': 'Cherrim', 'ja': 'チェリム', 'zh-Hans': '樱花儿'}, 'genera': {'ja-Hrkt': 'サクラポケモン', 'ko': '벚꽃포켓몬', 'zh-Hant': '櫻花寶可夢', 'fr': 'Pokémon Floraison', 'de': 'Blüte', 'es': 'Pokémon Floración', 'it': 'Pokémon Bocciolo', 'en': 'Blossom Pokémon', 'ja': 'サクラポケモン', 'zh-Hans': '樱花宝可梦'}}
	public class SpecieCherrim : PokemonSpecie
	{
#nullable enable
		private static SpecieCherrim? _instance = null;
#nullable restore
        public static SpecieCherrim Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCherrim();
                }
                return _instance;
            }
        }

		public SpecieCherrim() : base(
			"Cherrim",
			70, // HPs
			60, 70, // Attack & Defense
			87, 78, // Special Attack & Defense
			85			
		) {}
	}


	//Cherrim Pokemon Class
	public class Cherrim : Pokemon
	{

		public Cherrim(string nickname, int level)
		: base(
				421,
				SpecieCherrim.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cherrim(int level)
		: base(
				421,
				SpecieCherrim.Instance, // Pokemon Specie
				"Cherrim", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cherrim() : base(
			421,
			SpecieCherrim.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}