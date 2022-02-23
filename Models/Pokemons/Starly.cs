using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Starly Specie to store common natural stats of every {'abilities': ['keen-eye', 'reckless'], 'base_experience': 49, 'height': 3, 'id': 396, 'moves': ['wing-attack', 'whirlwind', 'fly', 'sand-attack', 'fury-attack', 'tackle', 'take-down', 'double-edge', 'growl', 'toxic', 'agility', 'quick-attack', 'double-team', 'mirror-move', 'swift', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'foresight', 'detect', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'revenge', 'endeavor', 'secret-power', 'feather-dance', 'astonish', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'brave-bird', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'final-gambit', 'work-up', 'confide'], 'name': 'starly', 'stats': {'hp': 40, 'attack': 55, 'defense': 30, 'special-attack': 30, 'special-defense': 30, 'speed': 60}, 'types': ['normal', 'flying'], 'weight': 20, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ムックル', 'roomaji': 'Mukkuru', 'ko': '찌르꼬', 'zh-Hant': '姆克兒', 'fr': 'Étourmi', 'de': 'Staralili', 'es': 'Starly', 'it': 'Starly', 'en': 'Starly', 'ja': 'ムックル', 'zh-Hans': '姆克儿'}, 'genera': {'ja-Hrkt': 'むくどりポケモン', 'ko': '찌르레기포켓몬', 'zh-Hant': '椋鳥寶可夢', 'fr': 'Pokémon Étourneau', 'de': 'Star', 'es': 'Pokémon Estornino', 'it': 'Pokémon Storno', 'en': 'Starling Pokémon', 'ja': 'むくどりポケモン', 'zh-Hans': '椋鸟宝可梦'}}
	public class SpecieStarly : PokemonSpecie
	{
#nullable enable
		private static SpecieStarly? _instance = null;
#nullable restore
        public static SpecieStarly Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStarly();
                }
                return _instance;
            }
        }

		public SpecieStarly() : base(
			"Starly",
			40, // HPs
			55, 30, // Attack & Defense
			30, 30, // Special Attack & Defense
			60			
		) {}
	}


	//Starly Pokemon Class
	public class Starly : Pokemon
	{

		public Starly(string nickname, int level) : base(
			396,
			SpecieStarly.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Starly() : base(
			396,
			SpecieStarly.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}