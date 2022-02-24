using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blaziken Specie to store common natural stats of every {'abilities': ['blaze', 'speed-boost'], 'base_experience': 239, 'height': 19, 'id': 257, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'double-kick', 'mega-kick', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'growl', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'peck', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'earthquake', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'focus-energy', 'mirror-move', 'fire-blast', 'swift', 'high-jump-kick', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'blaze-kick', 'blast-burn', 'overheat', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'bulk-up', 'bounce', 'natural-gift', 'fling', 'last-resort', 'flare-blitz', 'poison-jab', 'vacuum-wave', 'focus-blast', 'brave-bird', 'giga-impact', 'shadow-claw', 'rock-climb', 'stone-edge', 'captivate', 'hone-claws', 'flame-charge', 'low-sweep', 'round', 'echoed-voice', 'incinerate', 'acrobatics', 'fire-pledge', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'blaziken', 'stats': {'hp': 80, 'attack': 120, 'defense': 70, 'special-attack': 110, 'special-defense': 70, 'speed': 80}, 'types': ['fire', 'fighting'], 'weight': 520, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バシャーモ', 'roomaji': 'Bursyamo', 'ko': '번치코', 'zh-Hant': '火焰雞', 'fr': 'Braségali', 'de': 'Lohgock', 'es': 'Blaziken', 'it': 'Blaziken', 'en': 'Blaziken', 'ja': 'バシャーモ', 'zh-Hans': '火焰鸡'}, 'genera': {'ja-Hrkt': 'もうかポケモン', 'ko': '맹화포켓몬', 'zh-Hant': '猛火寶可夢', 'fr': 'Pokémon Ardent', 'de': 'Großbrand', 'es': 'Pokémon Llameante', 'it': 'Pokémon Vampe', 'en': 'Blaze Pokémon', 'ja': 'もうかポケモン', 'zh-Hans': '猛火宝可梦'}}
	public class SpecieBlaziken : PokemonSpecie
	{
#nullable enable
		private static SpecieBlaziken? _instance = null;
#nullable restore
        public static SpecieBlaziken Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlaziken();
                }
                return _instance;
            }
        }

		public SpecieBlaziken() : base(
			"Blaziken",
			80, // HPs
			120, 70, // Attack & Defense
			110, 70, // Special Attack & Defense
			80			
		) {}
	}


	//Blaziken Pokemon Class
	public class Blaziken : Pokemon
	{

		public Blaziken(string nickname, int level)
		: base(
				257,
				SpecieBlaziken.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blaziken(int level)
		: base(
				257,
				SpecieBlaziken.Instance, // Pokemon Specie
				"Blaziken", level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blaziken() : base(
			257,
			SpecieBlaziken.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
	}
}