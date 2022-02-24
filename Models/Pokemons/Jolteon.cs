using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jolteon Specie to store common natural stats of every {'abilities': ['volt-absorb', 'quick-feet'], 'base_experience': 184, 'height': 8, 'id': 135, 'moves': ['double-kick', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'pin-missile', 'roar', 'hyper-beam', 'strength', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'quick-attack', 'rage', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'swift', 'skull-bash', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'helping-hand', 'secret-power', 'hyper-voice', 'signal-beam', 'covet', 'shock-wave', 'natural-gift', 'last-resort', 'magnet-rise', 'giga-impact', 'thunder-fang', 'discharge', 'captivate', 'charge-beam', 'round', 'echoed-voice', 'retaliate', 'volt-switch', 'work-up', 'wild-charge', 'confide', 'baby-doll-eyes'], 'name': 'jolteon', 'stats': {'hp': 65, 'attack': 65, 'defense': 60, 'special-attack': 110, 'special-defense': 95, 'speed': 130}, 'types': ['electric'], 'weight': 245, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'サンダース', 'roomaji': 'Thunders', 'ko': '쥬피썬더', 'zh-Hant': '雷伊布', 'fr': 'Voltali', 'de': 'Blitza', 'es': 'Jolteon', 'it': 'Jolteon', 'en': 'Jolteon', 'ja': 'サンダース', 'zh-Hans': '雷伊布'}, 'genera': {'ja-Hrkt': 'かみなりポケモン', 'ko': '번개포켓몬', 'zh-Hant': '雷寶可夢', 'fr': 'Pokémon Orage', 'de': 'Blitz', 'es': 'Pokémon Relámpago', 'it': 'Pokémon Luminoso', 'en': 'Lightning Pokémon', 'ja': 'かみなりポケモン', 'zh-Hans': '雷宝可梦'}}
	public class SpecieJolteon : PokemonSpecie
	{
#nullable enable
		private static SpecieJolteon? _instance = null;
#nullable restore
        public static SpecieJolteon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJolteon();
                }
                return _instance;
            }
        }

		public SpecieJolteon() : base(
			"Jolteon",
			65, // HPs
			65, 60, // Attack & Defense
			110, 95, // Special Attack & Defense
			130			
		) {}
	}


	//Jolteon Pokemon Class
	public class Jolteon : Pokemon
	{

		public Jolteon(string nickname, int level)
		: base(
				135,
				SpecieJolteon.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Jolteon(int level)
		: base(
				135,
				SpecieJolteon.Instance, // Pokemon Specie
				"Jolteon", level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Jolteon() : base(
			135,
			SpecieJolteon.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}