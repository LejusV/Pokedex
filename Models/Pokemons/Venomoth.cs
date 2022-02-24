using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Venomoth Specie to store common natural stats of every {'abilities': ['shield-dust', 'tinted-lens', 'wonder-skin'], 'base_experience': 158, 'height': 15, 'id': 49, 'moves': ['razor-wind', 'gust', 'whirlwind', 'tackle', 'take-down', 'double-edge', 'supersonic', 'disable', 'psybeam', 'hyper-beam', 'mega-drain', 'solar-beam', 'poison-powder', 'stun-spore', 'sleep-powder', 'string-shot', 'toxic', 'confusion', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'reflect', 'bide', 'swift', 'leech-life', 'flash', 'psywave', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'foresight', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'hidden-power', 'twister', 'sunny-day', 'facade', 'skill-swap', 'secret-power', 'poison-fang', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'bug-buzz', 'energy-ball', 'giga-impact', 'zen-headbutt', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'venoshock', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'confide', 'infestation'], 'name': 'venomoth', 'stats': {'hp': 70, 'attack': 65, 'defense': 60, 'special-attack': 90, 'special-defense': 75, 'speed': 90}, 'types': ['bug', 'poison'], 'weight': 125, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'purple', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'モルフォン', 'roomaji': 'Morphon', 'ko': '도나리', 'zh-Hant': '摩魯蛾', 'fr': 'Aéromite', 'de': 'Omot', 'es': 'Venomoth', 'it': 'Venomoth', 'en': 'Venomoth', 'ja': 'モルフォン', 'zh-Hans': '摩鲁蛾'}, 'genera': {'ja-Hrkt': 'どくがポケモン', 'ko': '독나방포켓몬', 'zh-Hant': '毒蛾寶可夢', 'fr': 'Pokémon Papipoison', 'de': 'Giftmotte', 'es': 'Pokémon Polilla Ven.', 'it': 'Pokémon Velentarma', 'en': 'Poison Moth Pokémon', 'ja': 'どくがポケモン', 'zh-Hans': '毒蛾宝可梦'}}
	public class SpecieVenomoth : PokemonSpecie
	{
#nullable enable
		private static SpecieVenomoth? _instance = null;
#nullable restore
        public static SpecieVenomoth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVenomoth();
                }
                return _instance;
            }
        }

		public SpecieVenomoth() : base(
			"Venomoth",
			70, // HPs
			65, 60, // Attack & Defense
			90, 75, // Special Attack & Defense
			90			
		) {}
	}


	//Venomoth Pokemon Class
	public class Venomoth : Pokemon
	{

		public Venomoth(string nickname, int level)
		: base(
				49,
				SpecieVenomoth.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Venomoth(int level)
		: base(
				49,
				SpecieVenomoth.Instance, // Pokemon Specie
				"Venomoth", level,
				Bug.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Venomoth() : base(
			49,
			SpecieVenomoth.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}