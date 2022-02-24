using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kakuna Specie to store common natural stats of every {'abilities': ['shed-skin'], 'base_experience': 72, 'height': 6, 'id': 14, 'moves': ['string-shot', 'harden', 'iron-defense', 'bug-bite', 'electroweb'], 'name': 'kakuna', 'stats': {'hp': 45, 'attack': 25, 'defense': 50, 'special-attack': 25, 'special-defense': 25, 'speed': 35}, 'types': ['bug', 'poison'], 'weight': 100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'yellow', 'shape': 'squiggle', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'コクーン', 'roomaji': 'Cocoon', 'ko': '딱충이', 'zh-Hant': '鐵殼蛹', 'fr': 'Coconfort', 'de': 'Kokuna', 'es': 'Kakuna', 'it': 'Kakuna', 'en': 'Kakuna', 'ja': 'コクーン', 'zh-Hans': '铁壳蛹'}, 'genera': {'ja-Hrkt': 'さなぎポケモン', 'ko': '번데기포켓몬', 'zh-Hant': '蛹寶可夢', 'fr': 'Pokémon Cocon', 'de': 'Kokon', 'es': 'Pokémon Capullo', 'it': 'Pokémon Bozzolo', 'en': 'Cocoon Pokémon', 'ja': 'さなぎポケモン', 'zh-Hans': '蛹宝可梦'}}
	public class SpecieKakuna : PokemonSpecie
	{
#nullable enable
		private static SpecieKakuna? _instance = null;
#nullable restore
        public static SpecieKakuna Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKakuna();
                }
                return _instance;
            }
        }

		public SpecieKakuna() : base(
			"Kakuna",
			45, // HPs
			25, 50, // Attack & Defense
			25, 25, // Special Attack & Defense
			35			
		) {}
	}


	//Kakuna Pokemon Class
	public class Kakuna : Pokemon
	{

		public Kakuna(string nickname, int level)
		: base(
				14,
				SpecieKakuna.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kakuna(int level)
		: base(
				14,
				SpecieKakuna.Instance, // Pokemon Specie
				"Kakuna", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kakuna() : base(
			14,
			SpecieKakuna.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}