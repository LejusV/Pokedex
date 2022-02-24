using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Watchog Specie to store common natural stats of every {'abilities': ['illuminate', 'keen-eye', 'analytic'], 'base_experience': 147, 'height': 11, 'id': 505, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'slam', 'sand-attack', 'tackle', 'leer', 'bite', 'flamethrower', 'hyper-beam', 'low-kick', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'hypnosis', 'double-team', 'confuse-ray', 'light-screen', 'focus-energy', 'bide', 'dream-eater', 'flash', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'snore', 'protect', 'detect', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'shadow-ball', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'knock-off', 'endeavor', 'secret-power', 'signal-beam', 'covet', 'shock-wave', 'fling', 'last-resort', 'aqua-tail', 'seed-bomb', 'focus-blast', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'gunk-shot', 'grass-knot', 'after-you', 'round', 'retaliate', 'work-up', 'rototiller', 'confide', 'power-up-punch'], 'name': 'watchog', 'stats': {'hp': 60, 'attack': 85, 'defense': 69, 'special-attack': 60, 'special-defense': 69, 'speed': 77}, 'types': ['normal'], 'weight': 270, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ミルホッグ', 'ko': '보르그', 'zh-Hant': '步哨鼠', 'fr': 'Miradar', 'de': 'Kukmarda', 'es': 'Watchog', 'it': 'Watchog', 'en': 'Watchog', 'ja': 'ミルホッグ', 'zh-Hans': '步哨鼠'}, 'genera': {'ja-Hrkt': 'けいかいポケモン', 'ko': '경계포켓몬', 'zh-Hant': '警戒寶可夢', 'fr': 'Pokémon Vigilant', 'de': 'Wachsamkeit', 'es': 'Pokémon Alerta', 'it': 'Pokémon Sentinella', 'en': 'Lookout Pokémon', 'ja': 'けいかいポケモン', 'zh-Hans': '警戒宝可梦'}}
	public class SpecieWatchog : PokemonSpecie
	{
#nullable enable
		private static SpecieWatchog? _instance = null;
#nullable restore
        public static SpecieWatchog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWatchog();
                }
                return _instance;
            }
        }

		public SpecieWatchog() : base(
			"Watchog",
			60, // HPs
			85, 69, // Attack & Defense
			60, 69, // Special Attack & Defense
			77			
		) {}
	}


	//Watchog Pokemon Class
	public class Watchog : Pokemon
	{

		public Watchog(string nickname, int level)
		: base(
				505,
				SpecieWatchog.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Watchog() : base(
			505,
			SpecieWatchog.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}