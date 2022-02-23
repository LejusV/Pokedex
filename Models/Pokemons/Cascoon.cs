using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cascoon Specie to store common natural stats of every {'abilities': ['shed-skin'], 'base_experience': 72, 'height': 7, 'id': 268, 'moves': ['string-shot', 'harden', 'iron-defense', 'bug-bite', 'electroweb'], 'name': 'cascoon', 'stats': {'hp': 50, 'attack': 35, 'defense': 55, 'special-attack': 25, 'special-defense': 25, 'speed': 15}, 'types': ['bug'], 'weight': 115, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'purple', 'shape': 'ball', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'マユルド', 'roomaji': 'Mayuld', 'ko': '카스쿤', 'zh-Hant': '盾甲繭', 'fr': 'Blindalys', 'de': 'Panekon', 'es': 'Cascoon', 'it': 'Cascoon', 'en': 'Cascoon', 'ja': 'マユルド', 'zh-Hans': '盾甲茧'}, 'genera': {'ja-Hrkt': 'さなぎポケモン', 'ko': '번데기포켓몬', 'zh-Hant': '蛹寶可夢', 'fr': 'Pokémon Cocon', 'de': 'Kokon', 'es': 'Pokémon Capullo', 'it': 'Pokémon Bozzolo', 'en': 'Cocoon Pokémon', 'ja': 'さなぎポケモン', 'zh-Hans': '蛹宝可梦'}}
	public class SpecieCascoon : PokemonSpecie
	{
#nullable enable
		private static SpecieCascoon? _instance = null;
#nullable restore
        public static SpecieCascoon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCascoon();
                }
                return _instance;
            }
        }

		public SpecieCascoon() : base(
			"Cascoon",
			50, // HPs
			35, 55, // Attack & Defense
			25, 25, // Special Attack & Defense
			15			
		) {}
	}


	//Cascoon Pokemon Class
	public class Cascoon : Pokemon
	{

		public Cascoon(string nickname, int level) : base(
			268,
			SpecieCascoon.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Cascoon() : base(
			268,
			SpecieCascoon.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}