using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meowstic-Male Specie to store common natural stats of every {'abilities': ['keen-eye', 'infiltrator', 'prankster'], 'base_experience': 163, 'height': 6, 'id': 678, 'moves': ['scratch', 'cut', 'leer', 'psybeam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'charm', 'swagger', 'mean-look', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'torment', 'facade', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'imprison', 'snatch', 'secret-power', 'signal-beam', 'covet', 'calm-mind', 'shock-wave', 'gravity', 'miracle-eye', 'payback', 'sucker-punch', 'dark-pulse', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'charge-beam', 'wonder-room', 'psyshock', 'magic-room', 'round', 'echoed-voice', 'quick-guard', 'work-up', 'disarming-voice', 'misty-terrain', 'confide', 'power-up-punch'], 'name': 'meowstic-male', 'stats': {'hp': 74, 'attack': 48, 'defense': 76, 'special-attack': 83, 'special-defense': 81, 'speed': 104}, 'types': ['psychic'], 'weight': 85, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニャオニクス', 'ko': '냐오닉스', 'zh-Hant': '超能妙喵', 'fr': 'Mistigrix', 'de': 'Psiaugon', 'es': 'Meowstic', 'it': 'Meowstic', 'en': 'Meowstic', 'ja': 'ニャオニクス', 'zh-Hans': '超能妙喵'}, 'genera': {'ja-Hrkt': 'よくせいポケモン', 'ko': '억제포켓몬', 'zh-Hant': '抑制寶可夢', 'fr': 'Pokémon SelfContrôle', 'de': 'Fassung', 'es': 'Pokémon Autocontrol', 'it': 'Pokémon Temperanza', 'en': 'Constraint Pokémon', 'ja': 'よくせいポケモン', 'zh-Hans': '抑制宝可梦'}}
	public class SpecieMeowsticMale : PokemonSpecie
	{
#nullable enable
		private static SpecieMeowsticMale? _instance = null;
#nullable restore
        public static SpecieMeowsticMale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeowsticMale();
                }
                return _instance;
            }
        }

		public SpecieMeowsticMale() : base(
			"Meowstic-Male",
			74, // HPs
			48, 76, // Attack & Defense
			83, 81, // Special Attack & Defense
			104			
		) {}
	}


	//Meowstic-Male Pokemon Class
	public class MeowsticMale : Pokemon
	{

		public MeowsticMale(string nickname, int level)
		: base(
				678,
				SpecieMeowsticMale.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MeowsticMale(int level)
		: base(
				678,
				SpecieMeowsticMale.Instance, // Pokemon Specie
				"Meowstic-Male", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MeowsticMale() : base(
			678,
			SpecieMeowsticMale.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}