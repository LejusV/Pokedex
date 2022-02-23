using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dustox Specie to store common natural stats of every {'abilities': ['shield-dust', 'compound-eyes'], 'base_experience': 173, 'height': 12, 'id': 269, 'moves': ['gust', 'whirlwind', 'double-edge', 'psybeam', 'hyper-beam', 'solar-beam', 'poison-powder', 'string-shot', 'toxic', 'confusion', 'psychic', 'mimic', 'double-team', 'light-screen', 'swift', 'flash', 'rest', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'moonlight', 'hidden-power', 'twister', 'sunny-day', 'shadow-ball', 'facade', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'bug-buzz', 'energy-ball', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'venoshock', 'quiver-dance', 'round', 'acrobatics', 'struggle-bug', 'electroweb', 'confide', 'infestation'], 'name': 'dustox', 'stats': {'hp': 60, 'attack': 50, 'defense': 70, 'special-attack': 50, 'special-defense': 90, 'speed': 65}, 'types': ['bug', 'poison'], 'weight': 316, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'green', 'shape': 'bug-wings', 'habitat': 'forest', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ドクケイル', 'roomaji': 'Dokucale', 'ko': '독케일', 'zh-Hant': '毒粉蛾', 'fr': 'Papinox', 'de': 'Pudox', 'es': 'Dustox', 'it': 'Dustox', 'en': 'Dustox', 'ja': 'ドクケイル', 'zh-Hans': '毒粉蛾'}, 'genera': {'ja-Hrkt': 'どくがポケモン', 'ko': '독나방포켓몬', 'zh-Hant': '毒蛾寶可夢', 'fr': 'Pokémon Papipoison', 'de': 'Giftmotte', 'es': 'Pokémon Polilla Ven.', 'it': 'Pokémon Velentarma', 'en': 'Poison Moth Pokémon', 'ja': 'どくがポケモン', 'zh-Hans': '毒蛾宝可梦'}}
	public class SpecieDustox : PokemonSpecie
	{
#nullable enable
		private static SpecieDustox? _instance = null;
#nullable restore
        public static SpecieDustox Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDustox();
                }
                return _instance;
            }
        }

		public SpecieDustox() : base(
			"Dustox",
			60, // HPs
			50, 70, // Attack & Defense
			50, 90, // Special Attack & Defense
			65			
		) {}
	}


	//Dustox Pokemon Class
	public class Dustox : Pokemon
	{

		public Dustox(string nickname, int level) : base(
			269,
			SpecieDustox.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Poison.Instance			
		) {}

		public Dustox() : base(
			269,
			SpecieDustox.Instance, // Pokemon Specie
			Bug.Instance, Poison.Instance			
		) {}
	}
}