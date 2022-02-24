using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yanma Specie to store common natural stats of every {'abilities': ['speed-boost', 'compound-eyes', 'frisk'], 'base_experience': 78, 'height': 12, 'id': 193, 'moves': ['wing-attack', 'whirlwind', 'headbutt', 'tackle', 'double-edge', 'supersonic', 'sonic-boom', 'solar-beam', 'string-shot', 'toxic', 'psychic', 'hypnosis', 'quick-attack', 'mimic', 'screech', 'double-team', 'swift', 'dream-eater', 'leech-life', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'reversal', 'protect', 'feint-attack', 'foresight', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'sunny-day', 'ancient-power', 'shadow-ball', 'uproar', 'facade', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'feint', 'tailwind', 'u-turn', 'air-slash', 'bug-buzz', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'round', 'confide'], 'name': 'yanma', 'stats': {'hp': 65, 'attack': 65, 'defense': 45, 'special-attack': 75, 'special-defense': 45, 'speed': 95}, 'types': ['bug', 'flying'], 'weight': 380, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ヤンヤンマ', 'roomaji': 'Yanyanma', 'ko': '왕자리', 'zh-Hant': '蜻蜻蜓', 'fr': 'Yanma', 'de': 'Yanma', 'es': 'Yanma', 'it': 'Yanma', 'en': 'Yanma', 'ja': 'ヤンヤンマ', 'zh-Hans': '蜻蜻蜓'}, 'genera': {'ja-Hrkt': 'うすばねポケモン', 'ko': '얇은날개포켓몬', 'zh-Hant': '薄翼寶可夢', 'fr': 'Pokémon Translaile', 'de': 'Libelle', 'es': 'Pokémon Ala Clara', 'it': 'Pokémon Alachiara', 'en': 'Clear Wing Pokémon', 'ja': 'うすばねポケモン', 'zh-Hans': '薄翼宝可梦'}}
	public class SpecieYanma : PokemonSpecie
	{
#nullable enable
		private static SpecieYanma? _instance = null;
#nullable restore
        public static SpecieYanma Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYanma();
                }
                return _instance;
            }
        }

		public SpecieYanma() : base(
			"Yanma",
			65, // HPs
			65, 45, // Attack & Defense
			75, 45, // Special Attack & Defense
			95			
		) {}
	}


	//Yanma Pokemon Class
	public class Yanma : Pokemon
	{

		public Yanma(string nickname, int level)
		: base(
				193,
				SpecieYanma.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Yanma(int level)
		: base(
				193,
				SpecieYanma.Instance, // Pokemon Specie
				"Yanma", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Yanma() : base(
			193,
			SpecieYanma.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}