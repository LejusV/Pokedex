using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sirfetchd Specie to store common natural stats of every {'abilities': ['steadfast', 'scrappy'], 'base_experience': 177, 'height': 8, 'id': 865, 'moves': [], 'name': 'sirfetchd', 'stats': {'hp': 62, 'attack': 135, 'defense': 95, 'special-attack': 68, 'special-defense': 82, 'speed': 65}, 'types': ['fighting'], 'weight': 1170, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ネギガナイト', 'ko': '창파나이트', 'zh-Hant': '蔥遊兵', 'fr': 'Palarticho', 'de': 'Lauchzelot', 'es': "Sirfetch'd", 'it': "Sirfetch'd", 'en': "Sirfetch'd", 'ja': 'ネギガナイト', 'zh-Hans': '葱游兵'}, 'genera': {'ja-Hrkt': 'かるがもポケモン', 'ko': '청둥오리포켓몬', 'zh-Hant': '黃嘴鴨寶可夢', 'fr': 'Pokémon Canard Fou', 'de': 'Wildente', 'es': 'Pokémon Pato Salvaje', 'it': 'Pokémon Selvanatra', 'en': 'Wild Duck Pokémon', 'ja': 'かるがもポケモン', 'zh-Hans': '黄嘴鸭宝可梦'}}
	public class SpecieSirfetchd : PokemonSpecie
	{
#nullable enable
		private static SpecieSirfetchd? _instance = null;
#nullable restore
        public static SpecieSirfetchd Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSirfetchd();
                }
                return _instance;
            }
        }

		public SpecieSirfetchd() : base(
			"Sirfetchd",
			62, // HPs
			135, 95, // Attack & Defense
			68, 82, // Special Attack & Defense
			65			
		) {}
	}


	//Sirfetchd Pokemon Class
	public class Sirfetchd : Pokemon
	{

		public Sirfetchd(string nickname, int level) : base(
			865,
			SpecieSirfetchd.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public Sirfetchd() : base(
			865,
			SpecieSirfetchd.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}