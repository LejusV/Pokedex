using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pincurchin Specie to store common natural stats of every {'abilities': ['lightning-rod', 'electric-surge'], 'base_experience': 152, 'height': 3, 'id': 871, 'moves': [], 'name': 'pincurchin', 'stats': {'hp': 48, 'attack': 101, 'defense': 95, 'special-attack': 91, 'special-defense': 85, 'speed': 15}, 'types': ['electric'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'バチンウニ', 'ko': '찌르성게', 'zh-Hant': '啪嚓海膽', 'fr': 'Wattapik', 'de': 'Britzigel', 'es': 'Pincurchin', 'it': 'Pincurchin', 'en': 'Pincurchin', 'ja': 'バチンウニ', 'zh-Hans': '啪嚓海胆'}, 'genera': {'ja-Hrkt': 'うにポケモン', 'ko': '성게포켓몬', 'zh-Hant': '海膽寶可夢', 'fr': 'Pokémon Oursin', 'de': 'Seeigel', 'es': 'Pokémon Erizo de Mar', 'it': 'Pokémon Echino', 'en': 'Sea Urchin Pokémon', 'ja': 'うにポケモン', 'zh-Hans': '海胆宝可梦'}}
	public class SpeciePincurchin : PokemonSpecie
	{
#nullable enable
		private static SpeciePincurchin? _instance = null;
#nullable restore
        public static SpeciePincurchin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePincurchin();
                }
                return _instance;
            }
        }

		public SpeciePincurchin() : base(
			"Pincurchin",
			48, // HPs
			101, 95, // Attack & Defense
			91, 85, // Special Attack & Defense
			15			
		) {}
	}


	//Pincurchin Pokemon Class
	public class Pincurchin : Pokemon
	{

		public Pincurchin(string nickname, int level) : base(
			871,
			SpeciePincurchin.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Pincurchin() : base(
			871,
			SpeciePincurchin.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}