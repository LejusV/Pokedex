using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Popplio Specie to store common natural stats of every {'abilities': ['torrent', 'liquid-voice'], 'base_experience': 64, 'height': 4, 'id': 728, 'moves': ['pound', 'double-slap', 'growl', 'sing', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'toxic', 'double-team', 'waterfall', 'amnesia', 'rest', 'substitute', 'protect', 'perish-song', 'icy-wind', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'rain-dance', 'hail', 'facade', 'hyper-voice', 'aqua-ring', 'captivate', 'aqua-jet', 'wonder-room', 'round', 'echoed-voice', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'disarming-voice', 'misty-terrain', 'moonblast', 'confide', 'aromatic-mist', 'baby-doll-eyes'], 'name': 'popplio', 'stats': {'hp': 50, 'attack': 54, 'defense': 54, 'special-attack': 66, 'special-defense': 56, 'speed': 40}, 'types': ['water'], 'weight': 75, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'アシマリ', 'ko': '누리공', 'zh-Hant': '球球海獅', 'fr': 'Otaquin', 'de': 'Robball', 'es': 'Popplio', 'it': 'Popplio', 'en': 'Popplio', 'ja': 'アシマリ', 'zh-Hans': '球球海狮'}, 'genera': {'ja-Hrkt': 'あしかポケモン', 'ko': '강치포켓몬', 'zh-Hant': '海獅寶可夢', 'fr': 'Pokémon Otarie', 'de': 'Seehund', 'es': 'Pokémon León Marino', 'it': 'Pokémon Otaria', 'en': 'Sea Lion Pokémon', 'ja': 'あしかポケモン', 'zh-Hans': '海狮宝可梦'}}
	public class SpeciePopplio : PokemonSpecie
	{
#nullable enable
		private static SpeciePopplio? _instance = null;
#nullable restore
        public static SpeciePopplio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePopplio();
                }
                return _instance;
            }
        }

		public SpeciePopplio() : base(
			"Popplio",
			50, // HPs
			54, 54, // Attack & Defense
			66, 56, // Special Attack & Defense
			40			
		) {}
	}


	//Popplio Pokemon Class
	public class Popplio : Pokemon
	{

		public Popplio(string nickname, int level) : base(
			728,
			SpeciePopplio.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Popplio() : base(
			728,
			SpeciePopplio.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}