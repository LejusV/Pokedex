using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Eiscue-Ice Specie to store common natural stats of every {'abilities': ['ice-face'], 'base_experience': 165, 'height': 14, 'id': 875, 'moves': [], 'name': 'eiscue-ice', 'stats': {'hp': 75, 'attack': 80, 'defense': 110, 'special-attack': 65, 'special-defense': 90, 'speed': 50}, 'types': ['ice'], 'weight': 890, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'コオリッポ', 'ko': '빙큐보', 'zh-Hant': '冰砌鵝', 'fr': 'Bekaglaçon', 'de': 'Kubuin', 'es': 'Eiscue', 'it': 'Eiscue', 'en': 'Eiscue', 'ja': 'コオリッポ', 'zh-Hans': '冰砌鹅'}, 'genera': {'ja-Hrkt': 'ペンギンポケモン', 'ko': '펭귄포켓몬', 'zh-Hant': '企鵝寶可夢', 'fr': 'Pokémon Pingouin', 'de': 'Pinguin', 'es': 'Pokémon Pingüino', 'it': 'Pokémon Pinguino', 'en': 'Penguin Pokémon', 'ja': 'ペンギンポケモン', 'zh-Hans': '企鹅宝可梦'}}
	public class SpecieEiscueIce : PokemonSpecie
	{
#nullable enable
		private static SpecieEiscueIce? _instance = null;
#nullable restore
        public static SpecieEiscueIce Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEiscueIce();
                }
                return _instance;
            }
        }

		public SpecieEiscueIce() : base(
			"Eiscue-Ice",
			75, // HPs
			80, 110, // Attack & Defense
			65, 90, // Special Attack & Defense
			50			
		) {}
	}


	//Eiscue-Ice Pokemon Class
	public class EiscueIce : Pokemon
	{

		public EiscueIce(string nickname, int level) : base(
			875,
			SpecieEiscueIce.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance			
		) {}

		public EiscueIce() : base(
			875,
			SpecieEiscueIce.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}