using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gorebyss Specie to store common natural stats of every {'abilities': ['swift-swim', 'hydration'], 'base_experience': 170, 'height': 18, 'id': 368, 'moves': ['bind', 'body-slam', 'double-edge', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'toxic', 'confusion', 'psychic', 'agility', 'mimic', 'double-team', 'waterfall', 'swift', 'amnesia', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'signal-beam', 'bounce', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'aqua-ring', 'aqua-tail', 'giga-impact', 'captivate', 'coil', 'round', 'scald', 'draining-kiss', 'confide', 'infestation'], 'name': 'gorebyss', 'stats': {'hp': 55, 'attack': 84, 'defense': 105, 'special-attack': 114, 'special-defense': 75, 'speed': 52}, 'types': ['water'], 'weight': 226, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'pink', 'shape': 'squiggle', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow-then-very-fast', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'サクラビス', 'roomaji': 'Sakurabyss', 'ko': '분홍장이', 'zh-Hant': '櫻花魚', 'fr': 'Rosabyss', 'de': 'Saganabyss', 'es': 'Gorebyss', 'it': 'Gorebyss', 'en': 'Gorebyss', 'ja': 'サクラビス', 'zh-Hans': '樱花鱼'}, 'genera': {'ja-Hrkt': 'なんかいポケモン', 'ko': '남해포켓몬', 'zh-Hant': '南海寶可夢', 'fr': 'Pokémon Mer du Sud', 'de': 'Südsee', 'es': 'Pokémon Mar del Sur', 'it': 'Pokémon Sudmarino', 'en': 'South Sea Pokémon', 'ja': 'なんかいポケモン', 'zh-Hans': '南海宝可梦'}}
	public class SpecieGorebyss : PokemonSpecie
	{
#nullable enable
		private static SpecieGorebyss? _instance = null;
#nullable restore
        public static SpecieGorebyss Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGorebyss();
                }
                return _instance;
            }
        }

		public SpecieGorebyss() : base(
			"Gorebyss",
			55, // HPs
			84, 105, // Attack & Defense
			114, 75, // Special Attack & Defense
			52			
		) {}
	}


	//Gorebyss Pokemon Class
	public class Gorebyss : Pokemon
	{

		public Gorebyss(string nickname, int level) : base(
			368,
			SpecieGorebyss.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Gorebyss() : base(
			368,
			SpecieGorebyss.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}