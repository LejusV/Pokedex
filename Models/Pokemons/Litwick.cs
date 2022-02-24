using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Litwick Specie to store common natural stats of every {'abilities': ['flash-fire', 'flame-body', 'infiltrator'], 'base_experience': 55, 'height': 3, 'id': 607, 'moves': ['acid', 'ember', 'flamethrower', 'solar-beam', 'fire-spin', 'toxic', 'psychic', 'night-shade', 'double-team', 'minimize', 'confuse-ray', 'haze', 'smog', 'fire-blast', 'dream-eater', 'flash', 'acid-armor', 'rest', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'sunny-day', 'psych-up', 'shadow-ball', 'heat-wave', 'will-o-wisp', 'memento', 'facade', 'taunt', 'trick', 'imprison', 'secret-power', 'astonish', 'overheat', 'calm-mind', 'shock-wave', 'payback', 'embargo', 'dark-pulse', 'energy-ball', 'trick-room', 'captivate', 'power-split', 'telekinesis', 'flame-burst', 'flame-charge', 'round', 'clear-smog', 'hex', 'incinerate', 'inferno', 'confide'], 'name': 'litwick', 'stats': {'hp': 50, 'attack': 30, 'defense': 55, 'special-attack': 65, 'special-defense': 55, 'speed': 20}, 'types': ['ghost', 'fire'], 'weight': 31, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ヒトモシ', 'ko': '불켜미', 'zh-Hant': '燭光靈', 'fr': 'Funécire', 'de': 'Lichtel', 'es': 'Litwick', 'it': 'Litwick', 'en': 'Litwick', 'ja': 'ヒトモシ', 'zh-Hans': '烛光灵'}, 'genera': {'ja-Hrkt': 'ろうそくポケモン', 'ko': '양초포켓몬', 'zh-Hant': '蠟燭寶可夢', 'fr': 'Pokémon Chandelle', 'de': 'Kerze', 'es': 'Pokémon Vela', 'it': 'Pokémon Candela', 'en': 'Candle Pokémon', 'ja': 'ろうそくポケモン', 'zh-Hans': '蜡烛宝可梦'}}
	public class SpecieLitwick : PokemonSpecie
	{
#nullable enable
		private static SpecieLitwick? _instance = null;
#nullable restore
        public static SpecieLitwick Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLitwick();
                }
                return _instance;
            }
        }

		public SpecieLitwick() : base(
			"Litwick",
			50, // HPs
			30, 55, // Attack & Defense
			65, 55, // Special Attack & Defense
			20			
		) {}
	}


	//Litwick Pokemon Class
	public class Litwick : Pokemon
	{

		public Litwick(string nickname, int level)
		: base(
				607,
				SpecieLitwick.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Litwick() : base(
			607,
			SpecieLitwick.Instance, // Pokemon Specie
			Ghost.Instance, Fire.Instance			
		) {}
	}
}