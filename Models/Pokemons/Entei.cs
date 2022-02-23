using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Entei Specie to store common natural stats of every {'abilities': ['pressure', 'inner-focus'], 'base_experience': 261, 'height': 21, 'id': 244, 'moves': ['cut', 'stomp', 'headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'strength', 'solar-beam', 'fire-spin', 'dig', 'toxic', 'mimic', 'double-team', 'reflect', 'fire-blast', 'swift', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'detect', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'sacred-fire', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'eruption', 'secret-power', 'overheat', 'extrasensory', 'calm-mind', 'natural-gift', 'giga-impact', 'fire-fang', 'rock-climb', 'lava-plume', 'iron-head', 'stone-edge', 'flame-charge', 'round', 'incinerate', 'quash', 'bulldoze', 'snarl', 'confide'], 'name': 'entei', 'stats': {'hp': 115, 'attack': 115, 'defense': 85, 'special-attack': 90, 'special-defense': 75, 'speed': 100}, 'types': ['fire'], 'weight': 1980, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'エンテイ', 'roomaji': 'Entei', 'ko': '앤테이', 'zh-Hant': '炎帝', 'fr': 'Entei', 'de': 'Entei', 'es': 'Entei', 'it': 'Entei', 'en': 'Entei', 'ja': 'エンテイ', 'zh-Hans': '炎帝'}, 'genera': {'ja-Hrkt': 'かざんポケモン', 'ko': '화산포켓몬', 'zh-Hant': '火山寶可夢', 'fr': 'Pokémon Volcan', 'de': 'Vulkan', 'es': 'Pokémon Volcán', 'it': 'Pokémon Vulcano', 'en': 'Volcano Pokémon', 'ja': 'かざんポケモン', 'zh-Hans': '火山宝可梦'}}
	public class SpecieEntei : PokemonSpecie
	{
#nullable enable
		private static SpecieEntei? _instance = null;
#nullable restore
        public static SpecieEntei Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEntei();
                }
                return _instance;
            }
        }

		public SpecieEntei() : base(
			"Entei",
			115, // HPs
			115, 85, // Attack & Defense
			90, 75, // Special Attack & Defense
			100			
		) {}
	}


	//Entei Pokemon Class
	public class Entei : Pokemon
	{

		public Entei(string nickname, int level) : base(
			244,
			SpecieEntei.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Entei() : base(
			244,
			SpecieEntei.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}