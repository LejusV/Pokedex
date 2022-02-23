using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dracovish Specie to store common natural stats of every {'abilities': ['water-absorb', 'strong-jaw', 'sand-rush'], 'base_experience': 177, 'height': 23, 'id': 882, 'moves': [], 'name': 'dracovish', 'stats': {'hp': 90, 'attack': 90, 'defense': 100, 'special-attack': 70, 'special-defense': 80, 'speed': 75}, 'types': ['water', 'dragon'], 'weight': 2150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': -1, 'capture_rate': 45, 'color': 'green', 'shape': 'legs', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ウオノラゴン', 'ko': '어래곤', 'zh-Hant': '鰓魚龍', 'fr': 'Hydragon', 'de': 'Pescragon', 'es': 'Dracovish', 'it': 'Dracovish', 'en': 'Dracovish', 'ja': 'ウオノラゴン', 'zh-Hans': '鳃鱼龙'}, 'genera': {'ja-Hrkt': 'かせきポケモン', 'ko': '화석포켓몬', 'zh-Hant': '化石寶可夢', 'fr': 'Pokémon Fossile', 'de': 'Fossil', 'es': 'Pokémon Fósil', 'it': 'Pokémon Fossile', 'en': 'Fossil Pokémon', 'ja': 'かせきポケモン', 'zh-Hans': '化石宝可梦'}}
	public class SpecieDracovish : PokemonSpecie
	{
#nullable enable
		private static SpecieDracovish? _instance = null;
#nullable restore
        public static SpecieDracovish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDracovish();
                }
                return _instance;
            }
        }

		public SpecieDracovish() : base(
			"Dracovish",
			90, // HPs
			90, 100, // Attack & Defense
			70, 80, // Special Attack & Defense
			75			
		) {}
	}


	//Dracovish Pokemon Class
	public class Dracovish : Pokemon
	{

		public Dracovish(string nickname, int level) : base(
			882,
			SpecieDracovish.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Dragon.Instance			
		) {}

		public Dracovish() : base(
			882,
			SpecieDracovish.Instance, // Pokemon Specie
			Water.Instance, Dragon.Instance			
		) {}
	}
}