using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Heatran Specie to store common natural stats of every {'abilities': ['flash-fire', 'flame-body'], 'base_experience': 270, 'height': 17, 'id': 485, 'moves': ['headbutt', 'leer', 'roar', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'fire-spin', 'earthquake', 'dig', 'toxic', 'double-team', 'fire-blast', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'crunch', 'ancient-power', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'nature-power', 'taunt', 'secret-power', 'overheat', 'rock-tomb', 'metal-sound', 'iron-defense', 'natural-gift', 'payback', 'dark-pulse', 'dragon-pulse', 'earth-power', 'giga-impact', 'fire-fang', 'flash-cannon', 'rock-climb', 'lava-plume', 'iron-head', 'stone-edge', 'captivate', 'stealth-rock', 'bug-bite', 'magma-storm', 'flame-charge', 'round', 'incinerate', 'bulldoze', 'confide'], 'name': 'heatran', 'stats': {'hp': 91, 'attack': 90, 'defense': 106, 'special-attack': 130, 'special-defense': 106, 'speed': 77}, 'types': ['fire', 'steel'], 'weight': 4300, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 3, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ヒードラン', 'roomaji': 'Heatran', 'ko': '히드런', 'zh-Hant': '席多藍恩', 'fr': 'Heatran', 'de': 'Heatran', 'es': 'Heatran', 'it': 'Heatran', 'en': 'Heatran', 'ja': 'ヒードラン', 'zh-Hans': '席多蓝恩'}, 'genera': {'ja-Hrkt': 'かこうポケモン', 'ko': '화구포켓몬', 'zh-Hant': '火山口寶可夢', 'fr': 'Pokémon Caldeira', 'de': 'Lavadom', 'es': 'Pokémon Domo Lava', 'it': 'Pokémon Cratere', 'en': 'Lava Dome Pokémon', 'ja': 'かこうポケモン', 'zh-Hans': '火山口宝可梦'}}
	public class SpecieHeatran : PokemonSpecie
	{
#nullable enable
		private static SpecieHeatran? _instance = null;
#nullable restore
        public static SpecieHeatran Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHeatran();
                }
                return _instance;
            }
        }

		public SpecieHeatran() : base(
			"Heatran",
			91, // HPs
			90, 106, // Attack & Defense
			130, 106, // Special Attack & Defense
			77			
		) {}
	}


	//Heatran Pokemon Class
	public class Heatran : Pokemon
	{

		public Heatran(string nickname, int level) : base(
			485,
			SpecieHeatran.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Steel.Instance			
		) {}

		public Heatran() : base(
			485,
			SpecieHeatran.Instance, // Pokemon Specie
			Fire.Instance, Steel.Instance			
		) {}
	}
}