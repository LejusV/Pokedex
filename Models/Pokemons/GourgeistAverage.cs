using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gourgeist-Average Specie to store common natural stats of every {'abilities': ['pickup', 'frisk', 'insomnia'], 'base_experience': 173, 'height': 9, 'id': 711, 'moves': ['flamethrower', 'hyper-beam', 'leech-seed', 'razor-leaf', 'solar-beam', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'light-screen', 'fire-blast', 'dream-eater', 'flash', 'explosion', 'rest', 'rock-slide', 'substitute', 'thief', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'synthesis', 'hidden-power', 'sunny-day', 'shadow-ball', 'rock-smash', 'will-o-wisp', 'facade', 'nature-power', 'trick', 'role-play', 'magic-coat', 'skill-swap', 'secret-power', 'astonish', 'bullet-seed', 'gyro-ball', 'worry-seed', 'dark-pulse', 'seed-bomb', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-sneak', 'trick-room', 'grass-knot', 'charge-beam', 'flame-charge', 'foul-play', 'round', 'incinerate', 'phantom-force', 'trick-or-treat', 'confide'], 'name': 'gourgeist-average', 'stats': {'hp': 65, 'attack': 90, 'defense': 122, 'special-attack': 58, 'special-defense': 75, 'speed': 84}, 'types': ['ghost', 'grass'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'パンプジン', 'ko': '펌킨인', 'zh-Hant': '南瓜怪人', 'fr': 'Banshitrouye', 'de': 'Pumpdjinn', 'es': 'Gourgeist', 'it': 'Gourgeist', 'en': 'Gourgeist', 'ja': 'パンプジン', 'zh-Hans': '南瓜怪人'}, 'genera': {'ja-Hrkt': 'かぼちゃポケモン', 'ko': '호박포켓몬', 'zh-Hant': '南瓜寶可夢', 'fr': 'Pokémon Citrouille', 'de': 'Kürbis', 'es': 'Pokémon Calabaza', 'it': 'Pokémon Zucca', 'en': 'Pumpkin Pokémon', 'ja': 'かぼちゃポケモン', 'zh-Hans': '南瓜宝可梦'}}
	public class SpecieGourgeistAverage : PokemonSpecie
	{
#nullable enable
		private static SpecieGourgeistAverage? _instance = null;
#nullable restore
        public static SpecieGourgeistAverage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGourgeistAverage();
                }
                return _instance;
            }
        }

		public SpecieGourgeistAverage() : base(
			"Gourgeist-Average",
			65, // HPs
			90, 122, // Attack & Defense
			58, 75, // Special Attack & Defense
			84			
		) {}
	}


	//Gourgeist-Average Pokemon Class
	public class GourgeistAverage : Pokemon
	{

		public GourgeistAverage(string nickname, int level)
		: base(
				711,
				SpecieGourgeistAverage.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public GourgeistAverage() : base(
			711,
			SpecieGourgeistAverage.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
	}
}