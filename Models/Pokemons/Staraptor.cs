using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Staraptor Specie to store common natural stats of every {'abilities': ['intimidate', 'reckless'], 'base_experience': 218, 'height': 12, 'id': 398, 'moves': ['wing-attack', 'whirlwind', 'fly', 'tackle', 'take-down', 'growl', 'hyper-beam', 'toxic', 'agility', 'quick-attack', 'double-team', 'swift', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'protect', 'mud-slap', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'uproar', 'heat-wave', 'facade', 'endeavor', 'secret-power', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'close-combat', 'brave-bird', 'giga-impact', 'defog', 'captivate', 'ominous-wind', 'round', 'echoed-voice', 'retaliate', 'final-gambit', 'work-up', 'confide'], 'name': 'staraptor', 'stats': {'hp': 85, 'attack': 120, 'defense': 70, 'special-attack': 50, 'special-defense': 60, 'speed': 100}, 'types': ['normal', 'flying'], 'weight': 249, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ムクホーク', 'roomaji': 'Mukuhawk', 'ko': '찌르호크', 'zh-Hant': '姆克鷹', 'fr': 'Étouraptor', 'de': 'Staraptor', 'es': 'Staraptor', 'it': 'Staraptor', 'en': 'Staraptor', 'ja': 'ムクホーク', 'zh-Hans': '姆克鹰'}, 'genera': {'ja-Hrkt': 'もうきんポケモン', 'ko': '맹금포켓몬', 'zh-Hant': '猛禽寶可夢', 'fr': 'Pokémon Rapace', 'de': 'Raubtier', 'es': 'Pokémon Depredador', 'it': 'Pokémon Rapace', 'en': 'Predator Pokémon', 'ja': 'もうきんポケモン', 'zh-Hans': '猛禽宝可梦'}}
	public class SpecieStaraptor : PokemonSpecie
	{
#nullable enable
		private static SpecieStaraptor? _instance = null;
#nullable restore
        public static SpecieStaraptor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStaraptor();
                }
                return _instance;
            }
        }

		public SpecieStaraptor() : base(
			"Staraptor",
			85, // HPs
			120, 70, // Attack & Defense
			50, 60, // Special Attack & Defense
			100			
		) {}
	}


	//Staraptor Pokemon Class
	public class Staraptor : Pokemon
	{

		public Staraptor(string nickname, int level)
		: base(
				398,
				SpecieStaraptor.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Staraptor(int level)
		: base(
				398,
				SpecieStaraptor.Instance, // Pokemon Specie
				"Staraptor", level,
				Normal.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Staraptor() : base(
			398,
			SpecieStaraptor.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}