using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Regieleki Specie to store common natural stats of every {'abilities': ['transistor'], 'base_experience': 290, 'height': 12, 'id': 894, 'moves': [], 'name': 'regieleki', 'stats': {'hp': 80, 'attack': 100, 'defense': 50, 'special-attack': 100, 'special-defense': 50, 'speed': 200}, 'types': ['electric'], 'weight': 1450, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'レジエレキ', 'ko': '레지에레키', 'zh-Hant': '雷吉艾勒奇', 'fr': 'Regieleki', 'de': 'Regieleki', 'es': 'Regieleki', 'it': 'Regieleki', 'en': 'Regieleki', 'ja': 'レジエレキ', 'zh-Hans': '雷吉艾勒奇'}, 'genera': {'ja-Hrkt': 'エレクトロンポケモン', 'ko': '일렉트론포켓몬', 'zh-Hant': '電子寶可夢', 'fr': 'Pokémon Électron', 'de': 'Elektron', 'es': 'Pokémon Electrón', 'it': 'Pokémon Elettrone', 'en': 'Electron Pokémon', 'ja': 'エレクトロンポケモン', 'zh-Hans': '电子宝可梦'}}
	public class SpecieRegieleki : PokemonSpecie
	{
#nullable enable
		private static SpecieRegieleki? _instance = null;
#nullable restore
        public static SpecieRegieleki Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegieleki();
                }
                return _instance;
            }
        }

		public SpecieRegieleki() : base(
			"Regieleki",
			80, // HPs
			100, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			200			
		) {}
	}


	//Regieleki Pokemon Class
	public class Regieleki : Pokemon
	{

		public Regieleki(string nickname, int level)
		: base(
				894,
				SpecieRegieleki.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Regieleki() : base(
			894,
			SpecieRegieleki.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}