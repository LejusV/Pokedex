using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Arctovish Specie to store common natural stats of every {'abilities': ['water-absorb', 'ice-body', 'slush-rush'], 'base_experience': 177, 'height': 20, 'id': 883, 'moves': [], 'name': 'arctovish', 'stats': {'hp': 90, 'attack': 90, 'defense': 100, 'special-attack': 80, 'special-defense': 90, 'speed': 55}, 'types': ['water', 'ice'], 'weight': 1750, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': -1, 'capture_rate': 45, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ウオチルドン', 'ko': '어치르돈', 'zh-Hant': '鰓魚海獸', 'fr': 'Hydragla', 'de': 'Pescryodon', 'es': 'Arctovish', 'it': 'Arctovish', 'en': 'Arctovish', 'ja': 'ウオチルドン', 'zh-Hans': '鳃鱼海兽'}, 'genera': {'ja-Hrkt': 'かせきポケモン', 'ko': '화석포켓몬', 'zh-Hant': '化石寶可夢', 'fr': 'Pokémon Fossile', 'de': 'Fossil', 'es': 'Pokémon Fósil', 'it': 'Pokémon Fossile', 'en': 'Fossil Pokémon', 'ja': 'かせきポケモン', 'zh-Hans': '化石宝可梦'}}
	public class SpecieArctovish : PokemonSpecie
	{
#nullable enable
		private static SpecieArctovish? _instance = null;
#nullable restore
        public static SpecieArctovish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieArctovish();
                }
                return _instance;
            }
        }

		public SpecieArctovish() : base(
			"Arctovish",
			90, // HPs
			90, 100, // Attack & Defense
			80, 90, // Special Attack & Defense
			55			
		) {}
	}


	//Arctovish Pokemon Class
	public class Arctovish : Pokemon
	{

		public Arctovish(string nickname, int level)
		: base(
				883,
				SpecieArctovish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Arctovish() : base(
			883,
			SpecieArctovish.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
	}
}