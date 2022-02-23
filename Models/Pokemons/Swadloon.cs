using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Swadloon Specie to store common natural stats of every {'abilities': ['leaf-guard', 'chlorophyll', 'overcoat'], 'base_experience': 133, 'height': 5, 'id': 541, 'moves': ['cut', 'tackle', 'razor-leaf', 'solar-beam', 'string-shot', 'toxic', 'double-team', 'light-screen', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'facade', 'nature-power', 'magic-coat', 'secret-power', 'grass-whistle', 'signal-beam', 'iron-defense', 'calm-mind', 'payback', 'worry-seed', 'seed-bomb', 'energy-ball', 'grass-knot', 'bug-bite', 'round', 'struggle-bug', 'electroweb', 'confide'], 'name': 'swadloon', 'stats': {'hp': 55, 'attack': 63, 'defense': 90, 'special-attack': 50, 'special-defense': 80, 'speed': 42}, 'types': ['bug', 'grass'], 'weight': 73, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'arms', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'クルマユ', 'ko': '두르쿤', 'zh-Hant': '寶包繭', 'fr': 'Couverdure', 'de': 'Folikon', 'es': 'Swadloon', 'it': 'Swadloon', 'en': 'Swadloon', 'ja': 'クルマユ', 'zh-Hans': '宝包茧'}, 'genera': {'ja-Hrkt': 'はごもりポケモン', 'ko': '잎숨기포켓몬', 'zh-Hant': '足不出葉寶可夢', 'fr': 'Pokémon Capefeuille', 'de': 'Wickelblatt', 'es': 'Pokémon Arropado', 'it': 'Pokémon Coprifoglia', 'en': 'Leaf-Wrapped Pokémon', 'ja': 'はごもりポケモン', 'zh-Hans': '足不出叶宝可梦'}}
	public class SpecieSwadloon : PokemonSpecie
	{
#nullable enable
		private static SpecieSwadloon? _instance = null;
#nullable restore
        public static SpecieSwadloon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSwadloon();
                }
                return _instance;
            }
        }

		public SpecieSwadloon() : base(
			"Swadloon",
			55, // HPs
			63, 90, // Attack & Defense
			50, 80, // Special Attack & Defense
			42			
		) {}
	}


	//Swadloon Pokemon Class
	public class Swadloon : Pokemon
	{

		public Swadloon(string nickname, int level) : base(
			541,
			SpecieSwadloon.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Grass.Instance			
		) {}

		public Swadloon() : base(
			541,
			SpecieSwadloon.Instance, // Pokemon Specie
			Bug.Instance, Grass.Instance			
		) {}
	}
}