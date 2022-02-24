using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Voltorb Specie to store common natural stats of every {'abilities': ['soundproof', 'static', 'aftermath'], 'base_experience': 66, 'height': 5, 'id': 100, 'moves': ['headbutt', 'tackle', 'take-down', 'sonic-boom', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'rage', 'teleport', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'self-destruct', 'swift', 'flash', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'rollout', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'mirror-coat', 'torment', 'facade', 'charge', 'taunt', 'magic-coat', 'secret-power', 'signal-beam', 'shock-wave', 'gyro-ball', 'natural-gift', 'sucker-punch', 'magnet-rise', 'discharge', 'charge-beam', 'electro-ball', 'foul-play', 'round', 'volt-switch', 'wild-charge', 'confide', 'eerie-impulse'], 'name': 'voltorb', 'stats': {'hp': 40, 'attack': 30, 'defense': 50, 'special-attack': 55, 'special-defense': 55, 'speed': 100}, 'types': ['electric'], 'weight': 104, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 190, 'color': 'red', 'shape': 'ball', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ビリリダマ', 'roomaji': 'Biriridama', 'ko': '찌리리공', 'zh-Hant': '霹靂電球', 'fr': 'Voltorbe', 'de': 'Voltobal', 'es': 'Voltorb', 'it': 'Voltorb', 'en': 'Voltorb', 'ja': 'ビリリダマ', 'zh-Hans': '霹雳电球'}, 'genera': {'ja-Hrkt': 'ボールポケモン', 'ko': '볼포켓몬', 'zh-Hant': '球寶可夢', 'fr': 'Pokémon Balle', 'de': 'Ball', 'es': 'Pokémon Bola', 'it': 'Pokémon Ball', 'en': 'Ball Pokémon', 'ja': 'ボールポケモン', 'zh-Hans': '球宝可梦'}}
	public class SpecieVoltorb : PokemonSpecie
	{
#nullable enable
		private static SpecieVoltorb? _instance = null;
#nullable restore
        public static SpecieVoltorb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVoltorb();
                }
                return _instance;
            }
        }

		public SpecieVoltorb() : base(
			"Voltorb",
			40, // HPs
			30, 50, // Attack & Defense
			55, 55, // Special Attack & Defense
			100			
		) {}
	}


	//Voltorb Pokemon Class
	public class Voltorb : Pokemon
	{

		public Voltorb(string nickname, int level)
		: base(
				100,
				SpecieVoltorb.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Voltorb() : base(
			100,
			SpecieVoltorb.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}