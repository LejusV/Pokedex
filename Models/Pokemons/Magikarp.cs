using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Magikarp Specie to store common natural stats of every {'abilities': ['swift-swim', 'rattled'], 'base_experience': 40, 'height': 9, 'id': 129, 'moves': ['tackle', 'splash', 'flail', 'bounce'], 'name': 'magikarp', 'stats': {'hp': 20, 'attack': 10, 'defense': 55, 'special-attack': 15, 'special-defense': 20, 'speed': 80}, 'types': ['water'], 'weight': 100, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 5, 'gender_rate': 4, 'capture_rate': 255, 'color': 'red', 'shape': 'fish', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water2', 'dragon'], 'names': {'ja-Hrkt': 'コイキング', 'roomaji': 'Koiking', 'ko': '잉어킹', 'zh-Hant': '鯉魚王', 'fr': 'Magicarpe', 'de': 'Karpador', 'es': 'Magikarp', 'it': 'Magikarp', 'en': 'Magikarp', 'ja': 'コイキング', 'zh-Hans': '鲤鱼王'}, 'genera': {'ja-Hrkt': 'さかなポケモン', 'ko': '물고기포켓몬', 'zh-Hant': '魚寶可夢', 'fr': 'Pokémon Poisson', 'de': 'Fisch', 'es': 'Pokémon Pez', 'it': 'Pokémon Pesce', 'en': 'Fish Pokémon', 'ja': 'さかなポケモン', 'zh-Hans': '鱼宝可梦'}}
	public class SpecieMagikarp : PokemonSpecie
	{
#nullable enable
		private static SpecieMagikarp? _instance = null;
#nullable restore
        public static SpecieMagikarp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMagikarp();
                }
                return _instance;
            }
        }

		public SpecieMagikarp() : base(
			"Magikarp",
			20, // HPs
			10, 55, // Attack & Defense
			15, 20, // Special Attack & Defense
			80			
		) {}
	}


	//Magikarp Pokemon Class
	public class Magikarp : Pokemon
	{

		public Magikarp(string nickname, int level) : base(
			129,
			SpecieMagikarp.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Magikarp() : base(
			129,
			SpecieMagikarp.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}