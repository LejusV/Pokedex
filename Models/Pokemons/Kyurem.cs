using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kyurem Specie to store common natural stats of every {'abilities': ['pressure'], 'base_experience': 297, 'height': 30, 'id': 646, 'moves': ['cut', 'fly', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'dragon-rage', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'icy-wind', 'outrage', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'rain-dance', 'sunny-day', 'ancient-power', 'shadow-ball', 'rock-smash', 'hail', 'facade', 'endeavor', 'imprison', 'secret-power', 'hyper-voice', 'rock-tomb', 'signal-beam', 'dragon-claw', 'roost', 'payback', 'fling', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'flash-cannon', 'draco-meteor', 'iron-head', 'stone-edge', 'hone-claws', 'round', 'echoed-voice', 'dragon-tail', 'glaciate', 'noble-roar', 'confide', 'brutal-swing'], 'name': 'kyurem', 'stats': {'hp': 125, 'attack': 130, 'defense': 90, 'special-attack': 130, 'special-defense': 90, 'speed': 95}, 'types': ['dragon', 'ice'], 'weight': 3250, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'キュレム', 'ko': '큐레무', 'zh-Hant': '酋雷姆', 'fr': 'Kyurem', 'de': 'Kyurem', 'es': 'Kyurem', 'it': 'Kyurem', 'en': 'Kyurem', 'ja': 'キュレム', 'zh-Hans': '酋雷姆'}, 'genera': {'ja-Hrkt': 'きょうかいポケモン', 'ko': '경계포켓몬', 'zh-Hant': '境界寶可夢', 'fr': 'Pokémon Frontière', 'de': 'Schwelle', 'es': 'Pokémon Frontera', 'it': 'Pokémon Confine', 'en': 'Boundary Pokémon', 'ja': 'きょうかいポケモン', 'zh-Hans': '境界宝可梦'}}
	public class SpecieKyurem : PokemonSpecie
	{
#nullable enable
		private static SpecieKyurem? _instance = null;
#nullable restore
        public static SpecieKyurem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKyurem();
                }
                return _instance;
            }
        }

		public SpecieKyurem() : base(
			"Kyurem",
			125, // HPs
			130, 90, // Attack & Defense
			130, 90, // Special Attack & Defense
			95			
		) {}
	}


	//Kyurem Pokemon Class
	public class Kyurem : Pokemon
	{

		public Kyurem(string nickname, int level)
		: base(
				646,
				SpecieKyurem.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kyurem() : base(
			646,
			SpecieKyurem.Instance, // Pokemon Specie
			Dragon.Instance, Ice.Instance			
		) {}
	}
}