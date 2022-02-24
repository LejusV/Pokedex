using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Weezing Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 172, 'height': 12, 'id': 110, 'moves': ['tackle', 'flamethrower', 'hyper-beam', 'thunderbolt', 'thunder', 'toxic', 'rage', 'mimic', 'double-team', 'smokescreen', 'haze', 'bide', 'self-destruct', 'smog', 'sludge', 'fire-blast', 'poison-gas', 'flash', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'sludge-bomb', 'zap-cannon', 'destiny-bond', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'uproar', 'torment', 'will-o-wisp', 'memento', 'facade', 'taunt', 'secret-power', 'shock-wave', 'gyro-ball', 'natural-gift', 'payback', 'assurance', 'dark-pulse', 'giga-impact', 'captivate', 'double-hit', 'venoshock', 'round', 'clear-smog', 'incinerate', 'belch', 'confide', 'infestation'], 'name': 'weezing', 'stats': {'hp': 65, 'attack': 90, 'defense': 120, 'special-attack': 85, 'special-defense': 70, 'speed': 60}, 'types': ['poison'], 'weight': 95, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'purple', 'shape': 'heads', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'マタドガス', 'roomaji': 'Matadogas', 'ko': '또도가스', 'zh-Hant': '雙彈瓦斯', 'fr': 'Smogogo', 'de': 'Smogmog', 'es': 'Weezing', 'it': 'Weezing', 'en': 'Weezing', 'ja': 'マタドガス', 'zh-Hans': '双弹瓦斯'}, 'genera': {'ja-Hrkt': 'どくガスポケモン', 'ko': '독가스포켓몬', 'zh-Hant': '毒氣寶可夢', 'fr': 'Pokémon Gaz Mortel', 'de': 'Giftwolke', 'es': 'Pokémon Gas Venenoso', 'it': 'Pokémon Velenuvola', 'en': 'Poison Gas Pokémon', 'ja': 'どくガスポケモン', 'zh-Hans': '毒气宝可梦'}}
	public class SpecieWeezing : PokemonSpecie
	{
#nullable enable
		private static SpecieWeezing? _instance = null;
#nullable restore
        public static SpecieWeezing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeezing();
                }
                return _instance;
            }
        }

		public SpecieWeezing() : base(
			"Weezing",
			65, // HPs
			90, 120, // Attack & Defense
			85, 70, // Special Attack & Defense
			60			
		) {}
	}


	//Weezing Pokemon Class
	public class Weezing : Pokemon
	{

		public Weezing(string nickname, int level)
		: base(
				110,
				SpecieWeezing.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Weezing(int level)
		: base(
				110,
				SpecieWeezing.Instance, // Pokemon Specie
				"Weezing", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Weezing() : base(
			110,
			SpecieWeezing.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}