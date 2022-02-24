using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poochyena Specie to store common natural stats of every {'abilities': ['run-away', 'quick-feet', 'rattled'], 'base_experience': 56, 'height': 5, 'id': 261, 'moves': ['sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'leer', 'bite', 'roar', 'counter', 'dig', 'toxic', 'mimic', 'double-team', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'mud-slap', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'yawn', 'snatch', 'secret-power', 'hyper-voice', 'poison-fang', 'astonish', 'odor-sleuth', 'howl', 'covet', 'natural-gift', 'payback', 'assurance', 'embargo', 'me-first', 'sucker-punch', 'dark-pulse', 'thunder-fang', 'ice-fang', 'fire-fang', 'captivate', 'foul-play', 'round', 'incinerate', 'retaliate', 'snarl', 'play-rough', 'confide'], 'name': 'poochyena', 'stats': {'hp': 35, 'attack': 55, 'defense': 35, 'special-attack': 30, 'special-defense': 30, 'speed': 35}, 'types': ['dark'], 'weight': 136, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'gray', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ポチエナ', 'roomaji': 'Pochiena', 'ko': '포챠나', 'zh-Hant': '土狼犬', 'fr': 'Medhyèna', 'de': 'Fiffyen', 'es': 'Poochyena', 'it': 'Poochyena', 'en': 'Poochyena', 'ja': 'ポチエナ', 'zh-Hans': '土狼犬'}, 'genera': {'ja-Hrkt': 'かみつきポケモン', 'ko': '물어뜯기포켓몬', 'zh-Hant': '緊咬寶可夢', 'fr': 'Pokémon Morsure', 'de': 'Biss', 'es': 'Pokémon Mordisco', 'it': 'Pokémon Morso', 'en': 'Bite Pokémon', 'ja': 'かみつきポケモン', 'zh-Hans': '紧咬宝可梦'}}
	public class SpeciePoochyena : PokemonSpecie
	{
#nullable enable
		private static SpeciePoochyena? _instance = null;
#nullable restore
        public static SpeciePoochyena Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoochyena();
                }
                return _instance;
            }
        }

		public SpeciePoochyena() : base(
			"Poochyena",
			35, // HPs
			55, 35, // Attack & Defense
			30, 30, // Special Attack & Defense
			35			
		) {}
	}


	//Poochyena Pokemon Class
	public class Poochyena : Pokemon
	{

		public Poochyena(string nickname, int level)
		: base(
				261,
				SpeciePoochyena.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Poochyena(int level)
		: base(
				261,
				SpeciePoochyena.Instance, // Pokemon Specie
				"Poochyena", level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Poochyena() : base(
			261,
			SpeciePoochyena.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}