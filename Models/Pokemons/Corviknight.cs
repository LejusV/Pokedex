using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Corviknight Specie to store common natural stats of every {'abilities': ['pressure', 'unnerve', 'mirror-armor'], 'base_experience': 248, 'height': 22, 'id': 823, 'moves': [], 'name': 'corviknight', 'stats': {'hp': 98, 'attack': 87, 'defense': 105, 'special-attack': 53, 'special-defense': 85, 'speed': 67}, 'types': ['flying', 'steel'], 'weight': 750, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'アーマーガア', 'ko': '아머까오', 'zh-Hant': '鋼鎧鴉', 'fr': 'Corvaillus', 'de': 'Krarmor', 'es': 'Corviknight', 'it': 'Corviknight', 'en': 'Corviknight', 'ja': 'アーマーガア', 'zh-Hans': '钢铠鸦'}, 'genera': {'ja-Hrkt': 'カラスポケモン', 'ko': '까마귀포켓몬', 'zh-Hant': '烏鴉寶可夢', 'fr': 'Pokémon Corbeau', 'de': 'Krähe', 'es': 'Pokémon Cuervo', 'it': 'Pokémon Corvo', 'en': 'Raven Pokémon', 'ja': 'カラスポケモン', 'zh-Hans': '乌鸦宝可梦'}}
	public class SpecieCorviknight : PokemonSpecie
	{
#nullable enable
		private static SpecieCorviknight? _instance = null;
#nullable restore
        public static SpecieCorviknight Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorviknight();
                }
                return _instance;
            }
        }

		public SpecieCorviknight() : base(
			"Corviknight",
			98, // HPs
			87, 105, // Attack & Defense
			53, 85, // Special Attack & Defense
			67			
		) {}
	}


	//Corviknight Pokemon Class
	public class Corviknight : Pokemon
	{

		public Corviknight(string nickname, int level)
		: base(
				823,
				SpecieCorviknight.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Corviknight() : base(
			823,
			SpecieCorviknight.Instance, // Pokemon Specie
			Flying.Instance, Steel.Instance			
		) {}
	}
}