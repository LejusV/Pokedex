using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Hatterene Specie to store common natural stats of every {'abilities': ['healer', 'anticipation', 'magic-bounce'], 'base_experience': 255, 'height': 21, 'id': 858, 'moves': [], 'name': 'hatterene', 'stats': {'hp': 57, 'attack': 90, 'defense': 95, 'special-attack': 136, 'special-defense': 103, 'speed': 29}, 'types': ['psychic', 'fairy'], 'weight': 51, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 8, 'capture_rate': 45, 'color': 'pink', 'shape': 'blob', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ブリムオン', 'ko': '브리무음', 'zh-Hant': '布莉姆溫', 'fr': 'Sorcilence', 'de': 'Silembrim', 'es': 'Hatterene', 'it': 'Hatterene', 'en': 'Hatterene', 'ja': 'ブリムオン', 'zh-Hans': '布莉姆温'}, 'genera': {'ja-Hrkt': 'せいじゃくポケモン', 'ko': '정적포켓몬', 'zh-Hant': '寂靜寶可夢', 'fr': 'Pokémon Silencieux', 'de': 'Stille', 'es': 'Pokémon Silencio', 'it': 'Pokémon Silenzio', 'en': 'Silent Pokémon', 'ja': 'せいじゃくポケモン', 'zh-Hans': '寂静宝可梦'}}
	public class SpecieHatterene : PokemonSpecie
	{
#nullable enable
		private static SpecieHatterene? _instance = null;
#nullable restore
        public static SpecieHatterene Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHatterene();
                }
                return _instance;
            }
        }

		public SpecieHatterene() : base(
			"Hatterene",
			57, // HPs
			90, 95, // Attack & Defense
			136, 103, // Special Attack & Defense
			29			
		) {}
	}


	//Hatterene Pokemon Class
	public class Hatterene : Pokemon
	{

		public Hatterene(string nickname, int level)
		: base(
				858,
				SpecieHatterene.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Hatterene() : base(
			858,
			SpecieHatterene.Instance, // Pokemon Specie
			Psychic.Instance, Fairy.Instance			
		) {}
	}
}