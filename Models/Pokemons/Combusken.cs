using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Combusken Specie to store common natural stats of every {'abilities': ['blaze', 'speed-boost'], 'base_experience': 142, 'height': 9, 'id': 256, 'moves': ['mega-punch', 'fire-punch', 'thunder-punch', 'scratch', 'swords-dance', 'cut', 'double-kick', 'mega-kick', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'growl', 'ember', 'flamethrower', 'peck', 'low-kick', 'counter', 'seismic-toss', 'strength', 'dig', 'toxic', 'quick-attack', 'mimic', 'double-team', 'focus-energy', 'mirror-move', 'fire-blast', 'swift', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'overheat', 'rock-tomb', 'sky-uppercut', 'aerial-ace', 'bulk-up', 'bounce', 'natural-gift', 'fling', 'last-resort', 'flare-blitz', 'poison-jab', 'vacuum-wave', 'focus-blast', 'shadow-claw', 'captivate', 'hone-claws', 'flame-charge', 'low-sweep', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'combusken', 'stats': {'hp': 60, 'attack': 85, 'defense': 60, 'special-attack': 85, 'special-defense': 60, 'speed': 55}, 'types': ['fire', 'fighting'], 'weight': 195, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ワカシャモ', 'roomaji': 'Wakasyamo', 'ko': '영치코', 'zh-Hant': '力壯雞', 'fr': 'Galifeu', 'de': 'Jungglut', 'es': 'Combusken', 'it': 'Combusken', 'en': 'Combusken', 'ja': 'ワカシャモ', 'zh-Hans': '力壮鸡'}, 'genera': {'ja-Hrkt': 'わかどりポケモン', 'ko': '꼬마닭포켓몬', 'zh-Hant': '幼雞寶可夢', 'fr': 'Pokémon Poulet', 'de': 'Kleinhahn', 'es': 'Pokémon Ave Corral', 'it': 'Pokémon Rampollo', 'en': 'Young Fowl Pokémon', 'ja': 'わかどりポケモン', 'zh-Hans': '幼鸡宝可梦'}}
	public class SpecieCombusken : PokemonSpecie
	{
#nullable enable
		private static SpecieCombusken? _instance = null;
#nullable restore
        public static SpecieCombusken Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCombusken();
                }
                return _instance;
            }
        }

		public SpecieCombusken() : base(
			"Combusken",
			60, // HPs
			85, 60, // Attack & Defense
			85, 60, // Special Attack & Defense
			55			
		) {}
	}


	//Combusken Pokemon Class
	public class Combusken : Pokemon
	{

		public Combusken(string nickname, int level) : base(
			256,
			SpecieCombusken.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Fighting.Instance			
		) {}

		public Combusken() : base(
			256,
			SpecieCombusken.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
	}
}