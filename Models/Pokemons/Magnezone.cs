using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magnezone Specie to store common natural stats of every {'abilities': ['magnet-pull', 'sturdy', 'analytic'], 'base_experience': 241, 'height': 12, 'id': 462, 'moves': ['tackle', 'supersonic', 'sonic-boom', 'hyper-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'screech', 'double-team', 'barrier', 'light-screen', 'reflect', 'swift', 'flash', 'explosion', 'rest', 'tri-attack', 'substitute', 'snore', 'protect', 'zap-cannon', 'lock-on', 'endure', 'rollout', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'mirror-coat', 'psych-up', 'facade', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'iron-defense', 'shock-wave', 'gravity', 'gyro-ball', 'natural-gift', 'magnet-rise', 'giga-impact', 'mirror-shot', 'flash-cannon', 'discharge', 'iron-head', 'magnet-bomb', 'charge-beam', 'electro-ball', 'round', 'volt-switch', 'electroweb', 'wild-charge', 'confide', 'magnetic-flux', 'electric-terrain'], 'name': 'magnezone', 'stats': {'hp': 70, 'attack': 70, 'defense': 115, 'special-attack': 130, 'special-defense': 90, 'speed': 60}, 'types': ['electric', 'steel'], 'weight': 1800, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 30, 'color': 'gray', 'shape': 'arms', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ジバコイル', 'roomaji': 'Jibacoil', 'ko': '자포코일', 'zh-Hant': '自爆磁怪', 'fr': 'Magnézone', 'de': 'Magnezone', 'es': 'Magnezone', 'it': 'Magnezone', 'en': 'Magnezone', 'ja': 'ジバコイル', 'zh-Hans': '自爆磁怪'}, 'genera': {'ja-Hrkt': 'じばポケモン', 'ko': '자기장포켓몬', 'zh-Hant': '磁場寶可夢', 'fr': 'Pokémon Aimant', 'de': 'Magnetgebiet', 'es': 'Pokémon Magnético', 'it': 'Pokémon Magnetico', 'en': 'Magnet Area Pokémon', 'ja': 'じばポケモン', 'zh-Hans': '磁场宝可梦'}}
	public class SpecieMagnezone : PokemonSpecie
	{
#nullable enable
		private static SpecieMagnezone? _instance = null;
#nullable restore
        public static SpecieMagnezone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagnezone();
                }
                return _instance;
            }
        }

		public SpecieMagnezone() : base(
			"Magnezone",
			70, // HPs
			70, 115, // Attack & Defense
			130, 90, // Special Attack & Defense
			60			
		) {}
	}


	//Magnezone Pokemon Class
	public class Magnezone : Pokemon
	{

		public Magnezone(string nickname, int level)
		: base(
				462,
				SpecieMagnezone.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Magnezone(int level)
		: base(
				462,
				SpecieMagnezone.Instance, // Pokemon Specie
				"Magnezone", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Magnezone() : base(
			462,
			SpecieMagnezone.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
	}
}