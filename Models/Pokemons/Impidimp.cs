using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Impidimp Specie to store common natural stats of every {'abilities': ['prankster', 'frisk', 'pickpocket'], 'base_experience': 53, 'height': 4, 'id': 859, 'moves': [], 'name': 'impidimp', 'stats': {'hp': 45, 'attack': 45, 'defense': 30, 'special-attack': 55, 'special-defense': 40, 'speed': 50}, 'types': ['dark', 'fairy'], 'weight': 55, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 255, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ベロバー', 'ko': '메롱꿍', 'zh-Hant': '搗蛋小妖', 'fr': 'Grimalin', 'de': 'Bähmon', 'es': 'Impidimp', 'it': 'Impidimp', 'en': 'Impidimp', 'ja': 'ベロバー', 'zh-Hans': '捣蛋小妖'}, 'genera': {'ja-Hrkt': 'いじわるポケモン', 'ko': '꾀부리기포켓몬', 'zh-Hant': '捉弄寶可夢', 'fr': 'Pokémon Malin', 'de': 'Hinterlist', 'es': 'Pokémon Astuto', 'it': 'Pokémon Scaltro', 'en': 'Wily Pokémon', 'ja': 'いじわるポケモン', 'zh-Hans': '捉弄宝可梦'}}
	public class SpecieImpidimp : PokemonSpecie
	{
#nullable enable
		private static SpecieImpidimp? _instance = null;
#nullable restore
        public static SpecieImpidimp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieImpidimp();
                }
                return _instance;
            }
        }

		public SpecieImpidimp() : base(
			"Impidimp",
			45, // HPs
			45, 30, // Attack & Defense
			55, 40, // Special Attack & Defense
			50			
		) {}
	}


	//Impidimp Pokemon Class
	public class Impidimp : Pokemon
	{

		public Impidimp(string nickname, int level) : base(
			859,
			SpecieImpidimp.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Fairy.Instance			
		) {}

		public Impidimp() : base(
			859,
			SpecieImpidimp.Instance, // Pokemon Specie
			Dark.Instance, Fairy.Instance			
		) {}
	}
}