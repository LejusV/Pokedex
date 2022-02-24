using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tapu-Fini Specie to store common natural stats of every {'abilities': ['misty-surge', 'telepathy'], 'base_experience': 257, 'height': 13, 'id': 788, 'moves': ['mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'double-team', 'withdraw', 'light-screen', 'haze', 'reflect', 'waterfall', 'substitute', 'protect', 'swagger', 'mean-look', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'whirlpool', 'torment', 'facade', 'nature-power', 'taunt', 'refresh', 'muddy-water', 'calm-mind', 'water-pulse', 'brine', 'fling', 'aqua-ring', 'giga-impact', 'defog', 'grass-knot', 'soak', 'round', 'echoed-voice', 'scald', 'heal-pulse', 'misty-terrain', 'moonblast', 'confide', 'dazzling-gleam', 'smart-strike', 'natures-madness'], 'name': 'tapu-fini', 'stats': {'hp': 70, 'attack': 75, 'defense': 115, 'special-attack': 95, 'special-defense': 130, 'speed': 85}, 'types': ['water', 'fairy'], 'weight': 212, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': -1, 'capture_rate': 3, 'color': 'purple', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'カプ・レヒレ', 'ko': '카푸느지느', 'zh-Hant': '卡璞・鰭鰭', 'fr': 'Tokopisco', 'de': 'Kapu-Kime', 'es': 'Tapu Fini', 'it': 'Tapu Fini', 'en': 'Tapu Fini', 'ja': 'カプ・レヒレ', 'zh-Hans': '卡璞・鳍鳍'}, 'genera': {'ja-Hrkt': 'とちがみポケモン', 'ko': '토속신포켓몬', 'zh-Hant': '土地神寶可夢', 'fr': 'Pokémon Tutélaire', 'de': 'Schutzpatron', 'es': 'Pokémon Dios Nativo', 'it': 'Pokémon Nume Locale', 'en': 'Land Spirit Pokémon', 'ja': 'とちがみポケモン', 'zh-Hans': '土地神宝可梦'}}
	public class SpecieTapuFini : PokemonSpecie
	{
#nullable enable
		private static SpecieTapuFini? _instance = null;
#nullable restore
        public static SpecieTapuFini Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTapuFini();
                }
                return _instance;
            }
        }

		public SpecieTapuFini() : base(
			"Tapu-Fini",
			70, // HPs
			75, 115, // Attack & Defense
			95, 130, // Special Attack & Defense
			85			
		) {}
	}


	//Tapu-Fini Pokemon Class
	public class TapuFini : Pokemon
	{

		public TapuFini(string nickname, int level)
		: base(
				788,
				SpecieTapuFini.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public TapuFini(int level)
		: base(
				788,
				SpecieTapuFini.Instance, // Pokemon Specie
				"Tapu-Fini", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public TapuFini() : base(
			788,
			SpecieTapuFini.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
	}
}