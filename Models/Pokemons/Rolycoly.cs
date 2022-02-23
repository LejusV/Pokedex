using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rolycoly Specie to store common natural stats of every {'abilities': ['steam-engine', 'heatproof', 'flash-fire'], 'base_experience': 48, 'height': 3, 'id': 837, 'moves': [], 'name': 'rolycoly', 'stats': {'hp': 30, 'attack': 40, 'defense': 50, 'special-attack': 40, 'special-defense': 50, 'speed': 30}, 'types': ['rock'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'black', 'shape': 'ball', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'タンドン', 'ko': '탄동', 'zh-Hant': '小炭仔', 'fr': 'Charbi', 'de': 'Klonkett', 'es': 'Rolycoly', 'it': 'Rolycoly', 'en': 'Rolycoly', 'ja': 'タンドン', 'zh-Hans': '小炭仔'}, 'genera': {'ja-Hrkt': 'せきたんポケモン', 'ko': '석탄포켓몬', 'zh-Hant': '煤炭寶可夢', 'fr': 'Pokémon Charbon', 'de': 'Kohle', 'es': 'Pokémon Carbón', 'it': 'Pokémon Carbone', 'en': 'Coal Pokémon', 'ja': 'せきたんポケモン', 'zh-Hans': '煤炭宝可梦'}}
	public class SpecieRolycoly : PokemonSpecie
	{
#nullable enable
		private static SpecieRolycoly? _instance = null;
#nullable restore
        public static SpecieRolycoly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRolycoly();
                }
                return _instance;
            }
        }

		public SpecieRolycoly() : base(
			"Rolycoly",
			30, // HPs
			40, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			30			
		) {}
	}


	//Rolycoly Pokemon Class
	public class Rolycoly : Pokemon
	{

		public Rolycoly(string nickname, int level) : base(
			837,
			SpecieRolycoly.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance			
		) {}

		public Rolycoly() : base(
			837,
			SpecieRolycoly.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}