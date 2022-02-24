using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Orbeetle Specie to store common natural stats of every {'abilities': ['swarm', 'frisk', 'telepathy'], 'base_experience': 253, 'height': 4, 'id': 826, 'moves': [], 'name': 'orbeetle', 'stats': {'hp': 60, 'attack': 45, 'defense': 110, 'special-attack': 80, 'special-defense': 120, 'speed': 90}, 'types': ['bug', 'psychic'], 'weight': 408, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'イオルブ', 'ko': '이올브', 'zh-Hant': '以歐路普', 'fr': 'Astronelle', 'de': 'Maritellit', 'es': 'Orbeetle', 'it': 'Orbeetle', 'en': 'Orbeetle', 'ja': 'イオルブ', 'zh-Hans': '以欧路普'}, 'genera': {'ja-Hrkt': 'ななほしポケモン', 'ko': '칠성포켓몬', 'zh-Hant': '七星寶可夢', 'fr': 'Pokémon Sept Points', 'de': 'Siebensterne', 'es': 'Pokémon Siete Puntos', 'it': 'Pokémon Settepunti', 'en': 'Seven Spot Pokémon', 'ja': 'ななほしポケモン', 'zh-Hans': '七星宝可梦'}}
	public class SpecieOrbeetle : PokemonSpecie
	{
#nullable enable
		private static SpecieOrbeetle? _instance = null;
#nullable restore
        public static SpecieOrbeetle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOrbeetle();
                }
                return _instance;
            }
        }

		public SpecieOrbeetle() : base(
			"Orbeetle",
			60, // HPs
			45, 110, // Attack & Defense
			80, 120, // Special Attack & Defense
			90			
		) {}
	}


	//Orbeetle Pokemon Class
	public class Orbeetle : Pokemon
	{

		public Orbeetle(string nickname, int level)
		: base(
				826,
				SpecieOrbeetle.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Orbeetle() : base(
			826,
			SpecieOrbeetle.Instance, // Pokemon Specie
			Bug.Instance, Psychic.Instance			
		) {}
	}
}