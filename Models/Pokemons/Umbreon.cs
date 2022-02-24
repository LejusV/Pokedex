using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Umbreon Specie to store common natural stats of every {'abilities': ['synchronize', 'inner-focus'], 'base_experience': 184, 'height': 10, 'id': 197, 'moves': ['cut', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'tail-whip', 'hyper-beam', 'dig', 'toxic', 'psychic', 'quick-attack', 'mimic', 'screech', 'double-team', 'confuse-ray', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'pursuit', 'iron-tail', 'moonlight', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'torment', 'facade', 'taunt', 'helping-hand', 'snatch', 'secret-power', 'hyper-voice', 'covet', 'natural-gift', 'payback', 'assurance', 'guard-swap', 'last-resort', 'sucker-punch', 'dark-pulse', 'giga-impact', 'captivate', 'wonder-room', 'foul-play', 'round', 'echoed-voice', 'retaliate', 'work-up', 'snarl', 'confide', 'baby-doll-eyes'], 'name': 'umbreon', 'stats': {'hp': 95, 'attack': 65, 'defense': 110, 'special-attack': 60, 'special-defense': 130, 'speed': 65}, 'types': ['dark'], 'weight': 270, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'black', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ブラッキー', 'roomaji': 'Blacky', 'ko': '블래키', 'zh-Hant': '月亮伊布', 'fr': 'Noctali', 'de': 'Nachtara', 'es': 'Umbreon', 'it': 'Umbreon', 'en': 'Umbreon', 'ja': 'ブラッキー', 'zh-Hans': '月亮伊布'}, 'genera': {'ja-Hrkt': 'げっこうポケモン', 'ko': '달빛포켓몬', 'zh-Hant': '月光寶可夢', 'fr': 'Pokémon Lune', 'de': 'Mondschein', 'es': 'Pokémon Luz Lunar', 'it': 'Pokémon Lucelunare', 'en': 'Moonlight Pokémon', 'ja': 'げっこうポケモン', 'zh-Hans': '月光宝可梦'}}
	public class SpecieUmbreon : PokemonSpecie
	{
#nullable enable
		private static SpecieUmbreon? _instance = null;
#nullable restore
        public static SpecieUmbreon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUmbreon();
                }
                return _instance;
            }
        }

		public SpecieUmbreon() : base(
			"Umbreon",
			95, // HPs
			65, 110, // Attack & Defense
			60, 130, // Special Attack & Defense
			65			
		) {}
	}


	//Umbreon Pokemon Class
	public class Umbreon : Pokemon
	{

		public Umbreon(string nickname, int level)
		: base(
				197,
				SpecieUmbreon.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Umbreon() : base(
			197,
			SpecieUmbreon.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}