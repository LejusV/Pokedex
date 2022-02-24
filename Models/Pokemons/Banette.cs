using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Banette Specie to store common natural stats of every {'abilities': ['insomnia', 'frisk', 'cursed-body'], 'base_experience': 159, 'height': 11, 'id': 354, 'moves': ['headbutt', 'body-slam', 'double-edge', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'night-shade', 'mimic', 'screech', 'double-team', 'metronome', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'torment', 'will-o-wisp', 'facade', 'taunt', 'trick', 'role-play', 'magic-coat', 'knock-off', 'skill-swap', 'grudge', 'snatch', 'secret-power', 'calm-mind', 'shock-wave', 'natural-gift', 'payback', 'embargo', 'fling', 'sucker-punch', 'dark-pulse', 'giga-impact', 'shadow-claw', 'shadow-sneak', 'trick-room', 'captivate', 'charge-beam', 'ominous-wind', 'telekinesis', 'magic-room', 'foul-play', 'round', 'hex', 'phantom-force', 'confide', 'dazzling-gleam', 'infestation'], 'name': 'banette', 'stats': {'hp': 64, 'attack': 115, 'defense': 65, 'special-attack': 83, 'special-defense': 63, 'speed': 65}, 'types': ['ghost'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ジュペッタ', 'roomaji': 'Juppeta', 'ko': '다크펫', 'zh-Hant': '詛咒娃娃', 'fr': 'Branette', 'de': 'Banette', 'es': 'Banette', 'it': 'Banette', 'en': 'Banette', 'ja': 'ジュペッタ', 'zh-Hans': '诅咒娃娃'}, 'genera': {'ja-Hrkt': 'ぬいぐるみポケモン', 'ko': '봉제인형포켓몬', 'zh-Hant': '布偶寶可夢', 'fr': 'Pokémon Marionnette', 'de': 'Marionette', 'es': 'Pokémon Marioneta', 'it': 'Pokémon Marionetta', 'en': 'Marionette Pokémon', 'ja': 'ぬいぐるみポケモン', 'zh-Hans': '布偶宝可梦'}}
	public class SpecieBanette : PokemonSpecie
	{
#nullable enable
		private static SpecieBanette? _instance = null;
#nullable restore
        public static SpecieBanette Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBanette();
                }
                return _instance;
            }
        }

		public SpecieBanette() : base(
			"Banette",
			64, // HPs
			115, 65, // Attack & Defense
			83, 63, // Special Attack & Defense
			65			
		) {}
	}


	//Banette Pokemon Class
	public class Banette : Pokemon
	{

		public Banette(string nickname, int level)
		: base(
				354,
				SpecieBanette.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Banette() : base(
			354,
			SpecieBanette.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}