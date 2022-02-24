using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pachirisu Specie to store common natural stats of every {'abilities': ['run-away', 'pickup', 'volt-absorb'], 'base_experience': 142, 'height': 4, 'id': 417, 'moves': ['thunder-punch', 'cut', 'headbutt', 'tail-whip', 'bite', 'growl', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'double-team', 'defense-curl', 'light-screen', 'bide', 'swift', 'flash', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'snore', 'flail', 'protect', 'sweet-kiss', 'mud-slap', 'endure', 'charm', 'rollout', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'uproar', 'flatter', 'facade', 'follow-me', 'charge', 'helping-hand', 'secret-power', 'fake-tears', 'covet', 'shock-wave', 'natural-gift', 'u-turn', 'fling', 'last-resort', 'magnet-rise', 'seed-bomb', 'discharge', 'gunk-shot', 'captivate', 'grass-knot', 'charge-beam', 'electro-ball', 'round', 'echoed-voice', 'bestow', 'volt-switch', 'electroweb', 'ion-deluge', 'confide', 'baby-doll-eyes', 'nuzzle'], 'name': 'pachirisu', 'stats': {'hp': 60, 'attack': 45, 'defense': 70, 'special-attack': 45, 'special-defense': 90, 'speed': 95}, 'types': ['electric'], 'weight': 39, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 200, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground', 'fairy'], 'names': {'ja-Hrkt': 'パチリス', 'roomaji': 'Pachirisu', 'ko': '파치리스', 'zh-Hant': '帕奇利茲', 'fr': 'Pachirisu', 'de': 'Pachirisu', 'es': 'Pachirisu', 'it': 'Pachirisu', 'en': 'Pachirisu', 'ja': 'パチリス', 'zh-Hans': '帕奇利兹'}, 'genera': {'ja-Hrkt': 'でんきりすポケモン', 'ko': '전기다람쥐포켓몬', 'zh-Hant': '電松鼠寶可夢', 'fr': 'Pokémon Écurélec', 'de': 'Elektrohörnchen', 'es': 'Pokémon Ardillalec', 'it': 'Pokémon Elescoiatto', 'en': 'EleSquirrel Pokémon', 'ja': 'でんきりすポケモン', 'zh-Hans': '电松鼠宝可梦'}}
	public class SpeciePachirisu : PokemonSpecie
	{
#nullable enable
		private static SpeciePachirisu? _instance = null;
#nullable restore
        public static SpeciePachirisu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePachirisu();
                }
                return _instance;
            }
        }

		public SpeciePachirisu() : base(
			"Pachirisu",
			60, // HPs
			45, 70, // Attack & Defense
			45, 90, // Special Attack & Defense
			95			
		) {}
	}


	//Pachirisu Pokemon Class
	public class Pachirisu : Pokemon
	{

		public Pachirisu(string nickname, int level)
		: base(
				417,
				SpeciePachirisu.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pachirisu() : base(
			417,
			SpeciePachirisu.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}