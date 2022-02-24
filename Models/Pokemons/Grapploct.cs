using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Grapploct Specie to store common natural stats of every {'abilities': ['limber', 'technician'], 'base_experience': 168, 'height': 16, 'id': 853, 'moves': [], 'name': 'grapploct', 'stats': {'hp': 80, 'attack': 118, 'defense': 90, 'special-attack': 70, 'special-defense': 80, 'speed': 42}, 'types': ['fighting'], 'weight': 390, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'オトスパス', 'ko': '케오퍼스', 'zh-Hant': '八爪武師', 'fr': 'Krakos', 'de': 'Kaocto', 'es': 'Grapploct', 'it': 'Grapploct', 'en': 'Grapploct', 'ja': 'オトスパス', 'zh-Hans': '八爪武师'}, 'genera': {'ja-Hrkt': 'じゅうじゅつポケモン', 'ko': '유술포켓몬', 'zh-Hant': '柔術寶可夢', 'fr': 'Pokémon Jujitsu', 'de': 'Jiu-Jitsu', 'es': 'Pokémon Jiu-Jitsu', 'it': 'Pokémon Jujitsu', 'en': 'Jujitsu Pokémon', 'ja': 'じゅうじゅつポケモン', 'zh-Hans': '柔术宝可梦'}}
	public class SpecieGrapploct : PokemonSpecie
	{
#nullable enable
		private static SpecieGrapploct? _instance = null;
#nullable restore
        public static SpecieGrapploct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGrapploct();
                }
                return _instance;
            }
        }

		public SpecieGrapploct() : base(
			"Grapploct",
			80, // HPs
			118, 90, // Attack & Defense
			70, 80, // Special Attack & Defense
			42			
		) {}
	}


	//Grapploct Pokemon Class
	public class Grapploct : Pokemon
	{

		public Grapploct(string nickname, int level)
		: base(
				853,
				SpecieGrapploct.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grapploct(int level)
		: base(
				853,
				SpecieGrapploct.Instance, // Pokemon Specie
				"Grapploct", level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Grapploct() : base(
			853,
			SpecieGrapploct.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}