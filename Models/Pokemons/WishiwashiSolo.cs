using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wishiwashi-Solo Specie to store common natural stats of every {'abilities': ['schooling'], 'base_experience': 61, 'height': 2, 'id': 746, 'moves': ['take-down', 'double-edge', 'growl', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'earthquake', 'toxic', 'double-team', 'waterfall', 'rest', 'substitute', 'protect', 'feint-attack', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'whirlpool', 'beat-up', 'hail', 'facade', 'helping-hand', 'endeavor', 'dive', 'muddy-water', 'water-sport', 'water-pulse', 'brine', 'u-turn', 'aqua-ring', 'aqua-tail', 'soak', 'round', 'scald', 'bulldoze', 'confide', 'tearful-look'], 'name': 'wishiwashi-solo', 'stats': {'hp': 45, 'attack': 20, 'defense': 20, 'special-attack': 25, 'special-defense': 25, 'speed': 40}, 'types': ['water'], 'weight': 3, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'fast', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ヨワシ', 'ko': '약어리', 'zh-Hant': '弱丁魚', 'fr': 'Froussardine', 'de': 'Lusardin', 'es': 'Wishiwashi', 'it': 'Wishiwashi', 'en': 'Wishiwashi', 'ja': 'ヨワシ', 'zh-Hans': '弱丁鱼'}, 'genera': {'ja-Hrkt': 'こざかなポケモン', 'ko': '잔물고기포켓몬', 'zh-Hant': '小魚寶可夢', 'fr': 'Pokémon Minipoisson', 'de': 'Kleinfisch', 'es': 'Pokémon Pececillo', 'it': 'Pokémon Pesciolino', 'en': 'Small Fry Pokémon', 'ja': 'こざかなポケモン', 'zh-Hans': '小鱼宝可梦'}}
	public class SpecieWishiwashiSolo : PokemonSpecie
	{
#nullable enable
		private static SpecieWishiwashiSolo? _instance = null;
#nullable restore
        public static SpecieWishiwashiSolo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWishiwashiSolo();
                }
                return _instance;
            }
        }

		public SpecieWishiwashiSolo() : base(
			"Wishiwashi-Solo",
			45, // HPs
			20, 20, // Attack & Defense
			25, 25, // Special Attack & Defense
			40			
		) {}
	}


	//Wishiwashi-Solo Pokemon Class
	public class WishiwashiSolo : Pokemon
	{

		public WishiwashiSolo(string nickname, int level)
		: base(
				746,
				SpecieWishiwashiSolo.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public WishiwashiSolo(int level)
		: base(
				746,
				SpecieWishiwashiSolo.Instance, // Pokemon Specie
				"Wishiwashi-Solo", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public WishiwashiSolo() : base(
			746,
			SpecieWishiwashiSolo.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}