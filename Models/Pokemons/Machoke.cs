using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Machoke Specie to store common natural stats of every {'abilities': ['guts', 'no-guard', 'steadfast'], 'base_experience': 142, 'height': 15, 'id': 67, 'moves': ['karate-chop', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'leer', 'flamethrower', 'submission', 'low-kick', 'counter', 'seismic-toss', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'double-team', 'light-screen', 'focus-energy', 'bide', 'metronome', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'protect', 'scary-face', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'vital-throw', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'rock-smash', 'facade', 'focus-punch', 'helping-hand', 'role-play', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'bulk-up', 'wake-up-slap', 'natural-gift', 'payback', 'fling', 'poison-jab', 'vacuum-wave', 'focus-blast', 'rock-climb', 'captivate', 'smack-down', 'low-sweep', 'round', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'confide', 'power-up-punch'], 'name': 'machoke', 'stats': {'hp': 80, 'attack': 100, 'defense': 70, 'special-attack': 50, 'special-defense': 60, 'speed': 45}, 'types': ['fighting'], 'weight': 705, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 90, 'color': 'gray', 'shape': 'humanoid', 'habitat': 'mountain', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ゴーリキー', 'roomaji': 'Goriky', 'ko': '근육몬', 'zh-Hant': '豪力', 'fr': 'Machopeur', 'de': 'Maschock', 'es': 'Machoke', 'it': 'Machoke', 'en': 'Machoke', 'ja': 'ゴーリキー', 'zh-Hans': '豪力'}, 'genera': {'ja-Hrkt': 'かいりきポケモン', 'ko': '괴력포켓몬', 'zh-Hant': '怪力寶可夢', 'fr': 'Pokémon Colosse', 'de': 'Kraftprotz', 'es': 'Pokémon Superpoder', 'it': 'Pokémon Megaforza', 'en': 'Superpower Pokémon', 'ja': 'かいりきポケモン', 'zh-Hans': '怪力宝可梦'}}
	public class SpecieMachoke : PokemonSpecie
	{
#nullable enable
		private static SpecieMachoke? _instance = null;
#nullable restore
        public static SpecieMachoke Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMachoke();
                }
                return _instance;
            }
        }

		public SpecieMachoke() : base(
			"Machoke",
			80, // HPs
			100, 70, // Attack & Defense
			50, 60, // Special Attack & Defense
			45			
		) {}
	}


	//Machoke Pokemon Class
	public class Machoke : Pokemon
	{

		public Machoke(string nickname, int level) : base(
			67,
			SpecieMachoke.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Machoke() : base(
			67,
			SpecieMachoke.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}