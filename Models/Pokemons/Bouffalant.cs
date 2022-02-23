using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bouffalant Specie to store common natural stats of every {'abilities': ['reckless', 'sap-sipper', 'soundproof'], 'base_experience': 172, 'height': 16, 'id': 626, 'moves': ['swords-dance', 'cut', 'stomp', 'headbutt', 'horn-attack', 'fury-attack', 'thrash', 'leer', 'surf', 'strength', 'earthquake', 'toxic', 'rage', 'double-team', 'focus-energy', 'skull-bash', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'reversal', 'protect', 'scary-face', 'mud-slap', 'outrage', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'uproar', 'facade', 'taunt', 'superpower', 'revenge', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'mud-shot', 'payback', 'poison-jab', 'giga-impact', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'round', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'cotton-guard', 'head-charge', 'belch', 'confide', 'smart-strike'], 'name': 'bouffalant', 'stats': {'hp': 95, 'attack': 110, 'defense': 95, 'special-attack': 40, 'special-defense': 95, 'speed': 55}, 'types': ['normal'], 'weight': 946, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バッフロン', 'ko': '버프론', 'zh-Hant': '爆炸頭水牛', 'fr': 'Frison', 'de': 'Bisofank', 'es': 'Bouffalant', 'it': 'Bouffalant', 'en': 'Bouffalant', 'ja': 'バッフロン', 'zh-Hans': '爆炸头水牛'}, 'genera': {'ja-Hrkt': 'ずつきうしポケモン', 'ko': '박치기소포켓몬', 'zh-Hant': '頭錘牛寶可夢', 'fr': 'Pokémon Coup d’Bœuf', 'de': 'Kopfstoßrind', 'es': 'Pokémon Torocabezazo', 'it': 'Pokémon Sfondatoro', 'en': 'Bash Buffalo Pokémon', 'ja': 'ずつきうしポケモン', 'zh-Hans': '头锤牛宝可梦'}}
	public class SpecieBouffalant : PokemonSpecie
	{
#nullable enable
		private static SpecieBouffalant? _instance = null;
#nullable restore
        public static SpecieBouffalant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBouffalant();
                }
                return _instance;
            }
        }

		public SpecieBouffalant() : base(
			"Bouffalant",
			95, // HPs
			110, 95, // Attack & Defense
			40, 95, // Special Attack & Defense
			55			
		) {}
	}


	//Bouffalant Pokemon Class
	public class Bouffalant : Pokemon
	{

		public Bouffalant(string nickname, int level) : base(
			626,
			SpecieBouffalant.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Bouffalant() : base(
			626,
			SpecieBouffalant.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}