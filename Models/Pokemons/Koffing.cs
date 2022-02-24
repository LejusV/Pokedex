using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Koffing Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 68, 'height': 6, 'id': 109, 'moves': ['tackle', 'flamethrower', 'psybeam', 'thunderbolt', 'thunder', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'smokescreen', 'haze', 'bide', 'self-destruct', 'smog', 'sludge', 'fire-blast', 'poison-gas', 'flash', 'psywave', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'sludge-bomb', 'zap-cannon', 'destiny-bond', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'uproar', 'stockpile', 'spit-up', 'swallow', 'torment', 'will-o-wisp', 'memento', 'facade', 'taunt', 'grudge', 'secret-power', 'shock-wave', 'gyro-ball', 'natural-gift', 'payback', 'assurance', 'toxic-spikes', 'dark-pulse', 'captivate', 'venoshock', 'round', 'clear-smog', 'incinerate', 'belch', 'confide', 'venom-drench', 'infestation'], 'name': 'koffing', 'stats': {'hp': 40, 'attack': 65, 'defense': 95, 'special-attack': 60, 'special-defense': 45, 'speed': 35}, 'types': ['poison'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'ball', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ドガース', 'roomaji': 'Dogars', 'ko': '또가스', 'zh-Hant': '瓦斯彈', 'fr': 'Smogo', 'de': 'Smogon', 'es': 'Koffing', 'it': 'Koffing', 'en': 'Koffing', 'ja': 'ドガース', 'zh-Hans': '瓦斯弹'}, 'genera': {'ja-Hrkt': 'どくガスポケモン', 'ko': '독가스포켓몬', 'zh-Hant': '毒氣寶可夢', 'fr': 'Pokémon Gaz Mortel', 'de': 'Giftwolke', 'es': 'Pokémon Gas Venenoso', 'it': 'Pokémon Velenuvola', 'en': 'Poison Gas Pokémon', 'ja': 'どくガスポケモン', 'zh-Hans': '毒气宝可梦'}}
	public class SpecieKoffing : PokemonSpecie
	{
#nullable enable
		private static SpecieKoffing? _instance = null;
#nullable restore
        public static SpecieKoffing Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKoffing();
                }
                return _instance;
            }
        }

		public SpecieKoffing() : base(
			"Koffing",
			40, // HPs
			65, 95, // Attack & Defense
			60, 45, // Special Attack & Defense
			35			
		) {}
	}


	//Koffing Pokemon Class
	public class Koffing : Pokemon
	{

		public Koffing(string nickname, int level)
		: base(
				109,
				SpecieKoffing.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Koffing() : base(
			109,
			SpecieKoffing.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}