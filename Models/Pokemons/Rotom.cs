using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rotom Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 154, 'height': 3, 'id': 479, 'moves': ['thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'confuse-ray', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'mud-slap', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'will-o-wisp', 'facade', 'charge', 'trick', 'snatch', 'secret-power', 'astonish', 'signal-beam', 'shock-wave', 'natural-gift', 'sucker-punch', 'dark-pulse', 'discharge', 'charge-beam', 'ominous-wind', 'telekinesis', 'electro-ball', 'foul-play', 'round', 'hex', 'volt-switch', 'electroweb', 'confide'], 'name': 'rotom', 'stats': {'hp': 50, 'attack': 50, 'defense': 77, 'special-attack': 95, 'special-defense': 77, 'speed': 91}, 'types': ['electric', 'ghost'], 'weight': 3, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 45, 'color': 'red', 'shape': 'ball', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ロトム', 'roomaji': 'Rotom', 'ko': '로토무', 'zh-Hant': '洛托姆', 'fr': 'Motisma', 'de': 'Rotom', 'es': 'Rotom', 'it': 'Rotom', 'en': 'Rotom', 'ja': 'ロトム', 'zh-Hans': '洛托姆'}, 'genera': {'ja-Hrkt': 'プラズマポケモン', 'ko': '플라스마포켓몬', 'zh-Hant': '等離子寶可夢', 'fr': 'Pokémon Plasma', 'de': 'Plasma', 'es': 'Pokémon Plasma', 'it': 'Pokémon Plasma', 'en': 'Plasma Pokémon', 'ja': 'プラズマポケモン', 'zh-Hans': '等离子宝可梦'}}
	public class SpecieRotom : PokemonSpecie
	{
#nullable enable
		private static SpecieRotom? _instance = null;
#nullable restore
        public static SpecieRotom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRotom();
                }
                return _instance;
            }
        }

		public SpecieRotom() : base(
			"Rotom",
			50, // HPs
			50, 77, // Attack & Defense
			95, 77, // Special Attack & Defense
			91			
		) {}
	}


	//Rotom Pokemon Class
	public class Rotom : Pokemon
	{

		public Rotom(string nickname, int level)
		: base(
				479,
				SpecieRotom.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rotom(int level)
		: base(
				479,
				SpecieRotom.Instance, // Pokemon Specie
				"Rotom", level,
				Electric.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Rotom() : base(
			479,
			SpecieRotom.Instance, // Pokemon Specie
			Electric.Instance, Ghost.Instance			
		) {}
	}
}