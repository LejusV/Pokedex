using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Boltund Specie to store common natural stats of every {'abilities': ['strong-jaw', 'competitive'], 'base_experience': 172, 'height': 10, 'id': 836, 'moves': [], 'name': 'boltund', 'stats': {'hp': 69, 'attack': 90, 'defense': 60, 'special-attack': 90, 'special-defense': 60, 'speed': 121}, 'types': ['electric'], 'weight': 340, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'パルスワン', 'ko': '펄스멍', 'zh-Hant': '逐電犬', 'fr': 'Fulgudog', 'de': 'Bellektro', 'es': 'Boltund', 'it': 'Boltund', 'en': 'Boltund', 'ja': 'パルスワン', 'zh-Hans': '逐电犬'}, 'genera': {'ja-Hrkt': 'いぬポケモン', 'ko': '개포켓몬', 'zh-Hant': '狗寶可夢', 'fr': 'Pokémon Chien', 'de': 'Hund', 'es': 'Pokémon Perro', 'it': 'Pokémon Cane', 'en': 'Dog Pokémon', 'ja': 'いぬポケモン', 'zh-Hans': '狗宝可梦'}}
	public class SpecieBoltund : PokemonSpecie
	{
#nullable enable
		private static SpecieBoltund? _instance = null;
#nullable restore
        public static SpecieBoltund Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBoltund();
                }
                return _instance;
            }
        }

		public SpecieBoltund() : base(
			"Boltund",
			69, // HPs
			90, 60, // Attack & Defense
			90, 60, // Special Attack & Defense
			121			
		) {}
	}


	//Boltund Pokemon Class
	public class Boltund : Pokemon
	{

		public Boltund(string nickname, int level)
		: base(
				836,
				SpecieBoltund.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Boltund() : base(
			836,
			SpecieBoltund.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}