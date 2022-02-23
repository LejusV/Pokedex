using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zarude Specie to store common natural stats of every {'abilities': ['leaf-guard'], 'base_experience': 300, 'height': 18, 'id': 893, 'moves': [], 'name': 'zarude', 'stats': {'hp': 105, 'attack': 120, 'defense': 105, 'special-attack': 70, 'special-defense': 95, 'speed': 105}, 'types': ['dark', 'grass'], 'weight': 700, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ザルード', 'ko': '자루도', 'zh-Hant': '薩戮德', 'fr': 'Zarude', 'de': 'Zarude', 'es': 'Zarude', 'it': 'Zarude', 'en': 'Zarude', 'ja': 'ザルード', 'zh-Hans': '萨戮德'}, 'genera': {'ja-Hrkt': 'わるざるポケモン', 'ko': '나쁜원숭이포켓몬', 'zh-Hant': '惡猿寶可夢', 'fr': 'Pokémon Vilain Singe', 'de': 'Finsteraffen', 'es': 'Pokémon Simiestro', 'it': 'Pokémon Categoria', 'en': 'Rogue Monkey Pokémon', 'ja': 'わるざるポケモン', 'zh-Hans': '恶猿宝可梦'}}
	public class SpecieZarude : PokemonSpecie
	{
#nullable enable
		private static SpecieZarude? _instance = null;
#nullable restore
        public static SpecieZarude Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZarude();
                }
                return _instance;
            }
        }

		public SpecieZarude() : base(
			"Zarude",
			105, // HPs
			120, 105, // Attack & Defense
			70, 95, // Special Attack & Defense
			105			
		) {}
	}


	//Zarude Pokemon Class
	public class Zarude : Pokemon
	{

		public Zarude(string nickname, int level) : base(
			893,
			SpecieZarude.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Grass.Instance			
		) {}

		public Zarude() : base(
			893,
			SpecieZarude.Instance, // Pokemon Specie
			Dark.Instance, Grass.Instance			
		) {}
	}
}