using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Happiny Specie to store common natural stats of every {'abilities': ['natural-cure', 'serene-grace', 'friend-guard'], 'base_experience': 110, 'height': 6, 'id': 440, 'moves': ['pound', 'headbutt', 'flamethrower', 'counter', 'solar-beam', 'thunder-wave', 'toxic', 'psychic', 'double-team', 'light-screen', 'metronome', 'fire-blast', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'sweet-kiss', 'mud-slap', 'icy-wind', 'endure', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'present', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'hail', 'facade', 'helping-hand', 'recycle', 'endeavor', 'refresh', 'secret-power', 'hyper-voice', 'aromatherapy', 'covet', 'shock-wave', 'water-pulse', 'gravity', 'natural-gift', 'fling', 'copycat', 'last-resort', 'drain-punch', 'mud-bomb', 'zen-headbutt', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'incinerate', 'work-up', 'confide'], 'name': 'happiny', 'stats': {'hp': 100, 'attack': 5, 'defense': 5, 'special-attack': 15, 'special-defense': 65, 'speed': 30}, 'types': ['normal'], 'weight': 244, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 8, 'capture_rate': 130, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ピンプク', 'roomaji': 'Pinpuku', 'ko': '핑복', 'zh-Hant': '小福蛋', 'fr': 'Ptiravi', 'de': 'Wonneira', 'es': 'Happiny', 'it': 'Happiny', 'en': 'Happiny', 'ja': 'ピンプク', 'zh-Hans': '小福蛋'}, 'genera': {'ja-Hrkt': 'ままごとポケモン', 'ko': '소꿉놀이포켓몬', 'zh-Hant': '家家酒寶可夢', 'fr': 'Pokémon Maisonjouet', 'de': 'Spielhaus', 'es': 'Pokémon Casita', 'it': 'Pokémon Ovettino', 'en': 'Playhouse Pokémon', 'ja': 'ままごとポケモン', 'zh-Hans': '家家酒宝可梦'}}
	public class SpecieHappiny : PokemonSpecie
	{
#nullable enable
		private static SpecieHappiny? _instance = null;
#nullable restore
        public static SpecieHappiny Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHappiny();
                }
                return _instance;
            }
        }

		public SpecieHappiny() : base(
			"Happiny",
			100, // HPs
			5, 5, // Attack & Defense
			15, 65, // Special Attack & Defense
			30			
		) {}
	}


	//Happiny Pokemon Class
	public class Happiny : Pokemon
	{

		public Happiny(string nickname, int level) : base(
			440,
			SpecieHappiny.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Happiny() : base(
			440,
			SpecieHappiny.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}