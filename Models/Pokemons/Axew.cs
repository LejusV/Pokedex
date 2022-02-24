using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Axew Specie to store common natural stats of every {'abilities': ['rivalry', 'mold-breaker', 'unnerve'], 'base_experience': 64, 'height': 6, 'id': 610, 'moves': ['scratch', 'guillotine', 'razor-wind', 'swords-dance', 'cut', 'leer', 'roar', 'counter', 'strength', 'dragon-rage', 'dig', 'toxic', 'double-team', 'harden', 'focus-energy', 'rest', 'slash', 'substitute', 'snore', 'reversal', 'protect', 'scary-face', 'outrage', 'endure', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'taunt', 'superpower', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'dragon-claw', 'dragon-dance', 'shock-wave', 'payback', 'assurance', 'fling', 'poison-jab', 'night-slash', 'aqua-tail', 'x-scissor', 'dragon-pulse', 'giga-impact', 'draco-meteor', 'hone-claws', 'round', 'incinerate', 'dual-chop', 'confide'], 'name': 'axew', 'stats': {'hp': 46, 'attack': 87, 'defense': 60, 'special-attack': 30, 'special-defense': 40, 'speed': 57}, 'types': ['dragon'], 'weight': 180, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 75, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'キバゴ', 'ko': '터검니', 'zh-Hant': '牙牙', 'fr': 'Coupenotte', 'de': 'Milza', 'es': 'Axew', 'it': 'Axew', 'en': 'Axew', 'ja': 'キバゴ', 'zh-Hans': '牙牙'}, 'genera': {'ja-Hrkt': 'キバポケモン', 'ko': '이빨포켓몬', 'zh-Hant': '牙寶可夢', 'fr': 'Pokémon Crocs', 'de': 'Stoßzahn', 'es': 'Pokémon Colmillo', 'it': 'Pokémon Zanna', 'en': 'Tusk Pokémon', 'ja': 'キバポケモン', 'zh-Hans': '牙宝可梦'}}
	public class SpecieAxew : PokemonSpecie
	{
#nullable enable
		private static SpecieAxew? _instance = null;
#nullable restore
        public static SpecieAxew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAxew();
                }
                return _instance;
            }
        }

		public SpecieAxew() : base(
			"Axew",
			46, // HPs
			87, 60, // Attack & Defense
			30, 40, // Special Attack & Defense
			57			
		) {}
	}


	//Axew Pokemon Class
	public class Axew : Pokemon
	{

		public Axew(string nickname, int level)
		: base(
				610,
				SpecieAxew.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Axew(int level)
		: base(
				610,
				SpecieAxew.Instance, // Pokemon Specie
				"Axew", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Axew() : base(
			610,
			SpecieAxew.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}