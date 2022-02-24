using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Carnivine Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 159, 'height': 14, 'id': 455, 'moves': ['swords-dance', 'cut', 'bind', 'slam', 'vine-whip', 'bite', 'hyper-beam', 'leech-seed', 'growth', 'razor-leaf', 'solar-beam', 'stun-spore', 'sleep-powder', 'toxic', 'double-team', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'crunch', 'stockpile', 'spit-up', 'swallow', 'facade', 'nature-power', 'ingrain', 'knock-off', 'secret-power', 'grass-whistle', 'bullet-seed', 'magical-leaf', 'natural-gift', 'payback', 'fling', 'wring-out', 'gastro-acid', 'worry-seed', 'seed-bomb', 'energy-ball', 'giga-impact', 'power-whip', 'captivate', 'grass-knot', 'bug-bite', 'rage-powder', 'acid-spray', 'round', 'leaf-tornado', 'confide', 'infestation'], 'name': 'carnivine', 'stats': {'hp': 74, 'attack': 100, 'defense': 72, 'special-attack': 90, 'special-defense': 72, 'speed': 46}, 'types': ['grass'], 'weight': 270, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 200, 'color': 'green', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'マスキッパ', 'roomaji': 'Muskippa', 'ko': '무스틈니', 'zh-Hant': '尖牙籠', 'fr': 'Vortente', 'de': 'Venuflibis', 'es': 'Carnivine', 'it': 'Carnivine', 'en': 'Carnivine', 'ja': 'マスキッパ', 'zh-Hans': '尖牙笼'}, 'genera': {'ja-Hrkt': 'むしとりポケモン', 'ko': '벌레잡이포켓몬', 'zh-Hant': '捕蟲寶可夢', 'fr': 'Pokémon Chopinsecte', 'de': 'Käfertod', 'es': 'Pokémon Caza Bichos', 'it': 'Pokémon Insettivoro', 'en': 'Bug Catcher Pokémon', 'ja': 'むしとりポケモン', 'zh-Hans': '捕虫宝可梦'}}
	public class SpecieCarnivine : PokemonSpecie
	{
#nullable enable
		private static SpecieCarnivine? _instance = null;
#nullable restore
        public static SpecieCarnivine Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCarnivine();
                }
                return _instance;
            }
        }

		public SpecieCarnivine() : base(
			"Carnivine",
			74, // HPs
			100, 72, // Attack & Defense
			90, 72, // Special Attack & Defense
			46			
		) {}
	}


	//Carnivine Pokemon Class
	public class Carnivine : Pokemon
	{

		public Carnivine(string nickname, int level)
		: base(
				455,
				SpecieCarnivine.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carnivine(int level)
		: base(
				455,
				SpecieCarnivine.Instance, // Pokemon Specie
				"Carnivine", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Carnivine() : base(
			455,
			SpecieCarnivine.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}