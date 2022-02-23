using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Weedle Specie to store common natural stats of every {'abilities': ['shield-dust', 'run-away'], 'base_experience': 39, 'height': 3, 'id': 13, 'moves': ['poison-sting', 'string-shot', 'bug-bite', 'electroweb'], 'name': 'weedle', 'stats': {'hp': 40, 'attack': 35, 'defense': 30, 'special-attack': 20, 'special-defense': 20, 'speed': 50}, 'types': ['bug', 'poison'], 'weight': 32, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ビードル', 'roomaji': 'Beedle', 'ko': '뿔충이', 'zh-Hant': '獨角蟲', 'fr': 'Aspicot', 'de': 'Hornliu', 'es': 'Weedle', 'it': 'Weedle', 'en': 'Weedle', 'ja': 'ビードル', 'zh-Hans': '独角虫'}, 'genera': {'ja-Hrkt': 'けむしポケモン', 'ko': '송충이포켓몬', 'zh-Hant': '毛毛蟲寶可夢', 'fr': 'Pokémon Insectopic', 'de': 'Raupe', 'es': 'Pokémon Oruga', 'it': 'Pokémon Millepiedi', 'en': 'Hairy Bug Pokémon', 'ja': 'けむしポケモン', 'zh-Hans': '毛毛虫宝可梦'}}
	public class SpecieWeedle : PokemonSpecie
	{
#nullable enable
		private static SpecieWeedle? _instance = null;
#nullable restore
        public static SpecieWeedle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeedle();
                }
                return _instance;
            }
        }

		public SpecieWeedle() : base(
			"Weedle",
			40, // HPs
			35, 30, // Attack & Defense
			20, 20, // Special Attack & Defense
			50			
		) {}
	}


	//Weedle Pokemon Class
	public class Weedle : Pokemon
	{

		public Weedle(string nickname, int level) : base(
			13,
			SpecieWeedle.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Poison.Instance			
		) {}

		public Weedle() : base(
			13,
			SpecieWeedle.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}