using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Snom Specie to store common natural stats of every {'abilities': ['shield-dust', 'ice-scales'], 'base_experience': 37, 'height': 3, 'id': 872, 'moves': [], 'name': 'snom', 'stats': {'hp': 30, 'attack': 25, 'defense': 35, 'special-attack': 45, 'special-defense': 30, 'speed': 20}, 'types': ['ice', 'bug'], 'weight': 38, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ユキハミ', 'ko': '누니머기', 'zh-Hant': '雪吞蟲', 'fr': 'Frissonille', 'de': 'Snomnom', 'es': 'Snom', 'it': 'Snom', 'en': 'Snom', 'ja': 'ユキハミ', 'zh-Hans': '雪吞虫'}, 'genera': {'ja-Hrkt': 'いもむしポケモン', 'ko': '애벌레포켓몬', 'zh-Hant': '蟲寶寶寶可夢', 'fr': 'Pokémon Ver', 'de': 'Wurm', 'es': 'Pokémon Gusano', 'it': 'Pokémon Baco', 'en': 'Worm Pokémon', 'ja': 'いもむしポケモン', 'zh-Hans': '虫宝宝宝可梦'}}
	public class SpecieSnom : PokemonSpecie
	{
#nullable enable
		private static SpecieSnom? _instance = null;
#nullable restore
        public static SpecieSnom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSnom();
                }
                return _instance;
            }
        }

		public SpecieSnom() : base(
			"Snom",
			30, // HPs
			25, 35, // Attack & Defense
			45, 30, // Special Attack & Defense
			20			
		) {}
	}


	//Snom Pokemon Class
	public class Snom : Pokemon
	{

		public Snom(string nickname, int level) : base(
			872,
			SpecieSnom.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance, Bug.Instance			
		) {}

		public Snom() : base(
			872,
			SpecieSnom.Instance, // Pokemon Specie
			Ice.Instance, Bug.Instance			
		) {}
	}
}