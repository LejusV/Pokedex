using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Centiskorch Specie to store common natural stats of every {'abilities': ['flash-fire', 'white-smoke', 'flame-body'], 'base_experience': 184, 'height': 30, 'id': 851, 'moves': [], 'name': 'centiskorch', 'stats': {'hp': 100, 'attack': 115, 'defense': 65, 'special-attack': 90, 'special-defense': 90, 'speed': 65}, 'types': ['fire', 'bug'], 'weight': 1200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'マルヤクデ', 'ko': '다태우지네', 'zh-Hant': '焚焰蚣', 'fr': 'Scolocendre', 'de': 'Infernopod', 'es': 'Centiskorch', 'it': 'Centiskorch', 'en': 'Centiskorch', 'ja': 'マルヤクデ', 'zh-Hans': '焚焰蚣'}, 'genera': {'ja-Hrkt': 'はつねつポケモン', 'ko': '발열포켓몬', 'zh-Hant': '發熱寶可夢', 'fr': 'Pokémon Calorifère', 'de': 'Exotherm', 'es': 'Pokémon Radiador', 'it': 'Pokémon Termogeno', 'en': 'Radiator Pokémon', 'ja': 'はつねつポケモン', 'zh-Hans': '发热宝可梦'}}
	public class SpecieCentiskorch : PokemonSpecie
	{
#nullable enable
		private static SpecieCentiskorch? _instance = null;
#nullable restore
        public static SpecieCentiskorch Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCentiskorch();
                }
                return _instance;
            }
        }

		public SpecieCentiskorch() : base(
			"Centiskorch",
			100, // HPs
			115, 65, // Attack & Defense
			90, 90, // Special Attack & Defense
			65			
		) {}
	}


	//Centiskorch Pokemon Class
	public class Centiskorch : Pokemon
	{

		public Centiskorch(string nickname, int level) : base(
			851,
			SpecieCentiskorch.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Bug.Instance			
		) {}

		public Centiskorch() : base(
			851,
			SpecieCentiskorch.Instance, // Pokemon Specie
			Fire.Instance, Bug.Instance			
		) {}
	}
}