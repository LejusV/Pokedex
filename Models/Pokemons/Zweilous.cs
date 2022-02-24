using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zweilous Specie to store common natural stats of every {'abilities': ['hustle'], 'base_experience': 147, 'height': 14, 'id': 634, 'moves': ['slam', 'headbutt', 'body-slam', 'bite', 'roar', 'strength', 'dragon-rage', 'thunder-wave', 'toxic', 'double-team', 'focus-energy', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'superpower', 'secret-power', 'hyper-voice', 'shock-wave', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'earth-power', 'zen-headbutt', 'draco-meteor', 'double-hit', 'round', 'incinerate', 'dragon-tail', 'work-up', 'confide'], 'name': 'zweilous', 'stats': {'hp': 72, 'attack': 85, 'defense': 70, 'special-attack': 65, 'special-defense': 70, 'speed': 58}, 'types': ['dark', 'dragon'], 'weight': 500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'ジヘッド', 'ko': '디헤드', 'zh-Hant': '雙首暴龍', 'fr': 'Diamat', 'de': 'Duodino', 'es': 'Zweilous', 'it': 'Zweilous', 'en': 'Zweilous', 'ja': 'ジヘッド', 'zh-Hans': '双首暴龙'}, 'genera': {'ja-Hrkt': 'らんぼうポケモン', 'ko': '흉포포켓몬', 'zh-Hant': '粗暴寶可夢', 'fr': 'Pokémon Violent', 'de': 'Grobheit', 'es': 'Pokémon Violento', 'it': 'Pokémon Irruenza', 'en': 'Hostile Pokémon', 'ja': 'らんぼうポケモン', 'zh-Hans': '粗暴宝可梦'}}
	public class SpecieZweilous : PokemonSpecie
	{
#nullable enable
		private static SpecieZweilous? _instance = null;
#nullable restore
        public static SpecieZweilous Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZweilous();
                }
                return _instance;
            }
        }

		public SpecieZweilous() : base(
			"Zweilous",
			72, // HPs
			85, 70, // Attack & Defense
			65, 70, // Special Attack & Defense
			58			
		) {}
	}


	//Zweilous Pokemon Class
	public class Zweilous : Pokemon
	{

		public Zweilous(string nickname, int level)
		: base(
				634,
				SpecieZweilous.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zweilous() : base(
			634,
			SpecieZweilous.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
	}
}