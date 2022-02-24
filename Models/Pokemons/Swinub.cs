using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swinub Specie to store common natural stats of every {'abilities': ['oblivious', 'snow-cloak', 'thick-fat'], 'base_experience': 50, 'height': 4, 'id': 220, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'bite', 'roar', 'mist', 'ice-beam', 'blizzard', 'strength', 'earthquake', 'fissure', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'light-screen', 'reflect', 'amnesia', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'detect', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'hail', 'facade', 'superpower', 'endeavor', 'secret-power', 'mud-sport', 'odor-sleuth', 'rock-tomb', 'icicle-spear', 'mud-shot', 'natural-gift', 'earth-power', 'avalanche', 'ice-shard', 'mud-bomb', 'captivate', 'stealth-rock', 'round', 'bulldoze', 'icicle-crash', 'freeze-dry', 'confide'], 'name': 'swinub', 'stats': {'hp': 50, 'attack': 50, 'defense': 40, 'special-attack': 30, 'special-defense': 30, 'speed': 50}, 'types': ['ice', 'ground'], 'weight': 65, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 225, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ウリムー', 'roomaji': 'Urimoo', 'ko': '꾸꾸리', 'zh-Hant': '小山豬', 'fr': 'Marcacrin', 'de': 'Quiekel', 'es': 'Swinub', 'it': 'Swinub', 'en': 'Swinub', 'ja': 'ウリムー', 'zh-Hans': '小山猪'}, 'genera': {'ja-Hrkt': 'いのぶたポケモン', 'ko': '산돼지포켓몬', 'zh-Hant': '小豬寶可夢', 'fr': 'Pokémon Cochon', 'de': 'Ferkel', 'es': 'Pokémon Cerdo', 'it': 'Pokémon Maiale', 'en': 'Pig Pokémon', 'ja': 'いのぶたポケモン', 'zh-Hans': '小猪宝可梦'}}
	public class SpecieSwinub : PokemonSpecie
	{
#nullable enable
		private static SpecieSwinub? _instance = null;
#nullable restore
        public static SpecieSwinub Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwinub();
                }
                return _instance;
            }
        }

		public SpecieSwinub() : base(
			"Swinub",
			50, // HPs
			50, 40, // Attack & Defense
			30, 30, // Special Attack & Defense
			50			
		) {}
	}


	//Swinub Pokemon Class
	public class Swinub : Pokemon
	{

		public Swinub(string nickname, int level)
		: base(
				220,
				SpecieSwinub.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swinub(int level)
		: base(
				220,
				SpecieSwinub.Instance, // Pokemon Specie
				"Swinub", level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Swinub() : base(
			220,
			SpecieSwinub.Instance, // Pokemon Specie
			Ice.Instance, Ground.Instance			
		) {}
	}
}