using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vigoroth Specie to store common natural stats of every {'abilities': ['vital-spirit'], 'base_experience': 154, 'height': 14, 'id': 288, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'scratch', 'cut', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'roar', 'flamethrower', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'focus-energy', 'fire-blast', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'reversal', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'encore', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'focus-punch', 'taunt', 'brick-break', 'secret-power', 'rock-tomb', 'aerial-ace', 'bulk-up', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'sucker-punch', 'focus-blast', 'shadow-claw', 'rock-climb', 'gunk-shot', 'captivate', 'hone-claws', 'low-sweep', 'after-you', 'round', 'chip-away', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'vigoroth', 'stats': {'hp': 80, 'attack': 80, 'defense': 80, 'special-attack': 55, 'special-defense': 55, 'speed': 90}, 'types': ['normal'], 'weight': 465, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'white', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヤルキモノ', 'roomaji': 'Yarukimono', 'ko': '발바로', 'zh-Hant': '過動猿', 'fr': 'Vigoroth', 'de': 'Muntier', 'es': 'Vigoroth', 'it': 'Vigoroth', 'en': 'Vigoroth', 'ja': 'ヤルキモノ', 'zh-Hans': '过动猿'}, 'genera': {'ja-Hrkt': 'あばれザルポケモン', 'ko': '성난원숭이포켓몬', 'zh-Hant': '暴猿寶可夢', 'fr': 'Pokémon Turbusinge', 'de': 'Wildaffe', 'es': 'Pokémon Mono Feroz', 'it': 'Pokémon Indocile', 'en': 'Wild Monkey Pokémon', 'ja': 'あばれザルポケモン', 'zh-Hans': '暴猿宝可梦'}}
	public class SpecieVigoroth : PokemonSpecie
	{
#nullable enable
		private static SpecieVigoroth? _instance = null;
#nullable restore
        public static SpecieVigoroth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVigoroth();
                }
                return _instance;
            }
        }

		public SpecieVigoroth() : base(
			"Vigoroth",
			80, // HPs
			80, 80, // Attack & Defense
			55, 55, // Special Attack & Defense
			90			
		) {}
	}


	//Vigoroth Pokemon Class
	public class Vigoroth : Pokemon
	{

		public Vigoroth(string nickname, int level)
		: base(
				288,
				SpecieVigoroth.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vigoroth() : base(
			288,
			SpecieVigoroth.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}