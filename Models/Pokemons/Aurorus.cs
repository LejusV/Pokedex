using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aurorus Specie to store common natural stats of every {'abilities': ['refrigerate', 'snow-warning'], 'base_experience': 104, 'height': 27, 'id': 699, 'moves': ['take-down', 'growl', 'roar', 'mist', 'ice-beam', 'blizzard', 'aurora-beam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'rock-throw', 'earthquake', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'powder-snow', 'protect', 'icy-wind', 'outrage', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'rock-smash', 'hail', 'facade', 'nature-power', 'secret-power', 'hyper-voice', 'rock-tomb', 'iron-defense', 'calm-mind', 'water-pulse', 'magnet-rise', 'rock-polish', 'dark-pulse', 'aqua-tail', 'earth-power', 'giga-impact', 'avalanche', 'zen-headbutt', 'flash-cannon', 'iron-head', 'stone-edge', 'stealth-rock', 'charge-beam', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'dragon-tail', 'freeze-dry', 'confide'], 'name': 'aurorus', 'stats': {'hp': 123, 'attack': 77, 'defense': 72, 'special-attack': 99, 'special-defense': 92, 'speed': 58}, 'types': ['rock', 'ice'], 'weight': 2250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'アマルルガ', 'ko': '아마루르가', 'zh-Hant': '冰雪巨龍', 'fr': 'Dragmara', 'de': 'Amagarga', 'es': 'Aurorus', 'it': 'Aurorus', 'en': 'Aurorus', 'ja': 'アマルルガ', 'zh-Hans': '冰雪巨龙'}, 'genera': {'ja-Hrkt': 'ツンドラポケモン', 'ko': '툰드라포켓몬', 'zh-Hant': '凍原寶可夢', 'fr': 'Pokémon Toundra', 'de': 'Tundra', 'es': 'Pokémon Tundra', 'it': 'Pokémon Tundra', 'en': 'Tundra Pokémon', 'ja': 'ツンドラポケモン', 'zh-Hans': '冻原宝可梦'}}
	public class SpecieAurorus : PokemonSpecie
	{
#nullable enable
		private static SpecieAurorus? _instance = null;
#nullable restore
        public static SpecieAurorus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAurorus();
                }
                return _instance;
            }
        }

		public SpecieAurorus() : base(
			"Aurorus",
			123, // HPs
			77, 72, // Attack & Defense
			99, 92, // Special Attack & Defense
			58			
		) {}
	}


	//Aurorus Pokemon Class
	public class Aurorus : Pokemon
	{

		public Aurorus(string nickname, int level)
		: base(
				699,
				SpecieAurorus.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Aurorus() : base(
			699,
			SpecieAurorus.Instance, // Pokemon Specie
			Rock.Instance, Ice.Instance			
		) {}
	}
}