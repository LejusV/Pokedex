using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carvanha Specie to store common natural stats of every {'abilities': ['rough-skin', 'speed-boost'], 'base_experience': 61, 'height': 8, 'id': 318, 'moves': ['take-down', 'thrash', 'double-edge', 'leer', 'bite', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'toxic', 'agility', 'rage', 'mimic', 'screech', 'double-team', 'focus-energy', 'waterfall', 'swift', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'destiny-bond', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'ancient-power', 'whirlpool', 'uproar', 'hail', 'torment', 'facade', 'taunt', 'secret-power', 'dive', 'poison-fang', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'payback', 'assurance', 'dark-pulse', 'ice-fang', 'zen-headbutt', 'captivate', 'aqua-jet', 'round', 'scald', 'retaliate', 'snarl', 'confide', 'psychic-fangs'], 'name': 'carvanha', 'stats': {'hp': 45, 'attack': 90, 'defense': 20, 'special-attack': 65, 'special-defense': 20, 'speed': 65}, 'types': ['water', 'dark'], 'weight': 208, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'red', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'キバニア', 'roomaji': 'Kibanha', 'ko': '샤프니아', 'zh-Hant': '利牙魚', 'fr': 'Carvanha', 'de': 'Kanivanha', 'es': 'Carvanha', 'it': 'Carvanha', 'en': 'Carvanha', 'ja': 'キバニア', 'zh-Hans': '利牙鱼'}, 'genera': {'ja-Hrkt': 'どうもうポケモン', 'ko': '사나움포켓몬', 'zh-Hant': '凶猛寶可夢', 'fr': 'Pokémon Féroce', 'de': 'Gnadenlos', 'es': 'Pokémon Feroz', 'it': 'Pokémon Feroce', 'en': 'Savage Pokémon', 'ja': 'どうもうポケモン', 'zh-Hans': '凶猛宝可梦'}}
	public class SpecieCarvanha : PokemonSpecie
	{
#nullable enable
		private static SpecieCarvanha? _instance = null;
#nullable restore
        public static SpecieCarvanha Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarvanha();
                }
                return _instance;
            }
        }

		public SpecieCarvanha() : base(
			"Carvanha",
			45, // HPs
			90, 20, // Attack & Defense
			65, 20, // Special Attack & Defense
			65			
		) {}
	}


	//Carvanha Pokemon Class
	public class Carvanha : Pokemon
	{

		public Carvanha(string nickname, int level)
		: base(
				318,
				SpecieCarvanha.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carvanha(int level)
		: base(
				318,
				SpecieCarvanha.Instance, // Pokemon Specie
				"Carvanha", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carvanha() : base(
			318,
			SpecieCarvanha.Instance, // Pokemon Specie
			Water.Instance, Dark.Instance			
		) {}
	}
}