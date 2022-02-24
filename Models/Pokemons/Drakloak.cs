using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drakloak Specie to store common natural stats of every {'abilities': ['clear-body', 'infiltrator', 'cursed-body'], 'base_experience': 144, 'height': 14, 'id': 886, 'moves': [], 'name': 'drakloak', 'stats': {'hp': 68, 'attack': 80, 'defense': 50, 'special-attack': 60, 'special-defense': 50, 'speed': 102}, 'types': ['dragon', 'ghost'], 'weight': 110, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'arms', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ドロンチ', 'ko': '드래런치', 'zh-Hant': '多龍奇', 'fr': 'Dispareptil', 'de': 'Phandra', 'es': 'Drakloak', 'it': 'Drakloak', 'en': 'Drakloak', 'ja': 'ドロンチ', 'zh-Hans': '多龙奇'}, 'genera': {'ja-Hrkt': 'せわやくポケモン', 'ko': '돌보미포켓몬', 'zh-Hant': '保姆寶可夢', 'fr': 'Pokémon Baby-sitter', 'de': 'Betreuer', 'es': 'Pokémon Cuidador', 'it': 'Pokémon Sostegno', 'en': 'Caretaker Pokémon', 'ja': 'せわやくポケモン', 'zh-Hans': '保姆宝可梦'}}
	public class SpecieDrakloak : PokemonSpecie
	{
#nullable enable
		private static SpecieDrakloak? _instance = null;
#nullable restore
        public static SpecieDrakloak Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrakloak();
                }
                return _instance;
            }
        }

		public SpecieDrakloak() : base(
			"Drakloak",
			68, // HPs
			80, 50, // Attack & Defense
			60, 50, // Special Attack & Defense
			102			
		) {}
	}


	//Drakloak Pokemon Class
	public class Drakloak : Pokemon
	{

		public Drakloak(string nickname, int level)
		: base(
				886,
				SpecieDrakloak.Instance, // Pokemon Specie
				nickname, level,
				Dragon.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drakloak() : base(
			886,
			SpecieDrakloak.Instance, // Pokemon Specie
			Dragon.Instance, Ghost.Instance			
		) {}
	}
}