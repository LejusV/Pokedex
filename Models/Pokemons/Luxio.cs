using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Luxio Specie to store common natural stats of every {'abilities': ['rivalry', 'intimidate', 'guts'], 'base_experience': 127, 'height': 9, 'id': 404, 'moves': ['headbutt', 'tackle', 'leer', 'bite', 'roar', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'mud-slap', 'endure', 'swagger', 'spark', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'facade', 'charge', 'helping-hand', 'secret-power', 'signal-beam', 'shock-wave', 'natural-gift', 'magnet-rise', 'thunder-fang', 'discharge', 'captivate', 'charge-beam', 'round', 'volt-switch', 'wild-charge', 'snarl', 'confide'], 'name': 'luxio', 'stats': {'hp': 60, 'attack': 85, 'defense': 49, 'special-attack': 60, 'special-defense': 49, 'speed': 60}, 'types': ['electric'], 'weight': 305, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ルクシオ', 'roomaji': 'Luxio', 'ko': '럭시오', 'zh-Hant': '勒克貓', 'fr': 'Luxio', 'de': 'Luxio', 'es': 'Luxio', 'it': 'Luxio', 'en': 'Luxio', 'ja': 'ルクシオ', 'zh-Hans': '勒克猫'}, 'genera': {'ja-Hrkt': 'でんこうポケモン', 'ko': '전광포켓몬', 'zh-Hant': '電光寶可夢', 'fr': 'Pokémon Étincelle', 'de': 'Funken', 'es': 'Pokémon Chispa', 'it': 'Pokémon Favilla', 'en': 'Spark Pokémon', 'ja': 'でんこうポケモン', 'zh-Hans': '电光宝可梦'}}
	public class SpecieLuxio : PokemonSpecie
	{
#nullable enable
		private static SpecieLuxio? _instance = null;
#nullable restore
        public static SpecieLuxio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLuxio();
                }
                return _instance;
            }
        }

		public SpecieLuxio() : base(
			"Luxio",
			60, // HPs
			85, 49, // Attack & Defense
			60, 49, // Special Attack & Defense
			60			
		) {}
	}


	//Luxio Pokemon Class
	public class Luxio : Pokemon
	{

		public Luxio(string nickname, int level) : base(
			404,
			SpecieLuxio.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Luxio() : base(
			404,
			SpecieLuxio.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}