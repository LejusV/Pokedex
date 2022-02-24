using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Stakataka Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 55, 'id': 805, 'moves': ['tackle', 'take-down', 'double-edge', 'rock-throw', 'earthquake', 'toxic', 'light-screen', 'reflect', 'bide', 'rest', 'rock-slide', 'substitute', 'protect', 'sandstorm', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'facade', 'rock-tomb', 'iron-defense', 'rock-blast', 'gyro-ball', 'rock-polish', 'giga-impact', 'flash-cannon', 'trick-room', 'iron-head', 'stone-edge', 'stealth-rock', 'wide-guard', 'autotomize', 'smack-down', 'round', 'bulldoze', 'infestation', 'brutal-swing'], 'name': 'stakataka', 'stats': {'hp': 61, 'attack': 131, 'defense': 211, 'special-attack': 53, 'special-defense': 101, 'speed': 13}, 'types': ['rock', 'steel'], 'weight': 8200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 30, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ツンデツンデ', 'ko': '차곡차곡', 'zh-Hant': '壘磊石', 'fr': 'Ama-Ama', 'de': 'Muramura', 'es': 'Stakataka', 'it': 'Stakataka', 'en': 'Stakataka', 'ja': 'ツンデツンデ', 'zh-Hans': '垒磊石'}, 'genera': {'ja-Hrkt': 'いしがきポケモン', 'ko': '돌담포켓몬', 'zh-Hant': '石牆寶可夢', 'fr': 'Pokémon Muraille', 'de': 'Steinmauer', 'es': 'Pokémon Muro', 'it': 'Pokémon Bastione', 'en': 'Rampart Pokémon', 'ja': 'いしがきポケモン', 'zh-Hans': '石墙宝可梦'}}
	public class SpecieStakataka : PokemonSpecie
	{
#nullable enable
		private static SpecieStakataka? _instance = null;
#nullable restore
        public static SpecieStakataka Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStakataka();
                }
                return _instance;
            }
        }

		public SpecieStakataka() : base(
			"Stakataka",
			61, // HPs
			131, 211, // Attack & Defense
			53, 101, // Special Attack & Defense
			13			
		) {}
	}


	//Stakataka Pokemon Class
	public class Stakataka : Pokemon
	{

		public Stakataka(string nickname, int level)
		: base(
				805,
				SpecieStakataka.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stakataka(int level)
		: base(
				805,
				SpecieStakataka.Instance, // Pokemon Specie
				"Stakataka", level,
				Rock.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Stakataka() : base(
			805,
			SpecieStakataka.Instance, // Pokemon Specie
			Rock.Instance, Steel.Instance			
		) {}
	}
}