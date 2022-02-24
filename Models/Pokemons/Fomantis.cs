using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Fomantis Specie to store common natural stats of every {'abilities': ['leaf-guard', 'contrary'], 'base_experience': 50, 'height': 3, 'id': 753, 'moves': ['swords-dance', 'growth', 'razor-leaf', 'solar-beam', 'toxic', 'double-team', 'leech-life', 'rest', 'slash', 'substitute', 'protect', 'giga-drain', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'ingrain', 'weather-ball', 'aromatherapy', 'leaf-blade', 'payback', 'fling', 'poison-jab', 'x-scissor', 'energy-ball', 'defog', 'leaf-storm', 'grass-knot', 'round', 'confide', 'leafage'], 'name': 'fomantis', 'stats': {'hp': 40, 'attack': 55, 'defense': 35, 'special-attack': 50, 'special-defense': 35, 'speed': 35}, 'types': ['grass'], 'weight': 15, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'pink', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'カリキリ', 'ko': '짜랑랑', 'zh-Hant': '偽螳草', 'fr': 'Mimantis', 'de': 'Imantis', 'es': 'Fomantis', 'it': 'Fomantis', 'en': 'Fomantis', 'ja': 'カリキリ', 'zh-Hans': '伪螳草'}, 'genera': {'ja-Hrkt': 'かまくさポケモン', 'ko': '풀사마귀포켓몬', 'zh-Hant': '鐮草寶可夢', 'fr': 'Pokémon Fauch’Herbe', 'de': 'Grassichel', 'es': 'Pokémon Filo Hoja', 'it': 'Pokémon Mantiderba', 'en': 'Sickle Grass Pokémon', 'ja': 'かまくさポケモン', 'zh-Hans': '镰草宝可梦'}}
	public class SpecieFomantis : PokemonSpecie
	{
#nullable enable
		private static SpecieFomantis? _instance = null;
#nullable restore
        public static SpecieFomantis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFomantis();
                }
                return _instance;
            }
        }

		public SpecieFomantis() : base(
			"Fomantis",
			40, // HPs
			55, 35, // Attack & Defense
			50, 35, // Special Attack & Defense
			35			
		) {}
	}


	//Fomantis Pokemon Class
	public class Fomantis : Pokemon
	{

		public Fomantis(string nickname, int level)
		: base(
				753,
				SpecieFomantis.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Fomantis(int level)
		: base(
				753,
				SpecieFomantis.Instance, // Pokemon Specie
				"Fomantis", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Fomantis() : base(
			753,
			SpecieFomantis.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}