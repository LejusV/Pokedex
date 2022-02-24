using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hitmonlee Specie to store common natural stats of every {'abilities': ['limber', 'reckless', 'unburden'], 'base_experience': 159, 'height': 15, 'id': 106, 'moves': ['mega-punch', 'double-kick', 'mega-kick', 'jump-kick', 'rolling-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'toxic', 'meditate', 'rage', 'mimic', 'double-team', 'focus-energy', 'bide', 'metronome', 'swift', 'skull-bash', 'high-jump-kick', 'rest', 'rock-slide', 'substitute', 'thief', 'mind-reader', 'snore', 'curse', 'reversal', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'blaze-kick', 'rock-tomb', 'bulk-up', 'bounce', 'covet', 'natural-gift', 'feint', 'close-combat', 'fling', 'sucker-punch', 'poison-jab', 'vacuum-wave', 'focus-blast', 'rock-climb', 'stone-edge', 'captivate', 'wide-guard', 'low-sweep', 'round', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'hitmonlee', 'stats': {'hp': 50, 'attack': 120, 'defense': 53, 'special-attack': 35, 'special-defense': 110, 'speed': 87}, 'types': ['fighting'], 'weight': 498, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 0, 'capture_rate': 45, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'サワムラー', 'roomaji': 'Sawamular', 'ko': '시라소몬', 'zh-Hant': '飛腿郎', 'fr': 'Kicklee', 'de': 'Kicklee', 'es': 'Hitmonlee', 'it': 'Hitmonlee', 'en': 'Hitmonlee', 'ja': 'サワムラー', 'zh-Hans': '飞腿郎'}, 'genera': {'ja-Hrkt': 'キックポケモン', 'ko': '킥포켓몬', 'zh-Hant': '踢腿寶可夢', 'fr': 'Pokémon Latteur', 'de': 'Kicker', 'es': 'Pokémon Patada', 'it': 'Pokémon Tiracalci', 'en': 'Kicking Pokémon', 'ja': 'キックポケモン', 'zh-Hans': '踢腿宝可梦'}}
	public class SpecieHitmonlee : PokemonSpecie
	{
#nullable enable
		private static SpecieHitmonlee? _instance = null;
#nullable restore
        public static SpecieHitmonlee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHitmonlee();
                }
                return _instance;
            }
        }

		public SpecieHitmonlee() : base(
			"Hitmonlee",
			50, // HPs
			120, 53, // Attack & Defense
			35, 110, // Special Attack & Defense
			87			
		) {}
	}


	//Hitmonlee Pokemon Class
	public class Hitmonlee : Pokemon
	{

		public Hitmonlee(string nickname, int level)
		: base(
				106,
				SpecieHitmonlee.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hitmonlee(int level)
		: base(
				106,
				SpecieHitmonlee.Instance, // Pokemon Specie
				"Hitmonlee", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hitmonlee() : base(
			106,
			SpecieHitmonlee.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}