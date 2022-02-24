using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mimikyu-Disguised Specie to store common natural stats of every {'abilities': ['disguise'], 'base_experience': 167, 'height': 2, 'id': 778, 'moves': ['scratch', 'swords-dance', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'mimic', 'double-team', 'light-screen', 'dream-eater', 'leech-life', 'splash', 'rest', 'slash', 'substitute', 'thief', 'nightmare', 'curse', 'protect', 'feint-attack', 'destiny-bond', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'psych-up', 'shadow-ball', 'will-o-wisp', 'facade', 'taunt', 'grudge', 'astonish', 'bulk-up', 'payback', 'embargo', 'fling', 'copycat', 'dark-pulse', 'x-scissor', 'shadow-claw', 'shadow-sneak', 'trick-room', 'charge-beam', 'wood-hammer', 'hone-claws', 'round', 'work-up', 'play-rough', 'confide', 'dazzling-gleam', 'baby-doll-eyes', 'infestation'], 'name': 'mimikyu-disguised', 'stats': {'hp': 55, 'attack': 90, 'defense': 80, 'special-attack': 50, 'special-defense': 105, 'speed': 96}, 'types': ['ghost', 'fairy'], 'weight': 7, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'yellow', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ミミッキュ', 'ko': '따라큐', 'zh-Hant': '謎擬Ｑ', 'fr': 'Mimiqui', 'de': 'Mimigma', 'es': 'Mimikyu', 'it': 'Mimikyu', 'en': 'Mimikyu', 'ja': 'ミミッキュ', 'zh-Hans': '谜拟Ｑ'}, 'genera': {'ja-Hrkt': 'ばけのかわポケモン', 'ko': '탈포켓몬', 'zh-Hant': '畫皮寶可夢', 'fr': 'Pokémon Fantômasque', 'de': 'Kostümspuk', 'es': 'Pokémon Disfraz', 'it': 'Pokémon Fantasmanto', 'en': 'Disguise Pokémon', 'ja': 'ばけのかわポケモン', 'zh-Hans': '画皮宝可梦'}}
	public class SpecieMimikyuDisguised : PokemonSpecie
	{
#nullable enable
		private static SpecieMimikyuDisguised? _instance = null;
#nullable restore
        public static SpecieMimikyuDisguised Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMimikyuDisguised();
                }
                return _instance;
            }
        }

		public SpecieMimikyuDisguised() : base(
			"Mimikyu-Disguised",
			55, // HPs
			90, 80, // Attack & Defense
			50, 105, // Special Attack & Defense
			96			
		) {}
	}


	//Mimikyu-Disguised Pokemon Class
	public class MimikyuDisguised : Pokemon
	{

		public MimikyuDisguised(string nickname, int level)
		: base(
				778,
				SpecieMimikyuDisguised.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MimikyuDisguised() : base(
			778,
			SpecieMimikyuDisguised.Instance, // Pokemon Specie
			Ghost.Instance, Fairy.Instance			
		) {}
	}
}