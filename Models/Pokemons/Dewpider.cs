using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dewpider Specie to store common natural stats of every {'abilities': ['water-bubble', 'water-absorb'], 'base_experience': 54, 'height': 3, 'id': 751, 'moves': ['bite', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'toxic', 'double-team', 'waterfall', 'leech-life', 'bubble', 'rest', 'substitute', 'spider-web', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'mirror-coat', 'stockpile', 'spit-up', 'facade', 'water-sport', 'aqua-ring', 'poison-jab', 'x-scissor', 'bug-bite', 'power-split', 'entrainment', 'round', 'scald', 'frost-breath', 'sticky-web', 'confide', 'infestation', 'lunge', 'liquidation'], 'name': 'dewpider', 'stats': {'hp': 38, 'attack': 40, 'defense': 52, 'special-attack': 40, 'special-defense': 72, 'speed': 27}, 'types': ['water', 'bug'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 200, 'color': 'green', 'shape': 'legs', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'bug'], 'names': {'ja-Hrkt': 'シズクモ', 'ko': '물거미', 'zh-Hant': '滴蛛', 'fr': 'Araqua', 'de': 'Araqua', 'es': 'Dewpider', 'it': 'Dewpider', 'en': 'Dewpider', 'ja': 'シズクモ', 'zh-Hans': '滴蛛'}, 'genera': {'ja-Hrkt': 'すいほうポケモン', 'ko': '수포포켓몬', 'zh-Hant': '水泡寶可夢', 'fr': 'Pokémon Aquabulle', 'de': 'Wasserblase', 'es': 'Pokémon Pompa', 'it': 'Pokémon Bolladacqua', 'en': 'Water Bubble Pokémon', 'ja': 'すいほうポケモン', 'zh-Hans': '水泡宝可梦'}}
	public class SpecieDewpider : PokemonSpecie
	{
#nullable enable
		private static SpecieDewpider? _instance = null;
#nullable restore
        public static SpecieDewpider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDewpider();
                }
                return _instance;
            }
        }

		public SpecieDewpider() : base(
			"Dewpider",
			38, // HPs
			40, 52, // Attack & Defense
			40, 72, // Special Attack & Defense
			27			
		) {}
	}


	//Dewpider Pokemon Class
	public class Dewpider : Pokemon
	{

		public Dewpider(string nickname, int level)
		: base(
				751,
				SpecieDewpider.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dewpider() : base(
			751,
			SpecieDewpider.Instance, // Pokemon Specie
			Water.Instance, Bug.Instance			
		) {}
	}
}