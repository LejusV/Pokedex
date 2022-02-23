using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Machamp Specie to store common natural stats of every {'abilities': ['guts', 'no-guard', 'steadfast'], 'base_experience': 227, 'height': 16, 'id': 68, 'moves': ['karate-chop', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'flamethrower', 'hyper-beam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'light-screen', 'focus-energy', 'bide', 'metronome', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'vital-throw', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'bulk-up', 'wake-up-slap', 'natural-gift', 'payback', 'fling', 'poison-jab', 'vacuum-wave', 'focus-blast', 'giga-impact', 'rock-climb', 'stone-edge', 'captivate', 'wide-guard', 'smack-down', 'low-sweep', 'round', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'machamp', 'stats': {'hp': 90, 'attack': 130, 'defense': 80, 'special-attack': 65, 'special-defense': 85, 'speed': 55}, 'types': ['fighting'], 'weight': 1300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 45, 'color': 'gray', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'カイリキー', 'roomaji': 'Kairiky', 'ko': '괴력몬', 'zh-Hant': '怪力', 'fr': 'Mackogneur', 'de': 'Machomei', 'es': 'Machamp', 'it': 'Machamp', 'en': 'Machamp', 'ja': 'カイリキー', 'zh-Hans': '怪力'}, 'genera': {'ja-Hrkt': 'かいりきポケモン', 'ko': '괴력포켓몬', 'zh-Hant': '怪力寶可夢', 'fr': 'Pokémon Colosse', 'de': 'Kraftprotz', 'es': 'Pokémon Superpoder', 'it': 'Pokémon Megaforza', 'en': 'Superpower Pokémon', 'ja': 'かいりきポケモン', 'zh-Hans': '怪力宝可梦'}}
	public class SpecieMachamp : PokemonSpecie
	{
#nullable enable
		private static SpecieMachamp? _instance = null;
#nullable restore
        public static SpecieMachamp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMachamp();
                }
                return _instance;
            }
        }

		public SpecieMachamp() : base(
			"Machamp",
			90, // HPs
			130, 80, // Attack & Defense
			65, 85, // Special Attack & Defense
			55			
		) {}
	}


	//Machamp Pokemon Class
	public class Machamp : Pokemon
	{

		public Machamp(string nickname, int level) : base(
			68,
			SpecieMachamp.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Machamp() : base(
			68,
			SpecieMachamp.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}