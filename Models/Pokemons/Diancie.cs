using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Diancie Specie to store common natural stats of every {'abilities': ['clear-body'], 'base_experience': 270, 'height': 7, 'id': 719, 'moves': ['tackle', 'hyper-beam', 'rock-throw', 'toxic', 'psychic', 'double-team', 'harden', 'light-screen', 'reflect', 'flash', 'explosion', 'rest', 'rock-slide', 'sharpen', 'substitute', 'snore', 'flail', 'protect', 'sandstorm', 'swagger', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'hail', 'facade', 'nature-power', 'helping-hand', 'endeavor', 'skill-swap', 'secret-power', 'rock-tomb', 'iron-defense', 'covet', 'calm-mind', 'gravity', 'gyro-ball', 'last-resort', 'magnet-rise', 'rock-polish', 'power-gem', 'earth-power', 'giga-impact', 'trick-room', 'stone-edge', 'stealth-rock', 'guard-split', 'wonder-room', 'psyshock', 'smack-down', 'after-you', 'round', 'moonblast', 'confide', 'diamond-storm', 'dazzling-gleam'], 'name': 'diancie', 'stats': {'hp': 50, 'attack': 100, 'defense': 150, 'special-attack': 100, 'special-defense': 150, 'speed': 50}, 'types': ['rock', 'fairy'], 'weight': 88, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 3, 'color': 'pink', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ディアンシー', 'ko': '디안시', 'zh-Hant': '蒂安希', 'fr': 'Diancie', 'de': 'Diancie', 'es': 'Diancie', 'it': 'Diancie', 'en': 'Diancie', 'ja': 'ディアンシー', 'zh-Hans': '蒂安希'}, 'genera': {'ja-Hrkt': 'ほうせきポケモン', 'ko': '보석포켓몬', 'zh-Hant': '寶石寶可夢', 'fr': 'Pokémon Joyau', 'de': 'Edelstein', 'es': 'Pokémon Joya', 'it': 'Pokémon Gemma', 'en': 'Jewel Pokémon', 'ja': 'ほうせきポケモン', 'zh-Hans': '宝石宝可梦'}}
	public class SpecieDiancie : PokemonSpecie
	{
#nullable enable
		private static SpecieDiancie? _instance = null;
#nullable restore
        public static SpecieDiancie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDiancie();
                }
                return _instance;
            }
        }

		public SpecieDiancie() : base(
			"Diancie",
			50, // HPs
			100, 150, // Attack & Defense
			100, 150, // Special Attack & Defense
			50			
		) {}
	}


	//Diancie Pokemon Class
	public class Diancie : Pokemon
	{

		public Diancie(string nickname, int level)
		: base(
				719,
				SpecieDiancie.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Diancie() : base(
			719,
			SpecieDiancie.Instance, // Pokemon Specie
			Rock.Instance, Fairy.Instance			
		) {}
	}
}