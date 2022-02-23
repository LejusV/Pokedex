using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Amoonguss Specie to store common natural stats of every {'abilities': ['effect-spore', 'regenerator'], 'base_experience': 162, 'height': 6, 'id': 591, 'moves': ['hyper-beam', 'absorb', 'mega-drain', 'growth', 'solar-beam', 'toxic', 'double-team', 'bide', 'spore', 'flash', 'rest', 'substitute', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'facade', 'nature-power', 'ingrain', 'secret-power', 'astonish', 'payback', 'gastro-acid', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'grass-knot', 'venoshock', 'rage-powder', 'foul-play', 'after-you', 'round', 'clear-smog', 'confide'], 'name': 'amoonguss', 'stats': {'hp': 114, 'attack': 85, 'defense': 70, 'special-attack': 85, 'special-defense': 80, 'speed': 30}, 'types': ['grass', 'poison'], 'weight': 105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'white', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'モロバレル', 'ko': '뽀록나', 'zh-Hant': '敗露球菇', 'fr': 'Gaulet', 'de': 'Hutsassa', 'es': 'Amoonguss', 'it': 'Amoonguss', 'en': 'Amoonguss', 'ja': 'モロバレル', 'zh-Hans': '败露球菇'}, 'genera': {'ja-Hrkt': 'きのこポケモン', 'ko': '버섯포켓몬', 'zh-Hant': '蘑菇寶可夢', 'fr': 'Pokémon Champignon', 'de': 'Pilz', 'es': 'Pokémon Hongo', 'it': 'Pokémon Fungo', 'en': 'Mushroom Pokémon', 'ja': 'きのこポケモン', 'zh-Hans': '蘑菇宝可梦'}}
	public class SpecieAmoonguss : PokemonSpecie
	{
#nullable enable
		private static SpecieAmoonguss? _instance = null;
#nullable restore
        public static SpecieAmoonguss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmoonguss();
                }
                return _instance;
            }
        }

		public SpecieAmoonguss() : base(
			"Amoonguss",
			114, // HPs
			85, 70, // Attack & Defense
			85, 80, // Special Attack & Defense
			30			
		) {}
	}


	//Amoonguss Pokemon Class
	public class Amoonguss : Pokemon
	{

		public Amoonguss(string nickname, int level) : base(
			591,
			SpecieAmoonguss.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Poison.Instance			
		) {}

		public Amoonguss() : base(
			591,
			SpecieAmoonguss.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}