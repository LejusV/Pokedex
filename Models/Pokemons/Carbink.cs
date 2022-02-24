using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carbink Specie to store common natural stats of every {'abilities': ['clear-body', 'sturdy'], 'base_experience': 100, 'height': 3, 'id': 703, 'moves': ['tackle', 'rock-throw', 'toxic', 'psychic', 'double-team', 'harden', 'light-screen', 'reflect', 'flash', 'explosion', 'rest', 'rock-slide', 'sharpen', 'substitute', 'snore', 'flail', 'protect', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'hail', 'facade', 'nature-power', 'magic-coat', 'skill-swap', 'secret-power', 'rock-tomb', 'iron-defense', 'covet', 'calm-mind', 'gravity', 'gyro-ball', 'magnet-rise', 'rock-polish', 'power-gem', 'earth-power', 'trick-room', 'stone-edge', 'stealth-rock', 'guard-split', 'wonder-room', 'smack-down', 'after-you', 'round', 'moonblast', 'confide', 'dazzling-gleam'], 'name': 'carbink', 'stats': {'hp': 50, 'attack': 50, 'defense': 150, 'special-attack': 50, 'special-defense': 150, 'speed': 50}, 'types': ['rock', 'fairy'], 'weight': 57, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 60, 'color': 'gray', 'shape': 'ball', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['fairy', 'mineral'], 'names': {'ja-Hrkt': 'メレシー', 'ko': '멜리시', 'zh-Hant': '小碎鑽', 'fr': 'Strassie', 'de': 'Rocara', 'es': 'Carbink', 'it': 'Carbink', 'en': 'Carbink', 'ja': 'メレシー', 'zh-Hans': '小碎钻'}, 'genera': {'ja-Hrkt': 'ほうせきポケモン', 'ko': '보석포켓몬', 'zh-Hant': '寶石寶可夢', 'fr': 'Pokémon Joyau', 'de': 'Edelstein', 'es': 'Pokémon Joya', 'it': 'Pokémon Gemma', 'en': 'Jewel Pokémon', 'ja': 'ほうせきポケモン', 'zh-Hans': '宝石宝可梦'}}
	public class SpecieCarbink : PokemonSpecie
	{
#nullable enable
		private static SpecieCarbink? _instance = null;
#nullable restore
        public static SpecieCarbink Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarbink();
                }
                return _instance;
            }
        }

		public SpecieCarbink() : base(
			"Carbink",
			50, // HPs
			50, 150, // Attack & Defense
			50, 150, // Special Attack & Defense
			50			
		) {}
	}


	//Carbink Pokemon Class
	public class Carbink : Pokemon
	{

		public Carbink(string nickname, int level)
		: base(
				703,
				SpecieCarbink.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carbink(int level)
		: base(
				703,
				SpecieCarbink.Instance, // Pokemon Specie
				"Carbink", level,
				Rock.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carbink() : base(
			703,
			SpecieCarbink.Instance, // Pokemon Specie
			Rock.Instance, Fairy.Instance			
		) {}
	}
}