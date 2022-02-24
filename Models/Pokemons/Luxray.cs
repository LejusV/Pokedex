using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Luxray Specie to store common natural stats of every {'abilities': ['rivalry', 'intimidate', 'guts'], 'base_experience': 235, 'height': 14, 'id': 405, 'moves': ['headbutt', 'tackle', 'leer', 'bite', 'roar', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'mud-slap', 'endure', 'swagger', 'spark', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'facade', 'charge', 'helping-hand', 'superpower', 'secret-power', 'signal-beam', 'shock-wave', 'natural-gift', 'magnet-rise', 'giga-impact', 'thunder-fang', 'discharge', 'captivate', 'charge-beam', 'round', 'volt-switch', 'wild-charge', 'snarl', 'confide', 'electric-terrain'], 'name': 'luxray', 'stats': {'hp': 80, 'attack': 120, 'defense': 79, 'special-attack': 95, 'special-defense': 79, 'speed': 70}, 'types': ['electric'], 'weight': 420, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'レントラー', 'roomaji': 'Rentorar', 'ko': '렌트라', 'zh-Hant': '倫琴貓', 'fr': 'Luxray', 'de': 'Luxtra', 'es': 'Luxray', 'it': 'Luxray', 'en': 'Luxray', 'ja': 'レントラー', 'zh-Hans': '伦琴猫'}, 'genera': {'ja-Hrkt': 'がんこうポケモン', 'ko': '안광포켓몬', 'zh-Hant': '目光寶可夢', 'fr': 'Pokémon Brillœil', 'de': 'Glühauge', 'es': 'Pokémon Chispa Ojos', 'it': 'Pokémon Occhiluce', 'en': 'Gleam Eyes Pokémon', 'ja': 'がんこうポケモン', 'zh-Hans': '目光宝可梦'}}
	public class SpecieLuxray : PokemonSpecie
	{
#nullable enable
		private static SpecieLuxray? _instance = null;
#nullable restore
        public static SpecieLuxray Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLuxray();
                }
                return _instance;
            }
        }

		public SpecieLuxray() : base(
			"Luxray",
			80, // HPs
			120, 79, // Attack & Defense
			95, 79, // Special Attack & Defense
			70			
		) {}
	}


	//Luxray Pokemon Class
	public class Luxray : Pokemon
	{

		public Luxray(string nickname, int level)
		: base(
				405,
				SpecieLuxray.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Luxray(int level)
		: base(
				405,
				SpecieLuxray.Instance, // Pokemon Specie
				"Luxray", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Luxray() : base(
			405,
			SpecieLuxray.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}