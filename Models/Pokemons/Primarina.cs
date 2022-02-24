using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Primarina Specie to store common natural stats of every {'abilities': ['torrent', 'liquid-voice'], 'base_experience': 239, 'height': 18, 'id': 730, 'moves': ['pound', 'double-slap', 'growl', 'sing', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'waterfall', 'rest', 'substitute', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'hail', 'facade', 'hyper-voice', 'hydro-cannon', 'energy-ball', 'giga-impact', 'captivate', 'aqua-jet', 'round', 'echoed-voice', 'scald', 'acrobatics', 'water-pledge', 'work-up', 'disarming-voice', 'misty-terrain', 'moonblast', 'confide', 'dazzling-gleam', 'baby-doll-eyes', 'sparkling-aria'], 'name': 'primarina', 'stats': {'hp': 80, 'attack': 74, 'defense': 74, 'special-attack': 126, 'special-defense': 116, 'speed': 60}, 'types': ['water', 'fairy'], 'weight': 440, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'fish', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'アシレーヌ', 'ko': '누리레느', 'zh-Hant': '西獅海壬', 'fr': 'Oratoria', 'de': 'Primarene', 'es': 'Primarina', 'it': 'Primarina', 'en': 'Primarina', 'ja': 'アシレーヌ', 'zh-Hans': '西狮海壬'}, 'genera': {'ja-Hrkt': 'ソリストポケモン', 'ko': '솔리스트포켓몬', 'zh-Hant': '獨唱者寶可夢', 'fr': 'Pokémon Soliste', 'de': 'Solist', 'es': 'Pokémon Solista', 'it': 'Pokémon Solista', 'en': 'Soloist Pokémon', 'ja': 'ソリストポケモン', 'zh-Hans': '独唱者宝可梦'}}
	public class SpeciePrimarina : PokemonSpecie
	{
#nullable enable
		private static SpeciePrimarina? _instance = null;
#nullable restore
        public static SpeciePrimarina Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePrimarina();
                }
                return _instance;
            }
        }

		public SpeciePrimarina() : base(
			"Primarina",
			80, // HPs
			74, 74, // Attack & Defense
			126, 116, // Special Attack & Defense
			60			
		) {}
	}


	//Primarina Pokemon Class
	public class Primarina : Pokemon
	{

		public Primarina(string nickname, int level)
		: base(
				730,
				SpeciePrimarina.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Primarina(int level)
		: base(
				730,
				SpeciePrimarina.Instance, // Pokemon Specie
				"Primarina", level,
				Water.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Primarina() : base(
			730,
			SpeciePrimarina.Instance, // Pokemon Specie
			Water.Instance, Fairy.Instance			
		) {}
	}
}