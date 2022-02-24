using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Glastrier Specie to store common natural stats of every {'abilities': ['chilling-neigh'], 'base_experience': 290, 'height': 22, 'id': 896, 'moves': [], 'name': 'glastrier', 'stats': {'hp': 100, 'attack': 145, 'defense': 130, 'special-attack': 65, 'special-defense': 110, 'speed': 30}, 'types': ['ice'], 'weight': 8000, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ブリザポス', 'ko': '블리자포스', 'zh-Hant': '雪暴馬', 'fr': 'Blizzeval', 'de': 'Polaross', 'es': 'Glastrier', 'it': 'Glastrier', 'en': 'Glastrier', 'ja': 'ブリザポス', 'zh-Hans': '雪暴马'}, 'genera': {'ja-Hrkt': 'あばれうまポケモン', 'ko': '사나운말포켓몬', 'zh-Hant': '烈馬寶可夢', 'fr': 'Pokémon Cheval Rétif', 'de': 'Wildblut', 'es': 'Pokémon Corcel Feroz', 'it': 'Pokémon Furiequino', 'en': 'Wild Horse Pokémon', 'ja': 'あばれうまポケモン', 'zh-Hans': '烈马宝可梦'}}
	public class SpecieGlastrier : PokemonSpecie
	{
#nullable enable
		private static SpecieGlastrier? _instance = null;
#nullable restore
        public static SpecieGlastrier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlastrier();
                }
                return _instance;
            }
        }

		public SpecieGlastrier() : base(
			"Glastrier",
			100, // HPs
			145, 130, // Attack & Defense
			65, 110, // Special Attack & Defense
			30			
		) {}
	}


	//Glastrier Pokemon Class
	public class Glastrier : Pokemon
	{

		public Glastrier(string nickname, int level)
		: base(
				896,
				SpecieGlastrier.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Glastrier() : base(
			896,
			SpecieGlastrier.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}