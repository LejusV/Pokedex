using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Onix Specie to store common natural stats of every {'abilities': ['rock-head', 'sturdy', 'weak-armor'], 'base_experience': 77, 'height': 88, 'id': 95, 'moves': ['bind', 'slam', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'roar', 'strength', 'rock-throw', 'earthquake', 'fissure', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'harden', 'defense-curl', 'bide', 'self-destruct', 'skull-bash', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'flail', 'protect', 'mud-slap', 'sandstorm', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'torment', 'facade', 'nature-power', 'taunt', 'secret-power', 'mud-sport', 'rock-tomb', 'sand-tomb', 'block', 'rock-blast', 'gyro-ball', 'natural-gift', 'payback', 'rock-polish', 'dragon-pulse', 'earth-power', 'flash-cannon', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'wide-guard', 'smack-down', 'heavy-slam', 'round', 'bulldoze', 'dragon-tail', 'rototiller', 'confide', 'brutal-swing'], 'name': 'onix', 'stats': {'hp': 35, 'attack': 45, 'defense': 160, 'special-attack': 30, 'special-defense': 45, 'speed': 70}, 'types': ['rock', 'ground'], 'weight': 2100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'gray', 'shape': 'squiggle', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'イワーク', 'roomaji': 'Iwark', 'ko': '롱스톤', 'zh-Hant': '大岩蛇', 'fr': 'Onix', 'de': 'Onix', 'es': 'Onix', 'it': 'Onix', 'en': 'Onix', 'ja': 'イワーク', 'zh-Hans': '大岩蛇'}, 'genera': {'ja-Hrkt': 'いわへびポケモン', 'ko': '돌뱀포켓몬', 'zh-Hant': '岩蛇寶可夢', 'fr': 'Pokémon Serpenroc', 'de': 'Felsnatter', 'es': 'Pokémon Serp. Roca', 'it': 'Pokémon Serpesasso', 'en': 'Rock Snake Pokémon', 'ja': 'いわへびポケモン', 'zh-Hans': '岩蛇宝可梦'}}
	public class SpecieOnix : PokemonSpecie
	{
#nullable enable
		private static SpecieOnix? _instance = null;
#nullable restore
        public static SpecieOnix Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOnix();
                }
                return _instance;
            }
        }

		public SpecieOnix() : base(
			"Onix",
			35, // HPs
			45, 160, // Attack & Defense
			30, 45, // Special Attack & Defense
			70			
		) {}
	}


	//Onix Pokemon Class
	public class Onix : Pokemon
	{

		public Onix(string nickname, int level) : base(
			95,
			SpecieOnix.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Ground.Instance			
		) {}

		public Onix() : base(
			95,
			SpecieOnix.Instance, // Pokemon Specie
			Rock.Instance, Ground.Instance			
		) {}
	}
}