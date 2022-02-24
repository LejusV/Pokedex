using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chinchou Specie to store common natural stats of every {'abilities': ['volt-absorb', 'illuminate', 'water-absorb'], 'base_experience': 66, 'height': 5, 'id': 170, 'moves': ['take-down', 'double-edge', 'supersonic', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'mimic', 'screech', 'double-team', 'confuse-ray', 'waterfall', 'amnesia', 'bubble', 'flash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'zap-cannon', 'icy-wind', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'charge', 'secret-power', 'dive', 'signal-beam', 'bounce', 'shock-wave', 'water-pulse', 'brine', 'natural-gift', 'sucker-punch', 'aqua-ring', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'soak', 'round', 'scald', 'volt-switch', 'wild-charge', 'ion-deluge', 'confide', 'dazzling-gleam'], 'name': 'chinchou', 'stats': {'hp': 75, 'attack': 38, 'defense': 38, 'special-attack': 56, 'special-defense': 56, 'speed': 67}, 'types': ['water', 'electric'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'チョンチー', 'roomaji': 'Chonchie', 'ko': '초라기', 'zh-Hant': '燈籠魚', 'fr': 'Loupio', 'de': 'Lampi', 'es': 'Chinchou', 'it': 'Chinchou', 'en': 'Chinchou', 'ja': 'チョンチー', 'zh-Hans': '灯笼鱼'}, 'genera': {'ja-Hrkt': 'あんこうポケモン', 'ko': '아귀포켓몬', 'zh-Hant': '琵琶魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Angler', 'es': 'Pokémon Rape', 'it': 'Pokémon Pescatore', 'en': 'Angler Pokémon', 'ja': 'あんこうポケモン', 'zh-Hans': '琵琶鱼宝可梦'}}
	public class SpecieChinchou : PokemonSpecie
	{
#nullable enable
		private static SpecieChinchou? _instance = null;
#nullable restore
        public static SpecieChinchou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChinchou();
                }
                return _instance;
            }
        }

		public SpecieChinchou() : base(
			"Chinchou",
			75, // HPs
			38, 38, // Attack & Defense
			56, 56, // Special Attack & Defense
			67			
		) {}
	}


	//Chinchou Pokemon Class
	public class Chinchou : Pokemon
	{

		public Chinchou(string nickname, int level)
		: base(
				170,
				SpecieChinchou.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chinchou() : base(
			170,
			SpecieChinchou.Instance, // Pokemon Specie
			Water.Instance, Electric.Instance			
		) {}
	}
}