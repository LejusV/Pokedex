using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Silicobra Specie to store common natural stats of every {'abilities': ['sand-spit', 'shed-skin', 'sand-veil'], 'base_experience': 63, 'height': 22, 'id': 843, 'moves': [], 'name': 'silicobra', 'stats': {'hp': 52, 'attack': 57, 'defense': 75, 'special-attack': 35, 'special-defense': 50, 'speed': 46}, 'types': ['ground'], 'weight': 76, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'スナヘビ', 'ko': '모래뱀', 'zh-Hant': '沙包蛇', 'fr': 'Dunaja', 'de': 'Salanga', 'es': 'Silicobra', 'it': 'Silicobra', 'en': 'Silicobra', 'ja': 'スナヘビ', 'zh-Hans': '沙包蛇'}, 'genera': {'ja-Hrkt': 'すなへびポケモン', 'ko': '모래뱀포켓몬', 'zh-Hant': '沙蛇寶可夢', 'fr': 'Pokémon Serpensable', 'de': 'Sandschlange', 'es': 'Pokémon Serp. Arena', 'it': 'Pokémon Sabbiaserpe', 'en': 'Sand Snake Pokémon', 'ja': 'すなへびポケモン', 'zh-Hans': '沙蛇宝可梦'}}
	public class SpecieSilicobra : PokemonSpecie
	{
#nullable enable
		private static SpecieSilicobra? _instance = null;
#nullable restore
        public static SpecieSilicobra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSilicobra();
                }
                return _instance;
            }
        }

		public SpecieSilicobra() : base(
			"Silicobra",
			52, // HPs
			57, 75, // Attack & Defense
			35, 50, // Special Attack & Defense
			46			
		) {}
	}


	//Silicobra Pokemon Class
	public class Silicobra : Pokemon
	{

		public Silicobra(string nickname, int level)
		: base(
				843,
				SpecieSilicobra.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Silicobra(int level)
		: base(
				843,
				SpecieSilicobra.Instance, // Pokemon Specie
				"Silicobra", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Silicobra() : base(
			843,
			SpecieSilicobra.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}