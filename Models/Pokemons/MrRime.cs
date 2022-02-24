using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mr-Rime Specie to store common natural stats of every {'abilities': ['tangled-feet', 'screen-cleaner', 'ice-body'], 'base_experience': 182, 'height': 15, 'id': 866, 'moves': [], 'name': 'mr-rime', 'stats': {'hp': 80, 'attack': 85, 'defense': 75, 'special-attack': 110, 'special-defense': 100, 'speed': 70}, 'types': ['ice', 'psychic'], 'weight': 582, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'バリコオル', 'ko': '마임꽁꽁', 'zh-Hant': '踏冰人偶', 'fr': 'M. Glaquette', 'de': 'Pantifrost', 'es': 'Mr. Rime', 'it': 'Mr. Rime', 'en': 'Mr. Rime', 'ja': 'バリコオル', 'zh-Hans': '踏冰人偶'}, 'genera': {'ja-Hrkt': 'コメディアンポケモン', 'ko': '코미디언포켓몬', 'zh-Hant': '喜劇演員寶可夢', 'fr': 'Pokémon Comédien', 'de': 'Komiker', 'es': 'Pokémon Cómico', 'it': 'Pokémon Comico', 'en': 'Comedian Pokémon', 'ja': 'コメディアンポケモン', 'zh-Hans': '喜剧演员宝可梦'}}
	public class SpecieMrRime : PokemonSpecie
	{
#nullable enable
		private static SpecieMrRime? _instance = null;
#nullable restore
        public static SpecieMrRime Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMrRime();
                }
                return _instance;
            }
        }

		public SpecieMrRime() : base(
			"Mr-Rime",
			80, // HPs
			85, 75, // Attack & Defense
			110, 100, // Special Attack & Defense
			70			
		) {}
	}


	//Mr-Rime Pokemon Class
	public class MrRime : Pokemon
	{

		public MrRime(string nickname, int level)
		: base(
				866,
				SpecieMrRime.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MrRime(int level)
		: base(
				866,
				SpecieMrRime.Instance, // Pokemon Specie
				"Mr-Rime", level,
				Ice.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public MrRime() : base(
			866,
			SpecieMrRime.Instance, // Pokemon Specie
			Ice.Instance, Psychic.Instance			
		) {}
	}
}