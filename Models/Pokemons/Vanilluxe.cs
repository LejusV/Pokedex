using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vanilluxe Specie to store common natural stats of every {'abilities': ['ice-body', 'snow-warning', 'weak-armor'], 'base_experience': 241, 'height': 13, 'id': 584, 'moves': ['mist', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'double-team', 'harden', 'light-screen', 'acid-armor', 'explosion', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'mirror-coat', 'uproar', 'hail', 'facade', 'taunt', 'magic-coat', 'secret-power', 'astonish', 'weather-ball', 'signal-beam', 'sheer-cold', 'icicle-spear', 'iron-defense', 'water-pulse', 'magnet-rise', 'giga-impact', 'avalanche', 'mirror-shot', 'flash-cannon', 'round', 'frost-breath', 'freeze-dry', 'confide'], 'name': 'vanilluxe', 'stats': {'hp': 71, 'attack': 95, 'defense': 85, 'special-attack': 110, 'special-defense': 95, 'speed': 79}, 'types': ['ice'], 'weight': 575, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'heads', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'バイバニラ', 'ko': '배바닐라', 'zh-Hant': '雙倍多多冰', 'fr': 'Sorbouboul', 'de': 'Gelatwino', 'es': 'Vanilluxe', 'it': 'Vanilluxe', 'en': 'Vanilluxe', 'ja': 'バイバニラ', 'zh-Hans': '双倍多多冰'}, 'genera': {'ja-Hrkt': 'ブリザードポケモン', 'ko': '블리자드포켓몬', 'zh-Hant': '暴風雪寶可夢', 'fr': 'Pokémon Congère', 'de': 'Schneesturm', 'es': 'Pokémon Nieve Gélida', 'it': 'Pokémon Bufera', 'en': 'Snowstorm Pokémon', 'ja': 'ブリザードポケモン', 'zh-Hans': '暴风雪宝可梦'}}
	public class SpecieVanilluxe : PokemonSpecie
	{
#nullable enable
		private static SpecieVanilluxe? _instance = null;
#nullable restore
        public static SpecieVanilluxe Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVanilluxe();
                }
                return _instance;
            }
        }

		public SpecieVanilluxe() : base(
			"Vanilluxe",
			71, // HPs
			95, 85, // Attack & Defense
			110, 95, // Special Attack & Defense
			79			
		) {}
	}


	//Vanilluxe Pokemon Class
	public class Vanilluxe : Pokemon
	{

		public Vanilluxe(string nickname, int level)
		: base(
				584,
				SpecieVanilluxe.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vanilluxe() : base(
			584,
			SpecieVanilluxe.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}