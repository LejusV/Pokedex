using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Silvally Specie to store common natural stats of every {'abilities': ['rks-system'], 'base_experience': 257, 'height': 23, 'id': 773, 'moves': ['razor-wind', 'swords-dance', 'tackle', 'take-down', 'double-edge', 'bite', 'roar', 'flamethrower', 'surf', 'ice-beam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'toxic', 'rage', 'double-team', 'explosion', 'rest', 'rock-slide', 'tri-attack', 'substitute', 'protect', 'scary-face', 'sandstorm', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'hail', 'facade', 'imprison', 'poison-fang', 'crush-claw', 'metal-sound', 'aerial-ace', 'dragon-claw', 'u-turn', 'payback', 'heal-block', 'punishment', 'air-slash', 'x-scissor', 'giga-impact', 'shadow-claw', 'thunder-fang', 'ice-fang', 'fire-fang', 'flash-cannon', 'draco-meteor', 'iron-head', 'double-hit', 'flame-charge', 'round', 'water-pledge', 'fire-pledge', 'grass-pledge', 'work-up', 'snarl', 'parting-shot', 'confide', 'multi-attack'], 'name': 'silvally', 'stats': {'hp': 95, 'attack': 95, 'defense': 95, 'special-attack': 95, 'special-defense': 95, 'speed': 95}, 'types': ['normal'], 'weight': 1005, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'シルヴァディ', 'ko': '실버디', 'zh-Hant': '銀伴戰獸', 'fr': 'Silvallié', 'de': 'Amigento', 'es': 'Silvally', 'it': 'Silvally', 'en': 'Silvally', 'ja': 'シルヴァディ', 'zh-Hans': '银伴战兽'}, 'genera': {'ja-Hrkt': 'じんこうポケモン', 'ko': '인공포켓몬', 'zh-Hant': '人工寶可夢', 'fr': 'Pokémon Multigénome', 'de': 'Modifikation', 'es': 'Pokémon Multigénico', 'it': 'Pokémon Multigene', 'en': 'Synthetic Pokémon', 'ja': 'じんこうポケモン', 'zh-Hans': '人工宝可梦'}}
	public class SpecieSilvally : PokemonSpecie
	{
#nullable enable
		private static SpecieSilvally? _instance = null;
#nullable restore
        public static SpecieSilvally Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSilvally();
                }
                return _instance;
            }
        }

		public SpecieSilvally() : base(
			"Silvally",
			95, // HPs
			95, 95, // Attack & Defense
			95, 95, // Special Attack & Defense
			95			
		) {}
	}


	//Silvally Pokemon Class
	public class Silvally : Pokemon
	{

		public Silvally(string nickname, int level) : base(
			773,
			SpecieSilvally.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Silvally() : base(
			773,
			SpecieSilvally.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}