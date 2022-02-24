using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Emolga Specie to store common natural stats of every {'abilities': ['static', 'motor-drive'], 'base_experience': 150, 'height': 4, 'id': 587, 'moves': ['cut', 'tail-whip', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'quick-attack', 'double-team', 'light-screen', 'flash', 'rest', 'substitute', 'snore', 'protect', 'charm', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'encore', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'facade', 'charge', 'taunt', 'helping-hand', 'knock-off', 'secret-power', 'astonish', 'tickle', 'signal-beam', 'aerial-ace', 'covet', 'shock-wave', 'roost', 'tailwind', 'u-turn', 'fling', 'last-resort', 'air-slash', 'discharge', 'charge-beam', 'electro-ball', 'round', 'acrobatics', 'volt-switch', 'electroweb', 'wild-charge', 'ion-deluge', 'confide', 'nuzzle', 'speed-swap'], 'name': 'emolga', 'stats': {'hp': 55, 'attack': 75, 'defense': 60, 'special-attack': 75, 'special-defense': 60, 'speed': 103}, 'types': ['electric', 'flying'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'zh-Hans': '电飞鼠', 'ja-Hrkt': 'エモンガ', 'ko': '에몽가', 'zh-Hant': '電飛鼠', 'fr': 'Emolga', 'de': 'Emolga', 'es': 'Emolga', 'it': 'Emolga', 'en': 'Emolga', 'ja': 'エモンガ'}, 'genera': {'zh-Hans': '飞鼠宝可梦', 'ja-Hrkt': 'モモンガポケモン', 'ko': '하늘다람쥐포켓몬', 'zh-Hant': '飛鼠寶可夢', 'fr': 'Pokémon Pteromys', 'de': 'Flughörnchen', 'es': 'Pokémon Vuelardilla', 'it': 'Pokémon Petauro', 'en': 'Sky Squirrel Pokémon', 'ja': 'モモンガポケモン'}}
	public class SpecieEmolga : PokemonSpecie
	{
#nullable enable
		private static SpecieEmolga? _instance = null;
#nullable restore
        public static SpecieEmolga Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEmolga();
                }
                return _instance;
            }
        }

		public SpecieEmolga() : base(
			"Emolga",
			55, // HPs
			75, 60, // Attack & Defense
			75, 60, // Special Attack & Defense
			103			
		) {}
	}


	//Emolga Pokemon Class
	public class Emolga : Pokemon
	{

		public Emolga(string nickname, int level)
		: base(
				587,
				SpecieEmolga.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Emolga(int level)
		: base(
				587,
				SpecieEmolga.Instance, // Pokemon Specie
				"Emolga", level,
				Electric.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Emolga() : base(
			587,
			SpecieEmolga.Instance, // Pokemon Specie
			Electric.Instance, Flying.Instance			
		) {}
	}
}