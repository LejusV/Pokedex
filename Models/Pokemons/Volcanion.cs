using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Volcanion Specie to store common natural stats of every {'abilities': ['water-absorb'], 'base_experience': 270, 'height': 17, 'id': 721, 'moves': ['cut', 'stomp', 'body-slam', 'take-down', 'roar', 'flamethrower', 'mist', 'hydro-pump', 'hyper-beam', 'strength', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'haze', 'fire-blast', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sludge-bomb', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'superpower', 'brick-break', 'secret-power', 'weather-ball', 'overheat', 'water-pulse', 'gyro-ball', 'fling', 'flare-blitz', 'focus-blast', 'earth-power', 'giga-impact', 'flash-cannon', 'stone-edge', 'smack-down', 'sludge-wave', 'flame-charge', 'round', 'scald', 'incinerate', 'bulldoze', 'confide', 'steam-eruption'], 'name': 'volcanion', 'stats': {'hp': 80, 'attack': 110, 'defense': 120, 'special-attack': 130, 'special-defense': 90, 'speed': 70}, 'types': ['fire', 'water'], 'weight': 1950, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'it': 'Volcanion', 'ja-Hrkt': 'ボルケニオン', 'ko': '볼케니온', 'zh-Hant': '波爾凱尼恩', 'fr': 'Volcanion', 'de': 'Volcanion', 'es': 'Volcanion', 'en': 'Volcanion', 'ja': 'ボルケニオン', 'zh-Hans': '波尔凯尼恩'}, 'genera': {'it': 'Pokémon Vapore', 'ja-Hrkt': 'スチームポケモン', 'ko': '스팀포켓몬', 'zh-Hant': '蒸汽寶可夢', 'fr': 'Pokémon Vapeur', 'de': 'Dampf', 'es': 'Pokémon Vapor', 'en': 'Steam Pokémon', 'ja': 'スチームポケモン', 'zh-Hans': '蒸汽宝可梦'}}
	public class SpecieVolcanion : PokemonSpecie
	{
#nullable enable
		private static SpecieVolcanion? _instance = null;
#nullable restore
        public static SpecieVolcanion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVolcanion();
                }
                return _instance;
            }
        }

		public SpecieVolcanion() : base(
			"Volcanion",
			80, // HPs
			110, 120, // Attack & Defense
			130, 90, // Special Attack & Defense
			70			
		) {}
	}


	//Volcanion Pokemon Class
	public class Volcanion : Pokemon
	{

		public Volcanion(string nickname, int level)
		: base(
				721,
				SpecieVolcanion.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Volcanion() : base(
			721,
			SpecieVolcanion.Instance, // Pokemon Specie
			Fire.Instance, Water.Instance			
		) {}
	}
}