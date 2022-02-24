using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chimchar Specie to store common natural stats of every {'abilities': ['blaze', 'iron-fist'], 'base_experience': 62, 'height': 5, 'id': 390, 'moves': ['fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'double-kick', 'headbutt', 'leer', 'ember', 'flamethrower', 'submission', 'low-kick', 'counter', 'strength', 'fire-spin', 'dig', 'toxic', 'double-team', 'focus-energy', 'fire-blast', 'swift', 'fury-swipes', 'rest', 'substitute', 'flame-wheel', 'snore', 'protect', 'mud-slap', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'fake-out', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'assist', 'brick-break', 'endeavor', 'secret-power', 'blaze-kick', 'slack-off', 'overheat', 'aerial-ace', 'bulk-up', 'covet', 'natural-gift', 'u-turn', 'fling', 'vacuum-wave', 'nasty-plot', 'shadow-claw', 'rock-climb', 'gunk-shot', 'captivate', 'stealth-rock', 'grass-knot', 'hone-claws', 'flame-charge', 'low-sweep', 'round', 'quick-guard', 'incinerate', 'acrobatics', 'fire-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'chimchar', 'stats': {'hp': 44, 'attack': 58, 'defense': 44, 'special-attack': 58, 'special-defense': 44, 'speed': 61}, 'types': ['fire'], 'weight': 62, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ヒコザル', 'roomaji': 'Hikozaru', 'ko': '불꽃숭이', 'zh-Hant': '小火焰猴', 'fr': 'Ouisticram', 'de': 'Panflam', 'es': 'Chimchar', 'it': 'Chimchar', 'en': 'Chimchar', 'ja': 'ヒコザル', 'zh-Hans': '小火焰猴'}, 'genera': {'ja-Hrkt': 'こざるポケモン', 'ko': '꼬마원숭이포켓몬', 'zh-Hant': '小猴寶可夢', 'fr': 'Pokémon Chimpanzé', 'de': 'Schimpanse', 'es': 'Pokémon Chimpancé', 'it': 'Pokémon Scimpanzé', 'en': 'Chimp Pokémon', 'ja': 'こざるポケモン', 'zh-Hans': '小猴宝可梦'}}
	public class SpecieChimchar : PokemonSpecie
	{
#nullable enable
		private static SpecieChimchar? _instance = null;
#nullable restore
        public static SpecieChimchar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChimchar();
                }
                return _instance;
            }
        }

		public SpecieChimchar() : base(
			"Chimchar",
			44, // HPs
			58, 44, // Attack & Defense
			58, 44, // Special Attack & Defense
			61			
		) {}
	}


	//Chimchar Pokemon Class
	public class Chimchar : Pokemon
	{

		public Chimchar(string nickname, int level)
		: base(
				390,
				SpecieChimchar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chimchar() : base(
			390,
			SpecieChimchar.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}