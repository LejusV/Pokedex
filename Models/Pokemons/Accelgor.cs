using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Accelgor Specie to store common natural stats of every {'abilities': ['hydration', 'sticky-hold', 'unburden'], 'base_experience': 173, 'height': 8, 'id': 617, 'moves': ['hyper-beam', 'absorb', 'mega-drain', 'toxic', 'agility', 'quick-attack', 'double-team', 'recover', 'swift', 'leech-life', 'rest', 'substitute', 'snore', 'protect', 'sludge-bomb', 'sandstorm', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'facade', 'knock-off', 'secret-power', 'signal-beam', 'u-turn', 'gastro-acid', 'me-first', 'power-swap', 'bug-buzz', 'focus-blast', 'energy-ball', 'giga-impact', 'bug-bite', 'venoshock', 'acid-spray', 'round', 'final-gambit', 'struggle-bug', 'confide', 'water-shuriken', 'infestation'], 'name': 'accelgor', 'stats': {'hp': 80, 'attack': 70, 'defense': 40, 'special-attack': 100, 'special-defense': 60, 'speed': 145}, 'types': ['bug'], 'weight': 253, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'アギルダー', 'ko': '어지리더', 'zh-Hant': '敏捷蟲', 'fr': 'Limaspeed', 'de': 'Hydragil', 'es': 'Accelgor', 'it': 'Accelgor', 'en': 'Accelgor', 'ja': 'アギルダー', 'zh-Hans': '敏捷虫'}, 'genera': {'ja-Hrkt': 'からぬけポケモン', 'ko': '탈껍질포켓몬', 'zh-Hant': '脫殼寶可夢', 'fr': 'Pokémon Exuviateur', 'de': 'Entschalung', 'es': 'Pokémon Sincaparazón', 'it': 'Pokémon Sgusciato', 'en': 'Shell Out Pokémon', 'ja': 'からぬけポケモン', 'zh-Hans': '脱壳宝可梦'}}
	public class SpecieAccelgor : PokemonSpecie
	{
#nullable enable
		private static SpecieAccelgor? _instance = null;
#nullable restore
        public static SpecieAccelgor Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAccelgor();
                }
                return _instance;
            }
        }

		public SpecieAccelgor() : base(
			"Accelgor",
			80, // HPs
			70, 40, // Attack & Defense
			100, 60, // Special Attack & Defense
			145			
		) {}
	}


	//Accelgor Pokemon Class
	public class Accelgor : Pokemon
	{

		public Accelgor(string nickname, int level)
		: base(
				617,
				SpecieAccelgor.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Accelgor(int level)
		: base(
				617,
				SpecieAccelgor.Instance, // Pokemon Specie
				"Accelgor", level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Accelgor() : base(
			617,
			SpecieAccelgor.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}