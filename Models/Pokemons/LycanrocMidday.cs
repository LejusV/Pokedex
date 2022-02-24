using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lycanroc-Midday Specie to store common natural stats of every {'abilities': ['keen-eye', 'sand-rush', 'steadfast'], 'base_experience': 170, 'height': 8, 'id': 745, 'moves': ['swords-dance', 'sand-attack', 'tackle', 'leer', 'bite', 'roar', 'rock-throw', 'toxic', 'quick-attack', 'double-team', 'rest', 'rock-slide', 'substitute', 'protect', 'scary-face', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'crunch', 'facade', 'taunt', 'brick-break', 'odor-sleuth', 'rock-tomb', 'howl', 'bulk-up', 'rock-polish', 'rock-climb', 'stone-edge', 'stealth-rock', 'round', 'echoed-voice', 'quick-guard', 'snarl', 'confide', 'accelerock'], 'name': 'lycanroc-midday', 'stats': {'hp': 75, 'attack': 115, 'defense': 65, 'special-attack': 55, 'special-defense': 65, 'speed': 112}, 'types': ['rock'], 'weight': 250, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ルガルガン', 'ko': '루가루암', 'zh-Hant': '鬃岩狼人', 'fr': 'Lougaroc', 'de': 'Wolwerock', 'es': 'Lycanroc', 'it': 'Lycanroc', 'en': 'Lycanroc', 'ja': 'ルガルガン', 'zh-Hans': '鬃岩狼人'}, 'genera': {'ja-Hrkt': 'オオカミポケモン', 'ko': '늑대포켓몬', 'zh-Hant': '狼寶可夢', 'fr': 'Pokémon Loup', 'de': 'Wolf', 'es': 'Pokémon Lobo', 'it': 'Pokémon Lupo', 'en': 'Wolf Pokémon', 'ja': 'オオカミポケモン', 'zh-Hans': '狼宝可梦'}}
	public class SpecieLycanrocMidday : PokemonSpecie
	{
#nullable enable
		private static SpecieLycanrocMidday? _instance = null;
#nullable restore
        public static SpecieLycanrocMidday Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLycanrocMidday();
                }
                return _instance;
            }
        }

		public SpecieLycanrocMidday() : base(
			"Lycanroc-Midday",
			75, // HPs
			115, 65, // Attack & Defense
			55, 65, // Special Attack & Defense
			112			
		) {}
	}


	//Lycanroc-Midday Pokemon Class
	public class LycanrocMidday : Pokemon
	{

		public LycanrocMidday(string nickname, int level)
		: base(
				745,
				SpecieLycanrocMidday.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public LycanrocMidday() : base(
			745,
			SpecieLycanrocMidday.Instance, // Pokemon Specie
			Rock.Instance			
		) {}
	}
}