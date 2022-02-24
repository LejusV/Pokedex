using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Joltik Specie to store common natural stats of every {'abilities': ['compound-eyes', 'unnerve', 'swarm'], 'base_experience': 64, 'height': 1, 'id': 595, 'moves': ['cut', 'poison-sting', 'pin-missile', 'disable', 'absorb', 'string-shot', 'thunderbolt', 'thunder-wave', 'toxic', 'agility', 'screech', 'double-team', 'light-screen', 'leech-life', 'flash', 'rest', 'slash', 'substitute', 'thief', 'spider-web', 'snore', 'protect', 'feint-attack', 'giga-drain', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'facade', 'secret-power', 'camouflage', 'signal-beam', 'bounce', 'shock-wave', 'gastro-acid', 'sucker-punch', 'magnet-rise', 'poison-jab', 'x-scissor', 'bug-buzz', 'energy-ball', 'rock-climb', 'discharge', 'cross-poison', 'bug-bite', 'charge-beam', 'electro-ball', 'round', 'volt-switch', 'struggle-bug', 'electroweb', 'wild-charge', 'confide', 'infestation', 'lunge'], 'name': 'joltik', 'stats': {'hp': 50, 'attack': 47, 'defense': 50, 'special-attack': 57, 'special-defense': 50, 'speed': 65}, 'types': ['bug', 'electric'], 'weight': 6, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'yellow', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'バチュル', 'ko': '파쪼옥', 'zh-Hant': '電電蟲', 'fr': 'Statitik', 'de': 'Wattzapf', 'es': 'Joltik', 'it': 'Joltik', 'en': 'Joltik', 'ja': 'バチュル', 'zh-Hans': '电电虫'}, 'genera': {'ja-Hrkt': 'くっつきポケモン', 'ko': '들러붙기포켓몬', 'zh-Hant': '吸附寶可夢', 'fr': 'Pokémon Crampon', 'de': 'Kleben', 'es': 'Pokémon Lapa', 'it': 'Pokémon Appiccicante', 'en': 'Attaching Pokémon', 'ja': 'くっつきポケモン', 'zh-Hans': '吸附宝可梦'}}
	public class SpecieJoltik : PokemonSpecie
	{
#nullable enable
		private static SpecieJoltik? _instance = null;
#nullable restore
        public static SpecieJoltik Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJoltik();
                }
                return _instance;
            }
        }

		public SpecieJoltik() : base(
			"Joltik",
			50, // HPs
			47, 50, // Attack & Defense
			57, 50, // Special Attack & Defense
			65			
		) {}
	}


	//Joltik Pokemon Class
	public class Joltik : Pokemon
	{

		public Joltik(string nickname, int level)
		: base(
				595,
				SpecieJoltik.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Joltik(int level)
		: base(
				595,
				SpecieJoltik.Instance, // Pokemon Specie
				"Joltik", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Joltik() : base(
			595,
			SpecieJoltik.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
	}
}