using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shinx Specie to store common natural stats of every {'abilities': ['rivalry', 'intimidate', 'guts'], 'base_experience': 53, 'height': 5, 'id': 403, 'moves': ['double-kick', 'headbutt', 'tackle', 'take-down', 'leer', 'bite', 'roar', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'mud-slap', 'endure', 'swagger', 'spark', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'facade', 'charge', 'helping-hand', 'secret-power', 'fake-tears', 'signal-beam', 'howl', 'shock-wave', 'natural-gift', 'magnet-rise', 'night-slash', 'thunder-fang', 'ice-fang', 'fire-fang', 'discharge', 'captivate', 'charge-beam', 'round', 'volt-switch', 'wild-charge', 'snarl', 'confide', 'eerie-impulse', 'baby-doll-eyes'], 'name': 'shinx', 'stats': {'hp': 45, 'attack': 65, 'defense': 34, 'special-attack': 40, 'special-defense': 34, 'speed': 45}, 'types': ['electric'], 'weight': 95, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 235, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'コリンク', 'roomaji': 'Kolink', 'ko': '꼬링크', 'zh-Hant': '小貓怪', 'fr': 'Lixy', 'de': 'Sheinux', 'es': 'Shinx', 'it': 'Shinx', 'en': 'Shinx', 'ja': 'コリンク', 'zh-Hans': '小猫怪'}, 'genera': {'ja-Hrkt': 'せんこうポケモン', 'ko': '섬광포켓몬', 'zh-Hant': '閃光寶可夢', 'fr': 'Pokémon Flash', 'de': 'Flacker', 'es': 'Pokémon Flash', 'it': 'Pokémon Baleno', 'en': 'Flash Pokémon', 'ja': 'せんこうポケモン', 'zh-Hans': '闪光宝可梦'}}
	public class SpecieShinx : PokemonSpecie
	{
#nullable enable
		private static SpecieShinx? _instance = null;
#nullable restore
        public static SpecieShinx Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShinx();
                }
                return _instance;
            }
        }

		public SpecieShinx() : base(
			"Shinx",
			45, // HPs
			65, 34, // Attack & Defense
			40, 34, // Special Attack & Defense
			45			
		) {}
	}


	//Shinx Pokemon Class
	public class Shinx : Pokemon
	{

		public Shinx(string nickname, int level)
		: base(
				403,
				SpecieShinx.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shinx() : base(
			403,
			SpecieShinx.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}