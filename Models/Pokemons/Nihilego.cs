using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Nihilego Specie to store common natural stats of every {'abilities': ['beast-boost'], 'base_experience': 257, 'height': 12, 'id': 793, 'moves': ['pound', 'headbutt', 'acid', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'constrict', 'psywave', 'rest', 'substitute', 'protect', 'sludge-bomb', 'sandstorm', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'mirror-coat', 'facade', 'tickle', 'toxic-spikes', 'poison-jab', 'power-gem', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'head-smash', 'guard-split', 'power-split', 'wonder-room', 'psyshock', 'venoshock', 'sludge-wave', 'acid-spray', 'round', 'echoed-voice', 'clear-smog', 'confide', 'venom-drench', 'dazzling-gleam', 'brutal-swing'], 'name': 'nihilego', 'stats': {'hp': 109, 'attack': 53, 'defense': 47, 'special-attack': 127, 'special-defense': 131, 'speed': 103}, 'types': ['rock', 'poison'], 'weight': 555, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'white', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ウツロイド', 'ko': '텅비드', 'zh-Hant': '虛吾伊德', 'fr': 'Zéroïd', 'de': 'Anego', 'es': 'Nihilego', 'it': 'Nihilego', 'en': 'Nihilego', 'ja': 'ウツロイド', 'zh-Hans': '虛吾伊德'}, 'genera': {'ja-Hrkt': 'きせいポケモン', 'ko': '기생포켓몬', 'zh-Hant': '寄生寶可夢', 'fr': 'Pokémon Parasite', 'de': 'Parasit', 'es': 'Pokémon Parásito', 'it': 'Pokémon Parassita', 'en': 'Parasite Pokémon', 'ja': 'きせいポケモン', 'zh-Hans': '寄生宝可梦'}}
	public class SpecieNihilego : PokemonSpecie
	{
#nullable enable
		private static SpecieNihilego? _instance = null;
#nullable restore
        public static SpecieNihilego Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNihilego();
                }
                return _instance;
            }
        }

		public SpecieNihilego() : base(
			"Nihilego",
			109, // HPs
			53, 47, // Attack & Defense
			127, 131, // Special Attack & Defense
			103			
		) {}
	}


	//Nihilego Pokemon Class
	public class Nihilego : Pokemon
	{

		public Nihilego(string nickname, int level) : base(
			793,
			SpecieNihilego.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Poison.Instance			
		) {}

		public Nihilego() : base(
			793,
			SpecieNihilego.Instance, // Pokemon Specie
			Rock.Instance, Poison.Instance			
		) {}
	}
}