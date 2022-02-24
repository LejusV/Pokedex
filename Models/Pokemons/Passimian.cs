using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Passimian Specie to store common natural stats of every {'abilities': ['receiver', 'defiant'], 'base_experience': 172, 'height': 20, 'id': 766, 'moves': ['tackle', 'take-down', 'thrash', 'double-edge', 'leer', 'hyper-beam', 'seismic-toss', 'earthquake', 'toxic', 'quick-attack', 'double-team', 'focus-energy', 'rest', 'rock-slide', 'substitute', 'thief', 'reversal', 'protect', 'scary-face', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'vital-throw', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'beat-up', 'facade', 'taunt', 'brick-break', 'rock-tomb', 'aerial-ace', 'bulk-up', 'gyro-ball', 'feint', 'u-turn', 'close-combat', 'payback', 'fling', 'focus-blast', 'energy-ball', 'giga-impact', 'iron-head', 'grass-knot', 'smack-down', 'low-sweep', 'round', 'quick-guard', 'acrobatics', 'bestow', 'bulldoze', 'work-up', 'confide', 'brutal-swing'], 'name': 'passimian', 'stats': {'hp': 100, 'attack': 120, 'defense': 90, 'special-attack': 40, 'special-defense': 60, 'speed': 80}, 'types': ['fighting'], 'weight': 828, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ナゲツケサル', 'ko': '내던숭이', 'zh-Hant': '投擲猴', 'fr': 'Quartermac', 'de': 'Quartermak', 'es': 'Passimian', 'it': 'Passimian', 'en': 'Passimian', 'ja': 'ナゲツケサル', 'zh-Hans': '投掷猴'}, 'genera': {'ja-Hrkt': 'れんけいポケモン', 'ko': '연계포켓몬', 'zh-Hant': '配合寶可夢', 'fr': 'Pokémon Coopération', 'de': 'Teamwork', 'es': 'Pokémon Cooperación', 'it': 'Pokémon Giocosquadra', 'en': 'Teamwork Pokémon', 'ja': 'れんけいポケモン', 'zh-Hans': '配合宝可梦'}}
	public class SpeciePassimian : PokemonSpecie
	{
#nullable enable
		private static SpeciePassimian? _instance = null;
#nullable restore
        public static SpeciePassimian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePassimian();
                }
                return _instance;
            }
        }

		public SpeciePassimian() : base(
			"Passimian",
			100, // HPs
			120, 90, // Attack & Defense
			40, 60, // Special Attack & Defense
			80			
		) {}
	}


	//Passimian Pokemon Class
	public class Passimian : Pokemon
	{

		public Passimian(string nickname, int level)
		: base(
				766,
				SpeciePassimian.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Passimian() : base(
			766,
			SpeciePassimian.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}