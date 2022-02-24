using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rillaboom Specie to store common natural stats of every {'abilities': ['overgrow', 'grassy-surge'], 'base_experience': 265, 'height': 21, 'id': 812, 'moves': [], 'name': 'rillaboom', 'stats': {'hp': 100, 'attack': 125, 'defense': 90, 'special-attack': 60, 'special-defense': 70, 'speed': 85}, 'types': ['grass'], 'weight': 900, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ゴリランダー', 'ko': '고릴타', 'zh-Hant': '轟擂金剛猩', 'fr': 'Gorythmic', 'de': 'Gortrom', 'es': 'Rillaboom', 'it': 'Rillaboom', 'en': 'Rillaboom', 'ja': 'ゴリランダー', 'zh-Hans': '轰擂金刚猩'}, 'genera': {'ja-Hrkt': 'ドラマーポケモン', 'ko': '드러머포켓몬', 'zh-Hant': '鼓手寶可夢', 'fr': 'Pokémon Batteur', 'de': 'Drummer', 'es': 'Pokémon Percusión', 'it': 'Pokémon Percussione', 'en': 'Drummer Pokémon', 'ja': 'ドラマーポケモン', 'zh-Hans': '鼓手宝可梦'}}
	public class SpecieRillaboom : PokemonSpecie
	{
#nullable enable
		private static SpecieRillaboom? _instance = null;
#nullable restore
        public static SpecieRillaboom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRillaboom();
                }
                return _instance;
            }
        }

		public SpecieRillaboom() : base(
			"Rillaboom",
			100, // HPs
			125, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			85			
		) {}
	}


	//Rillaboom Pokemon Class
	public class Rillaboom : Pokemon
	{

		public Rillaboom(string nickname, int level)
		: base(
				812,
				SpecieRillaboom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rillaboom(int level)
		: base(
				812,
				SpecieRillaboom.Instance, // Pokemon Specie
				"Rillaboom", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rillaboom() : base(
			812,
			SpecieRillaboom.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}