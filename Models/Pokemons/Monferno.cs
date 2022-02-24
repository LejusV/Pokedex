using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Monferno Specie to store common natural stats of every {'abilities': ['blaze', 'iron-fist'], 'base_experience': 142, 'height': 9, 'id': 391, 'moves': ['fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'headbutt', 'leer', 'ember', 'flamethrower', 'low-kick', 'strength', 'fire-spin', 'dig', 'toxic', 'double-team', 'fire-blast', 'swift', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'flame-wheel', 'snore', 'protect', 'mach-punch', 'mud-slap', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'brick-break', 'endeavor', 'secret-power', 'slack-off', 'overheat', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'natural-gift', 'feint', 'u-turn', 'close-combat', 'fling', 'flare-blitz', 'poison-jab', 'vacuum-wave', 'focus-blast', 'shadow-claw', 'rock-climb', 'gunk-shot', 'captivate', 'stealth-rock', 'grass-knot', 'hone-claws', 'flame-charge', 'low-sweep', 'round', 'incinerate', 'acrobatics', 'retaliate', 'fire-pledge', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'monferno', 'stats': {'hp': 64, 'attack': 78, 'defense': 52, 'special-attack': 78, 'special-defense': 52, 'speed': 81}, 'types': ['fire', 'fighting'], 'weight': 220, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'モウカザル', 'roomaji': 'Mōkazaru', 'ko': '파이숭이', 'zh-Hant': '猛火猴', 'fr': 'Chimpenfeu', 'de': 'Panpyro', 'es': 'Monferno', 'it': 'Monferno', 'en': 'Monferno', 'ja': 'モウカザル', 'zh-Hans': '猛火猴'}, 'genera': {'ja-Hrkt': 'やんちゃポケモン', 'ko': '개구쟁이포켓몬', 'zh-Hant': '頑皮寶可夢', 'fr': 'Pokémon Garnement', 'de': 'Verspielt', 'es': 'Pokémon Juguetón', 'it': 'Pokémon Briccone', 'en': 'Playful Pokémon', 'ja': 'やんちゃポケモン', 'zh-Hans': '顽皮宝可梦'}}
	public class SpecieMonferno : PokemonSpecie
	{
#nullable enable
		private static SpecieMonferno? _instance = null;
#nullable restore
        public static SpecieMonferno Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMonferno();
                }
                return _instance;
            }
        }

		public SpecieMonferno() : base(
			"Monferno",
			64, // HPs
			78, 52, // Attack & Defense
			78, 52, // Special Attack & Defense
			81			
		) {}
	}


	//Monferno Pokemon Class
	public class Monferno : Pokemon
	{

		public Monferno(string nickname, int level)
		: base(
				391,
				SpecieMonferno.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Monferno() : base(
			391,
			SpecieMonferno.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
	}
}