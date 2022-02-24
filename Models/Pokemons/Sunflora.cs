using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sunflora Specie to store common natural stats of every {'abilities': ['chlorophyll', 'solar-power', 'early-bird'], 'base_experience': 149, 'height': 8, 'id': 192, 'moves': ['pound', 'swords-dance', 'cut', 'double-edge', 'hyper-beam', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'petal-dance', 'toxic', 'mimic', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'uproar', 'facade', 'nature-power', 'helping-hand', 'ingrain', 'endeavor', 'secret-power', 'grass-whistle', 'bullet-seed', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'earth-power', 'giga-impact', 'leaf-storm', 'captivate', 'grass-knot', 'after-you', 'round', 'petal-blizzard', 'flower-shield', 'confide'], 'name': 'sunflora', 'stats': {'hp': 75, 'attack': 75, 'defense': 55, 'special-attack': 105, 'special-defense': 85, 'speed': 30}, 'types': ['grass'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'キマワリ', 'roomaji': 'Kimawari', 'ko': '해루미', 'zh-Hant': '向日花怪', 'fr': 'Héliatronc', 'de': 'Sonnflora', 'es': 'Sunflora', 'it': 'Sunflora', 'en': 'Sunflora', 'ja': 'キマワリ', 'zh-Hans': '向日花怪'}, 'genera': {'ja-Hrkt': 'たいようポケモン', 'ko': '태양포켓몬', 'zh-Hant': '太陽寶可夢', 'fr': 'Pokémon Soleil', 'de': 'Sonne', 'es': 'Pokémon Sol', 'it': 'Pokémon Sole', 'en': 'Sun Pokémon', 'ja': 'たいようポケモン', 'zh-Hans': '太阳宝可梦'}}
	public class SpecieSunflora : PokemonSpecie
	{
#nullable enable
		private static SpecieSunflora? _instance = null;
#nullable restore
        public static SpecieSunflora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSunflora();
                }
                return _instance;
            }
        }

		public SpecieSunflora() : base(
			"Sunflora",
			75, // HPs
			75, 55, // Attack & Defense
			105, 85, // Special Attack & Defense
			30			
		) {}
	}


	//Sunflora Pokemon Class
	public class Sunflora : Pokemon
	{

		public Sunflora(string nickname, int level)
		: base(
				192,
				SpecieSunflora.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sunflora() : base(
			192,
			SpecieSunflora.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}