using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mienfoo Specie to store common natural stats of every {'abilities': ['inner-focus', 'regenerator', 'reckless'], 'base_experience': 70, 'height': 9, 'id': 619, 'moves': ['pound', 'double-slap', 'swords-dance', 'jump-kick', 'low-kick', 'strength', 'dig', 'toxic', 'meditate', 'double-team', 'reflect', 'swift', 'high-jump-kick', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'rock-smash', 'fake-out', 'facade', 'focus-punch', 'smelling-salts', 'taunt', 'helping-hand', 'role-play', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'aerial-ace', 'bulk-up', 'bounce', 'calm-mind', 'feint', 'u-turn', 'payback', 'fling', 'me-first', 'force-palm', 'aura-sphere', 'poison-jab', 'drain-punch', 'focus-blast', 'stone-edge', 'grass-knot', 'low-sweep', 'round', 'quick-guard', 'ally-switch', 'acrobatics', 'retaliate', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'mienfoo', 'stats': {'hp': 45, 'attack': 85, 'defense': 50, 'special-attack': 55, 'special-defense': 50, 'speed': 65}, 'types': ['fighting'], 'weight': 200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 180, 'color': 'yellow', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'コジョフー', 'ko': '비조푸', 'zh-Hant': '功夫鼬', 'fr': 'Kungfouine', 'de': 'Lin-Fu', 'es': 'Mienfoo', 'it': 'Mienfoo', 'en': 'Mienfoo', 'ja': 'コジョフー', 'zh-Hans': '功夫鼬'}, 'genera': {'ja-Hrkt': 'ぶじゅつポケモン', 'ko': '무술포켓몬', 'zh-Hant': '武術寶可夢', 'fr': 'Pokémon Art Martial', 'de': 'Kampfkünste', 'es': 'Pokémon Arte Marcial', 'it': 'Pokémon Marziale', 'en': 'Martial Arts Pokémon', 'ja': 'ぶじゅつポケモン', 'zh-Hans': '武术宝可梦'}}
	public class SpecieMienfoo : PokemonSpecie
	{
#nullable enable
		private static SpecieMienfoo? _instance = null;
#nullable restore
        public static SpecieMienfoo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMienfoo();
                }
                return _instance;
            }
        }

		public SpecieMienfoo() : base(
			"Mienfoo",
			45, // HPs
			85, 50, // Attack & Defense
			55, 50, // Special Attack & Defense
			65			
		) {}
	}


	//Mienfoo Pokemon Class
	public class Mienfoo : Pokemon
	{

		public Mienfoo(string nickname, int level)
		: base(
				619,
				SpecieMienfoo.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mienfoo() : base(
			619,
			SpecieMienfoo.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}