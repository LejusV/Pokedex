using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tranquill Specie to store common natural stats of every {'abilities': ['big-pecks', 'super-luck', 'rivalry'], 'base_experience': 125, 'height': 6, 'id': 520, 'moves': ['razor-wind', 'gust', 'fly', 'leer', 'growl', 'toxic', 'quick-attack', 'double-team', 'sky-attack', 'rest', 'substitute', 'snore', 'protect', 'detect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'taunt', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'roost', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'round', 'echoed-voice', 'work-up', 'confide'], 'name': 'tranquill', 'stats': {'hp': 62, 'attack': 77, 'defense': 62, 'special-attack': 50, 'special-defense': 42, 'speed': 65}, 'types': ['normal', 'flying'], 'weight': 150, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'gray', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ハトーボー', 'ko': '유토브', 'zh-Hant': '咕咕鴿', 'fr': 'Colombeau', 'de': 'Navitaub', 'es': 'Tranquill', 'it': 'Tranquill', 'en': 'Tranquill', 'ja': 'ハトーボー', 'zh-Hans': '咕咕鸽'}, 'genera': {'ja-Hrkt': 'のばとポケモン', 'ko': '들비둘기포켓몬', 'zh-Hant': '野鴿寶可夢', 'fr': 'Pokémon Sauvapigeon', 'de': 'Wildtaube', 'es': 'Pokémon Torcaz', 'it': 'Pokémon Granpiccione', 'en': 'Wild Pigeon Pokémon', 'ja': 'のばとポケモン', 'zh-Hans': '野鸽宝可梦'}}
	public class SpecieTranquill : PokemonSpecie
	{
#nullable enable
		private static SpecieTranquill? _instance = null;
#nullable restore
        public static SpecieTranquill Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTranquill();
                }
                return _instance;
            }
        }

		public SpecieTranquill() : base(
			"Tranquill",
			62, // HPs
			77, 62, // Attack & Defense
			50, 42, // Special Attack & Defense
			65			
		) {}
	}


	//Tranquill Pokemon Class
	public class Tranquill : Pokemon
	{

		public Tranquill(string nickname, int level)
		: base(
				520,
				SpecieTranquill.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tranquill() : base(
			520,
			SpecieTranquill.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}