using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drowzee Specie to store common natural stats of every {'abilities': ['insomnia', 'forewarn', 'inner-focus'], 'base_experience': 66, 'height': 10, 'id': 96, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'disable', 'psybeam', 'submission', 'low-kick', 'counter', 'seismic-toss', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'meditate', 'rage', 'teleport', 'mimic', 'double-team', 'barrier', 'light-screen', 'reflect', 'bide', 'metronome', 'skull-bash', 'dream-eater', 'poison-gas', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'flatter', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'assist', 'magic-coat', 'recycle', 'brick-break', 'skill-swap', 'snatch', 'secret-power', 'signal-beam', 'calm-mind', 'wake-up-slap', 'natural-gift', 'fling', 'guard-swap', 'drain-punch', 'nasty-plot', 'psycho-cut', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'power-split', 'psyshock', 'telekinesis', 'magic-room', 'synchronoise', 'low-sweep', 'foul-play', 'round', 'confide', 'dazzling-gleam', 'power-up-punch', 'psychic-terrain'], 'name': 'drowzee', 'stats': {'hp': 60, 'attack': 48, 'defense': 45, 'special-attack': 43, 'special-defense': 90, 'speed': 42}, 'types': ['psychic'], 'weight': 324, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'humanoid', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'スリープ', 'roomaji': 'Sleep', 'ko': '슬리프', 'zh-Hant': '催眠貘', 'fr': 'Soporifik', 'de': 'Traumato', 'es': 'Drowzee', 'it': 'Drowzee', 'en': 'Drowzee', 'ja': 'スリープ', 'zh-Hans': '催眠貘'}, 'genera': {'ja-Hrkt': 'さいみんポケモン', 'ko': '최면포켓몬', 'zh-Hant': '催眠寶可夢', 'fr': 'Pokémon Hypnose', 'de': 'Hypnose', 'es': 'Pokémon Hipnosis', 'it': 'Pokémon Ipnosi', 'en': 'Hypnosis Pokémon', 'ja': 'さいみんポケモン', 'zh-Hans': '催眠宝可梦'}}
	public class SpecieDrowzee : PokemonSpecie
	{
#nullable enable
		private static SpecieDrowzee? _instance = null;
#nullable restore
        public static SpecieDrowzee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrowzee();
                }
                return _instance;
            }
        }

		public SpecieDrowzee() : base(
			"Drowzee",
			60, // HPs
			48, 45, // Attack & Defense
			43, 90, // Special Attack & Defense
			42			
		) {}
	}


	//Drowzee Pokemon Class
	public class Drowzee : Pokemon
	{

		public Drowzee(string nickname, int level) : base(
			96,
			SpecieDrowzee.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Drowzee() : base(
			96,
			SpecieDrowzee.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}