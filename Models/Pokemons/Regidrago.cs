using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Regidrago Specie to store common natural stats of every {'abilities': ['dragons-maw'], 'base_experience': 290, 'height': 21, 'id': 895, 'moves': [], 'name': 'regidrago', 'stats': {'hp': 200, 'attack': 100, 'defense': 50, 'special-attack': 100, 'special-defense': 50, 'speed': 80}, 'types': ['dragon'], 'weight': 2000, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'レジドラゴ', 'ko': '레지드래고', 'zh-Hant': '雷吉鐸拉戈', 'fr': 'Regidrago', 'de': 'Regidrago', 'es': 'Regidrago', 'it': 'Regidrago', 'en': 'Regidrago', 'ja': 'レジドラゴ', 'zh-Hans': '雷吉铎拉戈'}, 'genera': {'ja-Hrkt': 'りゅうぎょくポケモン', 'ko': '용옥포켓몬', 'zh-Hant': '龍玉寶可夢', 'fr': 'Pokémon Boule Dragon', 'de': 'Drachenkugel', 'es': 'Pokémon Dragosfera', 'it': 'Pokémon Dracosfera', 'en': 'Dragon Orb Pokémon', 'ja': 'りゅうぎょくポケモン', 'zh-Hans': '龙玉宝可梦'}}
	public class SpecieRegidrago : PokemonSpecie
	{
#nullable enable
		private static SpecieRegidrago? _instance = null;
#nullable restore
        public static SpecieRegidrago Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegidrago();
                }
                return _instance;
            }
        }

		public SpecieRegidrago() : base(
			"Regidrago",
			200, // HPs
			100, 50, // Attack & Defense
			100, 50, // Special Attack & Defense
			80			
		) {}
	}


	//Regidrago Pokemon Class
	public class Regidrago : Pokemon
	{

		public Regidrago(string nickname, int level) : base(
			895,
			SpecieRegidrago.Instance, // Pokemon Specie
			nickname, level,
			Dragon.Instance			
		) {}

		public Regidrago() : base(
			895,
			SpecieRegidrago.Instance, // Pokemon Specie
			Dragon.Instance			
		) {}
	}
}