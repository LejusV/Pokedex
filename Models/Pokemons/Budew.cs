using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Budew Specie to store common natural stats of every {'abilities': ['natural-cure', 'poison-point', 'leaf-guard'], 'base_experience': 56, 'height': 2, 'id': 406, 'moves': ['swords-dance', 'cut', 'pin-missile', 'absorb', 'mega-drain', 'growth', 'razor-leaf', 'solar-beam', 'stun-spore', 'sleep-powder', 'toxic', 'double-team', 'swift', 'flash', 'rest', 'substitute', 'mind-reader', 'snore', 'cotton-spore', 'protect', 'sludge-bomb', 'mud-slap', 'spikes', 'giga-drain', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'nature-power', 'secret-power', 'grass-whistle', 'extrasensory', 'bullet-seed', 'covet', 'water-sport', 'natural-gift', 'worry-seed', 'seed-bomb', 'energy-ball', 'leaf-storm', 'captivate', 'grass-knot', 'venoshock', 'round', 'confide', 'dazzling-gleam'], 'name': 'budew', 'stats': {'hp': 40, 'attack': 30, 'defense': 35, 'special-attack': 50, 'special-defense': 70, 'speed': 55}, 'types': ['grass', 'poison'], 'weight': 12, 'is_baby': True, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'green', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'スボミー', 'roomaji': 'Subomie', 'ko': '꼬몽울', 'zh-Hant': '含羞苞', 'fr': 'Rozbouton', 'de': 'Knospi', 'es': 'Budew', 'it': 'Budew', 'en': 'Budew', 'ja': 'スボミー', 'zh-Hans': '含羞苞'}, 'genera': {'ja-Hrkt': 'つぼみポケモン', 'ko': '꽃봉오리포켓몬', 'zh-Hant': '花苞寶可夢', 'fr': 'Pokémon Bourgeon', 'de': 'Knospe', 'es': 'Pokémon Brote', 'it': 'Pokémon Germoglio', 'en': 'Bud Pokémon', 'ja': 'つぼみポケモン', 'zh-Hans': '花苞宝可梦'}}
	public class SpecieBudew : PokemonSpecie
	{
#nullable enable
		private static SpecieBudew? _instance = null;
#nullable restore
        public static SpecieBudew Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBudew();
                }
                return _instance;
            }
        }

		public SpecieBudew() : base(
			"Budew",
			40, // HPs
			30, 35, // Attack & Defense
			50, 70, // Special Attack & Defense
			55			
		) {}
	}


	//Budew Pokemon Class
	public class Budew : Pokemon
	{

		public Budew(string nickname, int level) : base(
			406,
			SpecieBudew.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Poison.Instance			
		) {}

		public Budew() : base(
			406,
			SpecieBudew.Instance, // Pokemon Specie
			Grass.Instance, Poison.Instance			
		) {}
	}
}