using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Coalossal Specie to store common natural stats of every {'abilities': ['steam-engine', 'flame-body', 'flash-fire'], 'base_experience': 255, 'height': 28, 'id': 839, 'moves': [], 'name': 'coalossal', 'stats': {'hp': 110, 'attack': 80, 'defense': 120, 'special-attack': 80, 'special-defense': 90, 'speed': 30}, 'types': ['rock', 'fire'], 'weight': 3105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'セキタンザン', 'ko': '석탄산', 'zh-Hant': '巨炭山', 'fr': 'Monthracite', 'de': 'Montecarbo', 'es': 'Coalossal', 'it': 'Coalossal', 'en': 'Coalossal', 'ja': 'セキタンザン', 'zh-Hans': '巨炭山'}, 'genera': {'ja-Hrkt': 'せきたんポケモン', 'ko': '석탄포켓몬', 'zh-Hant': '煤炭寶可夢', 'fr': 'Pokémon Charbon', 'de': 'Kohle', 'es': 'Pokémon Carbón', 'it': 'Pokémon Carbone', 'en': 'Coal Pokémon', 'ja': 'せきたんポケモン', 'zh-Hans': '煤炭宝可梦'}}
	public class SpecieCoalossal : PokemonSpecie
	{
#nullable enable
		private static SpecieCoalossal? _instance = null;
#nullable restore
        public static SpecieCoalossal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCoalossal();
                }
                return _instance;
            }
        }

		public SpecieCoalossal() : base(
			"Coalossal",
			110, // HPs
			80, 120, // Attack & Defense
			80, 90, // Special Attack & Defense
			30			
		) {}
	}


	//Coalossal Pokemon Class
	public class Coalossal : Pokemon
	{

		public Coalossal(string nickname, int level) : base(
			839,
			SpecieCoalossal.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Fire.Instance			
		) {}

		public Coalossal() : base(
			839,
			SpecieCoalossal.Instance, // Pokemon Specie
			Rock.Instance, Fire.Instance			
		) {}
	}
}