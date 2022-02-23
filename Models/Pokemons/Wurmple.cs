using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wurmple Specie to store common natural stats of every {'abilities': ['shield-dust', 'run-away'], 'base_experience': 56, 'height': 3, 'id': 265, 'moves': ['tackle', 'poison-sting', 'string-shot', 'snore', 'bug-bite', 'electroweb'], 'name': 'wurmple', 'stats': {'hp': 45, 'attack': 45, 'defense': 35, 'special-attack': 20, 'special-defense': 30, 'speed': 20}, 'types': ['bug'], 'weight': 36, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'red', 'shape': 'armor', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ケムッソ', 'roomaji': 'Kemusso', 'ko': '개무소', 'zh-Hant': '刺尾蟲', 'fr': 'Chenipotte', 'de': 'Waumpel', 'es': 'Wurmple', 'it': 'Wurmple', 'en': 'Wurmple', 'ja': 'ケムッソ', 'zh-Hans': '刺尾虫'}, 'genera': {'ja-Hrkt': 'いもむしポケモン', 'ko': '애벌레포켓몬', 'zh-Hant': '蟲寶寶寶可夢', 'fr': 'Pokémon Ver', 'de': 'Wurm', 'es': 'Pokémon Gusano', 'it': 'Pokémon Baco', 'en': 'Worm Pokémon', 'ja': 'いもむしポケモン', 'zh-Hans': '虫宝宝宝可梦'}}
	public class SpecieWurmple : PokemonSpecie
	{
#nullable enable
		private static SpecieWurmple? _instance = null;
#nullable restore
        public static SpecieWurmple Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWurmple();
                }
                return _instance;
            }
        }

		public SpecieWurmple() : base(
			"Wurmple",
			45, // HPs
			45, 35, // Attack & Defense
			20, 30, // Special Attack & Defense
			20			
		) {}
	}


	//Wurmple Pokemon Class
	public class Wurmple : Pokemon
	{

		public Wurmple(string nickname, int level) : base(
			265,
			SpecieWurmple.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Wurmple() : base(
			265,
			SpecieWurmple.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}