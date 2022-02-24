using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skrelp Specie to store common natural stats of every {'abilities': ['poison-point', 'poison-touch', 'adaptability'], 'base_experience': 64, 'height': 5, 'id': 690, 'moves': ['tackle', 'tail-whip', 'acid', 'water-gun', 'hydro-pump', 'surf', 'thunderbolt', 'toxic', 'double-team', 'smokescreen', 'haze', 'waterfall', 'bubble', 'acid-armor', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'icy-wind', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'shadow-ball', 'hail', 'facade', 'secret-power', 'dive', 'camouflage', 'bounce', 'poison-tail', 'shock-wave', 'water-pulse', 'toxic-spikes', 'aqua-tail', 'dragon-pulse', 'gunk-shot', 'venoshock', 'sludge-wave', 'round', 'scald', 'play-rough', 'confide', 'venom-drench'], 'name': 'skrelp', 'stats': {'hp': 50, 'attack': 60, 'defense': 60, 'special-attack': 60, 'special-defense': 60, 'speed': 30}, 'types': ['poison', 'water'], 'weight': 73, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'brown', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'クズモー', 'ko': '수레기', 'zh-Hant': '垃垃藻', 'fr': 'Venalgue', 'de': 'Algitt', 'es': 'Skrelp', 'it': 'Skrelp', 'en': 'Skrelp', 'ja': 'クズモー', 'zh-Hans': '垃垃藻'}, 'genera': {'ja-Hrkt': 'クサモドキポケモン', 'ko': '풀모방포켓몬', 'zh-Hant': '似草寶可夢', 'fr': 'Pokémon Simulalgue', 'de': 'Tangmimikry', 'es': 'Pokémon Pseudoalga', 'it': 'Pokémon Similalga', 'en': 'Mock Kelp Pokémon', 'ja': 'クサモドキポケモン', 'zh-Hans': '似草宝可梦'}}
	public class SpecieSkrelp : PokemonSpecie
	{
#nullable enable
		private static SpecieSkrelp? _instance = null;
#nullable restore
        public static SpecieSkrelp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkrelp();
                }
                return _instance;
            }
        }

		public SpecieSkrelp() : base(
			"Skrelp",
			50, // HPs
			60, 60, // Attack & Defense
			60, 60, // Special Attack & Defense
			30			
		) {}
	}


	//Skrelp Pokemon Class
	public class Skrelp : Pokemon
	{

		public Skrelp(string nickname, int level)
		: base(
				690,
				SpecieSkrelp.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skrelp() : base(
			690,
			SpecieSkrelp.Instance, // Pokemon Specie
			Poison.Instance, Water.Instance			
		) {}
	}
}