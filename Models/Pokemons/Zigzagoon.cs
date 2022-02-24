using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zigzagoon Specie to store common natural stats of every {'abilities': ['pickup', 'gluttony', 'quick-feet'], 'base_experience': 56, 'height': 4, 'id': 263, 'moves': ['cut', 'sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'pin-missile', 'growl', 'surf', 'ice-beam', 'blizzard', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'mimic', 'double-team', 'defense-curl', 'swift', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'flail', 'protect', 'belly-drum', 'mud-slap', 'icy-wind', 'endure', 'charm', 'rollout', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'extreme-speed', 'shadow-ball', 'rock-smash', 'whirlpool', 'facade', 'helping-hand', 'trick', 'secret-power', 'mud-sport', 'hyper-voice', 'odor-sleuth', 'tickle', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'last-resort', 'seed-bomb', 'rock-climb', 'gunk-shot', 'captivate', 'grass-knot', 'charge-beam', 'hone-claws', 'simple-beam', 'round', 'echoed-voice', 'retaliate', 'bestow', 'work-up', 'confide', 'baby-doll-eyes'], 'name': 'zigzagoon', 'stats': {'hp': 38, 'attack': 30, 'defense': 41, 'special-attack': 30, 'special-defense': 41, 'speed': 60}, 'types': ['normal'], 'weight': 175, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ジグザグマ', 'roomaji': 'Ziguzaguma', 'ko': '지그제구리', 'zh-Hant': '蛇紋熊', 'fr': 'Zigzaton', 'de': 'Zigzachs', 'es': 'Zigzagoon', 'it': 'Zigzagoon', 'en': 'Zigzagoon', 'ja': 'ジグザグマ', 'zh-Hans': '蛇纹熊'}, 'genera': {'ja-Hrkt': 'まめだぬきポケモン', 'ko': '앙증너구리포켓몬', 'zh-Hant': '豆貍寶可夢', 'fr': 'Pokémon Petit Raton', 'de': 'Kleindachs', 'es': 'Pokémon Mapachito', 'it': 'Pokémon Procione', 'en': 'Tiny Raccoon Pokémon', 'ja': 'まめだぬきポケモン', 'zh-Hans': '豆狸宝可梦'}}
	public class SpecieZigzagoon : PokemonSpecie
	{
#nullable enable
		private static SpecieZigzagoon? _instance = null;
#nullable restore
        public static SpecieZigzagoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZigzagoon();
                }
                return _instance;
            }
        }

		public SpecieZigzagoon() : base(
			"Zigzagoon",
			38, // HPs
			30, 41, // Attack & Defense
			30, 41, // Special Attack & Defense
			60			
		) {}
	}


	//Zigzagoon Pokemon Class
	public class Zigzagoon : Pokemon
	{

		public Zigzagoon(string nickname, int level)
		: base(
				263,
				SpecieZigzagoon.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zigzagoon(int level)
		: base(
				263,
				SpecieZigzagoon.Instance, // Pokemon Specie
				"Zigzagoon", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zigzagoon() : base(
			263,
			SpecieZigzagoon.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}