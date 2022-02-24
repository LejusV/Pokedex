using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Electrode Specie to store common natural stats of every {'abilities': ['soundproof', 'static', 'aftermath'], 'base_experience': 172, 'height': 12, 'id': 101, 'moves': ['headbutt', 'tackle', 'take-down', 'sonic-boom', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'rage', 'teleport', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'self-destruct', 'swift', 'skull-bash', 'flash', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'rollout', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'mirror-coat', 'torment', 'facade', 'charge', 'taunt', 'magic-coat', 'secret-power', 'signal-beam', 'shock-wave', 'gyro-ball', 'natural-gift', 'sucker-punch', 'magnet-rise', 'giga-impact', 'discharge', 'charge-beam', 'electro-ball', 'foul-play', 'round', 'volt-switch', 'wild-charge', 'confide', 'eerie-impulse', 'magnetic-flux'], 'name': 'electrode', 'stats': {'hp': 60, 'attack': 50, 'defense': 70, 'special-attack': 80, 'special-defense': 80, 'speed': 150}, 'types': ['electric'], 'weight': 666, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 60, 'color': 'red', 'shape': 'ball', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'マルマイン', 'roomaji': 'Marumine', 'ko': '붐볼', 'zh-Hant': '頑皮雷彈', 'fr': 'Électrode', 'de': 'Lektrobal', 'es': 'Electrode', 'it': 'Electrode', 'en': 'Electrode', 'ja': 'マルマイン', 'zh-Hans': '顽皮雷弹'}, 'genera': {'ja-Hrkt': 'ボールポケモン', 'ko': '볼포켓몬', 'zh-Hant': '球寶可夢', 'fr': 'Pokémon Balle', 'de': 'Ball', 'es': 'Pokémon Bola', 'it': 'Pokémon Ball', 'en': 'Ball Pokémon', 'ja': 'ボールポケモン', 'zh-Hans': '球宝可梦'}}
	public class SpecieElectrode : PokemonSpecie
	{
#nullable enable
		private static SpecieElectrode? _instance = null;
#nullable restore
        public static SpecieElectrode Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElectrode();
                }
                return _instance;
            }
        }

		public SpecieElectrode() : base(
			"Electrode",
			60, // HPs
			50, 70, // Attack & Defense
			80, 80, // Special Attack & Defense
			150			
		) {}
	}


	//Electrode Pokemon Class
	public class Electrode : Pokemon
	{

		public Electrode(string nickname, int level)
		: base(
				101,
				SpecieElectrode.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electrode(int level)
		: base(
				101,
				SpecieElectrode.Instance, // Pokemon Specie
				"Electrode", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Electrode() : base(
			101,
			SpecieElectrode.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}