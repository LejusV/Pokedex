using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shellos Specie to store common natural stats of every {'abilities': ['sticky-hold', 'storm-drain', 'sand-force'], 'base_experience': 65, 'height': 3, 'id': 422, 'moves': ['headbutt', 'body-slam', 'mist', 'surf', 'ice-beam', 'blizzard', 'counter', 'string-shot', 'fissure', 'toxic', 'double-team', 'recover', 'harden', 'sludge', 'amnesia', 'acid-armor', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'hidden-power', 'rain-dance', 'mirror-coat', 'ancient-power', 'whirlpool', 'stockpile', 'spit-up', 'swallow', 'hail', 'memento', 'facade', 'yawn', 'secret-power', 'dive', 'mud-sport', 'muddy-water', 'water-pulse', 'brine', 'natural-gift', 'trump-card', 'earth-power', 'mud-bomb', 'captivate', 'round', 'clear-smog', 'scald', 'confide', 'infestation'], 'name': 'shellos', 'stats': {'hp': 76, 'attack': 48, 'defense': 48, 'special-attack': 57, 'special-defense': 62, 'speed': 34}, 'types': ['water'], 'weight': 63, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['water1', 'indeterminate'], 'names': {'ja-Hrkt': 'カラナクシ', 'roomaji': 'Karanakushi', 'ko': '깝질무', 'zh-Hant': '無殼海兔', 'fr': 'Sancoki', 'de': 'Schalellos', 'es': 'Shellos', 'it': 'Shellos', 'en': 'Shellos', 'ja': 'カラナクシ', 'zh-Hans': '无壳海兔'}, 'genera': {'ja-Hrkt': 'ウミウシポケモン', 'ko': '갯민숭달팽이포켓몬', 'zh-Hant': '海兔寶可夢', 'fr': 'Pokémon Aqualimace', 'de': 'Seeschnecke', 'es': 'Pokémon Babosa Mar.', 'it': 'Pokémon Lumacomare', 'en': 'Sea Slug Pokémon', 'ja': 'ウミウシポケモン', 'zh-Hans': '海兔宝可梦'}}
	public class SpecieShellos : PokemonSpecie
	{
#nullable enable
		private static SpecieShellos? _instance = null;
#nullable restore
        public static SpecieShellos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShellos();
                }
                return _instance;
            }
        }

		public SpecieShellos() : base(
			"Shellos",
			76, // HPs
			48, 48, // Attack & Defense
			57, 62, // Special Attack & Defense
			34			
		) {}
	}


	//Shellos Pokemon Class
	public class Shellos : Pokemon
	{

		public Shellos(string nickname, int level)
		: base(
				422,
				SpecieShellos.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shellos() : base(
			422,
			SpecieShellos.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}