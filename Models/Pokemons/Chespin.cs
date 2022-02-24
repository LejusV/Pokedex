using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chespin Specie to store common natural stats of every {'abilities': ['overgrow', 'bulletproof'], 'base_experience': 63, 'height': 4, 'id': 650, 'moves': ['thunder-punch', 'swords-dance', 'cut', 'vine-whip', 'tackle', 'body-slam', 'take-down', 'pin-missile', 'bite', 'growl', 'roar', 'low-kick', 'strength', 'leech-seed', 'solar-beam', 'dig', 'toxic', 'double-team', 'defense-curl', 'reflect', 'flash', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'curse', 'protect', 'belly-drum', 'sludge-bomb', 'spikes', 'giga-drain', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'bulk-up', 'mud-shot', 'gyro-ball', 'payback', 'fling', 'worry-seed', 'poison-jab', 'seed-bomb', 'drain-punch', 'energy-ball', 'shadow-claw', 'zen-headbutt', 'iron-head', 'stone-edge', 'grass-knot', 'wood-hammer', 'smack-down', 'low-sweep', 'round', 'quick-guard', 'retaliate', 'grass-pledge', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'chespin', 'stats': {'hp': 56, 'attack': 61, 'defense': 65, 'special-attack': 48, 'special-defense': 45, 'speed': 38}, 'types': ['grass'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ハリマロン', 'ko': '도치마론', 'zh-Hant': '哈力栗', 'fr': 'Marisson', 'de': 'Igamaro', 'es': 'Chespin', 'it': 'Chespin', 'en': 'Chespin', 'ja': 'ハリマロン', 'zh-Hans': '哈力栗'}, 'genera': {'ja-Hrkt': 'いがぐりポケモン', 'ko': '밤송이포켓몬', 'zh-Hant': '刺栗寶可夢', 'fr': 'Pokémon Bogue', 'de': 'Stachelkopf', 'es': 'Pokémon Erizo', 'it': 'Pokémon Castanriccio', 'en': 'Spiny Nut Pokémon', 'ja': 'いがぐりポケモン', 'zh-Hans': '刺栗宝可梦'}}
	public class SpecieChespin : PokemonSpecie
	{
#nullable enable
		private static SpecieChespin? _instance = null;
#nullable restore
        public static SpecieChespin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChespin();
                }
                return _instance;
            }
        }

		public SpecieChespin() : base(
			"Chespin",
			56, // HPs
			61, 65, // Attack & Defense
			48, 45, // Special Attack & Defense
			38			
		) {}
	}


	//Chespin Pokemon Class
	public class Chespin : Pokemon
	{

		public Chespin(string nickname, int level)
		: base(
				650,
				SpecieChespin.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chespin() : base(
			650,
			SpecieChespin.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}