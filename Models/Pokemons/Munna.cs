using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Munna Specie to store common natural stats of every {'abilities': ['forewarn', 'synchronize', 'telepathy'], 'base_experience': 58, 'height': 6, 'id': 517, 'moves': ['sonic-boom', 'psybeam', 'thunder-wave', 'toxic', 'psychic', 'hypnosis', 'double-team', 'defense-curl', 'barrier', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'psywave', 'rest', 'rock-slide', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'pain-split', 'baton-pass', 'moonlight', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'torment', 'facade', 'helping-hand', 'trick', 'magic-coat', 'yawn', 'skill-swap', 'imprison', 'secret-power', 'rock-tomb', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'gyro-ball', 'healing-wish', 'lucky-chant', 'worry-seed', 'energy-ball', 'zen-headbutt', 'trick-room', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'synchronoise', 'after-you', 'round', 'stored-power', 'confide', 'dazzling-gleam'], 'name': 'munna', 'stats': {'hp': 76, 'attack': 25, 'defense': 45, 'special-attack': 67, 'special-defense': 55, 'speed': 24}, 'types': ['psychic'], 'weight': 233, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 190, 'color': 'pink', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ムンナ', 'ko': '몽나', 'zh-Hant': '食夢夢', 'fr': 'Munna', 'de': 'Somniam', 'es': 'Munna', 'it': 'Munna', 'en': 'Munna', 'ja': 'ムンナ', 'zh-Hans': '食梦梦'}, 'genera': {'ja-Hrkt': 'ゆめくいポケモン', 'ko': '꿈먹기포켓몬', 'zh-Hant': '食夢寶可夢', 'fr': 'Pokémon Mangerêve', 'de': 'Traumfresser', 'es': 'Pokémon Comesueños', 'it': 'Pokémon Divorasogni', 'en': 'Dream Eater Pokémon', 'ja': 'ゆめくいポケモン', 'zh-Hans': '食梦宝可梦'}}
	public class SpecieMunna : PokemonSpecie
	{
#nullable enable
		private static SpecieMunna? _instance = null;
#nullable restore
        public static SpecieMunna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMunna();
                }
                return _instance;
            }
        }

		public SpecieMunna() : base(
			"Munna",
			76, // HPs
			25, 45, // Attack & Defense
			67, 55, // Special Attack & Defense
			24			
		) {}
	}


	//Munna Pokemon Class
	public class Munna : Pokemon
	{

		public Munna(string nickname, int level) : base(
			517,
			SpecieMunna.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Munna() : base(
			517,
			SpecieMunna.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}