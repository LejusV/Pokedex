using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sylveon Specie to store common natural stats of every {'abilities': ['cute-charm', 'pixilate'], 'base_experience': 184, 'height': 10, 'id': 700, 'moves': ['cut', 'sand-attack', 'tackle', 'tail-whip', 'hyper-beam', 'dig', 'toxic', 'quick-attack', 'double-team', 'light-screen', 'reflect', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'helping-hand', 'magic-coat', 'skill-swap', 'secret-power', 'hyper-voice', 'covet', 'calm-mind', 'last-resort', 'giga-impact', 'psyshock', 'round', 'echoed-voice', 'retaliate', 'work-up', 'disarming-voice', 'draining-kiss', 'misty-terrain', 'fairy-wind', 'moonblast', 'confide', 'dazzling-gleam', 'baby-doll-eyes'], 'name': 'sylveon', 'stats': {'hp': 95, 'attack': 65, 'defense': 65, 'special-attack': 110, 'special-defense': 130, 'speed': 60}, 'types': ['fairy'], 'weight': 235, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'pink', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニンフィア', 'ko': '님피아', 'zh-Hant': '仙子伊布', 'fr': 'Nymphali', 'de': 'Feelinara', 'es': 'Sylveon', 'it': 'Sylveon', 'en': 'Sylveon', 'ja': 'ニンフィア', 'zh-Hans': '仙子伊布'}, 'genera': {'ja-Hrkt': 'むすびつきポケモン', 'ko': '연결포켓몬', 'zh-Hant': '連結寶可夢', 'fr': 'Pokémon Attachant', 'de': 'Bindung', 'es': 'Pokémon Vínculo', 'it': 'Pokémon Legame', 'en': 'Intertwining Pokémon', 'ja': 'むすびつきポケモン', 'zh-Hans': '连结宝可梦'}}
	public class SpecieSylveon : PokemonSpecie
	{
#nullable enable
		private static SpecieSylveon? _instance = null;
#nullable restore
        public static SpecieSylveon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSylveon();
                }
                return _instance;
            }
        }

		public SpecieSylveon() : base(
			"Sylveon",
			95, // HPs
			65, 65, // Attack & Defense
			110, 130, // Special Attack & Defense
			60			
		) {}
	}


	//Sylveon Pokemon Class
	public class Sylveon : Pokemon
	{

		public Sylveon(string nickname, int level)
		: base(
				700,
				SpecieSylveon.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sylveon() : base(
			700,
			SpecieSylveon.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}