using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carkol Specie to store common natural stats of every {'abilities': ['steam-engine', 'flame-body', 'flash-fire'], 'base_experience': 144, 'height': 11, 'id': 838, 'moves': [], 'name': 'carkol', 'stats': {'hp': 80, 'attack': 60, 'defense': 90, 'special-attack': 60, 'special-defense': 70, 'speed': 50}, 'types': ['rock', 'fire'], 'weight': 780, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'black', 'shape': 'legs', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'トロッゴン', 'ko': '탄차곤', 'zh-Hant': '大炭車', 'fr': 'Wagomine', 'de': 'Wagong', 'es': 'Carkol', 'it': 'Carkol', 'en': 'Carkol', 'ja': 'トロッゴン', 'zh-Hans': '大炭车'}, 'genera': {'ja-Hrkt': 'せきたんポケモン', 'ko': '석탄포켓몬', 'zh-Hant': '煤炭寶可夢', 'fr': 'Pokémon Charbon', 'de': 'Kohle', 'es': 'Pokémon Carbón', 'it': 'Pokémon Carbone', 'en': 'Coal Pokémon', 'ja': 'せきたんポケモン', 'zh-Hans': '煤炭宝可梦'}}
	public class SpecieCarkol : PokemonSpecie
	{
#nullable enable
		private static SpecieCarkol? _instance = null;
#nullable restore
        public static SpecieCarkol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarkol();
                }
                return _instance;
            }
        }

		public SpecieCarkol() : base(
			"Carkol",
			80, // HPs
			60, 90, // Attack & Defense
			60, 70, // Special Attack & Defense
			50			
		) {}
	}


	//Carkol Pokemon Class
	public class Carkol : Pokemon
	{

		public Carkol(string nickname, int level) : base(
			838,
			SpecieCarkol.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Fire.Instance			
		) {}

		public Carkol() : base(
			838,
			SpecieCarkol.Instance, // Pokemon Specie
			Rock.Instance, Fire.Instance			
		) {}
	}
}