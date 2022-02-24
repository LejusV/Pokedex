using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Weepinbell Specie to store common natural stats of every {'abilities': ['chlorophyll', 'gluttony'], 'base_experience': 137, 'height': 10, 'id': 70, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'wrap', 'take-down', 'double-edge', 'acid', 'mega-drain', 'growth', 'razor-leaf', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'flash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'knock-off', 'secret-power', 'bullet-seed', 'natural-gift', 'wring-out', 'gastro-acid', 'worry-seed', 'sucker-punch', 'poison-jab', 'seed-bomb', 'energy-ball', 'captivate', 'grass-knot', 'bug-bite', 'venoshock', 'round', 'confide', 'infestation'], 'name': 'weepinbell', 'stats': {'hp': 65, 'attack': 90, 'defense': 50, 'special-attack': 85, 'special-defense': 45, 'speed': 55}, 'types': ['grass', 'poison'], 'weight': 64, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'blob', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium-slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'ウツドン', 'roomaji': 'Utsudon', 'ko': '우츠동', 'zh-Hant': '口呆花', 'fr': 'Boustiflor', 'de': 'Ultrigaria', 'es': 'Weepinbell', 'it': 'Weepinbell', 'en': 'Weepinbell', 'ja': 'ウツドン', 'zh-Hans': '口呆花'}, 'genera': {'ja-Hrkt': 'ハエとりポケモン', 'ko': '파리잡이포켓몬', 'zh-Hant': '捕蠅寶可夢', 'fr': 'Pokémon Carnivore', 'de': 'Fliegentod', 'es': 'Pokémon Matamoscas', 'it': 'Pokémon Moschivoro', 'en': 'Flycatcher Pokémon', 'ja': 'ハエとりポケモン', 'zh-Hans': '捕蝇宝可梦'}}
	public class SpecieWeepinbell : PokemonSpecie
	{
#nullable enable
		private static SpecieWeepinbell? _instance = null;
#nullable restore
        public static SpecieWeepinbell Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeepinbell();
                }
                return _instance;
            }
        }

		public SpecieWeepinbell() : base(
			"Weepinbell",
			65, // HPs
			90, 50, // Attack & Defense
			85, 45, // Special Attack & Defense
			55			
		) {}
	}


	//Weepinbell Pokemon Class
	public class Weepinbell : Pokemon
	{

		public Weepinbell(string nickname, int level)
		: base(
				70,
				SpecieWeepinbell.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Weepinbell() : base(
			70,
			SpecieWeepinbell.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}