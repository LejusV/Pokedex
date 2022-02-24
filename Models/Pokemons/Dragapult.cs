using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dragapult Specie to store common natural stats of every {'abilities': ['clear-body', 'infiltrator', 'cursed-body'], 'base_experience': 300, 'height': 30, 'id': 887, 'moves': [], 'name': 'dragapult', 'stats': {'hp': 88, 'attack': 120, 'defense': 75, 'special-attack': 100, 'special-defense': 75, 'speed': 142}, 'types': ['dragon', 'ghost'], 'weight': 500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ドラパルト', 'ko': '드래펄트', 'zh-Hant': '多龍巴魯托', 'fr': 'Lanssorien', 'de': 'Katapuldra', 'es': 'Dragapult', 'it': 'Dragapult', 'en': 'Dragapult', 'ja': 'ドラパルト', 'zh-Hans': '多龙巴鲁托'}, 'genera': {'ja-Hrkt': 'ステルスポケモン', 'ko': '스텔스포켓몬', 'zh-Hant': '隱形寶可夢', 'fr': 'Pokémon Furtif', 'de': 'Tarnkünstler', 'es': 'Pokémon Furtivo', 'it': 'Pokémon Furtivo', 'en': 'Stealth Pokémon', 'ja': 'ステルスポケモン', 'zh-Hans': '隐形宝可梦'}}
	public class SpecieDragapult : PokemonSpecie
	{
#nullable enable
		private static SpecieDragapult? _instance = null;
#nullable restore
        public static SpecieDragapult Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragapult();
                }
                return _instance;
            }
        }

		public SpecieDragapult() : base(
			"Dragapult",
			88, // HPs
			120, 75, // Attack & Defense
			100, 75, // Special Attack & Defense
			142			
		) {}
	}


	//Dragapult Pokemon Class
	public class Dragapult : Pokemon
	{

		public Dragapult(string nickname, int level)
		: base(
				887,
				SpecieDragapult.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dragapult() : base(
			887,
			SpecieDragapult.Instance, // Pokemon Specie
			Dragon.Instance, Ghost.Instance			
		) {}
	}
}