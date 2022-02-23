using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zebstrika Specie to store common natural stats of every {'abilities': ['lightning-rod', 'motor-drive', 'sap-sipper'], 'base_experience': 174, 'height': 16, 'id': 523, 'moves': ['stomp', 'thrash', 'tail-whip', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'quick-attack', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'protect', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'charge', 'snatch', 'secret-power', 'overheat', 'signal-beam', 'bounce', 'shock-wave', 'magnet-rise', 'giga-impact', 'discharge', 'charge-beam', 'flame-charge', 'round', 'volt-switch', 'wild-charge', 'ion-deluge', 'confide'], 'name': 'zebstrika', 'stats': {'hp': 75, 'attack': 100, 'defense': 63, 'special-attack': 80, 'special-defense': 63, 'speed': 116}, 'types': ['electric'], 'weight': 795, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'black', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ゼブライカ', 'ko': '제브라이카', 'zh-Hant': '雷電斑馬', 'fr': 'Zéblitz', 'de': 'Zebritz', 'es': 'Zebstrika', 'it': 'Zebstrika', 'en': 'Zebstrika', 'ja': 'ゼブライカ', 'zh-Hans': '雷电斑马'}, 'genera': {'ja-Hrkt': 'らいでんポケモン', 'ko': '뇌전포켓몬', 'zh-Hant': '雷電寶可夢', 'fr': 'Pokémon Foudrélec', 'de': 'Donnerkeil', 'es': 'Pokémon Rayo', 'it': 'Pokémon Saetta', 'en': 'Thunderbolt Pokémon', 'ja': 'らいでんポケモン', 'zh-Hans': '雷电宝可梦'}}
	public class SpecieZebstrika : PokemonSpecie
	{
#nullable enable
		private static SpecieZebstrika? _instance = null;
#nullable restore
        public static SpecieZebstrika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZebstrika();
                }
                return _instance;
            }
        }

		public SpecieZebstrika() : base(
			"Zebstrika",
			75, // HPs
			100, 63, // Attack & Defense
			80, 63, // Special Attack & Defense
			116			
		) {}
	}


	//Zebstrika Pokemon Class
	public class Zebstrika : Pokemon
	{

		public Zebstrika(string nickname, int level) : base(
			523,
			SpecieZebstrika.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Zebstrika() : base(
			523,
			SpecieZebstrika.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}