using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eldegoss Specie to store common natural stats of every {'abilities': ['cotton-down', 'regenerator', 'effect-spore'], 'base_experience': 161, 'height': 5, 'id': 830, 'moves': [], 'name': 'eldegoss', 'stats': {'hp': 60, 'attack': 50, 'defense': 90, 'special-attack': 80, 'special-defense': 120, 'speed': 60}, 'types': ['grass'], 'weight': 25, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ワタシラガ', 'ko': '백솜모카', 'zh-Hant': '白蓬蓬', 'fr': 'Blancoton', 'de': 'Cottomi', 'es': 'Eldegoss', 'it': 'Eldegoss', 'en': 'Eldegoss', 'ja': 'ワタシラガ', 'zh-Hans': '白蓬蓬'}, 'genera': {'ja-Hrkt': 'わたかざりポケモン', 'ko': '솜장식포켓몬', 'zh-Hant': '棉飾寶可夢', 'fr': 'Pokémon Chef-Coton', 'de': 'Baumwollzier', 'es': 'Pokémon Adornalgodón', 'it': 'Pokémon Cotofronzolo', 'en': 'Cotton Bloom Pokémon', 'ja': 'わたかざりポケモン', 'zh-Hans': '棉饰宝可梦'}}
	public class SpecieEldegoss : PokemonSpecie
	{
#nullable enable
		private static SpecieEldegoss? _instance = null;
#nullable restore
        public static SpecieEldegoss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEldegoss();
                }
                return _instance;
            }
        }

		public SpecieEldegoss() : base(
			"Eldegoss",
			60, // HPs
			50, 90, // Attack & Defense
			80, 120, // Special Attack & Defense
			60			
		) {}
	}


	//Eldegoss Pokemon Class
	public class Eldegoss : Pokemon
	{

		public Eldegoss(string nickname, int level)
		: base(
				830,
				SpecieEldegoss.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Eldegoss(int level)
		: base(
				830,
				SpecieEldegoss.Instance, // Pokemon Specie
				"Eldegoss", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Eldegoss() : base(
			830,
			SpecieEldegoss.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}