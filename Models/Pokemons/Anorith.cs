using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Anorith Specie to store common natural stats of every {'abilities': ['battle-armor', 'swift-swim'], 'base_experience': 71, 'height': 7, 'id': 347, 'moves': ['scratch', 'swords-dance', 'cut', 'sand-attack', 'headbutt', 'body-slam', 'double-edge', 'water-gun', 'string-shot', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'harden', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'metal-claw', 'hidden-power', 'sunny-day', 'ancient-power', 'rock-smash', 'facade', 'brick-break', 'knock-off', 'secret-power', 'mud-sport', 'crush-claw', 'rock-tomb', 'aerial-ace', 'iron-defense', 'rock-blast', 'water-pulse', 'brine', 'natural-gift', 'rock-polish', 'x-scissor', 'earth-power', 'cross-poison', 'captivate', 'stealth-rock', 'bug-bite', 'aqua-jet', 'hone-claws', 'smack-down', 'round', 'struggle-bug', 'confide'], 'name': 'anorith', 'stats': {'hp': 45, 'attack': 95, 'defense': 50, 'special-attack': 40, 'special-defense': 50, 'speed': 75}, 'types': ['rock', 'bug'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 1, 'capture_rate': 45, 'color': 'gray', 'shape': 'armor', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'アノプス', 'roomaji': 'Anopth', 'ko': '아노딥스', 'zh-Hant': '太古羽蟲', 'fr': 'Anorith', 'de': 'Anorith', 'es': 'Anorith', 'it': 'Anorith', 'en': 'Anorith', 'ja': 'アノプス', 'zh-Hans': '太古羽虫'}, 'genera': {'ja-Hrkt': 'むかしエビポケモン', 'ko': '고대새우포켓몬', 'zh-Hant': '古蝦寶可夢', 'fr': 'Pokémon Crustage', 'de': 'Urgarnele', 'es': 'Pokémon Camarón', 'it': 'Pokémon Primaceo', 'en': 'Old Shrimp Pokémon', 'ja': 'むかしエビポケモン', 'zh-Hans': '古虾宝可梦'}}
	public class SpecieAnorith : PokemonSpecie
	{
#nullable enable
		private static SpecieAnorith? _instance = null;
#nullable restore
        public static SpecieAnorith Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAnorith();
                }
                return _instance;
            }
        }

		public SpecieAnorith() : base(
			"Anorith",
			45, // HPs
			95, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			75			
		) {}
	}


	//Anorith Pokemon Class
	public class Anorith : Pokemon
	{

		public Anorith(string nickname, int level)
		: base(
				347,
				SpecieAnorith.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Anorith() : base(
			347,
			SpecieAnorith.Instance, // Pokemon Specie
			Rock.Instance, Bug.Instance			
		) {}
	}
}