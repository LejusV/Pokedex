using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Goomy Specie to store common natural stats of every {'abilities': ['sap-sipper', 'hydration', 'gooey'], 'base_experience': 60, 'height': 3, 'id': 704, 'moves': ['tackle', 'body-slam', 'counter', 'absorb', 'thunderbolt', 'toxic', 'double-team', 'bide', 'bubble', 'acid-armor', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'sludge-bomb', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'secret-power', 'muddy-water', 'poison-tail', 'shock-wave', 'water-pulse', 'dragon-pulse', 'draco-meteor', 'sludge-wave', 'round', 'confide', 'infestation'], 'name': 'goomy', 'stats': {'hp': 45, 'attack': 50, 'defense': 35, 'special-attack': 55, 'special-defense': 75, 'speed': 40}, 'types': ['dragon'], 'weight': 28, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ヌメラ', 'ko': '미끄메라', 'zh-Hant': '黏黏寶', 'fr': 'Mucuscule', 'de': 'Viscora', 'es': 'Goomy', 'it': 'Goomy', 'en': 'Goomy', 'ja': 'ヌメラ', 'zh-Hans': '黏黏宝'}, 'genera': {'ja-Hrkt': 'なんたいポケモン', 'ko': '연체포켓몬', 'zh-Hant': '軟體生物寶可夢', 'fr': 'Pokémon Mollusque', 'de': 'Schneckedei', 'es': 'Pokémon Molusco', 'it': 'Pokémon Mollusco', 'en': 'Soft Tissue Pokémon', 'ja': 'なんたいポケモン', 'zh-Hans': '软体生物宝可梦'}}
	public class SpecieGoomy : PokemonSpecie
	{
#nullable enable
		private static SpecieGoomy? _instance = null;
#nullable restore
        public static SpecieGoomy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGoomy();
                }
                return _instance;
            }
        }

		public SpecieGoomy() : base(
			"Goomy",
			45, // HPs
			50, 35, // Attack & Defense
			55, 75, // Special Attack & Defense
			40			
		) {}
	}


	//Goomy Pokemon Class
	public class Goomy : Pokemon
	{

		public Goomy(string nickname, int level)
		: base(
				704,
				SpecieGoomy.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Goomy(int level)
		: base(
				704,
				SpecieGoomy.Instance, // Pokemon Specie
				"Goomy", level,
				Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Goomy() : base(
			704,
			SpecieGoomy.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}