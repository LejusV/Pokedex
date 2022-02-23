using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lileep Specie to store common natural stats of every {'abilities': ['suction-cups', 'storm-drain'], 'base_experience': 71, 'height': 10, 'id': 345, 'moves': ['swords-dance', 'bind', 'body-slam', 'double-edge', 'acid', 'mega-drain', 'solar-beam', 'string-shot', 'toxic', 'mimic', 'double-team', 'recover', 'confuse-ray', 'barrier', 'constrict', 'amnesia', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'synthesis', 'hidden-power', 'sunny-day', 'mirror-coat', 'psych-up', 'ancient-power', 'stockpile', 'spit-up', 'swallow', 'facade', 'ingrain', 'secret-power', 'astonish', 'rock-tomb', 'tickle', 'bullet-seed', 'brine', 'natural-gift', 'wring-out', 'gastro-acid', 'worry-seed', 'rock-polish', 'seed-bomb', 'energy-ball', 'earth-power', 'captivate', 'stealth-rock', 'grass-knot', 'smack-down', 'round', 'confide', 'infestation'], 'name': 'lileep', 'stats': {'hp': 66, 'attack': 41, 'defense': 77, 'special-attack': 61, 'special-defense': 87, 'speed': 23}, 'types': ['rock', 'grass'], 'weight': 238, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'purple', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'リリーラ', 'roomaji': 'Lilyla', 'ko': '릴링', 'zh-Hant': '觸手百合', 'fr': 'Lilia', 'de': 'Liliep', 'es': 'Lileep', 'it': 'Lileep', 'en': 'Lileep', 'ja': 'リリーラ', 'zh-Hans': '触手百合'}, 'genera': {'ja-Hrkt': 'ウミユリポケモン', 'ko': '바다나리포켓몬', 'zh-Hant': '海百合寶可夢', 'fr': 'Pokémon Lis d’Eau', 'de': 'Seeanemone', 'es': 'Pokémon Lila Mar', 'it': 'Pokémon Fiordimare', 'en': 'Sea Lily Pokémon', 'ja': 'ウミユリポケモン', 'zh-Hans': '海百合宝可梦'}}
	public class SpecieLileep : PokemonSpecie
	{
#nullable enable
		private static SpecieLileep? _instance = null;
#nullable restore
        public static SpecieLileep Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLileep();
                }
                return _instance;
            }
        }

		public SpecieLileep() : base(
			"Lileep",
			66, // HPs
			41, 77, // Attack & Defense
			61, 87, // Special Attack & Defense
			23			
		) {}
	}


	//Lileep Pokemon Class
	public class Lileep : Pokemon
	{

		public Lileep(string nickname, int level) : base(
			345,
			SpecieLileep.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Grass.Instance			
		) {}

		public Lileep() : base(
			345,
			SpecieLileep.Instance, // Pokemon Specie
			Rock.Instance, Grass.Instance			
		) {}
	}
}