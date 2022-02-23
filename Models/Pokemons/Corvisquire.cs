using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Corvisquire Specie to store common natural stats of every {'abilities': ['keen-eye', 'unnerve', 'big-pecks'], 'base_experience': 128, 'height': 8, 'id': 822, 'moves': [], 'name': 'corvisquire', 'stats': {'hp': 68, 'attack': 67, 'defense': 55, 'special-attack': 43, 'special-defense': 55, 'speed': 77}, 'types': ['flying'], 'weight': 160, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'アオガラス', 'ko': '파크로우', 'zh-Hant': '藍鴉', 'fr': 'Bleuseille', 'de': 'Kranoviz', 'es': 'Corvisquire', 'it': 'Corvisquire', 'en': 'Corvisquire', 'ja': 'アオガラス', 'zh-Hans': '蓝鸦'}, 'genera': {'ja-Hrkt': 'カラスポケモン', 'ko': '까마귀포켓몬', 'zh-Hant': '烏鴉寶可夢', 'fr': 'Pokémon Corbeau', 'de': 'Krähe', 'es': 'Pokémon Cuervo', 'it': 'Pokémon Corvo', 'en': 'Raven Pokémon', 'ja': 'カラスポケモン', 'zh-Hans': '乌鸦宝可梦'}}
	public class SpecieCorvisquire : PokemonSpecie
	{
#nullable enable
		private static SpecieCorvisquire? _instance = null;
#nullable restore
        public static SpecieCorvisquire Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCorvisquire();
                }
                return _instance;
            }
        }

		public SpecieCorvisquire() : base(
			"Corvisquire",
			68, // HPs
			67, 55, // Attack & Defense
			43, 55, // Special Attack & Defense
			77			
		) {}
	}


	//Corvisquire Pokemon Class
	public class Corvisquire : Pokemon
	{

		public Corvisquire(string nickname, int level) : base(
			822,
			SpecieCorvisquire.Instance, // Pokemon Specie
			nickname, level,
			Flying.Instance			
		) {}

		public Corvisquire() : base(
			822,
			SpecieCorvisquire.Instance, // Pokemon Specie
			Flying.Instance			
		) {}
	}
}