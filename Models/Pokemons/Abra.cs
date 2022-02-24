using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Abra Specie to store common natural stats of every {'abilities': ['synchronize', 'inner-focus', 'magic-guard'], 'base_experience': 62, 'height': 9, 'id': 63, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'submission', 'counter', 'seismic-toss', 'thunder-wave', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'barrier', 'light-screen', 'reflect', 'bide', 'metronome', 'skull-bash', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'natural-gift', 'embargo', 'fling', 'psycho-shift', 'power-trick', 'guard-swap', 'drain-punch', 'energy-ball', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'guard-split', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'ally-switch', 'confide', 'dazzling-gleam', 'psychic-terrain'], 'name': 'abra', 'stats': {'hp': 25, 'attack': 20, 'defense': 15, 'special-attack': 105, 'special-defense': 55, 'speed': 90}, 'types': ['psychic'], 'weight': 195, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 200, 'color': 'brown', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'ケーシィ', 'roomaji': 'Casey', 'ko': '캐이시', 'zh-Hant': '凱西', 'fr': 'Abra', 'de': 'Abra', 'es': 'Abra', 'it': 'Abra', 'en': 'Abra', 'ja': 'ケーシィ', 'zh-Hans': '凯西'}, 'genera': {'ja-Hrkt': 'ねんりきポケモン', 'ko': '초능력포켓몬', 'zh-Hant': '念力寶可夢', 'fr': 'Pokémon Psy', 'de': 'Psi', 'es': 'Pokémon Psi', 'it': 'Pokémon Psico', 'en': 'Psi Pokémon', 'ja': 'ねんりきポケモン', 'zh-Hans': '念力宝可梦'}}
	public class SpecieAbra : PokemonSpecie
	{
#nullable enable
		private static SpecieAbra? _instance = null;
#nullable restore
        public static SpecieAbra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAbra();
                }
                return _instance;
            }
        }

		public SpecieAbra() : base(
			"Abra",
			25, // HPs
			20, 15, // Attack & Defense
			105, 55, // Special Attack & Defense
			90			
		) {}
	}


	//Abra Pokemon Class
	public class Abra : Pokemon
	{

		public Abra(string nickname, int level)
		: base(
				63,
				SpecieAbra.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Abra(int level)
		: base(
				63,
				SpecieAbra.Instance, // Pokemon Specie
				"Abra", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Abra() : base(
			63,
			SpecieAbra.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}