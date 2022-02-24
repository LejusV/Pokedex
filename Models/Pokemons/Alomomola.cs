using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Alomomola Specie to store common natural stats of every {'abilities': ['healer', 'hydration', 'regenerator'], 'base_experience': 165, 'height': 12, 'id': 594, 'moves': ['pound', 'double-slap', 'mist', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'toxic', 'psychic', 'double-team', 'light-screen', 'waterfall', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'mirror-coat', 'psych-up', 'shadow-ball', 'whirlpool', 'hail', 'facade', 'helping-hand', 'wish', 'magic-coat', 'knock-off', 'refresh', 'secret-power', 'dive', 'tickle', 'bounce', 'water-sport', 'calm-mind', 'water-pulse', 'wake-up-slap', 'healing-wish', 'brine', 'aqua-ring', 'aqua-jet', 'wide-guard', 'soak', 'round', 'scald', 'heal-pulse', 'play-nice', 'confide'], 'name': 'alomomola', 'stats': {'hp': 165, 'attack': 75, 'defense': 80, 'special-attack': 40, 'special-defense': 45, 'speed': 65}, 'types': ['water'], 'weight': 316, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 75, 'color': 'pink', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'fast', 'egg_groups': ['water1', 'water2'], 'names': {'ja-Hrkt': 'ママンボウ', 'ko': '맘복치', 'zh-Hant': '保母曼波', 'fr': 'Mamanbo', 'de': 'Mamolida', 'es': 'Alomomola', 'it': 'Alomomola', 'en': 'Alomomola', 'ja': 'ママンボウ', 'zh-Hans': '保姆曼波'}, 'genera': {'ja-Hrkt': 'かいほうポケモン', 'ko': '돌보기포켓몬', 'zh-Hant': '看護寶可夢', 'fr': 'Pokémon Soigneur', 'de': 'Fürsorge', 'es': 'Pokémon Socorrista', 'it': 'Pokémon Assistenza', 'en': 'Caring Pokémon', 'ja': 'かいほうポケモン', 'zh-Hans': '看护宝可梦'}}
	public class SpecieAlomomola : PokemonSpecie
	{
#nullable enable
		private static SpecieAlomomola? _instance = null;
#nullable restore
        public static SpecieAlomomola Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAlomomola();
                }
                return _instance;
            }
        }

		public SpecieAlomomola() : base(
			"Alomomola",
			165, // HPs
			75, 80, // Attack & Defense
			40, 45, // Special Attack & Defense
			65			
		) {}
	}


	//Alomomola Pokemon Class
	public class Alomomola : Pokemon
	{

		public Alomomola(string nickname, int level)
		: base(
				594,
				SpecieAlomomola.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Alomomola(int level)
		: base(
				594,
				SpecieAlomomola.Instance, // Pokemon Specie
				"Alomomola", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Alomomola() : base(
			594,
			SpecieAlomomola.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}