using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spewpa Specie to store common natural stats of every {'abilities': ['shed-skin', 'friend-guard'], 'base_experience': 75, 'height': 3, 'id': 665, 'moves': ['harden', 'protect', 'iron-defense', 'bug-bite', 'electroweb'], 'name': 'spewpa', 'stats': {'hp': 45, 'attack': 22, 'defense': 60, 'special-attack': 27, 'special-defense': 30, 'speed': 29}, 'types': ['bug'], 'weight': 84, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'black', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'コフーライ', 'ko': '분떠도리', 'zh-Hant': '粉蝶蛹', 'fr': 'Pérégrain', 'de': 'Puponcho', 'es': 'Spewpa', 'it': 'Spewpa', 'en': 'Spewpa', 'ja': 'コフーライ', 'zh-Hans': '粉蝶蛹'}, 'genera': {'ja-Hrkt': 'こなふきポケモン', 'ko': '가루뿜기포켓몬', 'zh-Hant': '噴粉寶可夢', 'fr': 'Pokémon Exhalécaille', 'de': 'Puderinsekt', 'es': 'Pokémon Tiraescamas', 'it': 'Pokémon Tirascaglie', 'en': 'Scatterdust Pokémon', 'ja': 'こなふきポケモン', 'zh-Hans': '喷粉宝可梦'}}
	public class SpecieSpewpa : PokemonSpecie
	{
#nullable enable
		private static SpecieSpewpa? _instance = null;
#nullable restore
        public static SpecieSpewpa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpewpa();
                }
                return _instance;
            }
        }

		public SpecieSpewpa() : base(
			"Spewpa",
			45, // HPs
			22, 60, // Attack & Defense
			27, 30, // Special Attack & Defense
			29			
		) {}
	}


	//Spewpa Pokemon Class
	public class Spewpa : Pokemon
	{

		public Spewpa(string nickname, int level)
		: base(
				665,
				SpecieSpewpa.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spewpa(int level)
		: base(
				665,
				SpecieSpewpa.Instance, // Pokemon Specie
				"Spewpa", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spewpa() : base(
			665,
			SpecieSpewpa.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}