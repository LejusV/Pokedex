using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sandaconda Specie to store common natural stats of every {'abilities': ['sand-spit', 'shed-skin', 'sand-veil'], 'base_experience': 179, 'height': 38, 'id': 844, 'moves': [], 'name': 'sandaconda', 'stats': {'hp': 72, 'attack': 107, 'defense': 125, 'special-attack': 65, 'special-defense': 70, 'speed': 71}, 'types': ['ground'], 'weight': 655, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'サダイジャ', 'ko': '사다이사', 'zh-Hant': '沙螺蟒', 'fr': 'Dunaconda', 'de': 'Sanaconda', 'es': 'Sandaconda', 'it': 'Sandaconda', 'en': 'Sandaconda', 'ja': 'サダイジャ', 'zh-Hans': '沙螺蟒'}, 'genera': {'ja-Hrkt': 'すなへびポケモン', 'ko': '모래뱀포켓몬', 'zh-Hant': '沙蛇寶可夢', 'fr': 'Pokémon Serpensable', 'de': 'Sandschlange', 'es': 'Pokémon Serp. Arena', 'it': 'Pokémon Sabbiaserpe', 'en': 'Sand Snake Pokémon', 'ja': 'すなへびポケモン', 'zh-Hans': '沙蛇宝可梦'}}
	public class SpecieSandaconda : PokemonSpecie
	{
#nullable enable
		private static SpecieSandaconda? _instance = null;
#nullable restore
        public static SpecieSandaconda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSandaconda();
                }
                return _instance;
            }
        }

		public SpecieSandaconda() : base(
			"Sandaconda",
			72, // HPs
			107, 125, // Attack & Defense
			65, 70, // Special Attack & Defense
			71			
		) {}
	}


	//Sandaconda Pokemon Class
	public class Sandaconda : Pokemon
	{

		public Sandaconda(string nickname, int level)
		: base(
				844,
				SpecieSandaconda.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandaconda(int level)
		: base(
				844,
				SpecieSandaconda.Instance, // Pokemon Specie
				"Sandaconda", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sandaconda() : base(
			844,
			SpecieSandaconda.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}