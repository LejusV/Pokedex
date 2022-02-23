using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mareanie Specie to store common natural stats of every {'abilities': ['merciless', 'limber', 'regenerator'], 'base_experience': 61, 'height': 4, 'id': 747, 'moves': ['poison-sting', 'pin-missile', 'bite', 'surf', 'ice-beam', 'blizzard', 'peck', 'toxic', 'double-team', 'recover', 'haze', 'spike-cannon', 'rest', 'substitute', 'protect', 'sludge-bomb', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'stockpile', 'spit-up', 'swallow', 'hail', 'facade', 'payback', 'toxic-spikes', 'poison-jab', 'wide-guard', 'venoshock', 'sludge-wave', 'round', 'scald', 'frost-breath', 'confide', 'venom-drench', 'infestation', 'liquidation'], 'name': 'mareanie', 'stats': {'hp': 50, 'attack': 53, 'defense': 62, 'special-attack': 43, 'special-defense': 52, 'speed': 45}, 'types': ['poison', 'water'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'blue', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ヒドイデ', 'ko': '시마사리', 'zh-Hant': '好壞星', 'fr': 'Vorastérie', 'de': 'Garstella', 'es': 'Mareanie', 'it': 'Mareanie', 'en': 'Mareanie', 'ja': 'ヒドイデ', 'zh-Hans': '好坏星'}, 'genera': {'ja-Hrkt': 'ヒトデナシポケモン', 'ko': '깨비사리포켓몬', 'zh-Hant': '非星寶可夢', 'fr': 'Pokémon Cruel', 'de': 'Quäl-Stern', 'es': 'Pokémon Estrellatroz', 'it': 'Pokémon Stellatroce', 'en': 'Brutal Star Pokémon', 'ja': 'ヒトデナシポケモン', 'zh-Hans': '非星宝可梦'}}
	public class SpecieMareanie : PokemonSpecie
	{
#nullable enable
		private static SpecieMareanie? _instance = null;
#nullable restore
        public static SpecieMareanie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMareanie();
                }
                return _instance;
            }
        }

		public SpecieMareanie() : base(
			"Mareanie",
			50, // HPs
			53, 62, // Attack & Defense
			43, 52, // Special Attack & Defense
			45			
		) {}
	}


	//Mareanie Pokemon Class
	public class Mareanie : Pokemon
	{

		public Mareanie(string nickname, int level) : base(
			747,
			SpecieMareanie.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Water.Instance			
		) {}

		public Mareanie() : base(
			747,
			SpecieMareanie.Instance, // Pokemon Specie
			Poison.Instance, Water.Instance			
		) {}
	}
}