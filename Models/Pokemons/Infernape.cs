using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Infernape Specie to store common natural stats of every {'abilities': ['blaze', 'iron-fist'], 'base_experience': 240, 'height': 12, 'id': 392, 'moves': ['fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'headbutt', 'leer', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'fire-spin', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'swift', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'flame-wheel', 'snore', 'protect', 'mach-punch', 'mud-slap', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'brick-break', 'endeavor', 'secret-power', 'blast-burn', 'overheat', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'calm-mind', 'natural-gift', 'feint', 'u-turn', 'close-combat', 'fling', 'punishment', 'flare-blitz', 'poison-jab', 'vacuum-wave', 'focus-blast', 'giga-impact', 'shadow-claw', 'rock-climb', 'gunk-shot', 'stone-edge', 'captivate', 'stealth-rock', 'grass-knot', 'hone-claws', 'flame-charge', 'low-sweep', 'round', 'incinerate', 'acrobatics', 'retaliate', 'fire-pledge', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'infernape', 'stats': {'hp': 76, 'attack': 104, 'defense': 71, 'special-attack': 104, 'special-defense': 71, 'speed': 108}, 'types': ['fire', 'fighting'], 'weight': 550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'brown', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground', 'humanshape'], 'names': {'ja-Hrkt': 'ゴウカザル', 'roomaji': 'Gōkazaru', 'ko': '초염몽', 'zh-Hant': '烈焰猴', 'fr': 'Simiabraz', 'de': 'Panferno', 'es': 'Infernape', 'it': 'Infernape', 'en': 'Infernape', 'ja': 'ゴウカザル', 'zh-Hans': '烈焰猴'}, 'genera': {'ja-Hrkt': 'かえんポケモン', 'ko': '화염포켓몬', 'zh-Hant': '火焰寶可夢', 'fr': 'Pokémon Flamme', 'de': 'Flamme', 'es': 'Pokémon Llama', 'it': 'Pokémon Fiamma', 'en': 'Flame Pokémon', 'ja': 'かえんポケモン', 'zh-Hans': '火焰宝可梦'}}
	public class SpecieInfernape : PokemonSpecie
	{
#nullable enable
		private static SpecieInfernape? _instance = null;
#nullable restore
        public static SpecieInfernape Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieInfernape();
                }
                return _instance;
            }
        }

		public SpecieInfernape() : base(
			"Infernape",
			76, // HPs
			104, 71, // Attack & Defense
			104, 71, // Special Attack & Defense
			108			
		) {}
	}


	//Infernape Pokemon Class
	public class Infernape : Pokemon
	{

		public Infernape(string nickname, int level)
		: base(
				392,
				SpecieInfernape.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Infernape() : base(
			392,
			SpecieInfernape.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
	}
}