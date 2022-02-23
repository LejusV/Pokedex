using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Unfezant Specie to store common natural stats of every {'abilities': ['big-pecks', 'super-luck', 'rivalry'], 'base_experience': 220, 'height': 12, 'id': 521, 'moves': ['razor-wind', 'gust', 'fly', 'leer', 'growl', 'hyper-beam', 'toxic', 'quick-attack', 'double-team', 'sky-attack', 'rest', 'substitute', 'snore', 'protect', 'detect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'uproar', 'heat-wave', 'facade', 'taunt', 'secret-power', 'feather-dance', 'air-cutter', 'aerial-ace', 'roost', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'giga-impact', 'round', 'echoed-voice', 'work-up', 'confide'], 'name': 'unfezant', 'stats': {'hp': 80, 'attack': 115, 'defense': 80, 'special-attack': 65, 'special-defense': 55, 'speed': 93}, 'types': ['normal', 'flying'], 'weight': 290, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ケンホロウ', 'ko': '켄호로우', 'zh-Hant': '高傲雉雞', 'fr': 'Déflaisan', 'de': 'Fasasnob', 'es': 'Unfezant', 'it': 'Unfezant', 'en': 'Unfezant', 'ja': 'ケンホロウ', 'zh-Hans': '高傲雉鸡'}, 'genera': {'ja-Hrkt': 'プライドポケモン', 'ko': '프라이드포켓몬', 'zh-Hant': '自尊心寶可夢', 'fr': 'Pokémon Fier', 'de': 'Stolz', 'es': 'Pokémon Altanero', 'it': 'Pokémon Orgoglio', 'en': 'Proud Pokémon', 'ja': 'プライドポケモン', 'zh-Hans': '自尊心宝可梦'}}
	public class SpecieUnfezant : PokemonSpecie
	{
#nullable enable
		private static SpecieUnfezant? _instance = null;
#nullable restore
        public static SpecieUnfezant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUnfezant();
                }
                return _instance;
            }
        }

		public SpecieUnfezant() : base(
			"Unfezant",
			80, // HPs
			115, 80, // Attack & Defense
			65, 55, // Special Attack & Defense
			93			
		) {}
	}


	//Unfezant Pokemon Class
	public class Unfezant : Pokemon
	{

		public Unfezant(string nickname, int level) : base(
			521,
			SpecieUnfezant.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Unfezant() : base(
			521,
			SpecieUnfezant.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}