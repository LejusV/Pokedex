using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bergmite Specie to store common natural stats of every {'abilities': ['own-tempo', 'ice-body', 'sturdy'], 'base_experience': 61, 'height': 10, 'id': 712, 'moves': ['tackle', 'take-down', 'double-edge', 'bite', 'mist', 'surf', 'ice-beam', 'blizzard', 'strength', 'toxic', 'double-team', 'recover', 'harden', 'barrier', 'flash', 'rest', 'rock-slide', 'sharpen', 'substitute', 'snore', 'curse', 'powder-snow', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'hidden-power', 'rain-dance', 'mirror-coat', 'rock-smash', 'hail', 'facade', 'secret-power', 'ice-ball', 'rock-tomb', 'iron-defense', 'water-pulse', 'gyro-ball', 'rock-polish', 'avalanche', 'ice-fang', 'flash-cannon', 'stone-edge', 'after-you', 'round', 'frost-breath', 'confide'], 'name': 'bergmite', 'stats': {'hp': 55, 'attack': 69, 'defense': 85, 'special-attack': 32, 'special-defense': 35, 'speed': 28}, 'types': ['ice'], 'weight': 995, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'カチコール', 'ko': '꽁어름', 'zh-Hant': '冰寶', 'fr': 'Grelaçon', 'de': 'Arktip', 'es': 'Bergmite', 'it': 'Bergmite', 'en': 'Bergmite', 'ja': 'カチコール', 'zh-Hans': '冰宝'}, 'genera': {'ja-Hrkt': 'ひょうかいポケモン', 'ko': '얼음덩이포켓몬', 'zh-Hant': '冰塊寶可夢', 'fr': 'Pokémon Glaçon', 'de': 'Eisklumpen', 'es': 'Pokémon Témpano', 'it': 'Pokémon Ghiacciolo', 'en': 'Ice Chunk Pokémon', 'ja': 'ひょうかいポケモン', 'zh-Hans': '冰块宝可梦'}}
	public class SpecieBergmite : PokemonSpecie
	{
#nullable enable
		private static SpecieBergmite? _instance = null;
#nullable restore
        public static SpecieBergmite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBergmite();
                }
                return _instance;
            }
        }

		public SpecieBergmite() : base(
			"Bergmite",
			55, // HPs
			69, 85, // Attack & Defense
			32, 35, // Special Attack & Defense
			28			
		) {}
	}


	//Bergmite Pokemon Class
	public class Bergmite : Pokemon
	{

		public Bergmite(string nickname, int level)
		: base(
				712,
				SpecieBergmite.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bergmite() : base(
			712,
			SpecieBergmite.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}