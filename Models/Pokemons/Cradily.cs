using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cradily Specie to store common natural stats of every {'abilities': ['suction-cups', 'storm-drain'], 'base_experience': 173, 'height': 15, 'id': 346, 'moves': ['swords-dance', 'bind', 'headbutt', 'body-slam', 'double-edge', 'acid', 'hyper-beam', 'strength', 'solar-beam', 'string-shot', 'earthquake', 'toxic', 'mimic', 'double-team', 'confuse-ray', 'constrict', 'amnesia', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'facade', 'ingrain', 'secret-power', 'astonish', 'rock-tomb', 'bullet-seed', 'block', 'brine', 'natural-gift', 'wring-out', 'gastro-acid', 'worry-seed', 'rock-polish', 'seed-bomb', 'energy-ball', 'earth-power', 'giga-impact', 'stone-edge', 'captivate', 'stealth-rock', 'grass-knot', 'smack-down', 'sludge-wave', 'round', 'bulldoze', 'confide', 'infestation'], 'name': 'cradily', 'stats': {'hp': 86, 'attack': 81, 'defense': 97, 'special-attack': 81, 'special-defense': 107, 'speed': 43}, 'types': ['rock', 'grass'], 'weight': 604, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'ユレイドル', 'roomaji': 'Yuradle', 'ko': '릴리요', 'zh-Hant': '搖籃百合', 'fr': 'Vacilys', 'de': 'Wielie', 'es': 'Cradily', 'it': 'Cradily', 'en': 'Cradily', 'ja': 'ユレイドル', 'zh-Hans': '摇篮百合'}, 'genera': {'ja-Hrkt': 'いわつぼポケモン', 'ko': '바위단지포켓몬', 'zh-Hant': '藤壺寶可夢', 'fr': 'Pokémon Bernacle', 'de': 'Rankfüßer', 'es': 'Pokémon Percebe', 'it': 'Pokémon Lepade', 'en': 'Barnacle Pokémon', 'ja': 'いわつぼポケモン', 'zh-Hans': '藤壶宝可梦'}}
	public class SpecieCradily : PokemonSpecie
	{
#nullable enable
		private static SpecieCradily? _instance = null;
#nullable restore
        public static SpecieCradily Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCradily();
                }
                return _instance;
            }
        }

		public SpecieCradily() : base(
			"Cradily",
			86, // HPs
			81, 97, // Attack & Defense
			81, 107, // Special Attack & Defense
			43			
		) {}
	}


	//Cradily Pokemon Class
	public class Cradily : Pokemon
	{

		public Cradily(string nickname, int level)
		: base(
				346,
				SpecieCradily.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cradily(int level)
		: base(
				346,
				SpecieCradily.Instance, // Pokemon Specie
				"Cradily", level,
				Rock.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cradily() : base(
			346,
			SpecieCradily.Instance, // Pokemon Specie
			Rock.Instance, Grass.Instance			
		) {}
	}
}