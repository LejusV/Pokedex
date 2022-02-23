using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Whimsicott Specie to store common natural stats of every {'abilities': ['prankster', 'infiltrator', 'chlorophyll'], 'base_experience': 168, 'height': 7, 'id': 547, 'moves': ['gust', 'hyper-beam', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'toxic', 'psychic', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'cotton-spore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'sunny-day', 'shadow-ball', 'facade', 'nature-power', 'taunt', 'helping-hand', 'knock-off', 'endeavor', 'secret-power', 'covet', 'tailwind', 'u-turn', 'fling', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'trick-room', 'grass-knot', 'round', 'hurricane', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'whimsicott', 'stats': {'hp': 60, 'attack': 67, 'defense': 85, 'special-attack': 77, 'special-defense': 75, 'speed': 116}, 'types': ['grass', 'fairy'], 'weight': 66, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'エルフーン', 'ko': '엘풍', 'zh-Hant': '風妖精', 'fr': 'Farfaduvet', 'de': 'Elfun', 'es': 'Whimsicott', 'it': 'Whimsicott', 'en': 'Whimsicott', 'ja': 'エルフーン', 'zh-Hans': '风妖精'}, 'genera': {'ja-Hrkt': 'かぜかくれポケモン', 'ko': '바람숨기포켓몬', 'zh-Hant': '風隱寶可夢', 'fr': 'Pokémon Vole Vent', 'de': 'Windschatten', 'es': 'Pokémon Vuelalviento', 'it': 'Pokémon Spiffero', 'en': 'Windveiled Pokémon', 'ja': 'かぜかくれポケモン', 'zh-Hans': '风隐宝可梦'}}
	public class SpecieWhimsicott : PokemonSpecie
	{
#nullable enable
		private static SpecieWhimsicott? _instance = null;
#nullable restore
        public static SpecieWhimsicott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhimsicott();
                }
                return _instance;
            }
        }

		public SpecieWhimsicott() : base(
			"Whimsicott",
			60, // HPs
			67, 85, // Attack & Defense
			77, 75, // Special Attack & Defense
			116			
		) {}
	}


	//Whimsicott Pokemon Class
	public class Whimsicott : Pokemon
	{

		public Whimsicott(string nickname, int level) : base(
			547,
			SpecieWhimsicott.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Fairy.Instance			
		) {}

		public Whimsicott() : base(
			547,
			SpecieWhimsicott.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
	}
}