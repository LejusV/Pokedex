using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Minccino Specie to store common natural stats of every {'abilities': ['cute-charm', 'technician', 'skill-link'], 'base_experience': 60, 'height': 4, 'id': 572, 'moves': ['pound', 'double-slap', 'slam', 'tail-whip', 'growl', 'sing', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'double-team', 'swift', 'rest', 'substitute', 'thief', 'snore', 'flail', 'protect', 'mud-slap', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'uproar', 'facade', 'helping-hand', 'knock-off', 'secret-power', 'hyper-voice', 'fake-tears', 'tickle', 'covet', 'calm-mind', 'shock-wave', 'wake-up-slap', 'u-turn', 'fling', 'last-resort', 'aqua-tail', 'seed-bomb', 'gunk-shot', 'captivate', 'grass-knot', 'after-you', 'round', 'echoed-voice', 'retaliate', 'work-up', 'tail-slap', 'confide', 'dazzling-gleam', 'baby-doll-eyes'], 'name': 'minccino', 'stats': {'hp': 55, 'attack': 50, 'defense': 40, 'special-attack': 40, 'special-defense': 40, 'speed': 75}, 'types': ['normal'], 'weight': 58, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 6, 'capture_rate': 255, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'チラーミィ', 'ko': '치라미', 'zh-Hant': '泡沫栗鼠', 'fr': 'Chinchidou', 'de': 'Picochilla', 'es': 'Minccino', 'it': 'Minccino', 'en': 'Minccino', 'ja': 'チラーミィ', 'zh-Hans': '泡沫栗鼠'}, 'genera': {'ja-Hrkt': 'チンチラポケモン', 'ko': '친칠라포켓몬', 'zh-Hant': '栗鼠寶可夢', 'fr': 'Pokémon Chinchilla', 'de': 'Chinchilla', 'es': 'Pokémon Chinchilla', 'it': 'Pokémon Cincillà', 'en': 'Chinchilla Pokémon', 'ja': 'チンチラポケモン', 'zh-Hans': '栗鼠宝可梦'}}
	public class SpecieMinccino : PokemonSpecie
	{
#nullable enable
		private static SpecieMinccino? _instance = null;
#nullable restore
        public static SpecieMinccino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMinccino();
                }
                return _instance;
            }
        }

		public SpecieMinccino() : base(
			"Minccino",
			55, // HPs
			50, 40, // Attack & Defense
			40, 40, // Special Attack & Defense
			75			
		) {}
	}


	//Minccino Pokemon Class
	public class Minccino : Pokemon
	{

		public Minccino(string nickname, int level) : base(
			572,
			SpecieMinccino.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Minccino() : base(
			572,
			SpecieMinccino.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}