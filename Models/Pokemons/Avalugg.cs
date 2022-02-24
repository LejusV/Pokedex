using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Avalugg Specie to store common natural stats of every {'abilities': ['own-tempo', 'ice-body', 'sturdy'], 'base_experience': 180, 'height': 20, 'id': 713, 'moves': ['tackle', 'body-slam', 'take-down', 'double-edge', 'bite', 'roar', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'double-team', 'recover', 'harden', 'skull-bash', 'flash', 'rest', 'rock-slide', 'sharpen', 'substitute', 'snore', 'curse', 'powder-snow', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'rapid-spin', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'hail', 'facade', 'superpower', 'secret-power', 'ice-ball', 'rock-tomb', 'iron-defense', 'block', 'water-pulse', 'gyro-ball', 'rock-polish', 'giga-impact', 'avalanche', 'ice-fang', 'flash-cannon', 'iron-head', 'stone-edge', 'wide-guard', 'after-you', 'round', 'bulldoze', 'frost-breath', 'confide'], 'name': 'avalugg', 'stats': {'hp': 95, 'attack': 117, 'defense': 184, 'special-attack': 44, 'special-defense': 46, 'speed': 28}, 'types': ['ice'], 'weight': 5050, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 55, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'クレベース', 'ko': '크레베이스', 'zh-Hant': '冰岩怪', 'fr': 'Séracrawl', 'de': 'Arktilas', 'es': 'Avalugg', 'it': 'Avalugg', 'en': 'Avalugg', 'ja': 'クレベース', 'zh-Hans': '冰岩怪'}, 'genera': {'ja-Hrkt': 'ひょうざんポケモン', 'ko': '빙산포켓몬', 'zh-Hant': '冰山寶可夢', 'fr': 'Pokémon Iceberg', 'de': 'Eisberg', 'es': 'Pokémon Iceberg', 'it': 'Pokémon Iceberg', 'en': 'Iceberg Pokémon', 'ja': 'ひょうざんポケモン', 'zh-Hans': '冰山宝可梦'}}
	public class SpecieAvalugg : PokemonSpecie
	{
#nullable enable
		private static SpecieAvalugg? _instance = null;
#nullable restore
        public static SpecieAvalugg Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAvalugg();
                }
                return _instance;
            }
        }

		public SpecieAvalugg() : base(
			"Avalugg",
			95, // HPs
			117, 184, // Attack & Defense
			44, 46, // Special Attack & Defense
			28			
		) {}
	}


	//Avalugg Pokemon Class
	public class Avalugg : Pokemon
	{

		public Avalugg(string nickname, int level)
		: base(
				713,
				SpecieAvalugg.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Avalugg(int level)
		: base(
				713,
				SpecieAvalugg.Instance, // Pokemon Specie
				"Avalugg", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Avalugg() : base(
			713,
			SpecieAvalugg.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}