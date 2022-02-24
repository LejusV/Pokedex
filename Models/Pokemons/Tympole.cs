using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tympole Specie to store common natural stats of every {'abilities': ['swift-swim', 'hydration', 'water-absorb'], 'base_experience': 59, 'height': 5, 'id': 535, 'moves': ['growl', 'supersonic', 'mist', 'hydro-pump', 'surf', 'bubble-beam', 'toxic', 'double-team', 'bubble', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'uproar', 'hail', 'facade', 'endeavor', 'refresh', 'secret-power', 'mud-sport', 'hyper-voice', 'muddy-water', 'bounce', 'mud-shot', 'water-pulse', 'aqua-ring', 'earth-power', 'mud-bomb', 'sludge-wave', 'after-you', 'round', 'echoed-voice', 'scald', 'confide', 'venom-drench', 'infestation'], 'name': 'tympole', 'stats': {'hp': 50, 'attack': 50, 'defense': 40, 'special-attack': 50, 'special-defense': 40, 'speed': 64}, 'types': ['water'], 'weight': 45, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'オタマロ', 'ko': '동챙이', 'zh-Hant': '圓蝌蚪', 'fr': 'Tritonde', 'de': 'Schallquap', 'es': 'Tympole', 'it': 'Tympole', 'en': 'Tympole', 'ja': 'オタマロ', 'zh-Hans': '圆蝌蚪'}, 'genera': {'ja-Hrkt': 'おたまポケモン', 'ko': '올챙이포켓몬', 'zh-Hant': '蝌蚪寶可夢', 'fr': 'Pokémon Têtard', 'de': 'Kaulquappe', 'es': 'Pokémon Renacuajo', 'it': 'Pokémon Girino', 'en': 'Tadpole Pokémon', 'ja': 'おたまポケモン', 'zh-Hans': '蝌蚪宝可梦'}}
	public class SpecieTympole : PokemonSpecie
	{
#nullable enable
		private static SpecieTympole? _instance = null;
#nullable restore
        public static SpecieTympole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTympole();
                }
                return _instance;
            }
        }

		public SpecieTympole() : base(
			"Tympole",
			50, // HPs
			50, 40, // Attack & Defense
			50, 40, // Special Attack & Defense
			64			
		) {}
	}


	//Tympole Pokemon Class
	public class Tympole : Pokemon
	{

		public Tympole(string nickname, int level)
		: base(
				535,
				SpecieTympole.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tympole() : base(
			535,
			SpecieTympole.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}