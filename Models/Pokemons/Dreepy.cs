using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dreepy Specie to store common natural stats of every {'abilities': ['clear-body', 'infiltrator', 'cursed-body'], 'base_experience': 54, 'height': 5, 'id': 885, 'moves': [], 'name': 'dreepy', 'stats': {'hp': 28, 'attack': 60, 'defense': 30, 'special-attack': 40, 'special-defense': 30, 'speed': 82}, 'types': ['dragon', 'ghost'], 'weight': 20, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ドラメシヤ', 'ko': '드라꼰', 'zh-Hant': '多龍梅西亞', 'fr': 'Fantyrm', 'de': 'Grolldra', 'es': 'Dreepy', 'it': 'Dreepy', 'en': 'Dreepy', 'ja': 'ドラメシヤ', 'zh-Hans': '多龙梅西亚'}, 'genera': {'ja-Hrkt': 'うらめしポケモン', 'ko': '원망포켓몬', 'zh-Hant': '哀怨寶可夢', 'fr': 'Pokémon Âme Errante', 'de': 'Missgunst', 'es': 'Pokémon Resentido', 'it': 'Pokémon Risentimento', 'en': 'Lingering Pokémon', 'ja': 'うらめしポケモン', 'zh-Hans': '哀怨宝可梦'}}
	public class SpecieDreepy : PokemonSpecie
	{
#nullable enable
		private static SpecieDreepy? _instance = null;
#nullable restore
        public static SpecieDreepy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDreepy();
                }
                return _instance;
            }
        }

		public SpecieDreepy() : base(
			"Dreepy",
			28, // HPs
			60, 30, // Attack & Defense
			40, 30, // Special Attack & Defense
			82			
		) {}
	}


	//Dreepy Pokemon Class
	public class Dreepy : Pokemon
	{

		public Dreepy(string nickname, int level)
		: base(
				885,
				SpecieDreepy.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dreepy(int level)
		: base(
				885,
				SpecieDreepy.Instance, // Pokemon Specie
				"Dreepy", level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dreepy() : base(
			885,
			SpecieDreepy.Instance, // Pokemon Specie
			Dragon.Instance, Ghost.Instance			
		) {}
	}
}