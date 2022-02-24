using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Quilava Specie to store common natural stats of every {'abilities': ['blaze', 'flash-fire'], 'base_experience': 142, 'height': 9, 'id': 156, 'moves': ['cut', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'leer', 'roar', 'ember', 'flamethrower', 'strength', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'smokescreen', 'defense-curl', 'fire-blast', 'swift', 'rest', 'substitute', 'flame-wheel', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'nature-power', 'brick-break', 'eruption', 'secret-power', 'overheat', 'aerial-ace', 'covet', 'natural-gift', 'lava-plume', 'captivate', 'flame-charge', 'round', 'incinerate', 'inferno', 'fire-pledge', 'work-up', 'wild-charge', 'confide', 'burn-up'], 'name': 'quilava', 'stats': {'hp': 58, 'attack': 64, 'defense': 58, 'special-attack': 80, 'special-defense': 65, 'speed': 80}, 'types': ['fire'], 'weight': 190, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'マグマラシ', 'roomaji': 'Magmarashi', 'ko': '마그케인', 'zh-Hant': '火岩鼠', 'fr': 'Feurisson', 'de': 'Igelavar', 'es': 'Quilava', 'it': 'Quilava', 'en': 'Quilava', 'ja': 'マグマラシ', 'zh-Hans': '火岩鼠'}, 'genera': {'ja-Hrkt': 'かざんポケモン', 'ko': '화산포켓몬', 'zh-Hant': '火山寶可夢', 'fr': 'Pokémon Volcan', 'de': 'Vulkan', 'es': 'Pokémon Volcán', 'it': 'Pokémon Vulcano', 'en': 'Volcano Pokémon', 'ja': 'かざんポケモン', 'zh-Hans': '火山宝可梦'}}
	public class SpecieQuilava : PokemonSpecie
	{
#nullable enable
		private static SpecieQuilava? _instance = null;
#nullable restore
        public static SpecieQuilava Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieQuilava();
                }
                return _instance;
            }
        }

		public SpecieQuilava() : base(
			"Quilava",
			58, // HPs
			64, 58, // Attack & Defense
			80, 65, // Special Attack & Defense
			80			
		) {}
	}


	//Quilava Pokemon Class
	public class Quilava : Pokemon
	{

		public Quilava(string nickname, int level)
		: base(
				156,
				SpecieQuilava.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Quilava(int level)
		: base(
				156,
				SpecieQuilava.Instance, // Pokemon Specie
				"Quilava", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Quilava() : base(
			156,
			SpecieQuilava.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}