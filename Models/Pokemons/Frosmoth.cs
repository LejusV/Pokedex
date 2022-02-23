using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Frosmoth Specie to store common natural stats of every {'abilities': ['shield-dust', 'ice-scales'], 'base_experience': 168, 'height': 13, 'id': 873, 'moves': [], 'name': 'frosmoth', 'stats': {'hp': 70, 'attack': 65, 'defense': 60, 'special-attack': 125, 'special-defense': 90, 'speed': 65}, 'types': ['ice', 'bug'], 'weight': 420, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'white', 'shape': 'bug-wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'モスノウ', 'ko': '모스노우', 'zh-Hant': '雪絨蛾', 'fr': 'Beldeneige', 'de': 'Mottineva', 'es': 'Frosmoth', 'it': 'Frosmoth', 'en': 'Frosmoth', 'ja': 'モスノウ', 'zh-Hans': '雪绒蛾'}, 'genera': {'ja-Hrkt': 'こおりがポケモン', 'ko': '얼음나방포켓몬', 'zh-Hant': '冰蛾寶可夢', 'fr': 'Pokémon Mite Givre', 'de': 'Eismotte', 'es': 'Pokémon Polillahielo', 'it': 'Pokémon Gelofalena', 'en': 'Frost Moth Pokémon', 'ja': 'こおりがポケモン', 'zh-Hans': '冰蛾宝可梦'}}
	public class SpecieFrosmoth : PokemonSpecie
	{
#nullable enable
		private static SpecieFrosmoth? _instance = null;
#nullable restore
        public static SpecieFrosmoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFrosmoth();
                }
                return _instance;
            }
        }

		public SpecieFrosmoth() : base(
			"Frosmoth",
			70, // HPs
			65, 60, // Attack & Defense
			125, 90, // Special Attack & Defense
			65			
		) {}
	}


	//Frosmoth Pokemon Class
	public class Frosmoth : Pokemon
	{

		public Frosmoth(string nickname, int level) : base(
			873,
			SpecieFrosmoth.Instance, // Pokemon Specie
			nickname, level,
			Ice.Instance, Bug.Instance			
		) {}

		public Frosmoth() : base(
			873,
			SpecieFrosmoth.Instance, // Pokemon Specie
			Ice.Instance, Bug.Instance			
		) {}
	}
}