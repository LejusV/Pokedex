using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Honchkrow Specie to store common natural stats of every {'abilities': ['insomnia', 'super-luck', 'moxie'], 'base_experience': 177, 'height': 9, 'id': 430, 'moves': ['wing-attack', 'fly', 'hyper-beam', 'thunder-wave', 'toxic', 'psychic', 'double-team', 'haze', 'swift', 'dream-eater', 'sky-attack', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'superpower', 'snatch', 'secret-power', 'astonish', 'air-cutter', 'aerial-ace', 'calm-mind', 'roost', 'natural-gift', 'pluck', 'tailwind', 'payback', 'embargo', 'sucker-punch', 'dark-pulse', 'night-slash', 'giga-impact', 'nasty-plot', 'defog', 'captivate', 'ominous-wind', 'foul-play', 'round', 'incinerate', 'quash', 'retaliate', 'snarl', 'confide'], 'name': 'honchkrow', 'stats': {'hp': 100, 'attack': 125, 'defense': 52, 'special-attack': 105, 'special-defense': 52, 'speed': 71}, 'types': ['dark', 'flying'], 'weight': 273, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 30, 'color': 'black', 'shape': 'wings', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ドンカラス', 'roomaji': 'Donkarasu', 'ko': '돈크로우', 'zh-Hant': '烏鴉頭頭', 'fr': 'Corboss', 'de': 'Kramshef', 'es': 'Honchkrow', 'it': 'Honchkrow', 'en': 'Honchkrow', 'ja': 'ドンカラス', 'zh-Hans': '乌鸦头头'}, 'genera': {'ja-Hrkt': 'おおボスポケモン', 'ko': '큰형님포켓몬', 'zh-Hant': '大頭目寶可夢', 'fr': 'Pokémon Big Boss', 'de': 'Anführer', 'es': 'Pokémon Gran Jefe', 'it': 'Pokémon Grancapo', 'en': 'Big Boss Pokémon', 'ja': 'おおボスポケモン', 'zh-Hans': '大头目宝可梦'}}
	public class SpecieHonchkrow : PokemonSpecie
	{
#nullable enable
		private static SpecieHonchkrow? _instance = null;
#nullable restore
        public static SpecieHonchkrow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHonchkrow();
                }
                return _instance;
            }
        }

		public SpecieHonchkrow() : base(
			"Honchkrow",
			100, // HPs
			125, 52, // Attack & Defense
			105, 52, // Special Attack & Defense
			71			
		) {}
	}


	//Honchkrow Pokemon Class
	public class Honchkrow : Pokemon
	{

		public Honchkrow(string nickname, int level)
		: base(
				430,
				SpecieHonchkrow.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Honchkrow(int level)
		: base(
				430,
				SpecieHonchkrow.Instance, // Pokemon Specie
				"Honchkrow", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Honchkrow() : base(
			430,
			SpecieHonchkrow.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
	}
}