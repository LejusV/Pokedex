using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Qwilfish Specie to store common natural stats of every {'abilities': ['poison-point', 'swift-swim', 'intimidate'], 'base_experience': 88, 'height': 5, 'id': 211, 'moves': ['swords-dance', 'headbutt', 'tackle', 'take-down', 'double-edge', 'poison-sting', 'pin-missile', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'thunder-wave', 'toxic', 'mimic', 'double-team', 'harden', 'minimize', 'defense-curl', 'haze', 'self-destruct', 'waterfall', 'swift', 'bubble', 'explosion', 'rest', 'substitute', 'snore', 'curse', 'flail', 'protect', 'sludge-bomb', 'spikes', 'destiny-bond', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'shadow-ball', 'whirlpool', 'stockpile', 'spit-up', 'hail', 'facade', 'taunt', 'revenge', 'secret-power', 'dive', 'astonish', 'signal-beam', 'bounce', 'shock-wave', 'water-pulse', 'gyro-ball', 'brine', 'natural-gift', 'payback', 'toxic-spikes', 'poison-jab', 'aqua-tail', 'captivate', 'aqua-jet', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'scald', 'fell-stinger', 'confide'], 'name': 'qwilfish', 'stats': {'hp': 65, 'attack': 95, 'defense': 85, 'special-attack': 55, 'special-defense': 55, 'speed': 85}, 'types': ['water', 'poison'], 'weight': 39, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ハリーセン', 'roomaji': 'Harysen', 'ko': '침바루', 'zh-Hant': '千針魚', 'fr': 'Qwilfish', 'de': 'Baldorfish', 'es': 'Qwilfish', 'it': 'Qwilfish', 'en': 'Qwilfish', 'ja': 'ハリーセン', 'zh-Hans': '千针鱼'}, 'genera': {'ja-Hrkt': 'ふうせんポケモン', 'ko': '풍선포켓몬', 'zh-Hant': '氣球寶可夢', 'fr': 'Pokémon Bouboule', 'de': 'Ballon', 'es': 'Pokémon Globo', 'it': 'Pokémon Pallone', 'en': 'Balloon Pokémon', 'ja': 'ふうせんポケモン', 'zh-Hans': '气球宝可梦'}}
	public class SpecieQwilfish : PokemonSpecie
	{
#nullable enable
		private static SpecieQwilfish? _instance = null;
#nullable restore
        public static SpecieQwilfish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQwilfish();
                }
                return _instance;
            }
        }

		public SpecieQwilfish() : base(
			"Qwilfish",
			65, // HPs
			95, 85, // Attack & Defense
			55, 55, // Special Attack & Defense
			85			
		) {}
	}


	//Qwilfish Pokemon Class
	public class Qwilfish : Pokemon
	{

		public Qwilfish(string nickname, int level)
		: base(
				211,
				SpecieQwilfish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Qwilfish() : base(
			211,
			SpecieQwilfish.Instance, // Pokemon Specie
			Water.Instance, Poison.Instance			
		) {}
	}
}