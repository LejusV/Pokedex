using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Araquanid Specie to store common natural stats of every {'abilities': ['water-bubble', 'water-absorb'], 'base_experience': 159, 'height': 18, 'id': 752, 'moves': ['bite', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'toxic', 'double-team', 'reflect', 'waterfall', 'leech-life', 'bubble', 'rest', 'substitute', 'spider-web', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'crunch', 'mirror-coat', 'facade', 'aqua-ring', 'poison-jab', 'x-scissor', 'bug-bite', 'wide-guard', 'soak', 'entrainment', 'round', 'scald', 'frost-breath', 'confide', 'infestation', 'lunge', 'liquidation'], 'name': 'araquanid', 'stats': {'hp': 68, 'attack': 70, 'defense': 92, 'special-attack': 50, 'special-defense': 132, 'speed': 42}, 'types': ['water', 'bug'], 'weight': 820, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 100, 'color': 'green', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'bug'], 'names': {'ja-Hrkt': 'オニシズクモ', 'ko': '깨비물거미', 'zh-Hant': '滴蛛霸', 'fr': 'Tarenbulle', 'de': 'Aranestro', 'es': 'Araquanid', 'it': 'Araquanid', 'en': 'Araquanid', 'ja': 'オニシズクモ', 'zh-Hans': '滴蛛霸'}, 'genera': {'ja-Hrkt': 'すいほうポケモン', 'ko': '수포포켓몬', 'zh-Hant': '水泡寶可夢', 'fr': 'Pokémon Aquabulle', 'de': 'Wasserblase', 'es': 'Pokémon Pompa', 'it': 'Pokémon Bolladacqua', 'en': 'Water Bubble Pokémon', 'ja': 'すいほうポケモン', 'zh-Hans': '水泡宝可梦'}}
	public class SpecieAraquanid : PokemonSpecie
	{
#nullable enable
		private static SpecieAraquanid? _instance = null;
#nullable restore
        public static SpecieAraquanid Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAraquanid();
                }
                return _instance;
            }
        }

		public SpecieAraquanid() : base(
			"Araquanid",
			68, // HPs
			70, 92, // Attack & Defense
			50, 132, // Special Attack & Defense
			42			
		) {}
	}


	//Araquanid Pokemon Class
	public class Araquanid : Pokemon
	{

		public Araquanid(string nickname, int level)
		: base(
				752,
				SpecieAraquanid.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Araquanid(int level)
		: base(
				752,
				SpecieAraquanid.Instance, // Pokemon Specie
				"Araquanid", level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Araquanid() : base(
			752,
			SpecieAraquanid.Instance, // Pokemon Specie
			Water.Instance, Bug.Instance			
		) {}
	}
}