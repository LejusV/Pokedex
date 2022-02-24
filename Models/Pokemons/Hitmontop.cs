using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hitmontop Specie to store common natural stats of every {'abilities': ['intimidate', 'technician', 'steadfast'], 'base_experience': 159, 'height': 14, 'id': 237, 'moves': ['mega-kick', 'rolling-kick', 'headbutt', 'body-slam', 'double-edge', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'focus-energy', 'swift', 'rest', 'rock-slide', 'substitute', 'triple-kick', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'rapid-spin', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'helping-hand', 'role-play', 'revenge', 'brick-break', 'endeavor', 'secret-power', 'aerial-ace', 'bulk-up', 'covet', 'gyro-ball', 'natural-gift', 'feint', 'close-combat', 'sucker-punch', 'vacuum-wave', 'stone-edge', 'captivate', 'wide-guard', 'low-sweep', 'round', 'quick-guard', 'retaliate', 'bulldoze', 'work-up', 'drill-run', 'confide'], 'name': 'hitmontop', 'stats': {'hp': 50, 'attack': 95, 'defense': 95, 'special-attack': 35, 'special-defense': 110, 'speed': 70}, 'types': ['fighting'], 'weight': 480, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 0, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'カポエラー', 'roomaji': 'Kapoerer', 'ko': '카포에라', 'zh-Hant': '戰舞郎', 'fr': 'Kapoera', 'de': 'Kapoera', 'es': 'Hitmontop', 'it': 'Hitmontop', 'en': 'Hitmontop', 'ja': 'カポエラー', 'zh-Hans': '战舞郎'}, 'genera': {'ja-Hrkt': 'さかだちポケモン', 'ko': '물구나무포켓몬', 'zh-Hant': '倒立寶可夢', 'fr': 'Pokémon Poirier', 'de': 'Kopfstand', 'es': 'Pokémon Boca Abajo', 'it': 'Pokémon Verticale', 'en': 'Handstand Pokémon', 'ja': 'さかだちポケモン', 'zh-Hans': '倒立宝可梦'}}
	public class SpecieHitmontop : PokemonSpecie
	{
#nullable enable
		private static SpecieHitmontop? _instance = null;
#nullable restore
        public static SpecieHitmontop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHitmontop();
                }
                return _instance;
            }
        }

		public SpecieHitmontop() : base(
			"Hitmontop",
			50, // HPs
			95, 95, // Attack & Defense
			35, 110, // Special Attack & Defense
			70			
		) {}
	}


	//Hitmontop Pokemon Class
	public class Hitmontop : Pokemon
	{

		public Hitmontop(string nickname, int level)
		: base(
				237,
				SpecieHitmontop.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hitmontop(int level)
		: base(
				237,
				SpecieHitmontop.Instance, // Pokemon Specie
				"Hitmontop", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hitmontop() : base(
			237,
			SpecieHitmontop.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}