using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drizzile Specie to store common natural stats of every {'abilities': ['torrent', 'sniper'], 'base_experience': 147, 'height': 7, 'id': 817, 'moves': [], 'name': 'drizzile', 'stats': {'hp': 65, 'attack': 60, 'defense': 55, 'special-attack': 95, 'special-defense': 55, 'speed': 90}, 'types': ['water'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ジメレオン', 'ko': '누겔레온', 'zh-Hant': '變澀蜥', 'fr': 'Arrozard', 'de': 'Phlegleon', 'es': 'Drizzile', 'it': 'Drizzile', 'en': 'Drizzile', 'ja': 'ジメレオン', 'zh-Hans': '变涩蜥'}, 'genera': {'ja-Hrkt': 'みずとかげポケモン', 'ko': '물도마뱀포켓몬', 'zh-Hant': '水蜥寶可夢', 'fr': "Pokémon Lézard'Eau", 'de': 'Wasserechse', 'es': 'Pokémon Acuartija', 'it': 'Pokémon Acquacertola', 'en': 'Water Lizard Pokémon', 'ja': 'みずとかげポケモン', 'zh-Hans': '水蜥宝可梦'}}
	public class SpecieDrizzile : PokemonSpecie
	{
#nullable enable
		private static SpecieDrizzile? _instance = null;
#nullable restore
        public static SpecieDrizzile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrizzile();
                }
                return _instance;
            }
        }

		public SpecieDrizzile() : base(
			"Drizzile",
			65, // HPs
			60, 55, // Attack & Defense
			95, 55, // Special Attack & Defense
			90			
		) {}
	}


	//Drizzile Pokemon Class
	public class Drizzile : Pokemon
	{

		public Drizzile(string nickname, int level) : base(
			817,
			SpecieDrizzile.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Drizzile() : base(
			817,
			SpecieDrizzile.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}