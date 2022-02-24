using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hariyama Specie to store common natural stats of every {'abilities': ['thick-fat', 'guts', 'sheer-force'], 'base_experience': 166, 'height': 23, 'id': 297, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'whirlwind', 'mega-kick', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'surf', 'hyper-beam', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'focus-energy', 'metronome', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'belly-drum', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'whirlpool', 'fake-out', 'facade', 'focus-punch', 'smelling-salts', 'helping-hand', 'role-play', 'superpower', 'brick-break', 'knock-off', 'secret-power', 'arm-thrust', 'rock-tomb', 'bulk-up', 'wake-up-slap', 'brine', 'natural-gift', 'close-combat', 'payback', 'fling', 'force-palm', 'poison-jab', 'vacuum-wave', 'focus-blast', 'giga-impact', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'smack-down', 'heavy-slam', 'low-sweep', 'round', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'hariyama', 'stats': {'hp': 144, 'attack': 120, 'defense': 60, 'special-attack': 40, 'special-defense': 60, 'speed': 50}, 'types': ['fighting'], 'weight': 2538, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 200, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ハリテヤマ', 'roomaji': 'Hariteyama', 'ko': '하리뭉', 'zh-Hant': '鐵掌力士', 'fr': 'Hariyama', 'de': 'Hariyama', 'es': 'Hariyama', 'it': 'Hariyama', 'en': 'Hariyama', 'ja': 'ハリテヤマ', 'zh-Hans': '铁掌力士'}, 'genera': {'ja-Hrkt': 'つっぱりポケモン', 'ko': '손바닥치기포켓몬', 'zh-Hant': '猛推寶可夢', 'fr': 'Pokémon Cogneur', 'de': 'Armwurf', 'es': 'Pokémon Empuje', 'it': 'Pokémon Sberletese', 'en': 'Arm Thrust Pokémon', 'ja': 'つっぱりポケモン', 'zh-Hans': '猛推宝可梦'}}
	public class SpecieHariyama : PokemonSpecie
	{
#nullable enable
		private static SpecieHariyama? _instance = null;
#nullable restore
        public static SpecieHariyama Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHariyama();
                }
                return _instance;
            }
        }

		public SpecieHariyama() : base(
			"Hariyama",
			144, // HPs
			120, 60, // Attack & Defense
			40, 60, // Special Attack & Defense
			50			
		) {}
	}


	//Hariyama Pokemon Class
	public class Hariyama : Pokemon
	{

		public Hariyama(string nickname, int level)
		: base(
				297,
				SpecieHariyama.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hariyama(int level)
		: base(
				297,
				SpecieHariyama.Instance, // Pokemon Specie
				"Hariyama", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hariyama() : base(
			297,
			SpecieHariyama.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}