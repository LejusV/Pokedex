using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Applin Specie to store common natural stats of every {'abilities': ['ripen', 'gluttony', 'bulletproof'], 'base_experience': 52, 'height': 2, 'id': 840, 'moves': [], 'name': 'applin', 'stats': {'hp': 40, 'attack': 40, 'defense': 80, 'special-attack': 40, 'special-defense': 40, 'speed': 20}, 'types': ['grass', 'dragon'], 'weight': 5, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'カジッチュ', 'ko': '과사삭벌레', 'zh-Hant': '啃果蟲', 'fr': 'Verpom', 'de': 'Knapfel', 'es': 'Applin', 'it': 'Applin', 'en': 'Applin', 'ja': 'カジッチュ', 'zh-Hans': '啃果虫'}, 'genera': {'ja-Hrkt': 'りんごぐらしポケモン', 'ko': '사과살이포켓몬', 'zh-Hant': '蘋果居寶可夢', 'fr': 'Pokémon Nid Pomme', 'de': 'Apfelhaus', 'es': 'Pokémon Manzanido', 'it': 'Pokémon Pomicolo', 'en': 'Apple Core Pokémon', 'ja': 'りんごぐらしポケモン', 'zh-Hans': '苹果居宝可梦'}}
	public class SpecieApplin : PokemonSpecie
	{
#nullable enable
		private static SpecieApplin? _instance = null;
#nullable restore
        public static SpecieApplin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieApplin();
                }
                return _instance;
            }
        }

		public SpecieApplin() : base(
			"Applin",
			40, // HPs
			40, 80, // Attack & Defense
			40, 40, // Special Attack & Defense
			20			
		) {}
	}


	//Applin Pokemon Class
	public class Applin : Pokemon
	{

		public Applin(string nickname, int level)
		: base(
				840,
				SpecieApplin.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Applin(int level)
		: base(
				840,
				SpecieApplin.Instance, // Pokemon Specie
				"Applin", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Applin() : base(
			840,
			SpecieApplin.Instance, // Pokemon Specie
			Grass.Instance, Dragon.Instance			
		) {}
	}
}