using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Brionne Specie to store common natural stats of every {'abilities': ['torrent', 'liquid-voice'], 'base_experience': 147, 'height': 6, 'id': 729, 'moves': ['pound', 'double-slap', 'growl', 'sing', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'toxic', 'double-team', 'waterfall', 'rest', 'substitute', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'rain-dance', 'hail', 'facade', 'hyper-voice', 'captivate', 'aqua-jet', 'round', 'echoed-voice', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'disarming-voice', 'misty-terrain', 'moonblast', 'confide', 'baby-doll-eyes'], 'name': 'brionne', 'stats': {'hp': 60, 'attack': 69, 'defense': 69, 'special-attack': 91, 'special-defense': 81, 'speed': 50}, 'types': ['water'], 'weight': 175, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'オシャマリ', 'ko': '키요공', 'zh-Hant': '花漾海獅', 'fr': 'Otarlette', 'de': 'Marikeck', 'es': 'Brionne', 'it': 'Brionne', 'en': 'Brionne', 'ja': 'オシャマリ', 'zh-Hans': '花漾海狮'}, 'genera': {'ja-Hrkt': 'アイドルポケモン', 'ko': '아이돌포켓몬', 'zh-Hant': '偶像寶可夢', 'fr': 'Pokémon Starlette', 'de': 'Popsternchen', 'es': 'Pokémon Fama', 'it': 'Pokémon Pop Star', 'en': 'Pop Star Pokémon', 'ja': 'アイドルポケモン', 'zh-Hans': '偶像宝可梦'}}
	public class SpecieBrionne : PokemonSpecie
	{
#nullable enable
		private static SpecieBrionne? _instance = null;
#nullable restore
        public static SpecieBrionne Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBrionne();
                }
                return _instance;
            }
        }

		public SpecieBrionne() : base(
			"Brionne",
			60, // HPs
			69, 69, // Attack & Defense
			91, 81, // Special Attack & Defense
			50			
		) {}
	}


	//Brionne Pokemon Class
	public class Brionne : Pokemon
	{

		public Brionne(string nickname, int level)
		: base(
				729,
				SpecieBrionne.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Brionne(int level)
		: base(
				729,
				SpecieBrionne.Instance, // Pokemon Specie
				"Brionne", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Brionne() : base(
			729,
			SpecieBrionne.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}