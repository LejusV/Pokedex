using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Masquerain Specie to store common natural stats of every {'abilities': ['intimidate', 'unnerve'], 'base_experience': 159, 'height': 8, 'id': 284, 'moves': ['gust', 'whirlwind', 'double-edge', 'ice-beam', 'blizzard', 'hyper-beam', 'solar-beam', 'stun-spore', 'string-shot', 'toxic', 'quick-attack', 'mimic', 'double-team', 'swift', 'bubble', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'sweet-scent', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'secret-power', 'air-cutter', 'silver-wind', 'signal-beam', 'aerial-ace', 'water-sport', 'water-pulse', 'roost', 'natural-gift', 'tailwind', 'u-turn', 'air-slash', 'bug-buzz', 'energy-ball', 'giga-impact', 'defog', 'captivate', 'bug-bite', 'ominous-wind', 'quiver-dance', 'round', 'scald', 'struggle-bug', 'confide', 'infestation'], 'name': 'masquerain', 'stats': {'hp': 70, 'attack': 60, 'defense': 62, 'special-attack': 100, 'special-defense': 82, 'speed': 80}, 'types': ['bug', 'flying'], 'weight': 36, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 75, 'color': 'blue', 'shape': 'bug-wings', 'habitat': 'waters-edge', 'generation': 'generation-iii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'bug'], 'names': {'ja-Hrkt': 'アメモース', 'roomaji': 'Amemoth', 'ko': '비나방', 'zh-Hant': '雨翅蛾', 'fr': 'Maskadra', 'de': 'Maskeregen', 'es': 'Masquerain', 'it': 'Masquerain', 'en': 'Masquerain', 'ja': 'アメモース', 'zh-Hans': '雨翅蛾'}, 'genera': {'ja-Hrkt': 'めだまポケモン', 'ko': '안구포켓몬', 'zh-Hant': '眼珠寶可夢', 'fr': 'Pokémon Boule Œil', 'de': 'Auge', 'es': 'Pokémon Globocular', 'it': 'Pokémon Occhi', 'en': 'Eyeball Pokémon', 'ja': 'めだまポケモン', 'zh-Hans': '眼珠宝可梦'}}
	public class SpecieMasquerain : PokemonSpecie
	{
#nullable enable
		private static SpecieMasquerain? _instance = null;
#nullable restore
        public static SpecieMasquerain Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMasquerain();
                }
                return _instance;
            }
        }

		public SpecieMasquerain() : base(
			"Masquerain",
			70, // HPs
			60, 62, // Attack & Defense
			100, 82, // Special Attack & Defense
			80			
		) {}
	}


	//Masquerain Pokemon Class
	public class Masquerain : Pokemon
	{

		public Masquerain(string nickname, int level) : base(
			284,
			SpecieMasquerain.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Flying.Instance			
		) {}

		public Masquerain() : base(
			284,
			SpecieMasquerain.Instance, // Pokemon Specie
			Bug.Instance, Flying.Instance			
		) {}
	}
}