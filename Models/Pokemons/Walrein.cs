using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Walrein Specie to store common natural stats of every {'abilities': ['thick-fat', 'ice-body', 'oblivious'], 'base_experience': 239, 'height': 14, 'id': 365, 'moves': ['headbutt', 'body-slam', 'double-edge', 'growl', 'roar', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'aurora-beam', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'waterfall', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'crunch', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'ice-ball', 'rock-tomb', 'signal-beam', 'sheer-cold', 'block', 'water-pulse', 'brine', 'natural-gift', 'aqua-tail', 'giga-impact', 'avalanche', 'ice-fang', 'iron-head', 'captivate', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'confide'], 'name': 'walrein', 'stats': {'hp': 110, 'attack': 80, 'defense': 90, 'special-attack': 95, 'special-defense': 90, 'speed': 65}, 'types': ['ice', 'water'], 'weight': 1506, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'トドゼルガ', 'roomaji': 'Todoseruga', 'ko': '씨카이저', 'zh-Hant': '帝牙海獅', 'fr': 'Kaimorse', 'de': 'Walraisa', 'es': 'Walrein', 'it': 'Walrein', 'en': 'Walrein', 'ja': 'トドゼルガ', 'zh-Hans': '帝牙海狮'}, 'genera': {'ja-Hrkt': 'こおりわりポケモン', 'ko': '얼음깨기포켓몬', 'zh-Hant': '破冰寶可夢', 'fr': 'Pokémon Brise Glace', 'de': 'Eisbrecher', 'es': 'Pokémon Rompehielo', 'it': 'Pokémon Spaccagelo', 'en': 'Ice Break Pokémon', 'ja': 'こおりわりポケモン', 'zh-Hans': '破冰宝可梦'}}
	public class SpecieWalrein : PokemonSpecie
	{
#nullable enable
		private static SpecieWalrein? _instance = null;
#nullable restore
        public static SpecieWalrein Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWalrein();
                }
                return _instance;
            }
        }

		public SpecieWalrein() : base(
			"Walrein",
			110, // HPs
			80, 90, // Attack & Defense
			95, 90, // Special Attack & Defense
			65			
		) {}
	}


	//Walrein Pokemon Class
	public class Walrein : Pokemon
	{

		public Walrein(string nickname, int level)
		: base(
				365,
				SpecieWalrein.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Walrein(int level)
		: base(
				365,
				SpecieWalrein.Instance, // Pokemon Specie
				"Walrein", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Walrein() : base(
			365,
			SpecieWalrein.Instance, // Pokemon Specie
			Ice.Instance, Water.Instance			
		) {}
	}
}