using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Alakazam Specie to store common natural stats of every {'abilities': ['synchronize', 'inner-focus', 'magic-guard'], 'base_experience': 225, 'height': 15, 'id': 65, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'disable', 'psybeam', 'hyper-beam', 'submission', 'counter', 'seismic-toss', 'thunder-wave', 'dig', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'bide', 'metronome', 'skull-bash', 'kinesis', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dynamic-punch', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'miracle-eye', 'natural-gift', 'embargo', 'fling', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'psycho-cut', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'foul-play', 'round', 'ally-switch', 'confide', 'dazzling-gleam'], 'name': 'alakazam', 'stats': {'hp': 55, 'attack': 50, 'defense': 45, 'special-attack': 135, 'special-defense': 95, 'speed': 120}, 'types': ['psychic'], 'weight': 480, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 2, 'capture_rate': 50, 'color': 'brown', 'shape': 'humanoid', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'フーディン', 'roomaji': 'Foodin', 'ko': '후딘', 'zh-Hant': '胡地', 'fr': 'Alakazam', 'de': 'Simsala', 'es': 'Alakazam', 'it': 'Alakazam', 'en': 'Alakazam', 'ja': 'フーディン', 'zh-Hans': '胡地'}, 'genera': {'ja-Hrkt': 'ねんりきポケモン', 'ko': '초능력포켓몬', 'zh-Hant': '念力寶可夢', 'fr': 'Pokémon Psy', 'de': 'Psi', 'es': 'Pokémon Psi', 'it': 'Pokémon Psico', 'en': 'Psi Pokémon', 'ja': 'ねんりきポケモン', 'zh-Hans': '念力宝可梦'}}
	public class SpecieAlakazam : PokemonSpecie
	{
#nullable enable
		private static SpecieAlakazam? _instance = null;
#nullable restore
        public static SpecieAlakazam Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAlakazam();
                }
                return _instance;
            }
        }

		public SpecieAlakazam() : base(
			"Alakazam",
			55, // HPs
			50, 45, // Attack & Defense
			135, 95, // Special Attack & Defense
			120			
		) {}
	}


	//Alakazam Pokemon Class
	public class Alakazam : Pokemon
	{

		public Alakazam(string nickname, int level)
		: base(
				65,
				SpecieAlakazam.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Alakazam(int level)
		: base(
				65,
				SpecieAlakazam.Instance, // Pokemon Specie
				"Alakazam", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Alakazam() : base(
			65,
			SpecieAlakazam.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}