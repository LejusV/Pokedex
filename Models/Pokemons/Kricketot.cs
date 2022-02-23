using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kricketot Specie to store common natural stats of every {'abilities': ['shed-skin', 'run-away'], 'base_experience': 39, 'height': 3, 'id': 401, 'moves': ['growl', 'string-shot', 'bide', 'snore', 'mud-slap', 'uproar', 'endeavor', 'bug-bite', 'struggle-bug'], 'name': 'kricketot', 'stats': {'hp': 37, 'attack': 25, 'defense': 41, 'special-attack': 25, 'special-defense': 41, 'speed': 25}, 'types': ['bug'], 'weight': 22, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'red', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'コロボーシ', 'roomaji': 'Korobohshi', 'ko': '귀뚤뚜기', 'zh-Hant': '圓法師', 'fr': 'Crikzik', 'de': 'Zirpurze', 'es': 'Kricketot', 'it': 'Kricketot', 'en': 'Kricketot', 'ja': 'コロボーシ', 'zh-Hans': '圆法师'}, 'genera': {'ja-Hrkt': 'こおろぎポケモン', 'ko': '귀뚜라미포켓몬', 'zh-Hant': '蟋蟀寶可夢', 'fr': 'Pokémon Criquet', 'de': 'Zirper', 'es': 'Pokémon Grillo', 'it': 'Pokémon Grillo', 'en': 'Cricket Pokémon', 'ja': 'こおろぎポケモン', 'zh-Hans': '蟋蟀宝可梦'}}
	public class SpecieKricketot : PokemonSpecie
	{
#nullable enable
		private static SpecieKricketot? _instance = null;
#nullable restore
        public static SpecieKricketot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKricketot();
                }
                return _instance;
            }
        }

		public SpecieKricketot() : base(
			"Kricketot",
			37, // HPs
			25, 41, // Attack & Defense
			25, 41, // Special Attack & Defense
			25			
		) {}
	}


	//Kricketot Pokemon Class
	public class Kricketot : Pokemon
	{

		public Kricketot(string nickname, int level) : base(
			401,
			SpecieKricketot.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Kricketot() : base(
			401,
			SpecieKricketot.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}