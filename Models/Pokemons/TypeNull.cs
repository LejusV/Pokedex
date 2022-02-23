using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Type-Null Specie to store common natural stats of every {'abilities': ['battle-armor'], 'base_experience': 107, 'height': 19, 'id': 772, 'moves': ['razor-wind', 'swords-dance', 'tackle', 'take-down', 'double-edge', 'roar', 'thunder-wave', 'toxic', 'rage', 'double-team', 'rest', 'rock-slide', 'tri-attack', 'substitute', 'protect', 'scary-face', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'hail', 'facade', 'imprison', 'crush-claw', 'metal-sound', 'aerial-ace', 'dragon-claw', 'u-turn', 'payback', 'heal-block', 'punishment', 'air-slash', 'x-scissor', 'giga-impact', 'shadow-claw', 'iron-head', 'double-hit', 'flame-charge', 'round', 'work-up', 'confide'], 'name': 'type-null', 'stats': {'hp': 95, 'attack': 95, 'defense': 95, 'special-attack': 95, 'special-defense': 95, 'speed': 59}, 'types': ['normal'], 'weight': 1205, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'タイプ：ヌル', 'ko': '타입:널', 'zh-Hant': '屬性：空', 'fr': 'Type:0', 'de': 'Typ:Null', 'es': 'Código Cero', 'it': 'Tipo Zero', 'en': 'Type: Null', 'ja': 'タイプ：ヌル', 'zh-Hans': '属性：空'}, 'genera': {'ja-Hrkt': 'じんこうポケモン', 'ko': '인공포켓몬', 'zh-Hant': '人工寶可夢', 'fr': 'Pokémon Multigénome', 'de': 'Modifikation', 'es': 'Pokémon Multigénico', 'it': 'Pokémon Multigene', 'en': 'Synthetic Pokémon', 'ja': 'じんこうポケモン', 'zh-Hans': '人工宝可梦'}}
	public class SpecieTypeNull : PokemonSpecie
	{
#nullable enable
		private static SpecieTypeNull? _instance = null;
#nullable restore
        public static SpecieTypeNull Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTypeNull();
                }
                return _instance;
            }
        }

		public SpecieTypeNull() : base(
			"Type-Null",
			95, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			59			
		) {}
	}


	//Type-Null Pokemon Class
	public class TypeNull : Pokemon
	{

		public TypeNull(string nickname, int level) : base(
			772,
			SpecieTypeNull.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public TypeNull() : base(
			772,
			SpecieTypeNull.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}