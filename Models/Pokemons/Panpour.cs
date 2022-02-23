using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Panpour Specie to store common natural stats of every {'abilities': ['gluttony', 'torrent'], 'base_experience': 63, 'height': 6, 'id': 515, 'moves': ['ice-punch', 'scratch', 'cut', 'leer', 'bite', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'dig', 'toxic', 'double-team', 'lick', 'waterfall', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'uproar', 'hail', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'recycle', 'knock-off', 'endeavor', 'secret-power', 'dive', 'mud-sport', 'astonish', 'rock-tomb', 'tickle', 'covet', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'payback', 'fling', 'gastro-acid', 'aqua-ring', 'aqua-tail', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'grass-knot', 'hone-claws', 'low-sweep', 'round', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'disarming-voice', 'play-nice', 'confide'], 'name': 'panpour', 'stats': {'hp': 50, 'attack': 53, 'defense': 48, 'special-attack': 53, 'special-defense': 48, 'speed': 64}, 'types': ['water'], 'weight': 135, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 190, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヒヤップ', 'ko': '앗차프', 'zh-Hant': '冷水猴', 'fr': 'Flotajou', 'de': 'Sodamak', 'es': 'Panpour', 'it': 'Panpour', 'en': 'Panpour', 'ja': 'ヒヤップ', 'zh-Hans': '冷水猴'}, 'genera': {'ja-Hrkt': 'みずかけポケモン', 'ko': '물뿌리기포켓몬', 'zh-Hant': '潑水寶可夢', 'fr': 'Pokémon Jet d’Eau', 'de': 'Wasserstrahl', 'es': 'Pokémon Salpicadura', 'it': 'Pokémon Annaffiatore', 'en': 'Spray Pokémon', 'ja': 'みずかけポケモン', 'zh-Hans': '泼水宝可梦'}}
	public class SpeciePanpour : PokemonSpecie
	{
#nullable enable
		private static SpeciePanpour? _instance = null;
#nullable restore
        public static SpeciePanpour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePanpour();
                }
                return _instance;
            }
        }

		public SpeciePanpour() : base(
			"Panpour",
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64			
		) {}
	}


	//Panpour Pokemon Class
	public class Panpour : Pokemon
	{

		public Panpour(string nickname, int level) : base(
			515,
			SpeciePanpour.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Panpour() : base(
			515,
			SpeciePanpour.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}