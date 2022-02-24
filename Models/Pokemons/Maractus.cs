using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Maractus Specie to store common natural stats of every {'abilities': ['water-absorb', 'chlorophyll', 'storm-drain'], 'base_experience': 161, 'height': 10, 'id': 556, 'moves': ['pin-missile', 'peck', 'absorb', 'mega-drain', 'leech-seed', 'growth', 'solar-beam', 'petal-dance', 'toxic', 'double-team', 'rest', 'substitute', 'snore', 'cotton-spore', 'protect', 'spikes', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'sweet-scent', 'synthesis', 'hidden-power', 'sunny-day', 'uproar', 'facade', 'nature-power', 'helping-hand', 'ingrain', 'knock-off', 'endeavor', 'secret-power', 'needle-arm', 'hyper-voice', 'grass-whistle', 'bullet-seed', 'aerial-ace', 'bounce', 'acupressure', 'worry-seed', 'sucker-punch', 'poison-jab', 'seed-bomb', 'drain-punch', 'energy-ball', 'grass-knot', 'wood-hammer', 'after-you', 'round', 'cotton-guard', 'petal-blizzard', 'grassy-terrain', 'confide', 'spiky-shield'], 'name': 'maractus', 'stats': {'hp': 75, 'attack': 86, 'defense': 67, 'special-attack': 106, 'special-defense': 67, 'speed': 60}, 'types': ['grass'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['plant'], 'names': {'ja-Hrkt': 'マラカッチ', 'ko': '마라카치', 'zh-Hant': '沙鈴仙人掌', 'fr': 'Maracachi', 'de': 'Maracamba', 'es': 'Maractus', 'it': 'Maractus', 'en': 'Maractus', 'ja': 'マラカッチ', 'zh-Hans': '沙铃仙人掌'}, 'genera': {'ja-Hrkt': 'サボテンポケモン', 'ko': '선인장포켓몬', 'zh-Hant': '仙人掌寶可夢', 'fr': 'Pokémon Cactus', 'de': 'Kaktus', 'es': 'Pokémon Cactus', 'it': 'Pokémon Cactus', 'en': 'Cactus Pokémon', 'ja': 'サボテンポケモン', 'zh-Hans': '仙人掌宝可梦'}}
	public class SpecieMaractus : PokemonSpecie
	{
#nullable enable
		private static SpecieMaractus? _instance = null;
#nullable restore
        public static SpecieMaractus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMaractus();
                }
                return _instance;
            }
        }

		public SpecieMaractus() : base(
			"Maractus",
			75, // HPs
			86, 67, // Attack & Defense
			106, 67, // Special Attack & Defense
			60			
		) {}
	}


	//Maractus Pokemon Class
	public class Maractus : Pokemon
	{

		public Maractus(string nickname, int level)
		: base(
				556,
				SpecieMaractus.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Maractus(int level)
		: base(
				556,
				SpecieMaractus.Instance, // Pokemon Specie
				"Maractus", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Maractus() : base(
			556,
			SpecieMaractus.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}