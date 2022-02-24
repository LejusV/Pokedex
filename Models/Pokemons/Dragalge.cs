using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dragalge Specie to store common natural stats of every {'abilities': ['poison-point', 'poison-touch', 'adaptability'], 'base_experience': 173, 'height': 18, 'id': 691, 'moves': ['tackle', 'tail-whip', 'acid', 'water-gun', 'hydro-pump', 'surf', 'hyper-beam', 'thunderbolt', 'thunder', 'toxic', 'double-team', 'smokescreen', 'waterfall', 'bubble', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'icy-wind', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'shadow-ball', 'hail', 'facade', 'secret-power', 'dive', 'camouflage', 'bounce', 'poison-tail', 'shock-wave', 'water-pulse', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'giga-impact', 'draco-meteor', 'gunk-shot', 'venoshock', 'sludge-wave', 'round', 'scald', 'dragon-tail', 'confide'], 'name': 'dragalge', 'stats': {'hp': 65, 'attack': 75, 'defense': 90, 'special-attack': 97, 'special-defense': 123, 'speed': 44}, 'types': ['poison', 'dragon'], 'weight': 815, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 55, 'color': 'brown', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'ドラミドロ', 'ko': '드래캄', 'zh-Hant': '毒藻龍', 'fr': 'Kravarech', 'de': 'Tandrak', 'es': 'Dragalge', 'it': 'Dragalge', 'en': 'Dragalge', 'ja': 'ドラミドロ', 'zh-Hans': '毒藻龙'}, 'genera': {'ja-Hrkt': 'クサモドキポケモン', 'ko': '풀모방포켓몬', 'zh-Hant': '似草寶可夢', 'fr': 'Pokémon Simulalgue', 'de': 'Tangmimikry', 'es': 'Pokémon Pseudoalga', 'it': 'Pokémon Similalga', 'en': 'Mock Kelp Pokémon', 'ja': 'クサモドキポケモン', 'zh-Hans': '似草宝可梦'}}
	public class SpecieDragalge : PokemonSpecie
	{
#nullable enable
		private static SpecieDragalge? _instance = null;
#nullable restore
        public static SpecieDragalge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDragalge();
                }
                return _instance;
            }
        }

		public SpecieDragalge() : base(
			"Dragalge",
			65, // HPs
			75, 90, // Attack & Defense
			97, 123, // Special Attack & Defense
			44			
		) {}
	}


	//Dragalge Pokemon Class
	public class Dragalge : Pokemon
	{

		public Dragalge(string nickname, int level)
		: base(
				691,
				SpecieDragalge.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dragalge() : base(
			691,
			SpecieDragalge.Instance, // Pokemon Specie
			Poison.Instance, Dragon.Instance			
		) {}
	}
}