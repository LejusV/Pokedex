using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bellossom Specie to store common natural stats of every {'abilities': ['chlorophyll', 'healer'], 'base_experience': 221, 'height': 4, 'id': 182, 'moves': ['swords-dance', 'cut', 'double-edge', 'hyper-beam', 'absorb', 'mega-drain', 'solar-beam', 'stun-spore', 'petal-dance', 'toxic', 'mimic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'uproar', 'facade', 'nature-power', 'secret-power', 'bullet-seed', 'magical-leaf', 'leaf-blade', 'natural-gift', 'fling', 'gastro-acid', 'worry-seed', 'seed-bomb', 'drain-punch', 'energy-ball', 'giga-impact', 'leaf-storm', 'captivate', 'grass-knot', 'venoshock', 'quiver-dance', 'after-you', 'round', 'petal-blizzard', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'bellossom', 'stats': {'hp': 75, 'attack': 80, 'defense': 95, 'special-attack': 90, 'special-defense': 100, 'speed': 50}, 'types': ['grass'], 'weight': 58, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'キレイハナ', 'roomaji': 'Kireihana', 'ko': '아르코', 'zh-Hant': '美麗花', 'fr': 'Joliflor', 'de': 'Blubella', 'es': 'Bellossom', 'it': 'Bellossom', 'en': 'Bellossom', 'ja': 'キレイハナ', 'zh-Hans': '美丽花'}, 'genera': {'ja-Hrkt': 'フラワーポケモン', 'ko': '꽃포켓몬', 'zh-Hant': '花寶可夢', 'fr': 'Pokémon Fleur', 'de': 'Blume', 'es': 'Pokémon Flor', 'it': 'Pokémon Fiore', 'en': 'Flower Pokémon', 'ja': 'フラワーポケモン', 'zh-Hans': '花宝可梦'}}
	public class SpecieBellossom : PokemonSpecie
	{
#nullable enable
		private static SpecieBellossom? _instance = null;
#nullable restore
        public static SpecieBellossom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBellossom();
                }
                return _instance;
            }
        }

		public SpecieBellossom() : base(
			"Bellossom",
			75, // HPs
			80, 95, // Attack & Defense
			90, 100, // Special Attack & Defense
			50			
		) {}
	}


	//Bellossom Pokemon Class
	public class Bellossom : Pokemon
	{

		public Bellossom(string nickname, int level)
		: base(
				182,
				SpecieBellossom.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bellossom() : base(
			182,
			SpecieBellossom.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}