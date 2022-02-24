using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxel Specie to store common natural stats of every {'abilities': ['rattled', 'static', 'klutz'], 'base_experience': 48, 'height': 4, 'id': 848, 'moves': [], 'name': 'toxel', 'stats': {'hp': 40, 'attack': 38, 'defense': 35, 'special-attack': 54, 'special-defense': 35, 'speed': 40}, 'types': ['electric', 'poison'], 'weight': 110, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'エレズン', 'ko': '일레즌', 'zh-Hant': '毒電嬰', 'fr': 'Toxizap', 'de': 'Toxel', 'es': 'Toxel', 'it': 'Toxel', 'en': 'Toxel', 'ja': 'エレズン', 'zh-Hans': '毒电婴'}, 'genera': {'ja-Hrkt': 'あかごポケモン', 'ko': '젖먹이포켓몬', 'zh-Hant': '嬰兒寶可夢', 'fr': 'Pokémon Poupon', 'de': 'Baby', 'es': 'Pokémon Retoño', 'it': 'Pokémon Bebè', 'en': 'Baby Pokémon', 'ja': 'あかごポケモン', 'zh-Hans': '婴儿宝可梦'}}
	public class SpecieToxel : PokemonSpecie
	{
#nullable enable
		private static SpecieToxel? _instance = null;
#nullable restore
        public static SpecieToxel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxel();
                }
                return _instance;
            }
        }

		public SpecieToxel() : base(
			"Toxel",
			40, // HPs
			38, 35, // Attack & Defense
			54, 35, // Special Attack & Defense
			40			
		) {}
	}


	//Toxel Pokemon Class
	public class Toxel : Pokemon
	{

		public Toxel(string nickname, int level)
		: base(
				848,
				SpecieToxel.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Toxel() : base(
			848,
			SpecieToxel.Instance, // Pokemon Specie
			Electric.Instance, Poison.Instance			
		) {}
	}
}