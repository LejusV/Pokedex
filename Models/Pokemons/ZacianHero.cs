using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zacian-Hero Specie to store common natural stats of every {'abilities': ['intrepid-sword'], 'base_experience': 335, 'height': 28, 'id': 888, 'moves': [], 'name': 'zacian-hero', 'stats': {'hp': 92, 'attack': 130, 'defense': 115, 'special-attack': 80, 'special-defense': 115, 'speed': 138}, 'types': ['fairy'], 'weight': 1100, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 10, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ザシアン', 'ko': '자시안', 'zh-Hant': '蒼響', 'fr': 'Zacian', 'de': 'Zacian', 'es': 'Zacian', 'it': 'Zacian', 'en': 'Zacian', 'ja': 'ザシアン', 'zh-Hans': '苍响'}, 'genera': {'ja-Hrkt': 'つわものポケモン', 'ko': '강자포켓몬', 'zh-Hant': '強者寶可夢', 'fr': 'Pokémon Valeureux', 'de': 'Krieger', 'es': 'Pokémon Guerrero', 'it': 'Pokémon Guerriero', 'en': 'Warrior Pokémon', 'ja': 'つわものポケモン', 'zh-Hans': '强者宝可梦'}}
	public class SpecieZacianHero : PokemonSpecie
	{
#nullable enable
		private static SpecieZacianHero? _instance = null;
#nullable restore
        public static SpecieZacianHero Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZacianHero();
                }
                return _instance;
            }
        }

		public SpecieZacianHero() : base(
			"Zacian-Hero",
			92, // HPs
			130, 115, // Attack & Defense
			80, 115, // Special Attack & Defense
			138			
		) {}
	}


	//Zacian-Hero Pokemon Class
	public class ZacianHero : Pokemon
	{

		public ZacianHero(string nickname, int level)
		: base(
				888,
				SpecieZacianHero.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public ZacianHero(int level)
		: base(
				888,
				SpecieZacianHero.Instance, // Pokemon Specie
				"Zacian-Hero", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public ZacianHero() : base(
			888,
			SpecieZacianHero.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}