using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Combee Specie to store common natural stats of every {'abilities': ['honey-gather', 'hustle'], 'base_experience': 49, 'height': 3, 'id': 415, 'moves': ['gust', 'string-shot', 'swift', 'snore', 'mud-slap', 'sweet-scent', 'endeavor', 'air-cutter', 'tailwind', 'bug-buzz', 'bug-bite', 'ominous-wind'], 'name': 'combee', 'stats': {'hp': 30, 'attack': 30, 'defense': 42, 'special-attack': 30, 'special-defense': 42, 'speed': 70}, 'types': ['bug', 'flying'], 'weight': 55, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 120, 'color': 'yellow', 'shape': 'heads', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ミツハニー', 'roomaji': 'Mitsuhoney', 'ko': '세꿀버리', 'zh-Hant': '三蜜蜂', 'fr': 'Apitrini', 'de': 'Wadribie', 'es': 'Combee', 'it': 'Combee', 'en': 'Combee', 'ja': 'ミツハニー', 'zh-Hans': '三蜜蜂'}, 'genera': {'ja-Hrkt': 'はちのこポケモン', 'ko': '꼬마벌포켓몬', 'zh-Hant': '幼蜂寶可夢', 'fr': 'Pokémon Miniabeille', 'de': 'Kleinbiene', 'es': 'Pokémon Abejita', 'it': 'Pokémon Apetta', 'en': 'Tiny Bee Pokémon', 'ja': 'はちのこポケモン', 'zh-Hans': '幼蜂宝可梦'}}
	public class SpecieCombee : PokemonSpecie
	{
#nullable enable
		private static SpecieCombee? _instance = null;
#nullable restore
        public static SpecieCombee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCombee();
                }
                return _instance;
            }
        }

		public SpecieCombee() : base(
			"Combee",
			30, // HPs
			30, 42, // Attack & Defense
			30, 42, // Special Attack & Defense
			70			
		) {}
	}


	//Combee Pokemon Class
	public class Combee : Pokemon
	{

		public Combee(string nickname, int level)
		: base(
				415,
				SpecieCombee.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Combee(int level)
		: base(
				415,
				SpecieCombee.Instance, // Pokemon Specie
				"Combee", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Combee() : base(
			415,
			SpecieCombee.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}