using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vivillon Specie to store common natural stats of every {'abilities': ['shield-dust', 'compound-eyes', 'friend-guard'], 'base_experience': 185, 'height': 12, 'id': 666, 'moves': ['gust', 'supersonic', 'psybeam', 'hyper-beam', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'psychic', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'facade', 'endeavor', 'secret-power', 'aromatherapy', 'signal-beam', 'aerial-ace', 'calm-mind', 'roost', 'tailwind', 'u-turn', 'bug-buzz', 'energy-ball', 'giga-impact', 'bug-bite', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'electroweb', 'hurricane', 'draining-kiss', 'confide', 'powder', 'infestation'], 'name': 'vivillon', 'stats': {'hp': 80, 'attack': 52, 'defense': 50, 'special-attack': 90, 'special-defense': 50, 'speed': 89}, 'types': ['bug', 'flying'], 'weight': 170, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ビビヨン', 'ko': '비비용', 'zh-Hant': '彩粉蝶', 'fr': 'Prismillon', 'de': 'Vivillon', 'es': 'Vivillon', 'it': 'Vivillon', 'en': 'Vivillon', 'ja': 'ビビヨン', 'zh-Hans': '彩粉蝶'}, 'genera': {'ja-Hrkt': 'りんぷんポケモン', 'ko': '인분포켓몬', 'zh-Hant': '鱗粉寶可夢', 'fr': 'Pokémon Lépidécaille', 'de': 'Flügelstaub', 'es': 'Pokémon Escamaposa', 'it': 'Pokémon Farfascaglia', 'en': 'Scale Pokémon', 'ja': 'りんぷんポケモン', 'zh-Hans': '鳞粉宝可梦'}}
	public class SpecieVivillon : PokemonSpecie
	{
#nullable enable
		private static SpecieVivillon? _instance = null;
#nullable restore
        public static SpecieVivillon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVivillon();
                }
                return _instance;
            }
        }

		public SpecieVivillon() : base(
			"Vivillon",
			80, // HPs
			52, 50, // Attack & Defense
			90, 50, // Special Attack & Defense
			89			
		) {}
	}


	//Vivillon Pokemon Class
	public class Vivillon : Pokemon
	{

		public Vivillon(string nickname, int level)
		: base(
				666,
				SpecieVivillon.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vivillon(int level)
		: base(
				666,
				SpecieVivillon.Instance, // Pokemon Specie
				"Vivillon", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vivillon() : base(
			666,
			SpecieVivillon.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}