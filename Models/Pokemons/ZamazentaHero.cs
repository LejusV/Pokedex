using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zamazenta-Hero Specie to store common natural stats of every {'abilities': ['dauntless-shield'], 'base_experience': 335, 'height': 29, 'id': 889, 'moves': [], 'name': 'zamazenta-hero', 'stats': {'hp': 92, 'attack': 130, 'defense': 115, 'special-attack': 80, 'special-defense': 115, 'speed': 138}, 'types': ['fighting'], 'weight': 2100, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 10, 'color': 'red', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ザマゼンタ', 'ko': '자마젠타', 'zh-Hant': '藏瑪然特', 'fr': 'Zamazenta', 'de': 'Zamazenta', 'es': 'Zamazenta', 'it': 'Zamazenta', 'en': 'Zamazenta', 'ja': 'ザマゼンタ', 'zh-Hans': '藏玛然特'}, 'genera': {'ja-Hrkt': 'つわものポケモン', 'ko': '강자포켓몬', 'zh-Hant': '強者寶可夢', 'fr': 'Pokémon Valeureux', 'de': 'Krieger', 'es': 'Pokémon Guerrero', 'it': 'Pokémon Guerriero', 'en': 'Warrior Pokémon', 'ja': 'つわものポケモン', 'zh-Hans': '强者宝可梦'}}
	public class SpecieZamazentaHero : PokemonSpecie
	{
#nullable enable
		private static SpecieZamazentaHero? _instance = null;
#nullable restore
        public static SpecieZamazentaHero Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZamazentaHero();
                }
                return _instance;
            }
        }

		public SpecieZamazentaHero() : base(
			"Zamazenta-Hero",
			92, // HPs
			130, 115, // Attack & Defense
			80, 115, // Special Attack & Defense
			138			
		) {}
	}


	//Zamazenta-Hero Pokemon Class
	public class ZamazentaHero : Pokemon
	{

		public ZamazentaHero(string nickname, int level) : base(
			889,
			SpecieZamazentaHero.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance			
		) {}

		public ZamazentaHero() : base(
			889,
			SpecieZamazentaHero.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}