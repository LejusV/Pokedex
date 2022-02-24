using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kadabra Specie to store common natural stats of every {'abilities': ['synchronize', 'inner-focus', 'magic-guard'], 'base_experience': 140, 'height': 13, 'id': 64, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'disable', 'psybeam', 'submission', 'counter', 'seismic-toss', 'thunder-wave', 'dig', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'bide', 'metronome', 'skull-bash', 'kinesis', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'miracle-eye', 'natural-gift', 'embargo', 'fling', 'drain-punch', 'energy-ball', 'psycho-cut', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'ally-switch', 'confide', 'dazzling-gleam'], 'name': 'kadabra', 'stats': {'hp': 40, 'attack': 35, 'defense': 30, 'special-attack': 120, 'special-defense': 70, 'speed': 105}, 'types': ['psychic'], 'weight': 565, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 100, 'color': 'brown', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ユンゲラー', 'roomaji': 'Yungerer', 'ko': '윤겔라', 'zh-Hant': '勇基拉', 'fr': 'Kadabra', 'de': 'Kadabra', 'es': 'Kadabra', 'it': 'Kadabra', 'en': 'Kadabra', 'ja': 'ユンゲラー', 'zh-Hans': '勇基拉'}, 'genera': {'ja-Hrkt': 'ねんりきポケモン', 'ko': '초능력포켓몬', 'zh-Hant': '念力寶可夢', 'fr': 'Pokémon Psy', 'de': 'Psi', 'es': 'Pokémon Psi', 'it': 'Pokémon Psico', 'en': 'Psi Pokémon', 'ja': 'ねんりきポケモン', 'zh-Hans': '念力宝可梦'}}
	public class SpecieKadabra : PokemonSpecie
	{
#nullable enable
		private static SpecieKadabra? _instance = null;
#nullable restore
        public static SpecieKadabra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKadabra();
                }
                return _instance;
            }
        }

		public SpecieKadabra() : base(
			"Kadabra",
			40, // HPs
			35, 30, // Attack & Defense
			120, 70, // Special Attack & Defense
			105			
		) {}
	}


	//Kadabra Pokemon Class
	public class Kadabra : Pokemon
	{

		public Kadabra(string nickname, int level)
		: base(
				64,
				SpecieKadabra.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kadabra(int level)
		: base(
				64,
				SpecieKadabra.Instance, // Pokemon Specie
				"Kadabra", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kadabra() : base(
			64,
			SpecieKadabra.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}