using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zorua Specie to store common natural stats of every {'abilities': ['illusion'], 'base_experience': 66, 'height': 7, 'id': 570, 'moves': ['scratch', 'swords-dance', 'cut', 'leer', 'roar', 'counter', 'dig', 'toxic', 'agility', 'double-team', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'feint-attack', 'detect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'memento', 'facade', 'taunt', 'trick', 'knock-off', 'imprison', 'snatch', 'secret-power', 'hyper-voice', 'fake-tears', 'extrasensory', 'aerial-ace', 'bounce', 'covet', 'calm-mind', 'u-turn', 'payback', 'embargo', 'fling', 'copycat', 'punishment', 'sucker-punch', 'dark-pulse', 'nasty-plot', 'captivate', 'grass-knot', 'hone-claws', 'foul-play', 'round', 'incinerate', 'retaliate', 'night-daze', 'snarl', 'confide'], 'name': 'zorua', 'stats': {'hp': 40, 'attack': 65, 'defense': 40, 'special-attack': 80, 'special-defense': 40, 'speed': 65}, 'types': ['dark'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 1, 'capture_rate': 75, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ゾロア', 'ko': '조로아', 'zh-Hant': '索羅亞', 'fr': 'Zorua', 'de': 'Zorua', 'es': 'Zorua', 'it': 'Zorua', 'en': 'Zorua', 'ja': 'ゾロア', 'zh-Hans': '索罗亚'}, 'genera': {'ja-Hrkt': 'わるぎつねポケモン', 'ko': '나쁜여우포켓몬', 'zh-Hant': '惡狐寶可夢', 'fr': 'Pokémon Sombrenard', 'de': 'Lausefuchs', 'es': 'Pokémon Zorro Pillo', 'it': 'Pokémon Malavolpe', 'en': 'Tricky Fox Pokémon', 'ja': 'わるぎつねポケモン', 'zh-Hans': '恶狐宝可梦'}}
	public class SpecieZorua : PokemonSpecie
	{
#nullable enable
		private static SpecieZorua? _instance = null;
#nullable restore
        public static SpecieZorua Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZorua();
                }
                return _instance;
            }
        }

		public SpecieZorua() : base(
			"Zorua",
			40, // HPs
			65, 40, // Attack & Defense
			80, 40, // Special Attack & Defense
			65			
		) {}
	}


	//Zorua Pokemon Class
	public class Zorua : Pokemon
	{

		public Zorua(string nickname, int level)
		: base(
				570,
				SpecieZorua.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zorua() : base(
			570,
			SpecieZorua.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}