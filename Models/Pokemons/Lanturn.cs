using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lanturn Specie to store common natural stats of every {'abilities': ['volt-absorb', 'illuminate', 'water-absorb'], 'base_experience': 161, 'height': 12, 'id': 171, 'moves': ['take-down', 'double-edge', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'mimic', 'double-team', 'confuse-ray', 'waterfall', 'bubble', 'flash', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'zap-cannon', 'icy-wind', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'hidden-power', 'rain-dance', 'whirlpool', 'stockpile', 'spit-up', 'swallow', 'hail', 'facade', 'charge', 'secret-power', 'dive', 'signal-beam', 'bounce', 'shock-wave', 'water-pulse', 'brine', 'natural-gift', 'sucker-punch', 'aqua-ring', 'aqua-tail', 'giga-impact', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'round', 'scald', 'volt-switch', 'wild-charge', 'ion-deluge', 'confide', 'eerie-impulse', 'dazzling-gleam', 'spotlight'], 'name': 'lanturn', 'stats': {'hp': 125, 'attack': 58, 'defense': 58, 'special-attack': 76, 'special-defense': 76, 'speed': 67}, 'types': ['water', 'electric'], 'weight': 225, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ランターン', 'roomaji': 'Lantern', 'ko': '랜턴', 'zh-Hant': '電燈怪', 'fr': 'Lanturn', 'de': 'Lanturn', 'es': 'Lanturn', 'it': 'Lanturn', 'en': 'Lanturn', 'ja': 'ランターン', 'zh-Hans': '电灯怪'}, 'genera': {'ja-Hrkt': 'ライトポケモン', 'ko': '라이트포켓몬', 'zh-Hant': '燈寶可夢', 'fr': 'Pokémon Lumière', 'de': 'Leuchte', 'es': 'Pokémon Luz', 'it': 'Pokémon Luce', 'en': 'Light Pokémon', 'ja': 'ライトポケモン', 'zh-Hans': '灯宝可梦'}}
	public class SpecieLanturn : PokemonSpecie
	{
#nullable enable
		private static SpecieLanturn? _instance = null;
#nullable restore
        public static SpecieLanturn Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLanturn();
                }
                return _instance;
            }
        }

		public SpecieLanturn() : base(
			"Lanturn",
			125, // HPs
			58, 58, // Attack & Defense
			76, 76, // Special Attack & Defense
			67			
		) {}
	}


	//Lanturn Pokemon Class
	public class Lanturn : Pokemon
	{

		public Lanturn(string nickname, int level) : base(
			171,
			SpecieLanturn.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Electric.Instance			
		) {}

		public Lanturn() : base(
			171,
			SpecieLanturn.Instance, // Pokemon Specie
			Water.Instance, Electric.Instance			
		) {}
	}
}