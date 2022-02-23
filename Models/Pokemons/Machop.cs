using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Machop Specie to store common natural stats of every {'abilities': ['guts', 'no-guard', 'steadfast'], 'base_experience': 61, 'height': 8, 'id': 66, 'moves': ['karate-chop', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'rolling-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'flamethrower', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'meditate', 'rage', 'mimic', 'double-team', 'light-screen', 'focus-energy', 'bide', 'metronome', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'encore', 'vital-throw', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'smelling-salts', 'helping-hand', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'tickle', 'bulk-up', 'wake-up-slap', 'natural-gift', 'close-combat', 'payback', 'fling', 'power-trick', 'poison-jab', 'vacuum-wave', 'focus-blast', 'bullet-punch', 'rock-climb', 'captivate', 'smack-down', 'heavy-slam', 'low-sweep', 'round', 'quick-guard', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'machop', 'stats': {'hp': 70, 'attack': 80, 'defense': 50, 'special-attack': 35, 'special-defense': 35, 'speed': 35}, 'types': ['fighting'], 'weight': 195, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 180, 'color': 'gray', 'shape': 'upright', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ワンリキー', 'roomaji': 'Wanriky', 'ko': '알통몬', 'zh-Hant': '腕力', 'fr': 'Machoc', 'de': 'Machollo', 'es': 'Machop', 'it': 'Machop', 'en': 'Machop', 'ja': 'ワンリキー', 'zh-Hans': '腕力'}, 'genera': {'ja-Hrkt': 'かいりきポケモン', 'ko': '괴력포켓몬', 'zh-Hant': '怪力寶可夢', 'fr': 'Pokémon Colosse', 'de': 'Kraftprotz', 'es': 'Pokémon Superpoder', 'it': 'Pokémon Megaforza', 'en': 'Superpower Pokémon', 'ja': 'かいりきポケモン', 'zh-Hans': '怪力宝可梦'}}
	public class SpecieMachop : PokemonSpecie
	{
#nullable enable
		private static SpecieMachop? _instance = null;
#nullable restore
        public static SpecieMachop Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMachop();
                }
                return _instance;
            }
        }

		public SpecieMachop() : base(
			"Machop",
			70, // HPs
			80, 50, // Attack & Defense
			35, 35, // Special Attack & Defense
			35			
		) {}
	}


	//Machop Pokemon Class
	public class Machop : Pokemon
	{

		public Machop(string nickname, int level) : base(
			66,
			SpecieMachop.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Machop() : base(
			66,
			SpecieMachop.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}