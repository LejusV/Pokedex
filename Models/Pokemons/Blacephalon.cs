using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blacephalon Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 18, 'id': 806, 'moves': ['ember', 'flamethrower', 'hyper-beam', 'toxic', 'psychic', 'night-shade', 'double-team', 'light-screen', 'fire-blast', 'explosion', 'rest', 'substitute', 'thief', 'protect', 'swagger', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'shadow-ball', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'magic-coat', 'astonish', 'overheat', 'calm-mind', 'payback', 'fling', 'dark-pulse', 'shadow-claw', 'psyshock', 'smack-down', 'flame-burst', 'flame-charge', 'round', 'stored-power', 'quash', 'confide', 'mind-blown'], 'name': 'blacephalon', 'stats': {'hp': 53, 'attack': 127, 'defense': 53, 'special-attack': 151, 'special-defense': 79, 'speed': 107}, 'types': ['fire', 'ghost'], 'weight': 130, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 30, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ズガドーン', 'ko': '두파팡', 'zh-Hant': '砰頭小丑', 'fr': 'Pierroteknik', 'de': 'Kopplosio', 'es': 'Blacephalon', 'it': 'Blacephalon', 'en': 'Blacephalon', 'ja': 'ズガドーン', 'zh-Hans': '砰头小丑'}, 'genera': {'ja-Hrkt': 'はなびポケモン', 'ko': '불꽃놀이포켓몬', 'zh-Hant': '煙火寶可夢', 'fr': 'Pokémon Artificier', 'de': 'Feuerwerk', 'es': 'Pokémon Pirotecnia', 'it': 'Pokémon Pirotecnico', 'en': 'Fireworks Pokémon', 'ja': 'はなびポケモン', 'zh-Hans': '烟火宝可梦'}}
	public class SpecieBlacephalon : PokemonSpecie
	{
#nullable enable
		private static SpecieBlacephalon? _instance = null;
#nullable restore
        public static SpecieBlacephalon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlacephalon();
                }
                return _instance;
            }
        }

		public SpecieBlacephalon() : base(
			"Blacephalon",
			53, // HPs
			127, 53, // Attack & Defense
			151, 79, // Special Attack & Defense
			107			
		) {}
	}


	//Blacephalon Pokemon Class
	public class Blacephalon : Pokemon
	{

		public Blacephalon(string nickname, int level)
		: base(
				806,
				SpecieBlacephalon.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blacephalon() : base(
			806,
			SpecieBlacephalon.Instance, // Pokemon Specie
			Fire.Instance, Ghost.Instance			
		) {}
	}
}