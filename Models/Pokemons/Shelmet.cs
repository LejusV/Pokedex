using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shelmet Specie to store common natural stats of every {'abilities': ['hydration', 'shell-armor', 'overcoat'], 'base_experience': 61, 'height': 4, 'id': 616, 'moves': ['body-slam', 'double-edge', 'acid', 'absorb', 'mega-drain', 'toxic', 'double-team', 'recover', 'bide', 'leech-life', 'acid-armor', 'rest', 'substitute', 'mind-reader', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'spikes', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'baton-pass', 'encore', 'pursuit', 'hidden-power', 'rain-dance', 'facade', 'yawn', 'secret-power', 'signal-beam', 'feint', 'gastro-acid', 'guard-swap', 'toxic-spikes', 'bug-buzz', 'energy-ball', 'bug-bite', 'guard-split', 'venoshock', 'round', 'final-gambit', 'struggle-bug', 'confide', 'infestation'], 'name': 'shelmet', 'stats': {'hp': 50, 'attack': 40, 'defense': 85, 'special-attack': 40, 'special-defense': 65, 'speed': 25}, 'types': ['bug'], 'weight': 77, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 200, 'color': 'red', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'チョボマキ', 'ko': '쪼마리', 'zh-Hant': '小嘴蝸', 'fr': 'Escargaume', 'de': 'Schnuthelm', 'es': 'Shelmet', 'it': 'Shelmet', 'en': 'Shelmet', 'ja': 'チョボマキ', 'zh-Hans': '小嘴蜗'}, 'genera': {'ja-Hrkt': 'マイマイポケモン', 'ko': '달팽이포켓몬', 'zh-Hant': '蝸牛寶可夢', 'fr': 'Pokémon Escargot', 'de': 'Schnecke', 'es': 'Pokémon Caracol', 'it': 'Pokémon Lumachina', 'en': 'Snail Pokémon', 'ja': 'マイマイポケモン', 'zh-Hans': '蜗牛宝可梦'}}
	public class SpecieShelmet : PokemonSpecie
	{
#nullable enable
		private static SpecieShelmet? _instance = null;
#nullable restore
        public static SpecieShelmet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShelmet();
                }
                return _instance;
            }
        }

		public SpecieShelmet() : base(
			"Shelmet",
			50, // HPs
			40, 85, // Attack & Defense
			40, 65, // Special Attack & Defense
			25			
		) {}
	}


	//Shelmet Pokemon Class
	public class Shelmet : Pokemon
	{

		public Shelmet(string nickname, int level)
		: base(
				616,
				SpecieShelmet.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shelmet() : base(
			616,
			SpecieShelmet.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}