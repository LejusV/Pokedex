using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Steelix Specie to store common natural stats of every {'abilities': ['rock-head', 'sturdy', 'sheer-force'], 'base_experience': 179, 'height': 92, 'id': 208, 'moves': ['cut', 'bind', 'slam', 'headbutt', 'tackle', 'body-slam', 'double-edge', 'roar', 'hyper-beam', 'strength', 'rock-throw', 'earthquake', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'harden', 'defense-curl', 'self-destruct', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'sunny-day', 'crunch', 'psych-up', 'ancient-power', 'rock-smash', 'torment', 'facade', 'nature-power', 'taunt', 'secret-power', 'mud-sport', 'rock-tomb', 'block', 'gyro-ball', 'natural-gift', 'payback', 'magnet-rise', 'rock-polish', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'earth-power', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'flash-cannon', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'autotomize', 'smack-down', 'round', 'bulldoze', 'dragon-tail', 'confide', 'brutal-swing'], 'name': 'steelix', 'stats': {'hp': 75, 'attack': 85, 'defense': 200, 'special-attack': 55, 'special-defense': 65, 'speed': 30}, 'types': ['steel', 'ground'], 'weight': 4000, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 25, 'color': 'gray', 'shape': 'squiggle', 'habitat': 'cave', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ハガネール', 'roomaji': 'Haganeil', 'ko': '강철톤', 'zh-Hant': '大鋼蛇', 'fr': 'Steelix', 'de': 'Stahlos', 'es': 'Steelix', 'it': 'Steelix', 'en': 'Steelix', 'ja': 'ハガネール', 'zh-Hans': '大钢蛇'}, 'genera': {'ja-Hrkt': 'てつへびポケモン', 'ko': '철뱀포켓몬', 'zh-Hant': '鐵蛇寶可夢', 'fr': 'Pokémon Serpenfer', 'de': 'Stahlboa', 'es': 'Pokémon Serpférrea', 'it': 'Pokémon Ferroserpe', 'en': 'Iron Snake Pokémon', 'ja': 'てつへびポケモン', 'zh-Hans': '铁蛇宝可梦'}}
	public class SpecieSteelix : PokemonSpecie
	{
#nullable enable
		private static SpecieSteelix? _instance = null;
#nullable restore
        public static SpecieSteelix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSteelix();
                }
                return _instance;
            }
        }

		public SpecieSteelix() : base(
			"Steelix",
			75, // HPs
			85, 200, // Attack & Defense
			55, 65, // Special Attack & Defense
			30			
		) {}
	}


	//Steelix Pokemon Class
	public class Steelix : Pokemon
	{

		public Steelix(string nickname, int level)
		: base(
				208,
				SpecieSteelix.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Steelix(int level)
		: base(
				208,
				SpecieSteelix.Instance, // Pokemon Specie
				"Steelix", level,
				Steel.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Steelix() : base(
			208,
			SpecieSteelix.Instance, // Pokemon Specie
			Steel.Instance, Ground.Instance			
		) {}
	}
}