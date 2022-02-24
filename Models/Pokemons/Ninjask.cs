using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Ninjask Specie to store common natural stats of every {'abilities': ['speed-boost', 'infiltrator'], 'base_experience': 160, 'height': 8, 'id': 291, 'moves': ['scratch', 'swords-dance', 'cut', 'sand-attack', 'double-edge', 'hyper-beam', 'absorb', 'solar-beam', 'string-shot', 'dig', 'toxic', 'agility', 'mimic', 'screech', 'double-team', 'harden', 'swift', 'leech-life', 'flash', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'mind-reader', 'snore', 'spite', 'protect', 'mud-slap', 'sandstorm', 'giga-drain', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'hidden-power', 'sunny-day', 'shadow-ball', 'uproar', 'facade', 'secret-power', 'air-cutter', 'silver-wind', 'aerial-ace', 'roost', 'natural-gift', 'u-turn', 'x-scissor', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'hone-claws', 'round', 'struggle-bug', 'confide'], 'name': 'ninjask', 'stats': {'hp': 61, 'attack': 90, 'defense': 45, 'special-attack': 50, 'special-defense': 50, 'speed': 160}, 'types': ['bug', 'flying'], 'weight': 120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'yellow', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'テッカニン', 'roomaji': 'Tekkanin', 'ko': '아이스크', 'zh-Hant': '鐵面忍者', 'fr': 'Ninjask', 'de': 'Ninjask', 'es': 'Ninjask', 'it': 'Ninjask', 'en': 'Ninjask', 'ja': 'テッカニン', 'zh-Hans': '铁面忍者'}, 'genera': {'ja-Hrkt': 'しのびポケモン', 'ko': '시노비포켓몬', 'zh-Hant': '忍者寶可夢', 'fr': 'Pokémon Ninja', 'de': 'Ninja', 'es': 'Pokémon Ninja', 'it': 'Pokémon Ninja', 'en': 'Ninja Pokémon', 'ja': 'しのびポケモン', 'zh-Hans': '忍者宝可梦'}}
	public class SpecieNinjask : PokemonSpecie
	{
#nullable enable
		private static SpecieNinjask? _instance = null;
#nullable restore
        public static SpecieNinjask Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNinjask();
                }
                return _instance;
            }
        }

		public SpecieNinjask() : base(
			"Ninjask",
			61, // HPs
			90, 45, // Attack & Defense
			50, 50, // Special Attack & Defense
			160			
		) {}
	}


	//Ninjask Pokemon Class
	public class Ninjask : Pokemon
	{

		public Ninjask(string nickname, int level)
		: base(
				291,
				SpecieNinjask.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ninjask(int level)
		: base(
				291,
				SpecieNinjask.Instance, // Pokemon Specie
				"Ninjask", level,
				Bug.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Ninjask() : base(
			291,
			SpecieNinjask.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}