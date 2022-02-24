using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Skarmory Specie to store common natural stats of every {'abilities': ['keen-eye', 'sturdy', 'weak-armor'], 'base_experience': 163, 'height': 17, 'id': 227, 'moves': ['swords-dance', 'cut', 'whirlwind', 'fly', 'sand-attack', 'fury-attack', 'double-edge', 'leer', 'roar', 'peck', 'drill-peck', 'counter', 'toxic', 'agility', 'mimic', 'double-team', 'swift', 'sky-attack', 'flash', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'curse', 'protect', 'mud-slap', 'spikes', 'icy-wind', 'detect', 'sandstorm', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'metal-claw', 'hidden-power', 'twister', 'sunny-day', 'rock-smash', 'torment', 'facade', 'taunt', 'secret-power', 'air-cutter', 'rock-tomb', 'metal-sound', 'aerial-ace', 'iron-defense', 'roost', 'natural-gift', 'feint', 'pluck', 'tailwind', 'payback', 'assurance', 'guard-swap', 'dark-pulse', 'night-slash', 'air-slash', 'x-scissor', 'brave-bird', 'flash-cannon', 'defog', 'iron-head', 'captivate', 'stealth-rock', 'ominous-wind', 'autotomize', 'round', 'sky-drop', 'confide'], 'name': 'skarmory', 'stats': {'hp': 65, 'attack': 80, 'defense': 140, 'special-attack': 40, 'special-defense': 70, 'speed': 70}, 'types': ['steel', 'flying'], 'weight': 505, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 25, 'color': 'gray', 'shape': 'wings', 'habitat': 'rough-terrain', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'エアームド', 'roomaji': 'Airmd', 'ko': '무장조', 'zh-Hant': '盔甲鳥', 'fr': 'Airmure', 'de': 'Panzaeron', 'es': 'Skarmory', 'it': 'Skarmory', 'en': 'Skarmory', 'ja': 'エアームド', 'zh-Hans': '盔甲鸟'}, 'genera': {'ja-Hrkt': 'よろいどりポケモン', 'ko': '갑옷새포켓몬', 'zh-Hant': '鋼甲鳥寶可夢', 'fr': 'Pokémon Armoiseau', 'de': 'Flugstahl', 'es': 'Pokémon Coraza Ave', 'it': 'Pokémon Armuccello', 'en': 'Armor Bird Pokémon', 'ja': 'よろいどりポケモン', 'zh-Hans': '钢甲鸟宝可梦'}}
	public class SpecieSkarmory : PokemonSpecie
	{
#nullable enable
		private static SpecieSkarmory? _instance = null;
#nullable restore
        public static SpecieSkarmory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSkarmory();
                }
                return _instance;
            }
        }

		public SpecieSkarmory() : base(
			"Skarmory",
			65, // HPs
			80, 140, // Attack & Defense
			40, 70, // Special Attack & Defense
			70			
		) {}
	}


	//Skarmory Pokemon Class
	public class Skarmory : Pokemon
	{

		public Skarmory(string nickname, int level)
		: base(
				227,
				SpecieSkarmory.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Skarmory() : base(
			227,
			SpecieSkarmory.Instance, // Pokemon Specie
			Steel.Instance, Flying.Instance			
		) {}
	}
}