using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wormadam-Plant Specie to store common natural stats of every {'abilities': ['anticipation', 'overcoat'], 'base_experience': 148, 'height': 5, 'id': 413, 'moves': ['tackle', 'psybeam', 'hyper-beam', 'growth', 'razor-leaf', 'solar-beam', 'string-shot', 'toxic', 'confusion', 'psychic', 'double-team', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'snore', 'flail', 'protect', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'endeavor', 'skill-swap', 'secret-power', 'signal-beam', 'bullet-seed', 'natural-gift', 'worry-seed', 'sucker-punch', 'seed-bomb', 'bug-buzz', 'energy-ball', 'giga-impact', 'leaf-storm', 'captivate', 'grass-knot', 'bug-bite', 'venoshock', 'quiver-dance', 'round', 'struggle-bug', 'electroweb', 'confide', 'infestation'], 'name': 'wormadam-plant', 'stats': {'hp': 60, 'attack': 59, 'defense': 85, 'special-attack': 79, 'special-defense': 105, 'speed': 36}, 'types': ['bug', 'grass'], 'weight': 65, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 8, 'capture_rate': 45, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ミノマダム', 'roomaji': 'Minomadam', 'ko': '도롱마담', 'zh-Hant': '結草貴婦', 'fr': 'Cheniselle', 'de': 'Burmadame', 'es': 'Wormadam', 'it': 'Wormadam', 'en': 'Wormadam', 'ja': 'ミノマダム', 'zh-Hans': '结草贵妇'}, 'genera': {'ja-Hrkt': 'みのむしポケモン', 'ko': '도롱이벌레포켓몬', 'zh-Hant': '蓑衣蟲寶可夢', 'fr': 'Pokémon Ver Caché', 'de': 'Beutelwurm', 'es': 'Pokémon Larva', 'it': 'Pokémon Larva', 'en': 'Bagworm Pokémon', 'ja': 'みのむしポケモン', 'zh-Hans': '蓑衣虫宝可梦'}}
	public class SpecieWormadamPlant : PokemonSpecie
	{
#nullable enable
		private static SpecieWormadamPlant? _instance = null;
#nullable restore
        public static SpecieWormadamPlant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWormadamPlant();
                }
                return _instance;
            }
        }

		public SpecieWormadamPlant() : base(
			"Wormadam-Plant",
			60, // HPs
			59, 85, // Attack & Defense
			79, 105, // Special Attack & Defense
			36			
		) {}
	}


	//Wormadam-Plant Pokemon Class
	public class WormadamPlant : Pokemon
	{

		public WormadamPlant(string nickname, int level)
		: base(
				413,
				SpecieWormadamPlant.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public WormadamPlant() : base(
			413,
			SpecieWormadamPlant.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
	}
}