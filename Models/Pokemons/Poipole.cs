using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Poipole Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 189, 'height': 6, 'id': 803, 'moves': ['fury-attack', 'growl', 'acid', 'peck', 'toxic', 'rest', 'substitute', 'protect', 'sludge-bomb', 'charm', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'facade', 'helping-hand', 'poison-jab', 'dragon-pulse', 'nasty-plot', 'venoshock', 'sludge-wave', 'round', 'echoed-voice', 'fell-stinger', 'confide', 'venom-drench'], 'name': 'poipole', 'stats': {'hp': 67, 'attack': 73, 'defense': 67, 'special-attack': 73, 'special-defense': 67, 'speed': 73}, 'types': ['poison'], 'weight': 18, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ベベノム', 'ko': '베베놈', 'zh-Hant': '毒貝比', 'fr': 'Vémini', 'de': 'Venicro', 'es': 'Poipole', 'it': 'Poipole', 'en': 'Poipole', 'ja': 'ベベノム', 'zh-Hans': '毒贝比'}, 'genera': {'ja-Hrkt': 'どくばりポケモン', 'ko': '독침포켓몬', 'zh-Hant': '毒針寶可夢', 'fr': 'Pokémon Vénépic', 'de': 'Giftdorn', 'es': 'Pokémon Pin Veneno', 'it': 'Pokémon Velenago', 'en': 'Poison Pin Pokémon', 'ja': 'どくばりポケモン', 'zh-Hans': '毒针宝可梦'}}
	public class SpeciePoipole : PokemonSpecie
	{
#nullable enable
		private static SpeciePoipole? _instance = null;
#nullable restore
        public static SpeciePoipole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePoipole();
                }
                return _instance;
            }
        }

		public SpeciePoipole() : base(
			"Poipole",
			67, // HPs
			73, 67, // Attack & Defense
			73, 67, // Special Attack & Defense
			73			
		) {}
	}


	//Poipole Pokemon Class
	public class Poipole : Pokemon
	{

		public Poipole(string nickname, int level)
		: base(
				803,
				SpeciePoipole.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Poipole(int level)
		: base(
				803,
				SpeciePoipole.Instance, // Pokemon Specie
				"Poipole", level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Poipole() : base(
			803,
			SpeciePoipole.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}