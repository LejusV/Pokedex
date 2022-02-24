using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Whirlipede Specie to store common natural stats of every {'abilities': ['poison-point', 'swarm', 'speed-boost'], 'base_experience': 126, 'height': 12, 'id': 544, 'moves': ['double-edge', 'poison-sting', 'solar-beam', 'toxic', 'agility', 'screech', 'double-team', 'defense-curl', 'rest', 'substitute', 'snore', 'protect', 'sludge-bomb', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'endeavor', 'secret-power', 'signal-beam', 'iron-defense', 'poison-tail', 'gyro-ball', 'payback', 'poison-jab', 'rock-climb', 'bug-bite', 'venoshock', 'round', 'struggle-bug', 'steamroller', 'confide', 'venom-drench', 'infestation'], 'name': 'whirlipede', 'stats': {'hp': 40, 'attack': 55, 'defense': 99, 'special-attack': 40, 'special-defense': 79, 'speed': 47}, 'types': ['bug', 'poison'], 'weight': 585, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'gray', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ホイーガ', 'ko': '휠구', 'zh-Hant': '車輪毬', 'fr': 'Scobolide', 'de': 'Rollum', 'es': 'Whirlipede', 'it': 'Whirlipede', 'en': 'Whirlipede', 'ja': 'ホイーガ', 'zh-Hans': '车轮球'}, 'genera': {'ja-Hrkt': 'まゆムカデポケモン', 'ko': '눈썹지네포켓몬', 'zh-Hant': '繭蜈蚣寶可夢', 'fr': 'Pokémon Coconplopode', 'de': 'Kokonfüßer', 'es': 'Pokémon Pupaciempiés', 'it': 'Pokémon Rotopede', 'en': 'Curlipede Pokémon', 'ja': 'まゆムカデポケモン', 'zh-Hans': '茧蜈蚣宝可梦'}}
	public class SpecieWhirlipede : PokemonSpecie
	{
#nullable enable
		private static SpecieWhirlipede? _instance = null;
#nullable restore
        public static SpecieWhirlipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhirlipede();
                }
                return _instance;
            }
        }

		public SpecieWhirlipede() : base(
			"Whirlipede",
			40, // HPs
			55, 99, // Attack & Defense
			40, 79, // Special Attack & Defense
			47			
		) {}
	}


	//Whirlipede Pokemon Class
	public class Whirlipede : Pokemon
	{

		public Whirlipede(string nickname, int level)
		: base(
				544,
				SpecieWhirlipede.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Whirlipede() : base(
			544,
			SpecieWhirlipede.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}