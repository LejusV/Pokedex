using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mienshao Specie to store common natural stats of every {'abilities': ['inner-focus', 'regenerator', 'reckless'], 'base_experience': 179, 'height': 14, 'id': 620, 'moves': ['pound', 'double-slap', 'swords-dance', 'jump-kick', 'hyper-beam', 'low-kick', 'strength', 'dig', 'toxic', 'meditate', 'double-team', 'reflect', 'swift', 'high-jump-kick', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'detect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'rock-smash', 'fake-out', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'aerial-ace', 'bulk-up', 'bounce', 'calm-mind', 'u-turn', 'payback', 'fling', 'force-palm', 'aura-sphere', 'poison-jab', 'drain-punch', 'focus-blast', 'giga-impact', 'stone-edge', 'grass-knot', 'wide-guard', 'low-sweep', 'round', 'acrobatics', 'retaliate', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'mienshao', 'stats': {'hp': 65, 'attack': 125, 'defense': 60, 'special-attack': 95, 'special-defense': 60, 'speed': 105}, 'types': ['fighting'], 'weight': 355, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'コジョンド', 'ko': '비조도', 'zh-Hant': '師父鼬', 'fr': 'Shaofouine', 'de': 'Wie-Shu', 'es': 'Mienshao', 'it': 'Mienshao', 'en': 'Mienshao', 'ja': 'コジョンド', 'zh-Hans': '师父鼬'}, 'genera': {'ja-Hrkt': 'ぶじゅつポケモン', 'ko': '무술포켓몬', 'zh-Hant': '武術寶可夢', 'fr': 'Pokémon Art Martial', 'de': 'Kampfkünste', 'es': 'Pokémon Arte Marcial', 'it': 'Pokémon Marziale', 'en': 'Martial Arts Pokémon', 'ja': 'ぶじゅつポケモン', 'zh-Hans': '武术宝可梦'}}
	public class SpecieMienshao : PokemonSpecie
	{
#nullable enable
		private static SpecieMienshao? _instance = null;
#nullable restore
        public static SpecieMienshao Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMienshao();
                }
                return _instance;
            }
        }

		public SpecieMienshao() : base(
			"Mienshao",
			65, // HPs
			125, 60, // Attack & Defense
			95, 60, // Special Attack & Defense
			105			
		) {}
	}


	//Mienshao Pokemon Class
	public class Mienshao : Pokemon
	{

		public Mienshao(string nickname, int level)
		: base(
				620,
				SpecieMienshao.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mienshao(int level)
		: base(
				620,
				SpecieMienshao.Instance, // Pokemon Specie
				"Mienshao", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mienshao() : base(
			620,
			SpecieMienshao.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}