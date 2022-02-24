using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Appletun Specie to store common natural stats of every {'abilities': ['ripen', 'gluttony', 'thick-fat'], 'base_experience': 170, 'height': 4, 'id': 842, 'moves': [], 'name': 'appletun', 'stats': {'hp': 110, 'attack': 85, 'defense': 80, 'special-attack': 100, 'special-defense': 80, 'speed': 30}, 'types': ['grass', 'dragon'], 'weight': 130, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'タルップル', 'ko': '단지래플', 'zh-Hant': '豐蜜龍', 'fr': 'Dratatin', 'de': 'Schlapfel', 'es': 'Appletun', 'it': 'Appletun', 'en': 'Appletun', 'ja': 'タルップル', 'zh-Hans': '丰蜜龙'}, 'genera': {'ja-Hrkt': 'りんごじるポケモン', 'ko': '사과즙포켓몬', 'zh-Hant': '蘋果汁寶可夢', 'fr': 'Pokémon Jus Pomme', 'de': 'Apfelnektar', 'es': 'Pokémon Manzanéctar', 'it': 'Pokémon Pomisucco', 'en': 'Apple Nectar Pokémon', 'ja': 'りんごじるポケモン', 'zh-Hans': '苹果汁宝可梦'}}
	public class SpecieAppletun : PokemonSpecie
	{
#nullable enable
		private static SpecieAppletun? _instance = null;
#nullable restore
        public static SpecieAppletun Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAppletun();
                }
                return _instance;
            }
        }

		public SpecieAppletun() : base(
			"Appletun",
			110, // HPs
			85, 80, // Attack & Defense
			100, 80, // Special Attack & Defense
			30			
		) {}
	}


	//Appletun Pokemon Class
	public class Appletun : Pokemon
	{

		public Appletun(string nickname, int level)
		: base(
				842,
				SpecieAppletun.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Appletun(int level)
		: base(
				842,
				SpecieAppletun.Instance, // Pokemon Specie
				"Appletun", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Appletun() : base(
			842,
			SpecieAppletun.Instance, // Pokemon Specie
			Grass.Instance, Dragon.Instance			
		) {}
	}
}