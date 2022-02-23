using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Arctozolt Specie to store common natural stats of every {'abilities': ['volt-absorb', 'static', 'slush-rush'], 'base_experience': 177, 'height': 23, 'id': 881, 'moves': [], 'name': 'arctozolt', 'stats': {'hp': 90, 'attack': 100, 'defense': 90, 'special-attack': 90, 'special-defense': 80, 'speed': 55}, 'types': ['electric', 'ice'], 'weight': 1500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': -1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'パッチルドン', 'ko': '파치르돈', 'zh-Hant': '雷鳥海獸', 'fr': 'Galvagla', 'de': 'Lecryodon', 'es': 'Arctozolt', 'it': 'Arctozolt', 'en': 'Arctozolt', 'ja': 'パッチルドン', 'zh-Hans': '雷鸟海兽'}, 'genera': {'ja-Hrkt': 'かせきポケモン', 'ko': '화석포켓몬', 'zh-Hant': '化石寶可夢', 'fr': 'Pokémon Fossile', 'de': 'Fossil', 'es': 'Pokémon Fósil', 'it': 'Pokémon Fossile', 'en': 'Fossil Pokémon', 'ja': 'かせきポケモン', 'zh-Hans': '化石宝可梦'}}
	public class SpecieArctozolt : PokemonSpecie
	{
#nullable enable
		private static SpecieArctozolt? _instance = null;
#nullable restore
        public static SpecieArctozolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArctozolt();
                }
                return _instance;
            }
        }

		public SpecieArctozolt() : base(
			"Arctozolt",
			90, // HPs
			100, 90, // Attack & Defense
			90, 80, // Special Attack & Defense
			55			
		) {}
	}


	//Arctozolt Pokemon Class
	public class Arctozolt : Pokemon
	{

		public Arctozolt(string nickname, int level) : base(
			881,
			SpecieArctozolt.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance, Ice.Instance			
		) {}

		public Arctozolt() : base(
			881,
			SpecieArctozolt.Instance, // Pokemon Specie
			Electric.Instance, Ice.Instance			
		) {}
	}
}