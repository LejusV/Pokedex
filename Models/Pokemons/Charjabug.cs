using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Charjabug Specie to store common natural stats of every {'abilities': ['battery'], 'base_experience': 140, 'height': 5, 'id': 737, 'moves': ['vice-grip', 'bite', 'string-shot', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'double-team', 'light-screen', 'rest', 'substitute', 'protect', 'mud-slap', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'facade', 'charge', 'iron-defense', 'poison-jab', 'x-scissor', 'discharge', 'bug-bite', 'charge-beam', 'round', 'acrobatics', 'volt-switch', 'wild-charge', 'confide'], 'name': 'charjabug', 'stats': {'hp': 57, 'attack': 82, 'defense': 95, 'special-attack': 55, 'special-defense': 75, 'speed': 36}, 'types': ['bug', 'electric'], 'weight': 105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'デンヂムシ', 'ko': '전지충이', 'zh-Hant': '蟲電寶', 'fr': 'Chrysapile', 'de': 'Akkup', 'es': 'Charjabug', 'it': 'Charjabug', 'en': 'Charjabug', 'ja': 'デンヂムシ', 'zh-Hans': '虫电宝'}, 'genera': {'ja-Hrkt': 'バッテリーポケモン', 'ko': '배터리포켓몬', 'zh-Hant': '蓄電池寶可夢', 'fr': 'Pokémon Batterie', 'de': 'Batterie', 'es': 'Pokémon Batería', 'it': 'Pokémon Batteria', 'en': 'Battery Pokémon', 'ja': 'バッテリーポケモン', 'zh-Hans': '蓄电池宝可梦'}}
	public class SpecieCharjabug : PokemonSpecie
	{
#nullable enable
		private static SpecieCharjabug? _instance = null;
#nullable restore
        public static SpecieCharjabug Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCharjabug();
                }
                return _instance;
            }
        }

		public SpecieCharjabug() : base(
			"Charjabug",
			57, // HPs
			82, 95, // Attack & Defense
			55, 75, // Special Attack & Defense
			36			
		) {}
	}


	//Charjabug Pokemon Class
	public class Charjabug : Pokemon
	{

		public Charjabug(string nickname, int level)
		: base(
				737,
				SpecieCharjabug.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Charjabug() : base(
			737,
			SpecieCharjabug.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
	}
}