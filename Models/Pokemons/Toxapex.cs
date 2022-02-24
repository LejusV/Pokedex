using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxapex Specie to store common natural stats of every {'abilities': ['merciless', 'limber', 'regenerator'], 'base_experience': 173, 'height': 7, 'id': 748, 'moves': ['poison-sting', 'pin-missile', 'bite', 'surf', 'ice-beam', 'blizzard', 'peck', 'toxic', 'double-team', 'recover', 'light-screen', 'spike-cannon', 'rest', 'substitute', 'protect', 'sludge-bomb', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'hail', 'facade', 'payback', 'toxic-spikes', 'poison-jab', 'wide-guard', 'venoshock', 'smack-down', 'sludge-wave', 'round', 'scald', 'frost-breath', 'confide', 'venom-drench', 'infestation', 'baneful-bunker', 'liquidation'], 'name': 'toxapex', 'stats': {'hp': 50, 'attack': 63, 'defense': 152, 'special-attack': 53, 'special-defense': 142, 'speed': 35}, 'types': ['poison', 'water'], 'weight': 145, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ドヒドイデ', 'ko': '더시마사리', 'zh-Hant': '超壞星', 'fr': 'Prédastérie', 'de': 'Aggrostella', 'es': 'Toxapex', 'it': 'Toxapex', 'en': 'Toxapex', 'ja': 'ドヒドイデ', 'zh-Hans': '超坏星'}, 'genera': {'ja-Hrkt': 'ヒトデナシポケモン', 'ko': '깨비사리포켓몬', 'zh-Hant': '非星寶可夢', 'fr': 'Pokémon Cruel', 'de': 'Quäl-Stern', 'es': 'Pokémon Estrellatroz', 'it': 'Pokémon Stellatroce', 'en': 'Brutal Star Pokémon', 'ja': 'ヒトデナシポケモン', 'zh-Hans': '非星宝可梦'}}
	public class SpecieToxapex : PokemonSpecie
	{
#nullable enable
		private static SpecieToxapex? _instance = null;
#nullable restore
        public static SpecieToxapex Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxapex();
                }
                return _instance;
            }
        }

		public SpecieToxapex() : base(
			"Toxapex",
			50, // HPs
			63, 152, // Attack & Defense
			53, 142, // Special Attack & Defense
			35			
		) {}
	}


	//Toxapex Pokemon Class
	public class Toxapex : Pokemon
	{

		public Toxapex(string nickname, int level)
		: base(
				748,
				SpecieToxapex.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Toxapex() : base(
			748,
			SpecieToxapex.Instance, // Pokemon Specie
			Poison.Instance, Water.Instance			
		) {}
	}
}