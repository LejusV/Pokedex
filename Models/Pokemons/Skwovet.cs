using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skwovet Specie to store common natural stats of every {'abilities': ['cheek-pouch', 'gluttony'], 'base_experience': 55, 'height': 3, 'id': 819, 'moves': [], 'name': 'skwovet', 'stats': {'hp': 70, 'attack': 55, 'defense': 55, 'special-attack': 35, 'special-defense': 35, 'speed': 25}, 'types': ['normal'], 'weight': 25, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ホシガリス', 'ko': '탐리스', 'zh-Hant': '貪心栗鼠', 'fr': 'Rongourmand', 'de': 'Raffel', 'es': 'Skwovet', 'it': 'Skwovet', 'en': 'Skwovet', 'ja': 'ホシガリス', 'zh-Hans': '贪心栗鼠'}, 'genera': {'ja-Hrkt': 'ほおばりポケモン', 'ko': '볼가득포켓몬', 'zh-Hant': '貪吃寶可夢', 'fr': 'Pokémon Joufflu', 'de': 'Raffbacke', 'es': 'Pokémon Abazón', 'it': 'Pokémon Guancepiene', 'en': 'Cheeky Pokémon', 'ja': 'ほおばりポケモン', 'zh-Hans': '贪吃宝可梦'}}
	public class SpecieSkwovet : PokemonSpecie
	{
#nullable enable
		private static SpecieSkwovet? _instance = null;
#nullable restore
        public static SpecieSkwovet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkwovet();
                }
                return _instance;
            }
        }

		public SpecieSkwovet() : base(
			"Skwovet",
			70, // HPs
			55, 55, // Attack & Defense
			35, 35, // Special Attack & Defense
			25			
		) {}
	}


	//Skwovet Pokemon Class
	public class Skwovet : Pokemon
	{

		public Skwovet(string nickname, int level) : base(
			819,
			SpecieSkwovet.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Skwovet() : base(
			819,
			SpecieSkwovet.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}