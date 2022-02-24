using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bisharp Specie to store common natural stats of every {'abilities': ['defiant', 'inner-focus', 'pressure'], 'base_experience': 172, 'height': 16, 'id': 625, 'moves': ['scratch', 'guillotine', 'swords-dance', 'cut', 'leer', 'hyper-beam', 'low-kick', 'thunder-wave', 'dig', 'toxic', 'double-team', 'rest', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'feint-attack', 'sandstorm', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'rock-smash', 'torment', 'facade', 'taunt', 'role-play', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'metal-burst', 'payback', 'assurance', 'embargo', 'fling', 'magnet-rise', 'rock-polish', 'poison-jab', 'dark-pulse', 'night-slash', 'x-scissor', 'focus-blast', 'giga-impact', 'shadow-claw', 'iron-head', 'stone-edge', 'stealth-rock', 'grass-knot', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'retaliate', 'dual-chop', 'snarl', 'confide', 'power-up-punch'], 'name': 'bisharp', 'stats': {'hp': 65, 'attack': 125, 'defense': 100, 'special-attack': 60, 'special-defense': 70, 'speed': 70}, 'types': ['dark', 'steel'], 'weight': 700, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'キリキザン', 'ko': '절각참', 'zh-Hant': '劈斬司令', 'fr': 'Scalproie', 'de': 'Caesurio', 'es': 'Bisharp', 'it': 'Bisharp', 'en': 'Bisharp', 'ja': 'キリキザン', 'zh-Hans': '劈斩司令'}, 'genera': {'ja-Hrkt': 'とうじんポケモン', 'ko': '도인포켓몬', 'zh-Hant': '刀刃寶可夢', 'fr': 'Pokémon Tranchant', 'de': 'Schwertklinge', 'es': 'Pokémon Filo', 'it': 'Pokémon Fildilama', 'en': 'Sword Blade Pokémon', 'ja': 'とうじんポケモン', 'zh-Hans': '刀刃宝可梦'}}
	public class SpecieBisharp : PokemonSpecie
	{
#nullable enable
		private static SpecieBisharp? _instance = null;
#nullable restore
        public static SpecieBisharp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBisharp();
                }
                return _instance;
            }
        }

		public SpecieBisharp() : base(
			"Bisharp",
			65, // HPs
			125, 100, // Attack & Defense
			60, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Bisharp Pokemon Class
	public class Bisharp : Pokemon
	{

		public Bisharp(string nickname, int level)
		: base(
				625,
				SpecieBisharp.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bisharp() : base(
			625,
			SpecieBisharp.Instance, // Pokemon Specie
			Dark.Instance, Steel.Instance			
		) {}
	}
}