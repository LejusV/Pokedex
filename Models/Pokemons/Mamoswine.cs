using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mamoswine Specie to store common natural stats of every {'abilities': ['oblivious', 'snow-cloak', 'thick-fat'], 'base_experience': 239, 'height': 25, 'id': 473, 'moves': ['headbutt', 'fury-attack', 'take-down', 'thrash', 'roar', 'mist', 'ice-beam', 'blizzard', 'hyper-beam', 'peck', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'light-screen', 'reflect', 'rest', 'rock-slide', 'substitute', 'snore', 'powder-snow', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'ancient-power', 'rock-smash', 'hail', 'facade', 'superpower', 'knock-off', 'endeavor', 'secret-power', 'mud-sport', 'odor-sleuth', 'rock-tomb', 'block', 'natural-gift', 'earth-power', 'giga-impact', 'avalanche', 'ice-fang', 'mud-bomb', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'double-hit', 'round', 'bulldoze', 'confide'], 'name': 'mamoswine', 'stats': {'hp': 110, 'attack': 130, 'defense': 80, 'special-attack': 70, 'special-defense': 60, 'speed': 80}, 'types': ['ice', 'ground'], 'weight': 2910, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 50, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'マンムー', 'roomaji': 'Mammoo', 'ko': '맘모꾸리', 'zh-Hant': '象牙豬', 'fr': 'Mammochon', 'de': 'Mamutel', 'es': 'Mamoswine', 'it': 'Mamoswine', 'en': 'Mamoswine', 'ja': 'マンムー', 'zh-Hans': '象牙猪'}, 'genera': {'ja-Hrkt': '２ほんキバポケモン', 'ko': '2개송곳니포켓몬', 'zh-Hant': '雙牙寶可夢', 'fr': 'Pokémon Deudéfenses', 'de': 'Doppelstoßzahn', 'es': 'Pokémon Doscolmillos', 'it': 'Pokémon Duezanne', 'en': 'Twin Tusk Pokémon', 'ja': '２ほんキバポケモン', 'zh-Hans': '双牙宝可梦'}}
	public class SpecieMamoswine : PokemonSpecie
	{
#nullable enable
		private static SpecieMamoswine? _instance = null;
#nullable restore
        public static SpecieMamoswine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMamoswine();
                }
                return _instance;
            }
        }

		public SpecieMamoswine() : base(
			"Mamoswine",
			110, // HPs
			130, 80, // Attack & Defense
			70, 60, // Special Attack & Defense
			80			
		) {}
	}


	//Mamoswine Pokemon Class
	public class Mamoswine : Pokemon
	{

		public Mamoswine(string nickname, int level)
		: base(
				473,
				SpecieMamoswine.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Mamoswine() : base(
			473,
			SpecieMamoswine.Instance, // Pokemon Specie
			Ice.Instance, Ground.Instance			
		) {}
	}
}