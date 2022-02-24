using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Venonat Specie to store common natural stats of every {'abilities': ['compound-eyes', 'tinted-lens', 'run-away'], 'base_experience': 61, 'height': 10, 'id': 48, 'moves': ['tackle', 'take-down', 'double-edge', 'supersonic', 'disable', 'psybeam', 'mega-drain', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'string-shot', 'toxic', 'confusion', 'psychic', 'agility', 'rage', 'mimic', 'screech', 'double-team', 'reflect', 'bide', 'swift', 'leech-life', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'foresight', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'sweet-scent', 'morning-sun', 'hidden-power', 'sunny-day', 'facade', 'skill-swap', 'secret-power', 'poison-fang', 'signal-beam', 'natural-gift', 'toxic-spikes', 'zen-headbutt', 'captivate', 'bug-bite', 'venoshock', 'rage-powder', 'round', 'struggle-bug', 'confide', 'infestation'], 'name': 'venonat', 'stats': {'hp': 60, 'attack': 55, 'defense': 50, 'special-attack': 40, 'special-defense': 55, 'speed': 45}, 'types': ['bug', 'poison'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'humanoid', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'コンパン', 'roomaji': 'Kongpang', 'ko': '콘팡', 'zh-Hant': '毛球', 'fr': 'Mimitoss', 'de': 'Bluzuk', 'es': 'Venonat', 'it': 'Venonat', 'en': 'Venonat', 'ja': 'コンパン', 'zh-Hans': '毛球'}, 'genera': {'ja-Hrkt': 'こんちゅうポケモン', 'ko': '곤충포켓몬', 'zh-Hant': '昆蟲寶可夢', 'fr': 'Pokémon Vermine', 'de': 'Insekt', 'es': 'Pokémon Insecto', 'it': 'Pokémon Insetto', 'en': 'Insect Pokémon', 'ja': 'こんちゅうポケモン', 'zh-Hans': '昆虫宝可梦'}}
	public class SpecieVenonat : PokemonSpecie
	{
#nullable enable
		private static SpecieVenonat? _instance = null;
#nullable restore
        public static SpecieVenonat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenonat();
                }
                return _instance;
            }
        }

		public SpecieVenonat() : base(
			"Venonat",
			60, // HPs
			55, 50, // Attack & Defense
			40, 55, // Special Attack & Defense
			45			
		) {}
	}


	//Venonat Pokemon Class
	public class Venonat : Pokemon
	{

		public Venonat(string nickname, int level)
		: base(
				48,
				SpecieVenonat.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Venonat() : base(
			48,
			SpecieVenonat.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}