using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Falinks Specie to store common natural stats of every {'abilities': ['battle-armor', 'defiant'], 'base_experience': 165, 'height': 30, 'id': 870, 'moves': [], 'name': 'falinks', 'stats': {'hp': 65, 'attack': 100, 'defense': 100, 'special-attack': 70, 'special-defense': 60, 'speed': 75}, 'types': ['fighting'], 'weight': 620, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': -1, 'capture_rate': 45, 'color': 'yellow', 'shape': 'heads', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'タイレーツ', 'ko': '대여르', 'zh-Hant': '列陣兵', 'fr': 'Hexadron', 'de': 'Legios', 'es': 'Falinks', 'it': 'Falinks', 'en': 'Falinks', 'ja': 'タイレーツ', 'zh-Hans': '列阵兵'}, 'genera': {'ja-Hrkt': 'じんけいポケモン', 'ko': '진형포켓몬', 'zh-Hant': '陣形寶可夢', 'fr': 'Pokémon Escadron', 'de': 'Formation', 'es': 'Pokémon Formación', 'it': 'Pokémon Schieramento', 'en': 'Formation Pokémon', 'ja': 'じんけいポケモン', 'zh-Hans': '阵形宝可梦'}}
	public class SpecieFalinks : PokemonSpecie
	{
#nullable enable
		private static SpecieFalinks? _instance = null;
#nullable restore
        public static SpecieFalinks Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFalinks();
                }
                return _instance;
            }
        }

		public SpecieFalinks() : base(
			"Falinks",
			65, // HPs
			100, 100, // Attack & Defense
			70, 60, // Special Attack & Defense
			75			
		) {}
	}


	//Falinks Pokemon Class
	public class Falinks : Pokemon
	{

		public Falinks(string nickname, int level) : base(
			870,
			SpecieFalinks.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Falinks() : base(
			870,
			SpecieFalinks.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}