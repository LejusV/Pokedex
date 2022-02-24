using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pumpkaboo-Average Specie to store common natural stats of every {'abilities': ['pickup', 'frisk', 'insomnia'], 'base_experience': 67, 'height': 4, 'id': 710, 'moves': ['disable', 'flamethrower', 'leech-seed', 'razor-leaf', 'solar-beam', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'light-screen', 'fire-blast', 'dream-eater', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'curse', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'destiny-bond', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'synthesis', 'hidden-power', 'sunny-day', 'shadow-ball', 'rock-smash', 'will-o-wisp', 'facade', 'nature-power', 'trick', 'role-play', 'magic-coat', 'skill-swap', 'secret-power', 'astonish', 'bullet-seed', 'gyro-ball', 'worry-seed', 'dark-pulse', 'seed-bomb', 'energy-ball', 'shadow-sneak', 'trick-room', 'grass-knot', 'charge-beam', 'flame-charge', 'foul-play', 'round', 'incinerate', 'bestow', 'trick-or-treat', 'confide'], 'name': 'pumpkaboo-average', 'stats': {'hp': 49, 'attack': 66, 'defense': 70, 'special-attack': 44, 'special-defense': 55, 'speed': 51}, 'types': ['ghost', 'grass'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'バケッチャ', 'ko': '호바귀', 'zh-Hant': '南瓜精', 'fr': 'Pitrouille', 'de': 'Irrbis', 'es': 'Pumpkaboo', 'it': 'Pumpkaboo', 'en': 'Pumpkaboo', 'ja': 'バケッチャ', 'zh-Hans': '南瓜精'}, 'genera': {'ja-Hrkt': 'かぼちゃポケモン', 'ko': '호박포켓몬', 'zh-Hant': '南瓜寶可夢', 'fr': 'Pokémon Citrouille', 'de': 'Kürbis', 'es': 'Pokémon Calabaza', 'it': 'Pokémon Zucca', 'en': 'Pumpkin Pokémon', 'ja': 'かぼちゃポケモン', 'zh-Hans': '南瓜宝可梦'}}
	public class SpeciePumpkabooAverage : PokemonSpecie
	{
#nullable enable
		private static SpeciePumpkabooAverage? _instance = null;
#nullable restore
        public static SpeciePumpkabooAverage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePumpkabooAverage();
                }
                return _instance;
            }
        }

		public SpeciePumpkabooAverage() : base(
			"Pumpkaboo-Average",
			49, // HPs
			66, 70, // Attack & Defense
			44, 55, // Special Attack & Defense
			51			
		) {}
	}


	//Pumpkaboo-Average Pokemon Class
	public class PumpkabooAverage : Pokemon
	{

		public PumpkabooAverage(string nickname, int level)
		: base(
				710,
				SpeciePumpkabooAverage.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public PumpkabooAverage(int level)
		: base(
				710,
				SpeciePumpkabooAverage.Instance, // Pokemon Specie
				"Pumpkaboo-Average", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public PumpkabooAverage() : base(
			710,
			SpeciePumpkabooAverage.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
	}
}