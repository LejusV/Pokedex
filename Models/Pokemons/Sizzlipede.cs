using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sizzlipede Specie to store common natural stats of every {'abilities': ['flash-fire', 'white-smoke', 'flame-body'], 'base_experience': 61, 'height': 7, 'id': 850, 'moves': [], 'name': 'sizzlipede', 'stats': {'hp': 50, 'attack': 65, 'defense': 45, 'special-attack': 50, 'special-defense': 50, 'speed': 45}, 'types': ['fire', 'bug'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'red', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ヤクデ', 'ko': '태우지네', 'zh-Hant': '燒火蚣', 'fr': 'Grillepattes', 'de': 'Thermopod', 'es': 'Sizzlipede', 'it': 'Sizzlipede', 'en': 'Sizzlipede', 'ja': 'ヤクデ', 'zh-Hans': '烧火蚣'}, 'genera': {'ja-Hrkt': 'はつねつポケモン', 'ko': '발열포켓몬', 'zh-Hant': '發熱寶可夢', 'fr': 'Pokémon Calorifère', 'de': 'Exotherm', 'es': 'Pokémon Radiador', 'it': 'Pokémon Termogeno', 'en': 'Radiator Pokémon', 'ja': 'はつねつポケモン', 'zh-Hans': '发热宝可梦'}}
	public class SpecieSizzlipede : PokemonSpecie
	{
#nullable enable
		private static SpecieSizzlipede? _instance = null;
#nullable restore
        public static SpecieSizzlipede Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSizzlipede();
                }
                return _instance;
            }
        }

		public SpecieSizzlipede() : base(
			"Sizzlipede",
			50, // HPs
			65, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			45			
		) {}
	}


	//Sizzlipede Pokemon Class
	public class Sizzlipede : Pokemon
	{

		public Sizzlipede(string nickname, int level)
		: base(
				850,
				SpecieSizzlipede.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sizzlipede(int level)
		: base(
				850,
				SpecieSizzlipede.Instance, // Pokemon Specie
				"Sizzlipede", level,
				Fire.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sizzlipede() : base(
			850,
			SpecieSizzlipede.Instance, // Pokemon Specie
			Fire.Instance, Bug.Instance			
		) {}
	}
}