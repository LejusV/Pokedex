using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Trumbeak Specie to store common natural stats of every {'abilities': ['keen-eye', 'skill-link', 'pickup'], 'base_experience': 124, 'height': 6, 'id': 732, 'moves': ['swords-dance', 'fly', 'fury-attack', 'growl', 'supersonic', 'peck', 'drill-peck', 'toxic', 'screech', 'double-team', 'rest', 'substitute', 'thief', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'rock-smash', 'brick-break', 'feather-dance', 'hyper-voice', 'bullet-seed', 'aerial-ace', 'rock-blast', 'roost', 'pluck', 'u-turn', 'smack-down', 'flame-charge', 'round', 'echoed-voice', 'work-up', 'confide'], 'name': 'trumbeak', 'stats': {'hp': 55, 'attack': 85, 'defense': 50, 'special-attack': 40, 'special-defense': 50, 'speed': 75}, 'types': ['normal', 'flying'], 'weight': 148, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'black', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ケララッパ', 'ko': '크라파', 'zh-Hant': '喇叭啄鳥', 'fr': 'Piclairon', 'de': 'Trompeck', 'es': 'Trumbeak', 'it': 'Trumbeak', 'en': 'Trumbeak', 'ja': 'ケララッパ', 'zh-Hans': '喇叭啄鸟'}, 'genera': {'ja-Hrkt': 'ラッパぐちポケモン', 'ko': '나팔입포켓몬', 'zh-Hant': '喇叭喙寶可夢', 'fr': 'Pokémon Bec Clairon', 'de': 'Trompete', 'es': 'Pokémon Trompeta', 'it': 'Pokémon Trombecco', 'en': 'Bugle Beak Pokémon', 'ja': 'ラッパぐちポケモン', 'zh-Hans': '喇叭喙宝可梦'}}
	public class SpecieTrumbeak : PokemonSpecie
	{
#nullable enable
		private static SpecieTrumbeak? _instance = null;
#nullable restore
        public static SpecieTrumbeak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrumbeak();
                }
                return _instance;
            }
        }

		public SpecieTrumbeak() : base(
			"Trumbeak",
			55, // HPs
			85, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75			
		) {}
	}


	//Trumbeak Pokemon Class
	public class Trumbeak : Pokemon
	{

		public Trumbeak(string nickname, int level)
		: base(
				732,
				SpecieTrumbeak.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Trumbeak(int level)
		: base(
				732,
				SpecieTrumbeak.Instance, // Pokemon Specie
				"Trumbeak", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Trumbeak() : base(
			732,
			SpecieTrumbeak.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}