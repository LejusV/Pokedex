using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shiinotic Specie to store common natural stats of every {'abilities': ['illuminate', 'effect-spore', 'rain-dish'], 'base_experience': 142, 'height': 10, 'id': 756, 'moves': ['absorb', 'mega-drain', 'solar-beam', 'sleep-powder', 'thunder-wave', 'toxic', 'double-team', 'confuse-ray', 'light-screen', 'dream-eater', 'spore', 'flash', 'rest', 'substitute', 'protect', 'sludge-bomb', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'moonlight', 'hidden-power', 'sunny-day', 'nature-power', 'ingrain', 'astonish', 'energy-ball', 'giga-impact', 'grass-knot', 'charge-beam', 'round', 'moonblast', 'confide', 'dazzling-gleam', 'strength-sap', 'spotlight'], 'name': 'shiinotic', 'stats': {'hp': 60, 'attack': 45, 'defense': 80, 'special-attack': 90, 'special-defense': 100, 'speed': 30}, 'types': ['grass', 'fairy'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'マシェード', 'ko': '마셰이드', 'zh-Hant': '燈罩夜菇', 'fr': 'Lampignon', 'de': 'Lamellux', 'es': 'Shiinotic', 'it': 'Shiinotic', 'en': 'Shiinotic', 'ja': 'マシェード', 'zh-Hans': '灯罩夜菇'}, 'genera': {'ja-Hrkt': 'はっこうポケモン', 'ko': '발광포켓몬', 'zh-Hant': '發光寶可夢', 'fr': 'Pokémon Luminescent', 'de': 'Lumineszenz', 'es': 'Pokémon Luminiscente', 'it': 'Pokémon Luminescenza', 'en': 'Illuminating Pokémon', 'ja': 'はっこうポケモン', 'zh-Hans': '发光宝可梦'}}
	public class SpecieShiinotic : PokemonSpecie
	{
#nullable enable
		private static SpecieShiinotic? _instance = null;
#nullable restore
        public static SpecieShiinotic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShiinotic();
                }
                return _instance;
            }
        }

		public SpecieShiinotic() : base(
			"Shiinotic",
			60, // HPs
			45, 80, // Attack & Defense
			90, 100, // Special Attack & Defense
			30			
		) {}
	}


	//Shiinotic Pokemon Class
	public class Shiinotic : Pokemon
	{

		public Shiinotic(string nickname, int level)
		: base(
				756,
				SpecieShiinotic.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shiinotic() : base(
			756,
			SpecieShiinotic.Instance, // Pokemon Specie
			Grass.Instance, Fairy.Instance			
		) {}
	}
}