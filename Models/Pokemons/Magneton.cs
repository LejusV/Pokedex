using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magneton Specie to store common natural stats of every {'abilities': ['magnet-pull', 'sturdy', 'analytic'], 'base_experience': 163, 'height': 10, 'id': 82, 'moves': ['tackle', 'take-down', 'double-edge', 'supersonic', 'sonic-boom', 'hyper-beam', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'rage', 'teleport', 'mimic', 'screech', 'double-team', 'light-screen', 'reflect', 'bide', 'swift', 'flash', 'explosion', 'rest', 'tri-attack', 'substitute', 'snore', 'curse', 'protect', 'zap-cannon', 'lock-on', 'endure', 'rollout', 'swagger', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'facade', 'magic-coat', 'recycle', 'secret-power', 'metal-sound', 'signal-beam', 'iron-defense', 'shock-wave', 'gravity', 'gyro-ball', 'natural-gift', 'magnet-rise', 'giga-impact', 'mirror-shot', 'flash-cannon', 'discharge', 'magnet-bomb', 'charge-beam', 'electro-ball', 'round', 'volt-switch', 'electroweb', 'wild-charge', 'confide', 'electric-terrain'], 'name': 'magneton', 'stats': {'hp': 50, 'attack': 60, 'defense': 95, 'special-attack': 120, 'special-defense': 70, 'speed': 70}, 'types': ['electric', 'steel'], 'weight': 600, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 60, 'color': 'gray', 'shape': 'heads', 'habitat': 'rough-terrain', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'レアコイル', 'roomaji': 'Rarecoil', 'ko': '레어코일', 'zh-Hant': '三合一磁怪', 'fr': 'Magnéton', 'de': 'Magneton', 'es': 'Magneton', 'it': 'Magneton', 'en': 'Magneton', 'ja': 'レアコイル', 'zh-Hans': '三合一磁怪'}, 'genera': {'ja-Hrkt': 'じしゃくポケモン', 'ko': '자석포켓몬', 'zh-Hant': '磁鐵寶可夢', 'fr': 'Pokémon Magnétique', 'de': 'Magnet', 'es': 'Pokémon Imán', 'it': 'Pokémon Calamita', 'en': 'Magnet Pokémon', 'ja': 'じしゃくポケモン', 'zh-Hans': '磁铁宝可梦'}}
	public class SpecieMagneton : PokemonSpecie
	{
#nullable enable
		private static SpecieMagneton? _instance = null;
#nullable restore
        public static SpecieMagneton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagneton();
                }
                return _instance;
            }
        }

		public SpecieMagneton() : base(
			"Magneton",
			50, // HPs
			60, 95, // Attack & Defense
			120, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Magneton Pokemon Class
	public class Magneton : Pokemon
	{

		public Magneton(string nickname, int level)
		: base(
				82,
				SpecieMagneton.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Magneton(int level)
		: base(
				82,
				SpecieMagneton.Instance, // Pokemon Specie
				"Magneton", level,
				Electric.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Magneton() : base(
			82,
			SpecieMagneton.Instance, // Pokemon Specie
			Electric.Instance, Steel.Instance			
		) {}
	}
}