using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Trubbish Specie to store common natural stats of every {'abilities': ['stench', 'sticky-hold', 'aftermath'], 'base_experience': 66, 'height': 6, 'id': 568, 'moves': ['pound', 'double-slap', 'sand-attack', 'take-down', 'toxic', 'double-team', 'haze', 'self-destruct', 'sludge', 'amnesia', 'poison-gas', 'explosion', 'rest', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'sludge-bomb', 'spikes', 'giga-drain', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'stockpile', 'swallow', 'facade', 'recycle', 'secret-power', 'mud-sport', 'rock-blast', 'payback', 'toxic-spikes', 'dark-pulse', 'seed-bomb', 'drain-punch', 'gunk-shot', 'venoshock', 'autotomize', 'sludge-wave', 'acid-spray', 'round', 'clear-smog', 'belch', 'confide', 'infestation'], 'name': 'trubbish', 'stats': {'hp': 50, 'attack': 50, 'defense': 62, 'special-attack': 40, 'special-defense': 62, 'speed': 65}, 'types': ['poison'], 'weight': 310, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ヤブクロン', 'ko': '깨봉이', 'zh-Hant': '破破袋', 'fr': 'Miamiasme', 'de': 'Unratütox', 'es': 'Trubbish', 'it': 'Trubbish', 'en': 'Trubbish', 'ja': 'ヤブクロン', 'zh-Hans': '破破袋'}, 'genera': {'ja-Hrkt': 'ゴミぶくろポケモン', 'ko': '쓰레기봉투포켓몬', 'zh-Hant': '垃圾袋寶可夢', 'fr': 'Pokémon Sac Poubelle', 'de': 'Mülltüte', 'es': 'Pokémon Bolsa Basura', 'it': 'Pokémon Spazzatura', 'en': 'Trash Bag Pokémon', 'ja': 'ゴミぶくろポケモン', 'zh-Hans': '垃圾袋宝可梦'}}
	public class SpecieTrubbish : PokemonSpecie
	{
#nullable enable
		private static SpecieTrubbish? _instance = null;
#nullable restore
        public static SpecieTrubbish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTrubbish();
                }
                return _instance;
            }
        }

		public SpecieTrubbish() : base(
			"Trubbish",
			50, // HPs
			50, 62, // Attack & Defense
			40, 62, // Special Attack & Defense
			65			
		) {}
	}


	//Trubbish Pokemon Class
	public class Trubbish : Pokemon
	{

		public Trubbish(string nickname, int level)
		: base(
				568,
				SpecieTrubbish.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Trubbish(int level)
		: base(
				568,
				SpecieTrubbish.Instance, // Pokemon Specie
				"Trubbish", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Trubbish() : base(
			568,
			SpecieTrubbish.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}