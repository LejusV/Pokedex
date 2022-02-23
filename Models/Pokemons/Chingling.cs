using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Chingling Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 57, 'height': 2, 'id': 433, 'moves': ['bind', 'wrap', 'growl', 'disable', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'hypnosis', 'double-team', 'recover', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'torment', 'facade', 'taunt', 'helping-hand', 'trick', 'wish', 'magic-coat', 'recycle', 'yawn', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'hyper-voice', 'astonish', 'cosmic-power', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'natural-gift', 'last-resort', 'zen-headbutt', 'trick-room', 'captivate', 'grass-knot', 'charge-beam', 'psyshock', 'telekinesis', 'entrainment', 'round', 'echoed-voice', 'stored-power', 'confide', 'dazzling-gleam'], 'name': 'chingling', 'stats': {'hp': 45, 'attack': 30, 'defense': 50, 'special-attack': 65, 'special-defense': 50, 'speed': 45}, 'types': ['psychic'], 'weight': 6, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 120, 'color': 'yellow', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'fast', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'リーシャン', 'roomaji': 'Lisyan', 'ko': '랑딸랑', 'zh-Hant': '鈴鐺響', 'fr': 'Korillon', 'de': 'Klingplim', 'es': 'Chingling', 'it': 'Chingling', 'en': 'Chingling', 'ja': 'リーシャン', 'zh-Hans': '铃铛响'}, 'genera': {'ja-Hrkt': 'すずポケモン', 'ko': '방울포켓몬', 'zh-Hant': '鈴鐺寶可夢', 'fr': 'Pokémon Clochette', 'de': 'Glöckchen', 'es': 'Pokémon Campana', 'it': 'Pokémon Sonaglio', 'en': 'Bell Pokémon', 'ja': 'すずポケモン', 'zh-Hans': '铃铛宝可梦'}}
	public class SpecieChingling : PokemonSpecie
	{
#nullable enable
		private static SpecieChingling? _instance = null;
#nullable restore
        public static SpecieChingling Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieChingling();
                }
                return _instance;
            }
        }

		public SpecieChingling() : base(
			"Chingling",
			45, // HPs
			30, 50, // Attack & Defense
			65, 50, // Special Attack & Defense
			45			
		) {}
	}


	//Chingling Pokemon Class
	public class Chingling : Pokemon
	{

		public Chingling(string nickname, int level) : base(
			433,
			SpecieChingling.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Chingling() : base(
			433,
			SpecieChingling.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}