using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vullaby Specie to store common natural stats of every {'abilities': ['big-pecks', 'overcoat', 'weak-armor'], 'base_experience': 74, 'height': 5, 'id': 629, 'moves': ['cut', 'gust', 'whirlwind', 'fly', 'fury-attack', 'leer', 'toxic', 'double-team', 'mirror-move', 'rest', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'feint-attack', 'swagger', 'steel-wing', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'heat-wave', 'torment', 'flatter', 'facade', 'taunt', 'knock-off', 'snatch', 'secret-power', 'fake-tears', 'rock-tomb', 'aerial-ace', 'iron-defense', 'block', 'roost', 'pluck', 'tailwind', 'u-turn', 'payback', 'embargo', 'punishment', 'dark-pulse', 'air-slash', 'brave-bird', 'nasty-plot', 'defog', 'foul-play', 'round', 'incinerate', 'retaliate', 'snarl', 'confide'], 'name': 'vullaby', 'stats': {'hp': 70, 'attack': 55, 'defense': 75, 'special-attack': 45, 'special-defense': 65, 'speed': 60}, 'types': ['dark', 'flying'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 190, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'バルチャイ', 'ko': '벌차이', 'zh-Hant': '禿鷹丫頭', 'fr': 'Vostourno', 'de': 'Skallyk', 'es': 'Vullaby', 'it': 'Vullaby', 'en': 'Vullaby', 'ja': 'バルチャイ', 'zh-Hans': '秃鹰丫头'}, 'genera': {'ja-Hrkt': 'おむつポケモン', 'ko': '기저귀포켓몬', 'zh-Hant': '尿布寶可夢', 'fr': 'Pokémon Couche', 'de': 'Windel', 'es': 'Pokémon Pañal', 'it': 'Pokémon Pannolino', 'en': 'Diapered Pokémon', 'ja': 'おむつポケモン', 'zh-Hans': '尿布宝可梦'}}
	public class SpecieVullaby : PokemonSpecie
	{
#nullable enable
		private static SpecieVullaby? _instance = null;
#nullable restore
        public static SpecieVullaby Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVullaby();
                }
                return _instance;
            }
        }

		public SpecieVullaby() : base(
			"Vullaby",
			70, // HPs
			55, 75, // Attack & Defense
			45, 65, // Special Attack & Defense
			60			
		) {}
	}


	//Vullaby Pokemon Class
	public class Vullaby : Pokemon
	{

		public Vullaby(string nickname, int level)
		: base(
				629,
				SpecieVullaby.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vullaby(int level)
		: base(
				629,
				SpecieVullaby.Instance, // Pokemon Specie
				"Vullaby", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vullaby() : base(
			629,
			SpecieVullaby.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
	}
}