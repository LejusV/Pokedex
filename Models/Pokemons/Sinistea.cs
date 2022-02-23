using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sinistea Specie to store common natural stats of every {'abilities': ['weak-armor', 'cursed-body'], 'base_experience': 62, 'height': 1, 'id': 854, 'moves': [], 'name': 'sinistea', 'stats': {'hp': 40, 'attack': 45, 'defense': 45, 'special-attack': 74, 'special-defense': 54, 'speed': 50}, 'types': ['ghost'], 'weight': 2, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 120, 'color': 'purple', 'shape': 'ball', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'ヤバチャ', 'ko': '데인차', 'zh-Hant': '來悲茶', 'fr': 'Théffroi', 'de': 'Fatalitee', 'es': 'Sinistea', 'it': 'Sinistea', 'en': 'Sinistea', 'ja': 'ヤバチャ', 'zh-Hans': '来悲茶'}, 'genera': {'ja-Hrkt': 'こうちゃポケモン', 'ko': '홍차포켓몬', 'zh-Hant': '紅茶寶可夢', 'fr': 'Pokémon Thé Noir', 'de': 'Schwarztee', 'es': 'Pokémon Té', 'it': 'Pokémon Tè', 'en': 'Black Tea Pokémon', 'ja': 'こうちゃポケモン', 'zh-Hans': '红茶宝可梦'}}
	public class SpecieSinistea : PokemonSpecie
	{
#nullable enable
		private static SpecieSinistea? _instance = null;
#nullable restore
        public static SpecieSinistea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSinistea();
                }
                return _instance;
            }
        }

		public SpecieSinistea() : base(
			"Sinistea",
			40, // HPs
			45, 45, // Attack & Defense
			74, 54, // Special Attack & Defense
			50			
		) {}
	}


	//Sinistea Pokemon Class
	public class Sinistea : Pokemon
	{

		public Sinistea(string nickname, int level) : base(
			854,
			SpecieSinistea.Instance, // Pokemon Specie
			nickname, level,
			Ghost.Instance			
		) {}

		public Sinistea() : base(
			854,
			SpecieSinistea.Instance, // Pokemon Specie
			Ghost.Instance			
		) {}
	}
}