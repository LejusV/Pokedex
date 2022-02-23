using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Simipour Specie to store common natural stats of every {'abilities': ['gluttony', 'torrent'], 'base_experience': 174, 'height': 10, 'id': 516, 'moves': ['ice-punch', 'cut', 'leer', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'dig', 'toxic', 'double-team', 'lick', 'waterfall', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'uproar', 'hail', 'torment', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'superpower', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'dive', 'rock-tomb', 'covet', 'water-pulse', 'payback', 'fling', 'gastro-acid', 'aqua-tail', 'focus-blast', 'giga-impact', 'shadow-claw', 'gunk-shot', 'grass-knot', 'hone-claws', 'low-sweep', 'round', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'simipour', 'stats': {'hp': 75, 'attack': 98, 'defense': 63, 'special-attack': 98, 'special-defense': 63, 'speed': 101}, 'types': ['water'], 'weight': 290, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 75, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヒヤッキー', 'ko': '앗차키', 'zh-Hant': '冷水猿', 'fr': 'Flotoutan', 'de': 'Sodachita', 'es': 'Simipour', 'it': 'Simipour', 'en': 'Simipour', 'ja': 'ヒヤッキー', 'zh-Hans': '冷水猿'}, 'genera': {'ja-Hrkt': 'ほうすいポケモン', 'ko': '방수포켓몬', 'zh-Hant': '放水寶可夢', 'fr': 'Pokémon Drainage', 'de': 'Drainage', 'es': 'Pokémon Drenaje', 'it': 'Pokémon Spruzzacqua', 'en': 'Geyser Pokémon', 'ja': 'ほうすいポケモン', 'zh-Hans': '放水宝可梦'}}
	public class SpecieSimipour : PokemonSpecie
	{
#nullable enable
		private static SpecieSimipour? _instance = null;
#nullable restore
        public static SpecieSimipour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSimipour();
                }
                return _instance;
            }
        }

		public SpecieSimipour() : base(
			"Simipour",
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101			
		) {}
	}


	//Simipour Pokemon Class
	public class Simipour : Pokemon
	{

		public Simipour(string nickname, int level) : base(
			516,
			SpecieSimipour.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Simipour() : base(
			516,
			SpecieSimipour.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}