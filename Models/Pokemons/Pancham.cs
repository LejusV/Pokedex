using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pancham Specie to store common natural stats of every {'abilities': ['iron-fist', 'mold-breaker', 'scrappy'], 'base_experience': 70, 'height': 6, 'id': 674, 'moves': ['karate-chop', 'comet-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'swords-dance', 'cut', 'tackle', 'body-slam', 'leer', 'roar', 'surf', 'low-kick', 'strength', 'dig', 'toxic', 'double-team', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'spite', 'protect', 'sludge-bomb', 'false-swipe', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'helping-hand', 'superpower', 'brick-break', 'knock-off', 'endeavor', 'snatch', 'secret-power', 'arm-thrust', 'hyper-voice', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'block', 'bulk-up', 'covet', 'payback', 'fling', 'me-first', 'dark-pulse', 'drain-punch', 'shadow-claw', 'zen-headbutt', 'gunk-shot', 'iron-head', 'stone-edge', 'grass-knot', 'storm-throw', 'low-sweep', 'foul-play', 'entrainment', 'round', 'echoed-voice', 'quick-guard', 'circle-throw', 'quash', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'parting-shot', 'confide', 'power-up-punch', 'power-trip'], 'name': 'pancham', 'stats': {'hp': 67, 'attack': 82, 'defense': 62, 'special-attack': 46, 'special-defense': 48, 'speed': 43}, 'types': ['fighting'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 220, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ヤンチャム', 'ko': '판짱', 'zh-Hant': '頑皮熊貓', 'fr': 'Pandespiègle', 'de': 'Pam-Pam', 'es': 'Pancham', 'it': 'Pancham', 'en': 'Pancham', 'ja': 'ヤンチャム', 'zh-Hans': '顽皮熊猫'}, 'genera': {'ja-Hrkt': 'やんちゃポケモン', 'ko': '개구쟁이포켓몬', 'zh-Hant': '頑皮寶可夢', 'fr': 'Pokémon Garnement', 'de': 'Verspielt', 'es': 'Pokémon Juguetón', 'it': 'Pokémon Briccone', 'en': 'Playful Pokémon', 'ja': 'やんちゃポケモン', 'zh-Hans': '顽皮宝可梦'}}
	public class SpeciePancham : PokemonSpecie
	{
#nullable enable
		private static SpeciePancham? _instance = null;
#nullable restore
        public static SpeciePancham Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePancham();
                }
                return _instance;
            }
        }

		public SpeciePancham() : base(
			"Pancham",
			67, // HPs
			82, 62, // Attack & Defense
			46, 48, // Special Attack & Defense
			43			
		) {}
	}


	//Pancham Pokemon Class
	public class Pancham : Pokemon
	{

		public Pancham(string nickname, int level)
		: base(
				674,
				SpeciePancham.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pancham(int level)
		: base(
				674,
				SpeciePancham.Instance, // Pokemon Specie
				"Pancham", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pancham() : base(
			674,
			SpeciePancham.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}