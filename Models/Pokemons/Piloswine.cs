using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Piloswine Specie to store common natural stats of every {'abilities': ['oblivious', 'snow-cloak', 'thick-fat'], 'base_experience': 158, 'height': 11, 'id': 221, 'moves': ['headbutt', 'horn-attack', 'fury-attack', 'body-slam', 'take-down', 'thrash', 'double-edge', 'roar', 'mist', 'ice-beam', 'blizzard', 'hyper-beam', 'peck', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'detect', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'hail', 'facade', 'superpower', 'endeavor', 'secret-power', 'mud-sport', 'odor-sleuth', 'rock-tomb', 'natural-gift', 'earth-power', 'giga-impact', 'avalanche', 'ice-fang', 'mud-bomb', 'stone-edge', 'captivate', 'stealth-rock', 'round', 'bulldoze', 'confide'], 'name': 'piloswine', 'stats': {'hp': 100, 'attack': 100, 'defense': 80, 'special-attack': 60, 'special-defense': 60, 'speed': 50}, 'types': ['ice', 'ground'], 'weight': 558, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'イノムー', 'roomaji': 'Inomoo', 'ko': '메꾸리', 'zh-Hant': '長毛豬', 'fr': 'Cochignon', 'de': 'Keifel', 'es': 'Piloswine', 'it': 'Piloswine', 'en': 'Piloswine', 'ja': 'イノムー', 'zh-Hans': '长毛猪'}, 'genera': {'ja-Hrkt': 'いのししポケモン', 'ko': '멧돼지포켓몬', 'zh-Hant': '野豬寶可夢', 'fr': 'Pokémon Porc', 'de': 'Schwein', 'es': 'Pokémon Puerco', 'it': 'Pokémon Suino', 'en': 'Swine Pokémon', 'ja': 'いのししポケモン', 'zh-Hans': '野猪宝可梦'}}
	public class SpeciePiloswine : PokemonSpecie
	{
#nullable enable
		private static SpeciePiloswine? _instance = null;
#nullable restore
        public static SpeciePiloswine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePiloswine();
                }
                return _instance;
            }
        }

		public SpeciePiloswine() : base(
			"Piloswine",
			100, // HPs
			100, 80, // Attack & Defense
			60, 60, // Special Attack & Defense
			50			
		) {}
	}


	//Piloswine Pokemon Class
	public class Piloswine : Pokemon
	{

		public Piloswine(string nickname, int level)
		: base(
				221,
				SpeciePiloswine.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Piloswine() : base(
			221,
			SpeciePiloswine.Instance, // Pokemon Specie
			Ice.Instance, Ground.Instance			
		) {}
	}
}