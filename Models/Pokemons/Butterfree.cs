using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Butterfree Specie to store common natural stats of every {'abilities': ['compound-eyes', 'tinted-lens'], 'base_experience': 178, 'height': 11, 'id': 12, 'moves': ['razor-wind', 'gust', 'whirlwind', 'take-down', 'double-edge', 'supersonic', 'psybeam', 'hyper-beam', 'mega-drain', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'string-shot', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'reflect', 'bide', 'swift', 'dream-eater', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'skill-swap', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'air-slash', 'bug-buzz', 'energy-ball', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'venoshock', 'rage-powder', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'electroweb', 'confide', 'infestation'], 'name': 'butterfree', 'stats': {'hp': 60, 'attack': 45, 'defense': 50, 'special-attack': 90, 'special-defense': 80, 'speed': 70}, 'types': ['bug', 'flying'], 'weight': 320, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'バタフリー', 'roomaji': 'Butterfree', 'ko': '버터플', 'zh-Hant': '巴大蝶', 'fr': 'Papilusion', 'de': 'Smettbo', 'es': 'Butterfree', 'it': 'Butterfree', 'en': 'Butterfree', 'ja': 'バタフリー', 'zh-Hans': '巴大蝶'}, 'genera': {'ja-Hrkt': 'ちょうちょポケモン', 'ko': '나비포켓몬', 'zh-Hant': '蝴蝶寶可夢', 'fr': 'Pokémon Papillon', 'de': 'Falter', 'es': 'Pokémon Mariposa', 'it': 'Pokémon Farfalla', 'en': 'Butterfly Pokémon', 'ja': 'ちょうちょポケモン', 'zh-Hans': '蝴蝶宝可梦'}}
	public class SpecieButterfree : PokemonSpecie
	{
#nullable enable
		private static SpecieButterfree? _instance = null;
#nullable restore
        public static SpecieButterfree Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieButterfree();
                }
                return _instance;
            }
        }

		public SpecieButterfree() : base(
			"Butterfree",
			60, // HPs
			45, 50, // Attack & Defense
			90, 80, // Special Attack & Defense
			70			
		) {}
	}


	//Butterfree Pokemon Class
	public class Butterfree : Pokemon
	{

		public Butterfree(string nickname, int level)
		: base(
				12,
				SpecieButterfree.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Butterfree() : base(
			12,
			SpecieButterfree.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}