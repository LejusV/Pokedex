using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dhelmise Specie to store common natural stats of every {'abilities': ['steelworker'], 'base_experience': 181, 'height': 39, 'id': 781, 'moves': ['swords-dance', 'slam', 'wrap', 'surf', 'hyper-beam', 'absorb', 'mega-drain', 'growth', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'rest', 'rock-slide', 'substitute', 'thief', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'whirlpool', 'facade', 'brick-break', 'astonish', 'metal-sound', 'aerial-ace', 'gyro-ball', 'payback', 'embargo', 'energy-ball', 'switcheroo', 'giga-impact', 'shadow-claw', 'flash-cannon', 'power-whip', 'grass-knot', 'sludge-wave', 'heavy-slam', 'round', 'bulldoze', 'phantom-force', 'confide', 'anchor-shot', 'brutal-swing'], 'name': 'dhelmise', 'stats': {'hp': 70, 'attack': 131, 'defense': 100, 'special-attack': 86, 'special-defense': 90, 'speed': 40}, 'types': ['ghost', 'grass'], 'weight': 2100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 25, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ダダリン', 'ko': '타타륜', 'zh-Hant': '破破舵輪', 'fr': 'Sinistrail', 'de': 'Moruda', 'es': 'Dhelmise', 'it': 'Dhelmise', 'en': 'Dhelmise', 'ja': 'ダダリン', 'zh-Hans': '破破舵轮'}, 'genera': {'ja-Hrkt': 'もくずポケモン', 'ko': '해초조각포켓몬', 'zh-Hant': '碎藻寶可夢', 'fr': 'Pokémon Varech', 'de': 'Seetang', 'es': 'Pokémon Alga Ancla', 'it': 'Pokémon Brandellalga', 'en': 'Sea Creeper Pokémon', 'ja': 'もくずポケモン', 'zh-Hans': '碎藻宝可梦'}}
	public class SpecieDhelmise : PokemonSpecie
	{
#nullable enable
		private static SpecieDhelmise? _instance = null;
#nullable restore
        public static SpecieDhelmise Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDhelmise();
                }
                return _instance;
            }
        }

		public SpecieDhelmise() : base(
			"Dhelmise",
			70, // HPs
			131, 100, // Attack & Defense
			86, 90, // Special Attack & Defense
			40			
		) {}
	}


	//Dhelmise Pokemon Class
	public class Dhelmise : Pokemon
	{

		public Dhelmise(string nickname, int level)
		: base(
				781,
				SpecieDhelmise.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dhelmise(int level)
		: base(
				781,
				SpecieDhelmise.Instance, // Pokemon Specie
				"Dhelmise", level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dhelmise() : base(
			781,
			SpecieDhelmise.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
	}
}