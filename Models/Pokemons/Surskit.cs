using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Surskit Specie to store common natural stats of every {'abilities': ['swift-swim', 'rain-dish'], 'base_experience': 54, 'height': 5, 'id': 283, 'moves': ['double-edge', 'mist', 'hydro-pump', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'solar-beam', 'string-shot', 'toxic', 'agility', 'quick-attack', 'mimic', 'double-team', 'haze', 'swift', 'bubble', 'flash', 'rest', 'substitute', 'thief', 'mind-reader', 'snore', 'protect', 'mud-slap', 'foresight', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'secret-power', 'signal-beam', 'mud-shot', 'water-sport', 'water-pulse', 'natural-gift', 'captivate', 'bug-bite', 'aqua-jet', 'power-split', 'round', 'scald', 'struggle-bug', 'sticky-web', 'fell-stinger', 'confide', 'infestation', 'lunge'], 'name': 'surskit', 'stats': {'hp': 40, 'attack': 30, 'defense': 32, 'special-attack': 50, 'special-defense': 52, 'speed': 65}, 'types': ['bug', 'water'], 'weight': 17, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 200, 'color': 'blue', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'bug'], 'names': {'ja-Hrkt': 'アメタマ', 'roomaji': 'Ametama', 'ko': '비구술', 'zh-Hant': '溜溜糖球', 'fr': 'Arakdo', 'de': 'Gehweiher', 'es': 'Surskit', 'it': 'Surskit', 'en': 'Surskit', 'ja': 'アメタマ', 'zh-Hans': '溜溜糖球'}, 'genera': {'ja-Hrkt': 'あめんぼポケモン', 'ko': '소금쟁이포켓몬', 'zh-Hant': '水黽寶可夢', 'fr': 'Pokémon Maresurfeur', 'de': 'Wassergeher', 'es': 'Pokémon Zapatero', 'it': 'Pokémon Sfiorapozze', 'en': 'Pond Skater Pokémon', 'ja': 'あめんぼポケモン', 'zh-Hans': '水黾宝可梦'}}
	public class SpecieSurskit : PokemonSpecie
	{
#nullable enable
		private static SpecieSurskit? _instance = null;
#nullable restore
        public static SpecieSurskit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSurskit();
                }
                return _instance;
            }
        }

		public SpecieSurskit() : base(
			"Surskit",
			40, // HPs
			30, 32, // Attack & Defense
			50, 52, // Special Attack & Defense
			65			
		) {}
	}


	//Surskit Pokemon Class
	public class Surskit : Pokemon
	{

		public Surskit(string nickname, int level)
		: base(
				283,
				SpecieSurskit.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Surskit() : base(
			283,
			SpecieSurskit.Instance, // Pokemon Specie
			Bug.Instance, Water.Instance			
		) {}
	}
}