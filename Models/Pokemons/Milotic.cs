using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Milotic Specie to store common natural stats of every {'abilities': ['marvel-scale', 'competitive', 'cute-charm'], 'base_experience': 189, 'height': 62, 'id': 350, 'moves': ['bind', 'body-slam', 'wrap', 'double-edge', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'mimic', 'double-team', 'recover', 'light-screen', 'waterfall', 'swift', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'psych-up', 'whirlpool', 'hail', 'facade', 'magic-coat', 'refresh', 'secret-power', 'dive', 'water-sport', 'water-pulse', 'natural-gift', 'aqua-ring', 'aqua-tail', 'dragon-pulse', 'giga-impact', 'avalanche', 'iron-head', 'captivate', 'coil', 'round', 'scald', 'bulldoze', 'dragon-tail', 'disarming-voice', 'confide', 'brutal-swing'], 'name': 'milotic', 'stats': {'hp': 95, 'attack': 60, 'defense': 79, 'special-attack': 100, 'special-defense': 125, 'speed': 81}, 'types': ['water'], 'weight': 1620, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'pink', 'shape': 'squiggle', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water1', 'dragon'], 'names': {'ja-Hrkt': 'ミロカロス', 'roomaji': 'Milokaross', 'ko': '밀로틱', 'zh-Hant': '美納斯', 'fr': 'Milobellus', 'de': 'Milotic', 'es': 'Milotic', 'it': 'Milotic', 'en': 'Milotic', 'ja': 'ミロカロス', 'zh-Hans': '美纳斯'}, 'genera': {'ja-Hrkt': 'いつくしみポケモン', 'ko': '사랑포켓몬', 'zh-Hant': '慈愛寶可夢', 'fr': 'Pokémon Tendre', 'de': 'Zartheit', 'es': 'Pokémon Tierno', 'it': 'Pokémon Tenerezza', 'en': 'Tender Pokémon', 'ja': 'いつくしみポケモン', 'zh-Hans': '慈爱宝可梦'}}
	public class SpecieMilotic : PokemonSpecie
	{
#nullable enable
		private static SpecieMilotic? _instance = null;
#nullable restore
        public static SpecieMilotic Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMilotic();
                }
                return _instance;
            }
        }

		public SpecieMilotic() : base(
			"Milotic",
			95, // HPs
			60, 79, // Attack & Defense
			100, 125, // Special Attack & Defense
			81			
		) {}
	}


	//Milotic Pokemon Class
	public class Milotic : Pokemon
	{

		public Milotic(string nickname, int level)
		: base(
				350,
				SpecieMilotic.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Milotic() : base(
			350,
			SpecieMilotic.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}