using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pawniard Specie to store common natural stats of every {'abilities': ['defiant', 'inner-focus', 'pressure'], 'base_experience': 68, 'height': 5, 'id': 624, 'moves': ['scratch', 'guillotine', 'swords-dance', 'cut', 'headbutt', 'leer', 'low-kick', 'thunder-wave', 'dig', 'toxic', 'double-team', 'rest', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'feint-attack', 'sandstorm', 'false-swipe', 'swagger', 'fury-cutter', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'metal-claw', 'hidden-power', 'rain-dance', 'rock-smash', 'torment', 'facade', 'taunt', 'role-play', 'revenge', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'payback', 'assurance', 'embargo', 'fling', 'sucker-punch', 'magnet-rise', 'rock-polish', 'poison-jab', 'dark-pulse', 'night-slash', 'x-scissor', 'shadow-claw', 'psycho-cut', 'iron-head', 'stealth-rock', 'grass-knot', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'quick-guard', 'retaliate', 'dual-chop', 'snarl', 'confide', 'power-up-punch'], 'name': 'pawniard', 'stats': {'hp': 45, 'attack': 85, 'defense': 70, 'special-attack': 40, 'special-defense': 40, 'speed': 60}, 'types': ['dark', 'steel'], 'weight': 102, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'red', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'コマタナ', 'ko': '자망칼', 'zh-Hant': '駒刀小兵', 'fr': 'Scalpion', 'de': 'Gladiantri', 'es': 'Pawniard', 'it': 'Pawniard', 'en': 'Pawniard', 'ja': 'コマタナ', 'zh-Hans': '驹刀小兵'}, 'genera': {'ja-Hrkt': 'はものポケモン', 'ko': '날붙이포켓몬', 'zh-Hant': '利器寶可夢', 'fr': 'Pokémon Coupant', 'de': 'Stahlklinge', 'es': 'Pokémon Tajo', 'it': 'Pokémon Lamaffilata', 'en': 'Sharp Blade Pokémon', 'ja': 'はものポケモン', 'zh-Hans': '利器宝可梦'}}
	public class SpeciePawniard : PokemonSpecie
	{
#nullable enable
		private static SpeciePawniard? _instance = null;
#nullable restore
        public static SpeciePawniard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePawniard();
                }
                return _instance;
            }
        }

		public SpeciePawniard() : base(
			"Pawniard",
			45, // HPs
			85, 70, // Attack & Defense
			40, 40, // Special Attack & Defense
			60			
		) {}
	}


	//Pawniard Pokemon Class
	public class Pawniard : Pokemon
	{

		public Pawniard(string nickname, int level)
		: base(
				624,
				SpeciePawniard.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pawniard() : base(
			624,
			SpeciePawniard.Instance, // Pokemon Specie
			Dark.Instance, Steel.Instance			
		) {}
	}
}