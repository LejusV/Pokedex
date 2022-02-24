using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Caterpie Specie to store common natural stats of every {'abilities': ['shield-dust', 'run-away'], 'base_experience': 39, 'height': 3, 'id': 10, 'moves': ['tackle', 'string-shot', 'snore', 'bug-bite', 'electroweb'], 'name': 'caterpie', 'stats': {'hp': 45, 'attack': 30, 'defense': 35, 'special-attack': 20, 'special-defense': 20, 'speed': 45}, 'types': ['bug'], 'weight': 29, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'キャタピー', 'roomaji': 'Caterpie', 'ko': '캐터피', 'zh-Hant': '綠毛蟲', 'fr': 'Chenipan', 'de': 'Raupy', 'es': 'Caterpie', 'it': 'Caterpie', 'en': 'Caterpie', 'ja': 'キャタピー', 'zh-Hans': '绿毛虫'}, 'genera': {'ja-Hrkt': 'いもむしポケモン', 'ko': '애벌레포켓몬', 'zh-Hant': '蟲寶寶寶可夢', 'fr': 'Pokémon Ver', 'de': 'Wurm', 'es': 'Pokémon Gusano', 'it': 'Pokémon Baco', 'en': 'Worm Pokémon', 'ja': 'いもむしポケモン', 'zh-Hans': '虫宝宝宝可梦'}}
	public class SpecieCaterpie : PokemonSpecie
	{
#nullable enable
		private static SpecieCaterpie? _instance = null;
#nullable restore
        public static SpecieCaterpie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCaterpie();
                }
                return _instance;
            }
        }

		public SpecieCaterpie() : base(
			"Caterpie",
			45, // HPs
			30, 35, // Attack & Defense
			20, 20, // Special Attack & Defense
			45			
		) {}
	}


	//Caterpie Pokemon Class
	public class Caterpie : Pokemon
	{

		public Caterpie(string nickname, int level)
		: base(
				10,
				SpecieCaterpie.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Caterpie() : base(
			10,
			SpecieCaterpie.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}