using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bidoof Specie to store common natural stats of every {'abilities': ['simple', 'unaware', 'moody'], 'base_experience': 50, 'height': 5, 'id': 399, 'moves': ['swords-dance', 'cut', 'headbutt', 'tackle', 'take-down', 'double-edge', 'growl', 'ice-beam', 'blizzard', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'quick-attack', 'double-team', 'defense-curl', 'swift', 'skull-bash', 'amnesia', 'fury-swipes', 'rest', 'hyper-fang', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'facade', 'taunt', 'superpower', 'yawn', 'secret-power', 'mud-sport', 'odor-sleuth', 'covet', 'water-sport', 'shock-wave', 'natural-gift', 'pluck', 'last-resort', 'aqua-tail', 'rock-climb', 'captivate', 'stealth-rock', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'retaliate', 'work-up', 'confide'], 'name': 'bidoof', 'stats': {'hp': 59, 'attack': 45, 'defense': 40, 'special-attack': 35, 'special-defense': 40, 'speed': 31}, 'types': ['normal'], 'weight': 200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ビッパ', 'roomaji': 'Bipper', 'ko': '비버니', 'zh-Hant': '大牙狸', 'fr': 'Keunotor', 'de': 'Bidiza', 'es': 'Bidoof', 'it': 'Bidoof', 'en': 'Bidoof', 'ja': 'ビッパ', 'zh-Hans': '大牙狸'}, 'genera': {'ja-Hrkt': 'まるねずみポケモン', 'ko': '둥글쥐포켓몬', 'zh-Hant': '圓鼠寶可夢', 'fr': 'Pokémon Souridodue', 'de': 'Dickmaus', 'es': 'Pokémon Gran Ratón', 'it': 'Pokémon Topaffuto', 'en': 'Plump Mouse Pokémon', 'ja': 'まるねずみポケモン', 'zh-Hans': '圆鼠宝可梦'}}
	public class SpecieBidoof : PokemonSpecie
	{
#nullable enable
		private static SpecieBidoof? _instance = null;
#nullable restore
        public static SpecieBidoof Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBidoof();
                }
                return _instance;
            }
        }

		public SpecieBidoof() : base(
			"Bidoof",
			59, // HPs
			45, 40, // Attack & Defense
			35, 40, // Special Attack & Defense
			31			
		) {}
	}


	//Bidoof Pokemon Class
	public class Bidoof : Pokemon
	{

		public Bidoof(string nickname, int level)
		: base(
				399,
				SpecieBidoof.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bidoof(int level)
		: base(
				399,
				SpecieBidoof.Instance, // Pokemon Specie
				"Bidoof", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bidoof() : base(
			399,
			SpecieBidoof.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}