using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magby Specie to store common natural stats of every {'abilities': ['flame-body', 'vital-spirit'], 'base_experience': 73, 'height': 7, 'id': 240, 'moves': ['karate-chop', 'mega-punch', 'fire-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'leer', 'ember', 'flamethrower', 'counter', 'seismic-toss', 'fire-spin', 'toxic', 'psychic', 'mimic', 'screech', 'double-team', 'smokescreen', 'confuse-ray', 'barrier', 'focus-energy', 'smog', 'fire-blast', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mach-punch', 'feint-attack', 'belly-drum', 'mud-slap', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'iron-tail', 'hidden-power', 'cross-chop', 'sunny-day', 'rock-smash', 'uproar', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'helping-hand', 'brick-break', 'secret-power', 'overheat', 'covet', 'natural-gift', 'fling', 'power-swap', 'flare-blitz', 'lava-plume', 'captivate', 'flame-burst', 'flame-charge', 'round', 'clear-smog', 'incinerate', 'dual-chop', 'belch', 'confide', 'power-up-punch'], 'name': 'magby', 'stats': {'hp': 45, 'attack': 75, 'defense': 37, 'special-attack': 70, 'special-defense': 55, 'speed': 83}, 'types': ['fire'], 'weight': 214, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 2, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ブビィ', 'roomaji': 'Buby', 'ko': '마그비', 'zh-Hant': '鴨嘴寶寶', 'fr': 'Magby', 'de': 'Magby', 'es': 'Magby', 'it': 'Magby', 'en': 'Magby', 'ja': 'ブビィ', 'zh-Hans': '鸭嘴宝宝'}, 'genera': {'ja-Hrkt': 'ひだねポケモン', 'ko': '불씨포켓몬', 'zh-Hant': '火種寶可夢', 'fr': 'Pokémon Charbon', 'de': 'Glutherd', 'es': 'Pokémon Ascuas', 'it': 'Pokémon Carbonvivo', 'en': 'Live Coal Pokémon', 'ja': 'ひだねポケモン', 'zh-Hans': '火种宝可梦'}}
	public class SpecieMagby : PokemonSpecie
	{
#nullable enable
		private static SpecieMagby? _instance = null;
#nullable restore
        public static SpecieMagby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagby();
                }
                return _instance;
            }
        }

		public SpecieMagby() : base(
			"Magby",
			45, // HPs
			75, 37, // Attack & Defense
			70, 55, // Special Attack & Defense
			83			
		) {}
	}


	//Magby Pokemon Class
	public class Magby : Pokemon
	{

		public Magby(string nickname, int level) : base(
			240,
			SpecieMagby.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Magby() : base(
			240,
			SpecieMagby.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}