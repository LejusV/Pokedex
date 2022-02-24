using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sobble Specie to store common natural stats of every {'abilities': ['torrent', 'sniper'], 'base_experience': 62, 'height': 3, 'id': 816, 'moves': [], 'name': 'sobble', 'stats': {'hp': 50, 'attack': 40, 'defense': 40, 'special-attack': 70, 'special-defense': 40, 'speed': 70}, 'types': ['water'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'メッソン', 'ko': '울머기', 'zh-Hant': '淚眼蜥', 'fr': 'Larméléon', 'de': 'Memmeon', 'es': 'Sobble', 'it': 'Sobble', 'en': 'Sobble', 'ja': 'メッソン', 'zh-Hans': '泪眼蜥'}, 'genera': {'ja-Hrkt': 'みずとかげポケモン', 'ko': '물도마뱀포켓몬', 'zh-Hant': '水蜥寶可夢', 'fr': "Pokémon Lézard'Eau", 'de': 'Wasserechse', 'es': 'Pokémon Acuartija', 'it': 'Pokémon Acquacertola', 'en': 'Water Lizard Pokémon', 'ja': 'みずとかげポケモン', 'zh-Hans': '水蜥宝可梦'}}
	public class SpecieSobble : PokemonSpecie
	{
#nullable enable
		private static SpecieSobble? _instance = null;
#nullable restore
        public static SpecieSobble Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSobble();
                }
                return _instance;
            }
        }

		public SpecieSobble() : base(
			"Sobble",
			50, // HPs
			40, 40, // Attack & Defense
			70, 40, // Special Attack & Defense
			70			
		) {}
	}


	//Sobble Pokemon Class
	public class Sobble : Pokemon
	{

		public Sobble(string nickname, int level)
		: base(
				816,
				SpecieSobble.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sobble() : base(
			816,
			SpecieSobble.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}