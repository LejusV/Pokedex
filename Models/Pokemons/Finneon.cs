using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Finneon Specie to store common natural stats of every {'abilities': ['swift-swim', 'storm-drain', 'water-veil'], 'base_experience': 66, 'height': 4, 'id': 456, 'moves': ['pound', 'gust', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'aurora-beam', 'toxic', 'agility', 'double-team', 'confuse-ray', 'waterfall', 'swift', 'flash', 'splash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sweet-kiss', 'icy-wind', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'twister', 'rain-dance', 'psych-up', 'whirlpool', 'hail', 'facade', 'nature-power', 'secret-power', 'dive', 'air-cutter', 'silver-wind', 'tickle', 'signal-beam', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'tailwind', 'u-turn', 'payback', 'aqua-ring', 'aqua-tail', 'defog', 'captivate', 'ominous-wind', 'soak', 'round', 'scald', 'confide'], 'name': 'finneon', 'stats': {'hp': 49, 'attack': 49, 'defense': 56, 'special-attack': 49, 'special-defense': 61, 'speed': 66}, 'types': ['water'], 'weight': 70, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ケイコウオ', 'roomaji': 'Keikouo', 'ko': '형광어', 'zh-Hant': '螢光魚', 'fr': 'Écayon', 'de': 'Finneon', 'es': 'Finneon', 'it': 'Finneon', 'en': 'Finneon', 'ja': 'ケイコウオ', 'zh-Hans': '荧光鱼'}, 'genera': {'ja-Hrkt': 'はねうおポケモン', 'ko': '비어포켓몬', 'zh-Hant': '飛翅魚寶可夢', 'fr': 'Pokémon Poisson Ailé', 'de': 'Flügelfisch', 'es': 'Pokémon Pez Ala', 'it': 'Pokémon Pescealato', 'en': 'Wing Fish Pokémon', 'ja': 'はねうおポケモン', 'zh-Hans': '飞翅鱼宝可梦'}}
	public class SpecieFinneon : PokemonSpecie
	{
#nullable enable
		private static SpecieFinneon? _instance = null;
#nullable restore
        public static SpecieFinneon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFinneon();
                }
                return _instance;
            }
        }

		public SpecieFinneon() : base(
			"Finneon",
			49, // HPs
			49, 56, // Attack & Defense
			49, 61, // Special Attack & Defense
			66			
		) {}
	}


	//Finneon Pokemon Class
	public class Finneon : Pokemon
	{

		public Finneon(string nickname, int level)
		: base(
				456,
				SpecieFinneon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Finneon(int level)
		: base(
				456,
				SpecieFinneon.Instance, // Pokemon Specie
				"Finneon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Finneon() : base(
			456,
			SpecieFinneon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}