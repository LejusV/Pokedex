using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Jellicent Specie to store common natural stats of every {'abilities': ['water-absorb', 'cursed-body', 'damp'], 'base_experience': 168, 'height': 22, 'id': 593, 'moves': ['bind', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'absorb', 'toxic', 'psychic', 'night-shade', 'double-team', 'recover', 'waterfall', 'dream-eater', 'bubble', 'flash', 'rest', 'substitute', 'snore', 'spite', 'protect', 'sludge-bomb', 'icy-wind', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'hail', 'will-o-wisp', 'facade', 'taunt', 'trick', 'magic-coat', 'secret-power', 'dive', 'water-spout', 'water-sport', 'shock-wave', 'water-pulse', 'brine', 'wring-out', 'dark-pulse', 'energy-ball', 'giga-impact', 'trick-room', 'ominous-wind', 'sludge-wave', 'round', 'scald', 'hex', 'confide', 'dazzling-gleam'], 'name': 'jellicent', 'stats': {'hp': 100, 'attack': 60, 'defense': 70, 'special-attack': 85, 'special-defense': 105, 'speed': 60}, 'types': ['water', 'ghost'], 'weight': 1350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'white', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ブルンゲル', 'ko': '탱탱겔', 'zh-Hant': '胖嘟嘟', 'fr': 'Moyade', 'de': 'Apoquallyp', 'es': 'Jellicent', 'it': 'Jellicent', 'en': 'Jellicent', 'ja': 'ブルンゲル', 'zh-Hans': '胖嘟嘟'}, 'genera': {'ja-Hrkt': 'ふゆうポケモン', 'ko': '부유포켓몬', 'zh-Hant': '漂浮寶可夢', 'fr': 'Pokémon Flottaison', 'de': 'Gleit', 'es': 'Pokémon Ingrávido', 'it': 'Pokémon Fluttuante', 'en': 'Floating Pokémon', 'ja': 'ふゆうポケモン', 'zh-Hans': '漂浮宝可梦'}}
	public class SpecieJellicent : PokemonSpecie
	{
#nullable enable
		private static SpecieJellicent? _instance = null;
#nullable restore
        public static SpecieJellicent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieJellicent();
                }
                return _instance;
            }
        }

		public SpecieJellicent() : base(
			"Jellicent",
			100, // HPs
			60, 70, // Attack & Defense
			85, 105, // Special Attack & Defense
			60			
		) {}
	}


	//Jellicent Pokemon Class
	public class Jellicent : Pokemon
	{

		public Jellicent(string nickname, int level) : base(
			593,
			SpecieJellicent.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ghost.Instance			
		) {}

		public Jellicent() : base(
			593,
			SpecieJellicent.Instance, // Pokemon Specie
			Water.Instance, Ghost.Instance			
		) {}
	}
}