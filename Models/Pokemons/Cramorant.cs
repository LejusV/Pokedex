using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cramorant Specie to store common natural stats of every {'abilities': ['gulp-missile'], 'base_experience': 166, 'height': 8, 'id': 845, 'moves': [], 'name': 'cramorant', 'stats': {'hp': 70, 'attack': 85, 'defense': 55, 'special-attack': 85, 'special-defense': 95, 'speed': 85}, 'types': ['flying', 'water'], 'weight': 180, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'wings', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ウッウ', 'ko': '윽우지', 'zh-Hant': '古月鳥', 'fr': 'Nigosier', 'de': 'Urgl', 'es': 'Cramorant', 'it': 'Cramorant', 'en': 'Cramorant', 'ja': 'ウッウ', 'zh-Hans': '古月鸟'}, 'genera': {'ja-Hrkt': 'うのみポケモン', 'ko': '그대로삼키기포켓몬', 'zh-Hant': '一口吞寶可夢', 'fr': 'Pokémon Avaltouron', 'de': 'Schling', 'es': 'Pokémon Tragón', 'it': 'Pokémon Inghiottone', 'en': 'Gulp Pokémon', 'ja': 'うのみポケモン', 'zh-Hans': '一口吞宝可梦'}}
	public class SpecieCramorant : PokemonSpecie
	{
#nullable enable
		private static SpecieCramorant? _instance = null;
#nullable restore
        public static SpecieCramorant Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCramorant();
                }
                return _instance;
            }
        }

		public SpecieCramorant() : base(
			"Cramorant",
			70, // HPs
			85, 55, // Attack & Defense
			85, 95, // Special Attack & Defense
			85			
		) {}
	}


	//Cramorant Pokemon Class
	public class Cramorant : Pokemon
	{

		public Cramorant(string nickname, int level) : base(
			845,
			SpecieCramorant.Instance, // Pokemon Specie
			nickname, level,
			Flying.Instance, Water.Instance			
		) {}

		public Cramorant() : base(
			845,
			SpecieCramorant.Instance, // Pokemon Specie
			Flying.Instance, Water.Instance			
		) {}
	}
}