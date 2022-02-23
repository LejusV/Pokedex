using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dubwool Specie to store common natural stats of every {'abilities': ['fluffy', 'run-away', 'bulletproof'], 'base_experience': 172, 'height': 13, 'id': 832, 'moves': [], 'name': 'dubwool', 'stats': {'hp': 72, 'attack': 80, 'defense': 100, 'special-attack': 60, 'special-defense': 90, 'speed': 88}, 'types': ['normal'], 'weight': 430, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'fr': 'Moumouflon', 'de': 'Zwollock', 'ja-Hrkt': 'バイウールー', 'ko': '배우르', 'zh-Hant': '毛毛角羊', 'es': 'Dubwool', 'it': 'Dubwool', 'en': 'Dubwool', 'ja': 'バイウールー', 'zh-Hans': '毛毛角羊'}, 'genera': {'fr': 'Pokémon Mouton', 'de': 'Schaf', 'ja-Hrkt': 'ひつじポケモン', 'ko': '양포켓몬', 'zh-Hant': '綿羊寶可夢', 'es': 'Pokémon Oveja', 'it': 'Pokémon Pecora', 'en': 'Sheep Pokémon', 'ja': 'ひつじポケモン', 'zh-Hans': '绵羊宝可梦'}}
	public class SpecieDubwool : PokemonSpecie
	{
#nullable enable
		private static SpecieDubwool? _instance = null;
#nullable restore
        public static SpecieDubwool Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDubwool();
                }
                return _instance;
            }
        }

		public SpecieDubwool() : base(
			"Dubwool",
			72, // HPs
			80, 100, // Attack & Defense
			60, 90, // Special Attack & Defense
			88			
		) {}
	}


	//Dubwool Pokemon Class
	public class Dubwool : Pokemon
	{

		public Dubwool(string nickname, int level) : base(
			832,
			SpecieDubwool.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Dubwool() : base(
			832,
			SpecieDubwool.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}