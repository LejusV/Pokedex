using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zeraora Specie to store common natural stats of every {'abilities': ['volt-absorb'], 'base_experience': 270, 'height': 15, 'id': 807, 'moves': ['thunder-punch', 'scratch', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'double-team', 'fury-swipes', 'rest', 'slash', 'substitute', 'protect', 'false-swipe', 'spark', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'fake-out', 'facade', 'charge', 'taunt', 'brick-break', 'aerial-ace', 'bulk-up', 'calm-mind', 'close-combat', 'fling', 'focus-blast', 'giga-impact', 'discharge', 'grass-knot', 'hone-claws', 'low-sweep', 'round', 'echoed-voice', 'quick-guard', 'acrobatics', 'volt-switch', 'work-up', 'wild-charge', 'snarl', 'confide', 'brutal-swing', 'plasma-fists'], 'name': 'zeraora', 'stats': {'hp': 88, 'attack': 112, 'defense': 75, 'special-attack': 102, 'special-defense': 80, 'speed': 143}, 'types': ['electric'], 'weight': 445, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ゼラオラ', 'ko': '제라오라', 'zh-Hant': '捷拉奥拉', 'fr': 'Zeraora', 'de': 'Zeraora', 'es': 'Zeraora', 'it': 'Zeraora', 'en': 'Zeraora', 'ja': 'ゼラオラ', 'zh-Hans': '捷拉奥拉'}, 'genera': {'ja-Hrkt': 'じんらいポケモン', 'ko': '신뢰포켓몬', 'zh-Hant': '奔雷寶可夢', 'fr': 'Pokémon Vif Éclair', 'de': 'Blitzsturm', 'es': 'Pokémon Fulgor', 'it': 'Pokémon Fulmirapido', 'en': 'Thunderclap Pokémon', 'ja': 'じんらいポケモン', 'zh-Hans': '奔雷宝可梦'}}
	public class SpecieZeraora : PokemonSpecie
	{
#nullable enable
		private static SpecieZeraora? _instance = null;
#nullable restore
        public static SpecieZeraora Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZeraora();
                }
                return _instance;
            }
        }

		public SpecieZeraora() : base(
			"Zeraora",
			88, // HPs
			112, 75, // Attack & Defense
			102, 80, // Special Attack & Defense
			143			
		) {}
	}


	//Zeraora Pokemon Class
	public class Zeraora : Pokemon
	{

		public Zeraora(string nickname, int level)
		: base(
				807,
				SpecieZeraora.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zeraora(int level)
		: base(
				807,
				SpecieZeraora.Instance, // Pokemon Specie
				"Zeraora", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zeraora() : base(
			807,
			SpecieZeraora.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}