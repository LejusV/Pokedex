using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Indeedee-Male Specie to store common natural stats of every {'abilities': ['inner-focus', 'synchronize', 'psychic-surge'], 'base_experience': 166, 'height': 9, 'id': 876, 'moves': [], 'name': 'indeedee-male', 'stats': {'hp': 60, 'attack': 65, 'defense': 55, 'special-attack': 105, 'special-defense': 95, 'speed': 95}, 'types': ['psychic', 'normal'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 30, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'イエッサン', 'ko': '에써르', 'zh-Hant': '愛管侍', 'fr': 'Wimessir', 'de': 'Servol', 'es': 'Indeedee', 'it': 'Indeedee', 'en': 'Indeedee', 'ja': 'イエッサン', 'zh-Hans': '爱管侍'}, 'genera': {'ja-Hrkt': 'かんじょうポケモン', 'ko': '감정포켓몬', 'zh-Hant': '感情寶可夢', 'fr': 'Pokémon Émotion', 'de': 'Emotion', 'es': 'Pokémon Sensorio', 'it': 'Pokémon Emozione', 'en': 'Emotion Pokémon', 'ja': 'かんじょうポケモン', 'zh-Hans': '感情宝可梦'}}
	public class SpecieIndeedeeMale : PokemonSpecie
	{
#nullable enable
		private static SpecieIndeedeeMale? _instance = null;
#nullable restore
        public static SpecieIndeedeeMale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieIndeedeeMale();
                }
                return _instance;
            }
        }

		public SpecieIndeedeeMale() : base(
			"Indeedee-Male",
			60, // HPs
			65, 55, // Attack & Defense
			105, 95, // Special Attack & Defense
			95			
		) {}
	}


	//Indeedee-Male Pokemon Class
	public class IndeedeeMale : Pokemon
	{

		public IndeedeeMale(string nickname, int level)
		: base(
				876,
				SpecieIndeedeeMale.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public IndeedeeMale(int level)
		: base(
				876,
				SpecieIndeedeeMale.Instance, // Pokemon Specie
				"Indeedee-Male", level,
				Psychic.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public IndeedeeMale() : base(
			876,
			SpecieIndeedeeMale.Instance, // Pokemon Specie
			Psychic.Instance, Normal.Instance			
		) {}
	}
}