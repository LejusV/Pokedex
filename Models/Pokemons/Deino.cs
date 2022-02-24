using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Deino Specie to store common natural stats of every {'abilities': ['hustle'], 'base_experience': 60, 'height': 8, 'id': 633, 'moves': ['slam', 'headbutt', 'tackle', 'body-slam', 'bite', 'roar', 'strength', 'dragon-rage', 'thunder-wave', 'toxic', 'screech', 'double-team', 'focus-energy', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'superpower', 'secret-power', 'hyper-voice', 'astonish', 'shock-wave', 'assurance', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'dragon-rush', 'earth-power', 'thunder-fang', 'ice-fang', 'fire-fang', 'zen-headbutt', 'draco-meteor', 'head-smash', 'double-hit', 'round', 'incinerate', 'dragon-tail', 'work-up', 'belch', 'confide'], 'name': 'deino', 'stats': {'hp': 52, 'attack': 65, 'defense': 50, 'special-attack': 45, 'special-defense': 50, 'speed': 38}, 'types': ['dark', 'dragon'], 'weight': 173, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['dragon'], 'names': {'ja-Hrkt': 'モノズ', 'ko': '모노두', 'zh-Hant': '單首龍', 'fr': 'Solochi', 'de': 'Kapuno', 'es': 'Deino', 'it': 'Deino', 'en': 'Deino', 'ja': 'モノズ', 'zh-Hans': '单首龙'}, 'genera': {'ja-Hrkt': 'そぼうポケモン', 'ko': '폭거포켓몬', 'zh-Hant': '粗魯寶可夢', 'fr': 'Pokémon Rude', 'de': 'Haudrauf', 'es': 'Pokémon Tosco', 'it': 'Pokémon Impeto', 'en': 'Irate Pokémon', 'ja': 'そぼうポケモン', 'zh-Hans': '粗鲁宝可梦'}}
	public class SpecieDeino : PokemonSpecie
	{
#nullable enable
		private static SpecieDeino? _instance = null;
#nullable restore
        public static SpecieDeino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDeino();
                }
                return _instance;
            }
        }

		public SpecieDeino() : base(
			"Deino",
			52, // HPs
			65, 50, // Attack & Defense
			45, 50, // Special Attack & Defense
			38			
		) {}
	}


	//Deino Pokemon Class
	public class Deino : Pokemon
	{

		public Deino(string nickname, int level)
		: base(
				633,
				SpecieDeino.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Deino(int level)
		: base(
				633,
				SpecieDeino.Instance, // Pokemon Specie
				"Deino", level,
				Dark.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Deino() : base(
			633,
			SpecieDeino.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
	}
}