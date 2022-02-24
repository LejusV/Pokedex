using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Blitzle Specie to store common natural stats of every {'abilities': ['lightning-rod', 'motor-drive', 'sap-sipper'], 'base_experience': 59, 'height': 8, 'id': 522, 'moves': ['stomp', 'double-kick', 'sand-attack', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'quick-attack', 'rage', 'screech', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'protect', 'endure', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'facade', 'charge', 'snatch', 'secret-power', 'signal-beam', 'bounce', 'shock-wave', 'feint', 'me-first', 'magnet-rise', 'discharge', 'charge-beam', 'flame-charge', 'round', 'volt-switch', 'wild-charge', 'confide'], 'name': 'blitzle', 'stats': {'hp': 45, 'attack': 60, 'defense': 32, 'special-attack': 50, 'special-defense': 32, 'speed': 76}, 'types': ['electric'], 'weight': 298, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'black', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'シママ', 'ko': '줄뮤마', 'zh-Hant': '斑斑馬', 'fr': 'Zébibron', 'de': 'Elezeba', 'es': 'Blitzle', 'it': 'Blitzle', 'en': 'Blitzle', 'ja': 'シママ', 'zh-Hans': '斑斑马'}, 'genera': {'ja-Hrkt': 'たいでんポケモン', 'ko': '하전포켓몬', 'zh-Hant': '帶電寶可夢', 'fr': 'Pokémon Étincélec', 'de': 'Hochspannung', 'es': 'Pokémon Electrizado', 'it': 'Pokémon Caricavolt', 'en': 'Electrified Pokémon', 'ja': 'たいでんポケモン', 'zh-Hans': '带电宝可梦'}}
	public class SpecieBlitzle : PokemonSpecie
	{
#nullable enable
		private static SpecieBlitzle? _instance = null;
#nullable restore
        public static SpecieBlitzle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBlitzle();
                }
                return _instance;
            }
        }

		public SpecieBlitzle() : base(
			"Blitzle",
			45, // HPs
			60, 32, // Attack & Defense
			50, 32, // Special Attack & Defense
			76			
		) {}
	}


	//Blitzle Pokemon Class
	public class Blitzle : Pokemon
	{

		public Blitzle(string nickname, int level)
		: base(
				522,
				SpecieBlitzle.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Blitzle() : base(
			522,
			SpecieBlitzle.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}