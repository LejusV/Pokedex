using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tirtouga Specie to store common natural stats of every {'abilities': ['solid-rock', 'sturdy', 'swift-swim'], 'base_experience': 71, 'height': 7, 'id': 564, 'moves': ['slam', 'body-slam', 'bite', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'strength', 'rock-throw', 'earthquake', 'dig', 'toxic', 'double-team', 'withdraw', 'bide', 'waterfall', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'icy-wind', 'sandstorm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'rock-smash', 'whirlpool', 'facade', 'knock-off', 'secret-power', 'dive', 'rock-tomb', 'iron-defense', 'block', 'water-pulse', 'brine', 'guard-swap', 'rock-polish', 'aqua-tail', 'earth-power', 'zen-headbutt', 'stone-edge', 'stealth-rock', 'aqua-jet', 'wide-guard', 'smack-down', 'round', 'scald', 'shell-smash', 'bulldoze', 'confide', 'liquidation'], 'name': 'tirtouga', 'stats': {'hp': 54, 'attack': 78, 'defense': 103, 'special-attack': 53, 'special-defense': 45, 'speed': 22}, 'types': ['water', 'rock'], 'weight': 165, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'プロトーガ', 'ko': '프로토가', 'zh-Hant': '原蓋海龜', 'fr': 'Carapagos', 'de': 'Galapaflos', 'es': 'Tirtouga', 'it': 'Tirtouga', 'en': 'Tirtouga', 'ja': 'プロトーガ', 'zh-Hans': '原盖海龟'}, 'genera': {'ja-Hrkt': 'こだいがめポケモン', 'ko': '옛날거북포켓몬', 'zh-Hant': '古代龜寶可夢', 'fr': 'Pokémon Tortantique', 'de': 'Urzeitkröte', 'es': 'Pokémon Pretortuga', 'it': 'Pokémon Ancestruga', 'en': 'Prototurtle Pokémon', 'ja': 'こだいがめポケモン', 'zh-Hans': '古代龟宝可梦'}}
	public class SpecieTirtouga : PokemonSpecie
	{
#nullable enable
		private static SpecieTirtouga? _instance = null;
#nullable restore
        public static SpecieTirtouga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTirtouga();
                }
                return _instance;
            }
        }

		public SpecieTirtouga() : base(
			"Tirtouga",
			54, // HPs
			78, 103, // Attack & Defense
			53, 45, // Special Attack & Defense
			22			
		) {}
	}


	//Tirtouga Pokemon Class
	public class Tirtouga : Pokemon
	{

		public Tirtouga(string nickname, int level)
		: base(
				564,
				SpecieTirtouga.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tirtouga(int level)
		: base(
				564,
				SpecieTirtouga.Instance, // Pokemon Specie
				"Tirtouga", level,
				Water.Instance, Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tirtouga() : base(
			564,
			SpecieTirtouga.Instance, // Pokemon Specie
			Water.Instance, Rock.Instance			
		) {}
	}
}