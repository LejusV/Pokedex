using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lurantis Specie to store common natural stats of every {'abilities': ['leaf-guard', 'contrary'], 'base_experience': 168, 'height': 9, 'id': 754, 'moves': ['swords-dance', 'hyper-beam', 'growth', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'leech-life', 'rest', 'slash', 'substitute', 'protect', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'ingrain', 'brick-break', 'aerial-ace', 'leaf-blade', 'payback', 'fling', 'poison-jab', 'night-slash', 'x-scissor', 'energy-ball', 'giga-impact', 'grass-knot', 'low-sweep', 'round', 'petal-blizzard', 'confide', 'solar-blade', 'leafage'], 'name': 'lurantis', 'stats': {'hp': 70, 'attack': 105, 'defense': 90, 'special-attack': 80, 'special-defense': 90, 'speed': 45}, 'types': ['grass'], 'weight': 185, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ラランテス', 'ko': '라란티스', 'zh-Hant': '蘭螳花', 'fr': 'Floramantis', 'de': 'Mantidea', 'es': 'Lurantis', 'it': 'Lurantis', 'en': 'Lurantis', 'ja': 'ラランテス', 'zh-Hans': '兰螳花'}, 'genera': {'ja-Hrkt': 'はなかまポケモン', 'ko': '꽃사마귀포켓몬', 'zh-Hant': '花鐮寶可夢', 'fr': 'Pokémon Fauch’Fleur', 'de': 'Blumensichel', 'es': 'Pokémon Filo Flor', 'it': 'Pokémon Mantifiore', 'en': 'Bloom Sickle Pokémon', 'ja': 'はなかまポケモン', 'zh-Hans': '花镰宝可梦'}}
	public class SpecieLurantis : PokemonSpecie
	{
#nullable enable
		private static SpecieLurantis? _instance = null;
#nullable restore
        public static SpecieLurantis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLurantis();
                }
                return _instance;
            }
        }

		public SpecieLurantis() : base(
			"Lurantis",
			70, // HPs
			105, 90, // Attack & Defense
			80, 90, // Special Attack & Defense
			45			
		) {}
	}


	//Lurantis Pokemon Class
	public class Lurantis : Pokemon
	{

		public Lurantis(string nickname, int level) : base(
			754,
			SpecieLurantis.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Lurantis() : base(
			754,
			SpecieLurantis.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}