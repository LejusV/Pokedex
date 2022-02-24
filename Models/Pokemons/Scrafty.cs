using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scrafty Specie to store common natural stats of every {'abilities': ['shed-skin', 'moxie', 'intimidate'], 'base_experience': 171, 'height': 11, 'id': 560, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'sand-attack', 'headbutt', 'leer', 'roar', 'hyper-beam', 'low-kick', 'strength', 'dig', 'toxic', 'double-team', 'high-jump-kick', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'feint-attack', 'sludge-bomb', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'torment', 'facade', 'focus-punch', 'taunt', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'iron-defense', 'dragon-claw', 'bulk-up', 'payback', 'fling', 'poison-jab', 'dark-pulse', 'dragon-pulse', 'drain-punch', 'focus-blast', 'giga-impact', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'grass-knot', 'head-smash', 'smack-down', 'low-sweep', 'foul-play', 'round', 'chip-away', 'incinerate', 'retaliate', 'dragon-tail', 'work-up', 'dual-chop', 'snarl', 'confide', 'power-up-punch'], 'name': 'scrafty', 'stats': {'hp': 65, 'attack': 90, 'defense': 115, 'special-attack': 45, 'special-defense': 115, 'speed': 58}, 'types': ['dark', 'fighting'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground', 'dragon'], 'names': {'ja-Hrkt': 'ズルズキン', 'ko': '곤율거니', 'zh-Hant': '頭巾混混', 'fr': 'Baggaïd', 'de': 'Irokex', 'es': 'Scrafty', 'it': 'Scrafty', 'en': 'Scrafty', 'ja': 'ズルズキン', 'zh-Hans': '头巾混混'}, 'genera': {'ja-Hrkt': 'あくとうポケモン', 'ko': '악당포켓몬', 'zh-Hant': '惡黨寶可夢', 'fr': 'Pokémon Gang', 'de': 'Halunke', 'es': 'Pokémon Gamberro', 'it': 'Pokémon Furfante', 'en': 'Hoodlum Pokémon', 'ja': 'あくとうポケモン', 'zh-Hans': '恶党宝可梦'}}
	public class SpecieScrafty : PokemonSpecie
	{
#nullable enable
		private static SpecieScrafty? _instance = null;
#nullable restore
        public static SpecieScrafty Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScrafty();
                }
                return _instance;
            }
        }

		public SpecieScrafty() : base(
			"Scrafty",
			65, // HPs
			90, 115, // Attack & Defense
			45, 115, // Special Attack & Defense
			58			
		) {}
	}


	//Scrafty Pokemon Class
	public class Scrafty : Pokemon
	{

		public Scrafty(string nickname, int level)
		: base(
				560,
				SpecieScrafty.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Scrafty() : base(
			560,
			SpecieScrafty.Instance, // Pokemon Specie
			Dark.Instance, Fighting.Instance			
		) {}
	}
}