using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pikipek Specie to store common natural stats of every {'abilities': ['keen-eye', 'skill-link', 'pickup'], 'base_experience': 53, 'height': 3, 'id': 731, 'moves': ['swords-dance', 'fly', 'fury-attack', 'growl', 'supersonic', 'peck', 'drill-peck', 'toxic', 'screech', 'double-team', 'mirror-move', 'rest', 'substitute', 'thief', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'brick-break', 'feather-dance', 'hyper-voice', 'bullet-seed', 'aerial-ace', 'roost', 'pluck', 'tailwind', 'u-turn', 'brave-bird', 'smack-down', 'flame-charge', 'round', 'echoed-voice', 'work-up', 'boomburst', 'confide'], 'name': 'pikipek', 'stats': {'hp': 35, 'attack': 75, 'defense': 30, 'special-attack': 30, 'special-defense': 30, 'speed': 65}, 'types': ['normal', 'flying'], 'weight': 12, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'black', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ツツケラ', 'ko': '콕코구리', 'zh-Hant': '小篤兒', 'fr': 'Picassaut', 'de': 'Peppeck', 'es': 'Pikipek', 'it': 'Pikipek', 'en': 'Pikipek', 'ja': 'ツツケラ', 'zh-Hans': '小笃儿'}, 'genera': {'ja-Hrkt': 'きつつきポケモン', 'ko': '딱따구리포켓몬', 'zh-Hant': '啄木鳥寶可夢', 'fr': 'Pokémon Pivert', 'de': 'Specht', 'es': 'Pokémon Carpintero', 'it': 'Pokémon Picchio', 'en': 'Woodpecker Pokémon', 'ja': 'きつつきポケモン', 'zh-Hans': '啄木鸟宝可梦'}}
	public class SpeciePikipek : PokemonSpecie
	{
#nullable enable
		private static SpeciePikipek? _instance = null;
#nullable restore
        public static SpeciePikipek Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePikipek();
                }
                return _instance;
            }
        }

		public SpeciePikipek() : base(
			"Pikipek",
			35, // HPs
			75, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			65			
		) {}
	}


	//Pikipek Pokemon Class
	public class Pikipek : Pokemon
	{

		public Pikipek(string nickname, int level)
		: base(
				731,
				SpeciePikipek.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pikipek(int level)
		: base(
				731,
				SpeciePikipek.Instance, // Pokemon Specie
				"Pikipek", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pikipek() : base(
			731,
			SpeciePikipek.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}