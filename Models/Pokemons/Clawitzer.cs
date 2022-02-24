using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clawitzer Specie to store common natural stats of every {'abilities': ['mega-launcher'], 'base_experience': 100, 'height': 13, 'id': 693, 'moves': ['vice-grip', 'swords-dance', 'cut', 'water-gun', 'surf', 'ice-beam', 'bubble-beam', 'hyper-beam', 'toxic', 'double-team', 'waterfall', 'bubble', 'splash', 'crabhammer', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'shadow-ball', 'facade', 'helping-hand', 'secret-power', 'dive', 'muddy-water', 'bounce', 'water-sport', 'water-pulse', 'u-turn', 'aura-sphere', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'giga-impact', 'flash-cannon', 'aqua-jet', 'venoshock', 'smack-down', 'sludge-wave', 'round', 'scald', 'heal-pulse', 'confide'], 'name': 'clawitzer', 'stats': {'hp': 71, 'attack': 73, 'defense': 88, 'special-attack': 120, 'special-defense': 89, 'speed': 59}, 'types': ['water'], 'weight': 353, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 55, 'color': 'blue', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['water1', 'water3'], 'names': {'ja-Hrkt': 'ブロスター', 'ko': '블로스터', 'zh-Hant': '鋼砲臂蝦', 'fr': 'Gamblast', 'de': 'Wummer', 'es': 'Clawitzer', 'it': 'Clawitzer', 'en': 'Clawitzer', 'ja': 'ブロスター', 'zh-Hans': '钢炮臂虾'}, 'genera': {'ja-Hrkt': 'ランチャーポケモン', 'ko': '런처포켓몬', 'zh-Hant': '發射器寶可夢', 'fr': 'Pokémon Blaster', 'de': 'Aquawumme', 'es': 'Pokémon Lanzachorro', 'it': 'Pokémon Acqualancio', 'en': 'Howitzer Pokémon', 'ja': 'ランチャーポケモン', 'zh-Hans': '发射器宝可梦'}}
	public class SpecieClawitzer : PokemonSpecie
	{
#nullable enable
		private static SpecieClawitzer? _instance = null;
#nullable restore
        public static SpecieClawitzer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClawitzer();
                }
                return _instance;
            }
        }

		public SpecieClawitzer() : base(
			"Clawitzer",
			71, // HPs
			73, 88, // Attack & Defense
			120, 89, // Special Attack & Defense
			59			
		) {}
	}


	//Clawitzer Pokemon Class
	public class Clawitzer : Pokemon
	{

		public Clawitzer(string nickname, int level)
		: base(
				693,
				SpecieClawitzer.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clawitzer(int level)
		: base(
				693,
				SpecieClawitzer.Instance, // Pokemon Specie
				"Clawitzer", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clawitzer() : base(
			693,
			SpecieClawitzer.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}