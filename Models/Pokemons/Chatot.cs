using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chatot Specie to store common natural stats of every {'abilities': ['keen-eye', 'tangled-feet', 'big-pecks'], 'base_experience': 144, 'height': 5, 'id': 441, 'moves': ['fly', 'fury-attack', 'growl', 'sing', 'supersonic', 'peck', 'toxic', 'agility', 'night-shade', 'mimic', 'double-team', 'mirror-move', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'role-play', 'secret-power', 'feather-dance', 'hyper-voice', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'nasty-plot', 'defog', 'captivate', 'chatter', 'ominous-wind', 'synchronoise', 'round', 'echoed-voice', 'work-up', 'boomburst', 'confide'], 'name': 'chatot', 'stats': {'hp': 76, 'attack': 65, 'defense': 45, 'special-attack': 92, 'special-defense': 42, 'speed': 91}, 'types': ['normal', 'flying'], 'weight': 19, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'black', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ペラップ', 'roomaji': 'Perap', 'ko': '페라페', 'zh-Hant': '聒噪鳥', 'fr': 'Pijako', 'de': 'Plaudagei', 'es': 'Chatot', 'it': 'Chatot', 'en': 'Chatot', 'ja': 'ペラップ', 'zh-Hans': '聒噪鸟'}, 'genera': {'ja-Hrkt': 'おんぷポケモン', 'ko': '음표포켓몬', 'zh-Hant': '音符寶可夢', 'fr': 'Pokémon Note Musique', 'de': 'Musiknote', 'es': 'Pokémon Corchea', 'it': 'Pokémon Musicale', 'en': 'Music Note Pokémon', 'ja': 'おんぷポケモン', 'zh-Hans': '音符宝可梦'}}
	public class SpecieChatot : PokemonSpecie
	{
#nullable enable
		private static SpecieChatot? _instance = null;
#nullable restore
        public static SpecieChatot Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChatot();
                }
                return _instance;
            }
        }

		public SpecieChatot() : base(
			"Chatot",
			76, // HPs
			65, 45, // Attack & Defense
			92, 42, // Special Attack & Defense
			91			
		) {}
	}


	//Chatot Pokemon Class
	public class Chatot : Pokemon
	{

		public Chatot(string nickname, int level)
		: base(
				441,
				SpecieChatot.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Chatot() : base(
			441,
			SpecieChatot.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}