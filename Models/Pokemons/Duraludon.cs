using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Duraludon Specie to store common natural stats of every {'abilities': ['light-metal', 'heavy-metal', 'stalwart'], 'base_experience': 187, 'height': 18, 'id': 884, 'moves': [], 'name': 'duraludon', 'stats': {'hp': 70, 'attack': 95, 'defense': 115, 'special-attack': 120, 'special-defense': 50, 'speed': 85}, 'types': ['steel', 'dragon'], 'weight': 400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ジュラルドン', 'ko': '두랄루돈', 'zh-Hant': '鋁鋼龍', 'fr': 'Duralugon', 'de': 'Duraludon', 'es': 'Duraludon', 'it': 'Duraludon', 'en': 'Duraludon', 'ja': 'ジュラルドン', 'zh-Hans': '铝钢龙'}, 'genera': {'ja-Hrkt': 'ごうきんポケモン', 'ko': '합금포켓몬', 'zh-Hant': '合金寶可夢', 'fr': 'Pokémon Alliage', 'de': 'Legierung', 'es': 'Pokémon Aleación', 'it': 'Pokémon Metallolega', 'en': 'Alloy Pokémon', 'ja': 'ごうきんポケモン', 'zh-Hans': '合金宝可梦'}}
	public class SpecieDuraludon : PokemonSpecie
	{
#nullable enable
		private static SpecieDuraludon? _instance = null;
#nullable restore
        public static SpecieDuraludon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDuraludon();
                }
                return _instance;
            }
        }

		public SpecieDuraludon() : base(
			"Duraludon",
			70, // HPs
			95, 115, // Attack & Defense
			120, 50, // Special Attack & Defense
			85			
		) {}
	}


	//Duraludon Pokemon Class
	public class Duraludon : Pokemon
	{

		public Duraludon(string nickname, int level)
		: base(
				884,
				SpecieDuraludon.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Duraludon() : base(
			884,
			SpecieDuraludon.Instance, // Pokemon Specie
			Steel.Instance, Dragon.Instance			
		) {}
	}
}