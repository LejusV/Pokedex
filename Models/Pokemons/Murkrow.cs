using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Murkrow Specie to store common natural stats of every {'abilities': ['insomnia', 'super-luck', 'prankster'], 'base_experience': 81, 'height': 5, 'id': 198, 'moves': ['wing-attack', 'whirlwind', 'fly', 'double-edge', 'peck', 'drill-peck', 'thunder-wave', 'toxic', 'psychic', 'quick-attack', 'night-shade', 'mimic', 'screech', 'double-team', 'confuse-ray', 'haze', 'mirror-move', 'swift', 'dream-eater', 'sky-attack', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'mud-slap', 'perish-song', 'icy-wind', 'detect', 'endure', 'swagger', 'steel-wing', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'flatter', 'facade', 'taunt', 'snatch', 'secret-power', 'feather-dance', 'astonish', 'air-cutter', 'aerial-ace', 'calm-mind', 'roost', 'natural-gift', 'pluck', 'tailwind', 'payback', 'assurance', 'embargo', 'psycho-shift', 'punishment', 'sucker-punch', 'dark-pulse', 'brave-bird', 'defog', 'captivate', 'ominous-wind', 'foul-play', 'round', 'quash', 'retaliate', 'snarl', 'confide'], 'name': 'murkrow', 'stats': {'hp': 60, 'attack': 85, 'defense': 42, 'special-attack': 85, 'special-defense': 42, 'speed': 91}, 'types': ['dark', 'flying'], 'weight': 21, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'black', 'shape': 'wings', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ヤミカラス', 'roomaji': 'Yamikarasu', 'ko': '니로우', 'zh-Hant': '黑暗鴉', 'fr': 'Cornèbre', 'de': 'Kramurx', 'es': 'Murkrow', 'it': 'Murkrow', 'en': 'Murkrow', 'ja': 'ヤミカラス', 'zh-Hans': '黑暗鸦'}, 'genera': {'ja-Hrkt': 'くらやみポケモン', 'ko': '어둠포켓몬', 'zh-Hant': '黑暗寶可夢', 'fr': 'Pokémon Obscurité', 'de': 'Finsternis', 'es': 'Pokémon Oscuridad', 'it': 'Pokémon Oscurità', 'en': 'Darkness Pokémon', 'ja': 'くらやみポケモン', 'zh-Hans': '黑暗宝可梦'}}
	public class SpecieMurkrow : PokemonSpecie
	{
#nullable enable
		private static SpecieMurkrow? _instance = null;
#nullable restore
        public static SpecieMurkrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMurkrow();
                }
                return _instance;
            }
        }

		public SpecieMurkrow() : base(
			"Murkrow",
			60, // HPs
			85, 42, // Attack & Defense
			85, 42, // Special Attack & Defense
			91			
		) {}
	}


	//Murkrow Pokemon Class
	public class Murkrow : Pokemon
	{

		public Murkrow(string nickname, int level) : base(
			198,
			SpecieMurkrow.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Flying.Instance			
		) {}

		public Murkrow() : base(
			198,
			SpecieMurkrow.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
	}
}