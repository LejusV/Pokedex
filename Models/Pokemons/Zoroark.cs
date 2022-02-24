using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zoroark Specie to store common natural stats of every {'abilities': ['illusion'], 'base_experience': 179, 'height': 16, 'id': 571, 'moves': ['scratch', 'swords-dance', 'cut', 'leer', 'roar', 'flamethrower', 'hyper-beam', 'low-kick', 'dig', 'toxic', 'agility', 'double-team', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'feint-attack', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'trick', 'knock-off', 'imprison', 'snatch', 'secret-power', 'hyper-voice', 'aerial-ace', 'bounce', 'covet', 'calm-mind', 'u-turn', 'payback', 'embargo', 'fling', 'punishment', 'dark-pulse', 'night-slash', 'focus-blast', 'giga-impact', 'nasty-plot', 'shadow-claw', 'grass-knot', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'incinerate', 'retaliate', 'night-daze', 'snarl', 'confide'], 'name': 'zoroark', 'stats': {'hp': 60, 'attack': 105, 'defense': 60, 'special-attack': 120, 'special-defense': 60, 'speed': 105}, 'types': ['dark'], 'weight': 811, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ゾロアーク', 'ko': '조로아크', 'zh-Hant': '索羅亞克', 'fr': 'Zoroark', 'de': 'Zoroark', 'es': 'Zoroark', 'it': 'Zoroark', 'en': 'Zoroark', 'ja': 'ゾロアーク', 'zh-Hans': '索罗亚克'}, 'genera': {'ja-Hrkt': 'ばけぎつねポケモン', 'ko': '요괴여우포켓몬', 'zh-Hant': '妖狐寶可夢', 'fr': 'Pokémon Polymorfox', 'de': 'Polymorfuchs', 'es': 'Pokémon Disfrazorro', 'it': 'Pokémon Mutevolpe', 'en': 'Illusion Fox Pokémon', 'ja': 'ばけぎつねポケモン', 'zh-Hans': '妖狐宝可梦'}}
	public class SpecieZoroark : PokemonSpecie
	{
#nullable enable
		private static SpecieZoroark? _instance = null;
#nullable restore
        public static SpecieZoroark Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZoroark();
                }
                return _instance;
            }
        }

		public SpecieZoroark() : base(
			"Zoroark",
			60, // HPs
			105, 60, // Attack & Defense
			120, 60, // Special Attack & Defense
			105			
		) {}
	}


	//Zoroark Pokemon Class
	public class Zoroark : Pokemon
	{

		public Zoroark(string nickname, int level)
		: base(
				571,
				SpecieZoroark.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Zoroark() : base(
			571,
			SpecieZoroark.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}