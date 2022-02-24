using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Garbodor Specie to store common natural stats of every {'abilities': ['stench', 'weak-armor', 'aftermath'], 'base_experience': 166, 'height': 19, 'id': 569, 'moves': ['pound', 'double-slap', 'body-slam', 'hyper-beam', 'solar-beam', 'thunderbolt', 'toxic', 'psychic', 'double-team', 'sludge', 'amnesia', 'poison-gas', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'sludge-bomb', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'stockpile', 'swallow', 'facade', 'recycle', 'secret-power', 'payback', 'fling', 'toxic-spikes', 'rock-polish', 'dark-pulse', 'seed-bomb', 'drain-punch', 'focus-blast', 'giga-impact', 'gunk-shot', 'venoshock', 'smack-down', 'sludge-wave', 'acid-spray', 'round', 'clear-smog', 'belch', 'confide', 'infestation'], 'name': 'garbodor', 'stats': {'hp': 80, 'attack': 95, 'defense': 82, 'special-attack': 60, 'special-defense': 82, 'speed': 75}, 'types': ['poison'], 'weight': 1073, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ダストダス', 'ko': '더스트나', 'zh-Hant': '灰塵山', 'fr': 'Miasmax', 'de': 'Deponitox', 'es': 'Garbodor', 'it': 'Garbodor', 'en': 'Garbodor', 'ja': 'ダストダス', 'zh-Hans': '灰尘山'}, 'genera': {'ja-Hrkt': 'ゴミすてばポケモン', 'ko': '쓰레기장포켓몬', 'zh-Hant': '垃圾場寶可夢', 'fr': 'Pokémon Dépotoir', 'de': 'Müllhalde', 'es': 'Pokémon Vertedero', 'it': 'Pokémon Discarica', 'en': 'Trash Heap Pokémon', 'ja': 'ゴミすてばポケモン', 'zh-Hans': '垃圾场宝可梦'}}
	public class SpecieGarbodor : PokemonSpecie
	{
#nullable enable
		private static SpecieGarbodor? _instance = null;
#nullable restore
        public static SpecieGarbodor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGarbodor();
                }
                return _instance;
            }
        }

		public SpecieGarbodor() : base(
			"Garbodor",
			80, // HPs
			95, 82, // Attack & Defense
			60, 82, // Special Attack & Defense
			75			
		) {}
	}


	//Garbodor Pokemon Class
	public class Garbodor : Pokemon
	{

		public Garbodor(string nickname, int level)
		: base(
				569,
				SpecieGarbodor.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Garbodor(int level)
		: base(
				569,
				SpecieGarbodor.Instance, // Pokemon Specie
				"Garbodor", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Garbodor() : base(
			569,
			SpecieGarbodor.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}