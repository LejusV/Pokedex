using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ampharos Specie to store common natural stats of every {'abilities': ['static', 'plus'], 'base_experience': 230, 'height': 14, 'id': 181, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'growl', 'hyper-beam', 'counter', 'seismic-toss', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'mimic', 'double-team', 'confuse-ray', 'defense-curl', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'snore', 'curse', 'cotton-spore', 'protect', 'zap-cannon', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'focus-punch', 'charge', 'brick-break', 'secret-power', 'signal-beam', 'shock-wave', 'natural-gift', 'fling', 'magnet-rise', 'dragon-pulse', 'power-gem', 'focus-blast', 'giga-impact', 'rock-climb', 'discharge', 'captivate', 'charge-beam', 'electro-ball', 'after-you', 'round', 'echoed-voice', 'volt-switch', 'bulldoze', 'electroweb', 'wild-charge', 'cotton-guard', 'ion-deluge', 'confide', 'magnetic-flux', 'power-up-punch', 'brutal-swing'], 'name': 'ampharos', 'stats': {'hp': 90, 'attack': 75, 'defense': 85, 'special-attack': 115, 'special-defense': 90, 'speed': 55}, 'types': ['electric'], 'weight': 615, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'デンリュウ', 'roomaji': 'Denryu', 'ko': '전룡', 'zh-Hant': '電龍', 'fr': 'Pharamp', 'de': 'Ampharos', 'es': 'Ampharos', 'it': 'Ampharos', 'en': 'Ampharos', 'ja': 'デンリュウ', 'zh-Hans': '电龙'}, 'genera': {'ja-Hrkt': 'ライトポケモン', 'ko': '라이트포켓몬', 'zh-Hant': '燈寶可夢', 'fr': 'Pokémon Lumière', 'de': 'Leuchte', 'es': 'Pokémon Luz', 'it': 'Pokémon Luce', 'en': 'Light Pokémon', 'ja': 'ライトポケモン', 'zh-Hans': '灯宝可梦'}}
	public class SpecieAmpharos : PokemonSpecie
	{
#nullable enable
		private static SpecieAmpharos? _instance = null;
#nullable restore
        public static SpecieAmpharos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmpharos();
                }
                return _instance;
            }
        }

		public SpecieAmpharos() : base(
			"Ampharos",
			90, // HPs
			75, 85, // Attack & Defense
			115, 90, // Special Attack & Defense
			55			
		) {}
	}


	//Ampharos Pokemon Class
	public class Ampharos : Pokemon
	{

		public Ampharos(string nickname, int level)
		: base(
				181,
				SpecieAmpharos.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ampharos(int level)
		: base(
				181,
				SpecieAmpharos.Instance, // Pokemon Specie
				"Ampharos", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ampharos() : base(
			181,
			SpecieAmpharos.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}