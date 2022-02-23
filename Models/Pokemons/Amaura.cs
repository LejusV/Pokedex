using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Amaura Specie to store common natural stats of every {'abilities': ['refrigerate', 'snow-warning'], 'base_experience': 72, 'height': 13, 'id': 698, 'moves': ['take-down', 'growl', 'roar', 'mist', 'ice-beam', 'blizzard', 'aurora-beam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'rock-throw', 'toxic', 'double-team', 'barrier', 'light-screen', 'haze', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'snore', 'powder-snow', 'protect', 'icy-wind', 'outrage', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'mirror-coat', 'psych-up', 'ancient-power', 'rock-smash', 'hail', 'facade', 'nature-power', 'secret-power', 'hyper-voice', 'rock-tomb', 'iron-defense', 'calm-mind', 'water-pulse', 'magnet-rise', 'rock-polish', 'dark-pulse', 'aqua-tail', 'earth-power', 'avalanche', 'zen-headbutt', 'flash-cannon', 'discharge', 'iron-head', 'stone-edge', 'stealth-rock', 'charge-beam', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'dragon-tail', 'confide'], 'name': 'amaura', 'stats': {'hp': 77, 'attack': 59, 'defense': 50, 'special-attack': 67, 'special-defense': 63, 'speed': 46}, 'types': ['rock', 'ice'], 'weight': 252, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['monster'], 'names': {'ja-Hrkt': 'アマルス', 'ko': '아마루스', 'zh-Hant': '冰雪龍', 'fr': 'Amagara', 'de': 'Amarino', 'es': 'Amaura', 'it': 'Amaura', 'en': 'Amaura', 'ja': 'アマルス', 'zh-Hans': '冰雪龙'}, 'genera': {'ja-Hrkt': 'ツンドラポケモン', 'ko': '툰드라포켓몬', 'zh-Hant': '凍原寶可夢', 'fr': 'Pokémon Toundra', 'de': 'Tundra', 'es': 'Pokémon Tundra', 'it': 'Pokémon Tundra', 'en': 'Tundra Pokémon', 'ja': 'ツンドラポケモン', 'zh-Hans': '冻原宝可梦'}}
	public class SpecieAmaura : PokemonSpecie
	{
#nullable enable
		private static SpecieAmaura? _instance = null;
#nullable restore
        public static SpecieAmaura Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAmaura();
                }
                return _instance;
            }
        }

		public SpecieAmaura() : base(
			"Amaura",
			77, // HPs
			59, 50, // Attack & Defense
			67, 63, // Special Attack & Defense
			46			
		) {}
	}


	//Amaura Pokemon Class
	public class Amaura : Pokemon
	{

		public Amaura(string nickname, int level) : base(
			698,
			SpecieAmaura.Instance, // Pokemon Specie
			nickname, level,
			Rock.Instance, Ice.Instance			
		) {}

		public Amaura() : base(
			698,
			SpecieAmaura.Instance, // Pokemon Specie
			Rock.Instance, Ice.Instance			
		) {}
	}
}