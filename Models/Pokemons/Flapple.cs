using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Flapple Specie to store common natural stats of every {'abilities': ['ripen', 'gluttony', 'hustle'], 'base_experience': 170, 'height': 3, 'id': 841, 'moves': [], 'name': 'flapple', 'stats': {'hp': 70, 'attack': 110, 'defense': 80, 'special-attack': 95, 'special-defense': 60, 'speed': 70}, 'types': ['grass', 'dragon'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'アップリュー', 'ko': '애프룡', 'zh-Hant': '蘋裹龍', 'fr': 'Pomdrapi', 'de': 'Drapfel', 'es': 'Flapple', 'it': 'Flapple', 'en': 'Flapple', 'ja': 'アップリュー', 'zh-Hans': '苹裹龙'}, 'genera': {'ja-Hrkt': 'りんごはねポケモン', 'ko': '사과날개포켓몬', 'zh-Hant': '蘋果翅寶可夢', 'fr': 'Pokémon Ailes Pomme', 'de': 'Apfelflügel', 'es': 'Pokémon Manzanala', 'it': 'Pokémon Pomivolo', 'en': 'Apple Wing Pokémon', 'ja': 'りんごはねポケモン', 'zh-Hans': '苹果翅宝可梦'}}
	public class SpecieFlapple : PokemonSpecie
	{
#nullable enable
		private static SpecieFlapple? _instance = null;
#nullable restore
        public static SpecieFlapple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFlapple();
                }
                return _instance;
            }
        }

		public SpecieFlapple() : base(
			"Flapple",
			70, // HPs
			110, 80, // Attack & Defense
			95, 60, // Special Attack & Defense
			70			
		) {}
	}


	//Flapple Pokemon Class
	public class Flapple : Pokemon
	{

		public Flapple(string nickname, int level)
		: base(
				841,
				SpecieFlapple.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flapple(int level)
		: base(
				841,
				SpecieFlapple.Instance, // Pokemon Specie
				"Flapple", level,
				Grass.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Flapple() : base(
			841,
			SpecieFlapple.Instance, // Pokemon Specie
			Grass.Instance, Dragon.Instance			
		) {}
	}
}