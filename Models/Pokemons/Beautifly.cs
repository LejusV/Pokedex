using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Beautifly Specie to store common natural stats of every {'abilities': ['swarm', 'rivalry'], 'base_experience': 178, 'height': 10, 'id': 267, 'moves': ['gust', 'whirlwind', 'double-edge', 'hyper-beam', 'absorb', 'mega-drain', 'solar-beam', 'stun-spore', 'string-shot', 'toxic', 'psychic', 'rage', 'mimic', 'double-team', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'morning-sun', 'hidden-power', 'twister', 'sunny-day', 'shadow-ball', 'facade', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'bug-buzz', 'energy-ball', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'venoshock', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'electroweb', 'confide', 'infestation'], 'name': 'beautifly', 'stats': {'hp': 60, 'attack': 70, 'defense': 50, 'special-attack': 100, 'special-defense': 50, 'speed': 65}, 'types': ['bug', 'flying'], 'weight': 284, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'アゲハント', 'roomaji': 'Agehunt', 'ko': '뷰티플라이', 'zh-Hant': '狩獵鳳蝶', 'fr': 'Charmillon', 'de': 'Papinella', 'es': 'Beautifly', 'it': 'Beautifly', 'en': 'Beautifly', 'ja': 'アゲハント', 'zh-Hans': '狩猎凤蝶'}, 'genera': {'ja-Hrkt': 'ちょうちょポケモン', 'ko': '나비포켓몬', 'zh-Hant': '蝴蝶寶可夢', 'fr': 'Pokémon Papillon', 'de': 'Falter', 'es': 'Pokémon Mariposa', 'it': 'Pokémon Farfalla', 'en': 'Butterfly Pokémon', 'ja': 'ちょうちょポケモン', 'zh-Hans': '蝴蝶宝可梦'}}
	public class SpecieBeautifly : PokemonSpecie
	{
#nullable enable
		private static SpecieBeautifly? _instance = null;
#nullable restore
        public static SpecieBeautifly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeautifly();
                }
                return _instance;
            }
        }

		public SpecieBeautifly() : base(
			"Beautifly",
			60, // HPs
			70, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			65			
		) {}
	}


	//Beautifly Pokemon Class
	public class Beautifly : Pokemon
	{

		public Beautifly(string nickname, int level)
		: base(
				267,
				SpecieBeautifly.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Beautifly() : base(
			267,
			SpecieBeautifly.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}