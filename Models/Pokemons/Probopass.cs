using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Probopass Specie to store common natural stats of every {'abilities': ['sturdy', 'magnet-pull', 'sand-force'], 'base_experience': 184, 'height': 14, 'id': 476, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'tackle', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'double-team', 'explosion', 'rest', 'rock-slide', 'tri-attack', 'substitute', 'snore', 'protect', 'mud-slap', 'zap-cannon', 'lock-on', 'sandstorm', 'endure', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'torment', 'facade', 'taunt', 'magic-coat', 'secret-power', 'rock-tomb', 'iron-defense', 'block', 'rock-blast', 'shock-wave', 'gravity', 'natural-gift', 'magnet-rise', 'rock-polish', 'power-gem', 'earth-power', 'giga-impact', 'flash-cannon', 'discharge', 'iron-head', 'magnet-bomb', 'stone-edge', 'captivate', 'stealth-rock', 'wide-guard', 'smack-down', 'round', 'volt-switch', 'bulldoze', 'confide', 'magnetic-flux', 'dazzling-gleam'], 'name': 'probopass', 'stats': {'hp': 60, 'attack': 55, 'defense': 145, 'special-attack': 75, 'special-defense': 150, 'speed': 40}, 'types': ['rock', 'steel'], 'weight': 3400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'gray', 'shape': 'heads', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ダイノーズ', 'roomaji': 'Dainose', 'ko': '대코파스', 'zh-Hant': '大朝北鼻', 'fr': 'Tarinorme', 'de': 'Voluminas', 'es': 'Probopass', 'it': 'Probopass', 'en': 'Probopass', 'ja': 'ダイノーズ', 'zh-Hans': '大朝北鼻'}, 'genera': {'ja-Hrkt': 'コンパスポケモン', 'ko': '콤파스포켓몬', 'zh-Hant': '羅盤寶可夢', 'fr': 'Pokémon Boussole', 'de': 'Kompass', 'es': 'Pokémon Brújula', 'it': 'Pokémon Bussola', 'en': 'Compass Pokémon', 'ja': 'コンパスポケモン', 'zh-Hans': '罗盘宝可梦'}}
	public class SpecieProbopass : PokemonSpecie
	{
#nullable enable
		private static SpecieProbopass? _instance = null;
#nullable restore
        public static SpecieProbopass Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieProbopass();
                }
                return _instance;
            }
        }

		public SpecieProbopass() : base(
			"Probopass",
			60, // HPs
			55, 145, // Attack & Defense
			75, 150, // Special Attack & Defense
			40			
		) {}
	}


	//Probopass Pokemon Class
	public class Probopass : Pokemon
	{

		public Probopass(string nickname, int level)
		: base(
				476,
				SpecieProbopass.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Probopass(int level)
		: base(
				476,
				SpecieProbopass.Instance, // Pokemon Specie
				"Probopass", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Probopass() : base(
			476,
			SpecieProbopass.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
	}
}