using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meltan Specie to store common natural stats of every {'abilities': ['magnet-pull'], 'base_experience': 135, 'height': 2, 'id': 808, 'moves': [], 'name': 'meltan', 'stats': {'hp': 46, 'attack': 65, 'defense': 65, 'special-attack': 55, 'special-defense': 35, 'speed': 34}, 'types': ['steel'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'メルタン', 'ko': '멜탄', 'zh-Hant': '美錄坦', 'fr': 'Meltan', 'de': 'Meltan', 'es': 'Meltan', 'it': 'Meltan', 'en': 'Meltan', 'ja': 'メルタン', 'zh-Hans': '美录坦'}, 'genera': {'ja-Hrkt': 'ナットポケモン', 'ko': '너트포켓몬', 'zh-Hant': '螺帽寶可夢', 'fr': 'Pokémon Écrou', 'de': 'Mutter', 'es': 'Pokémon Tuerca', 'it': 'Pokémon Bullone', 'en': 'Hex Nut Pokémon', 'ja': 'ナットポケモン', 'zh-Hans': '螺帽宝可梦'}}
	public class SpecieMeltan : PokemonSpecie
	{
#nullable enable
		private static SpecieMeltan? _instance = null;
#nullable restore
        public static SpecieMeltan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeltan();
                }
                return _instance;
            }
        }

		public SpecieMeltan() : base(
			"Meltan",
			46, // HPs
			65, 65, // Attack & Defense
			55, 35, // Special Attack & Defense
			34			
		) {}
	}


	//Meltan Pokemon Class
	public class Meltan : Pokemon
	{

		public Meltan(string nickname, int level)
		: base(
				808,
				SpecieMeltan.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Meltan() : base(
			808,
			SpecieMeltan.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}