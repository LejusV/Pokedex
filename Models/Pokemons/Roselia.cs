using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Roselia Specie to store common natural stats of every {'abilities': ['natural-cure', 'poison-point', 'leaf-guard'], 'base_experience': 140, 'height': 3, 'id': 315, 'moves': ['swords-dance', 'cut', 'body-slam', 'double-edge', 'poison-sting', 'pin-missile', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'stun-spore', 'sleep-powder', 'petal-dance', 'toxic', 'mimic', 'double-team', 'swift', 'flash', 'rest', 'substitute', 'mind-reader', 'nightmare', 'snore', 'cotton-spore', 'protect', 'sludge-bomb', 'mud-slap', 'spikes', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'nature-power', 'ingrain', 'secret-power', 'aromatherapy', 'grass-whistle', 'bullet-seed', 'covet', 'magical-leaf', 'natural-gift', 'worry-seed', 'toxic-spikes', 'poison-jab', 'seed-bomb', 'energy-ball', 'leaf-storm', 'power-whip', 'captivate', 'grass-knot', 'venoshock', 'round', 'petal-blizzard', 'confide', 'dazzling-gleam'], 'name': 'roselia', 'stats': {'hp': 50, 'attack': 60, 'defense': 45, 'special-attack': 100, 'special-defense': 80, 'speed': 65}, 'types': ['grass', 'poison'], 'weight': 20, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 150, 'color': 'green', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['fairy', 'plant'], 'names': {'ja-Hrkt': 'ロゼリア', 'roomaji': 'Roselia', 'ko': '로젤리아', 'zh-Hant': '毒薔薇', 'fr': 'Rosélia', 'de': 'Roselia', 'es': 'Roselia', 'it': 'Roselia', 'en': 'Roselia', 'ja': 'ロゼリア', 'zh-Hans': '毒蔷薇'}, 'genera': {'ja-Hrkt': 'いばらポケモン', 'ko': '가시포켓몬', 'zh-Hant': '荊棘寶可夢', 'fr': 'Pokémon Épine', 'de': 'Dorn', 'es': 'Pokémon Espina', 'it': 'Pokémon Spina', 'en': 'Thorn Pokémon', 'ja': 'いばらポケモン', 'zh-Hans': '荆棘宝可梦'}}
	public class SpecieRoselia : PokemonSpecie
	{
#nullable enable
		private static SpecieRoselia? _instance = null;
#nullable restore
        public static SpecieRoselia Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRoselia();
                }
                return _instance;
            }
        }

		public SpecieRoselia() : base(
			"Roselia",
			50, // HPs
			60, 45, // Attack & Defense
			100, 80, // Special Attack & Defense
			65			
		) {}
	}


	//Roselia Pokemon Class
	public class Roselia : Pokemon
	{

		public Roselia(string nickname, int level)
		: base(
				315,
				SpecieRoselia.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Roselia() : base(
			315,
			SpecieRoselia.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}