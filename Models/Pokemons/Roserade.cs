using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Roserade Specie to store common natural stats of every {'abilities': ['natural-cure', 'poison-point', 'technician'], 'base_experience': 232, 'height': 9, 'id': 407, 'moves': ['swords-dance', 'cut', 'poison-sting', 'hyper-beam', 'mega-drain', 'solar-beam', 'toxic', 'double-team', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'nature-power', 'secret-power', 'weather-ball', 'bullet-seed', 'covet', 'magical-leaf', 'natural-gift', 'worry-seed', 'poison-jab', 'seed-bomb', 'energy-ball', 'giga-impact', 'captivate', 'grass-knot', 'venoshock', 'round', 'grassy-terrain', 'confide', 'venom-drench', 'dazzling-gleam'], 'name': 'roserade', 'stats': {'hp': 60, 'attack': 70, 'defense': 65, 'special-attack': 125, 'special-defense': 105, 'speed': 90}, 'types': ['grass', 'poison'], 'weight': 145, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'ロズレイド', 'roomaji': 'Roserade', 'ko': '로즈레이드', 'zh-Hant': '羅絲雷朵', 'fr': 'Roserade', 'de': 'Roserade', 'es': 'Roserade', 'it': 'Roserade', 'en': 'Roserade', 'ja': 'ロズレイド', 'zh-Hans': '罗丝雷朵'}, 'genera': {'ja-Hrkt': 'ブーケポケモン', 'ko': '부케포켓몬', 'zh-Hant': '花束寶可夢', 'fr': 'Pokémon Bouquet', 'de': 'Blumenstrauß', 'es': 'Pokémon Ramillete', 'it': 'Pokémon Floreale', 'en': 'Bouquet Pokémon', 'ja': 'ブーケポケモン', 'zh-Hans': '花束宝可梦'}}
	public class SpecieRoserade : PokemonSpecie
	{
#nullable enable
		private static SpecieRoserade? _instance = null;
#nullable restore
        public static SpecieRoserade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRoserade();
                }
                return _instance;
            }
        }

		public SpecieRoserade() : base(
			"Roserade",
			60, // HPs
			70, 65, // Attack & Defense
			125, 105, // Special Attack & Defense
			90			
		) {}
	}


	//Roserade Pokemon Class
	public class Roserade : Pokemon
	{

		public Roserade(string nickname, int level)
		: base(
				407,
				SpecieRoserade.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Roserade() : base(
			407,
			SpecieRoserade.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}