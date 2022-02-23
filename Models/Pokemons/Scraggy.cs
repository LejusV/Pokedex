using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Scraggy Specie to store common natural stats of every {'abilities': ['shed-skin', 'moxie', 'intimidate'], 'base_experience': 70, 'height': 6, 'id': 559, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'sand-attack', 'headbutt', 'leer', 'roar', 'low-kick', 'counter', 'strength', 'dig', 'toxic', 'double-team', 'amnesia', 'high-jump-kick', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'spite', 'protect', 'scary-face', 'feint-attack', 'sludge-bomb', 'detect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'fake-out', 'torment', 'facade', 'focus-punch', 'taunt', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'iron-defense', 'dragon-claw', 'bulk-up', 'dragon-dance', 'payback', 'fling', 'poison-jab', 'dark-pulse', 'dragon-pulse', 'drain-punch', 'focus-blast', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'grass-knot', 'head-smash', 'smack-down', 'low-sweep', 'acid-spray', 'foul-play', 'round', 'chip-away', 'quick-guard', 'incinerate', 'retaliate', 'dragon-tail', 'work-up', 'dual-chop', 'snarl', 'confide', 'power-up-punch'], 'name': 'scraggy', 'stats': {'hp': 50, 'attack': 75, 'defense': 70, 'special-attack': 35, 'special-defense': 70, 'speed': 48}, 'types': ['dark', 'fighting'], 'weight': 118, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 180, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground', 'dragon'], 'names': {'ja-Hrkt': 'ズルッグ', 'ko': '곤율랭', 'zh-Hant': '滑滑小子', 'fr': 'Baggiguane', 'de': 'Zurrokex', 'es': 'Scraggy', 'it': 'Scraggy', 'en': 'Scraggy', 'ja': 'ズルッグ', 'zh-Hans': '滑滑小子'}, 'genera': {'ja-Hrkt': 'だっぴポケモン', 'ko': '탈피포켓몬', 'zh-Hant': '蛻皮寶可夢', 'fr': 'Pokémon Mue', 'de': 'Hautwechsel', 'es': 'Pokémon Mudapiel', 'it': 'Pokémon Mutapelle', 'en': 'Shedding Pokémon', 'ja': 'だっぴポケモン', 'zh-Hans': '蜕皮宝可梦'}}
	public class SpecieScraggy : PokemonSpecie
	{
#nullable enable
		private static SpecieScraggy? _instance = null;
#nullable restore
        public static SpecieScraggy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieScraggy();
                }
                return _instance;
            }
        }

		public SpecieScraggy() : base(
			"Scraggy",
			50, // HPs
			75, 70, // Attack & Defense
			35, 70, // Special Attack & Defense
			48			
		) {}
	}


	//Scraggy Pokemon Class
	public class Scraggy : Pokemon
	{

		public Scraggy(string nickname, int level) : base(
			559,
			SpecieScraggy.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Fighting.Instance			
		) {}

		public Scraggy() : base(
			559,
			SpecieScraggy.Instance, // Pokemon Specie
			Dark.Instance, Fighting.Instance			
		) {}
	}
}