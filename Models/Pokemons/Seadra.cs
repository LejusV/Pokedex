using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seadra Specie to store common natural stats of every {'abilities': ['poison-point', 'sniper', 'damp'], 'base_experience': 154, 'height': 12, 'id': 117, 'moves': ['headbutt', 'take-down', 'double-edge', 'leer', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'smokescreen', 'focus-energy', 'bide', 'waterfall', 'swift', 'skull-bash', 'bubble', 'rest', 'substitute', 'snore', 'curse', 'protect', 'icy-wind', 'outrage', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'signal-beam', 'bounce', 'dragon-dance', 'water-pulse', 'brine', 'natural-gift', 'dragon-pulse', 'giga-impact', 'flash-cannon', 'captivate', 'round', 'scald', 'confide'], 'name': 'seadra', 'stats': {'hp': 55, 'attack': 65, 'defense': 95, 'special-attack': 95, 'special-defense': 45, 'speed': 85}, 'types': ['water'], 'weight': 250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'シードラ', 'roomaji': 'Seadra', 'ko': '시드라', 'zh-Hant': '海刺龍', 'fr': 'Hypocéan', 'de': 'Seemon', 'es': 'Seadra', 'it': 'Seadra', 'en': 'Seadra', 'ja': 'シードラ', 'zh-Hans': '海刺龙'}, 'genera': {'ja-Hrkt': 'ドラゴンポケモン', 'ko': '드래곤포켓몬', 'zh-Hant': '龍寶可夢', 'fr': 'Pokémon Dragon', 'de': 'Drache', 'es': 'Pokémon Dragón', 'it': 'Pokémon Drago', 'en': 'Dragon Pokémon', 'ja': 'ドラゴンポケモン', 'zh-Hans': '龙宝可梦'}}
	public class SpecieSeadra : PokemonSpecie
	{
#nullable enable
		private static SpecieSeadra? _instance = null;
#nullable restore
        public static SpecieSeadra Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeadra();
                }
                return _instance;
            }
        }

		public SpecieSeadra() : base(
			"Seadra",
			55, // HPs
			65, 95, // Attack & Defense
			95, 45, // Special Attack & Defense
			85			
		) {}
	}


	//Seadra Pokemon Class
	public class Seadra : Pokemon
	{

		public Seadra(string nickname, int level)
		: base(
				117,
				SpecieSeadra.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Seadra(int level)
		: base(
				117,
				SpecieSeadra.Instance, // Pokemon Specie
				"Seadra", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Seadra() : base(
			117,
			SpecieSeadra.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}