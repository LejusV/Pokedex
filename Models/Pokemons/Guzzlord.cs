using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Guzzlord Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 55, 'id': 799, 'moves': ['stomp', 'thrash', 'bite', 'flamethrower', 'hyper-beam', 'dragon-rage', 'earthquake', 'toxic', 'double-team', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'thief', 'protect', 'sludge-bomb', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'crunch', 'stockpile', 'swallow', 'facade', 'brick-break', 'rock-tomb', 'dragon-claw', 'hammer-arm', 'gyro-ball', 'payback', 'fling', 'wring-out', 'gastro-acid', 'poison-jab', 'dark-pulse', 'dragon-rush', 'giga-impact', 'shadow-claw', 'draco-meteor', 'stone-edge', 'wide-guard', 'smack-down', 'sludge-wave', 'heavy-slam', 'round', 'bulldoze', 'dragon-tail', 'steamroller', 'snarl', 'belch', 'brutal-swing', 'stomping-tantrum'], 'name': 'guzzlord', 'stats': {'hp': 223, 'attack': 101, 'defense': 53, 'special-attack': 97, 'special-defense': 53, 'speed': 43}, 'types': ['dark', 'dragon'], 'weight': 8880, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'black', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'アクジキング', 'ko': '악식킹', 'zh-Hant': '惡食大王', 'fr': 'Engloutyran', 'de': 'Schlingking', 'es': 'Guzzlord', 'it': 'Guzzlord', 'en': 'Guzzlord', 'ja': 'アクジキング', 'zh-Hans': '恶食大王'}, 'genera': {'ja-Hrkt': 'あくじきポケモン', 'ko': '악식성포켓몬', 'zh-Hant': '異食寶可夢', 'fr': 'Pokémon Bizarrovore', 'de': 'Gaumenfolter', 'es': 'Pokémon Tragaldabas', 'it': 'Pokémon Divoratutto', 'en': 'Junkivore Pokémon', 'ja': 'あくじきポケモン', 'zh-Hans': '异食宝可梦'}}
	public class SpecieGuzzlord : PokemonSpecie
	{
#nullable enable
		private static SpecieGuzzlord? _instance = null;
#nullable restore
        public static SpecieGuzzlord Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGuzzlord();
                }
                return _instance;
            }
        }

		public SpecieGuzzlord() : base(
			"Guzzlord",
			223, // HPs
			101, 53, // Attack & Defense
			97, 53, // Special Attack & Defense
			43			
		) {}
	}


	//Guzzlord Pokemon Class
	public class Guzzlord : Pokemon
	{

		public Guzzlord(string nickname, int level) : base(
			799,
			SpecieGuzzlord.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Dragon.Instance			
		) {}

		public Guzzlord() : base(
			799,
			SpecieGuzzlord.Instance, // Pokemon Specie
			Dark.Instance, Dragon.Instance			
		) {}
	}
}