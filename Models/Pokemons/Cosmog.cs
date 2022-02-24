using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cosmog Specie to store common natural stats of every {'abilities': ['unaware'], 'base_experience': 40, 'height': 2, 'id': 789, 'moves': ['teleport', 'splash'], 'name': 'cosmog', 'stats': {'hp': 43, 'attack': 29, 'defense': 31, 'special-attack': 29, 'special-defense': 31, 'speed': 37}, 'types': ['psychic'], 'weight': 1, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'blue', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'コスモッグ', 'ko': '코스모그', 'zh-Hant': '科斯莫古', 'fr': 'Cosmog', 'de': 'Cosmog', 'es': 'Cosmog', 'it': 'Cosmog', 'en': 'Cosmog', 'ja': 'コスモッグ', 'zh-Hans': '科斯莫古'}, 'genera': {'ja-Hrkt': 'せいうんポケモン', 'ko': '성운포켓몬', 'zh-Hant': '星雲寶可夢', 'fr': 'Pokémon Nébuleuse', 'de': 'Nebula', 'es': 'Pokémon Nebulosa', 'it': 'Pokémon Nebulosa', 'en': 'Nebula Pokémon', 'ja': 'せいうんポケモン', 'zh-Hans': '星云宝可梦'}}
	public class SpecieCosmog : PokemonSpecie
	{
#nullable enable
		private static SpecieCosmog? _instance = null;
#nullable restore
        public static SpecieCosmog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCosmog();
                }
                return _instance;
            }
        }

		public SpecieCosmog() : base(
			"Cosmog",
			43, // HPs
			29, 31, // Attack & Defense
			29, 31, // Special Attack & Defense
			37			
		) {}
	}


	//Cosmog Pokemon Class
	public class Cosmog : Pokemon
	{

		public Cosmog(string nickname, int level)
		: base(
				789,
				SpecieCosmog.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cosmog() : base(
			789,
			SpecieCosmog.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}