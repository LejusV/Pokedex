using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Rufflet Specie to store common natural stats of every {'abilities': ['keen-eye', 'sheer-force', 'hustle'], 'base_experience': 70, 'height': 5, 'id': 627, 'moves': ['cut', 'wing-attack', 'whirlwind', 'fly', 'fury-attack', 'thrash', 'leer', 'peck', 'strength', 'toxic', 'double-team', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'protect', 'scary-face', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'heat-wave', 'facade', 'superpower', 'secret-power', 'crush-claw', 'rock-tomb', 'aerial-ace', 'bulk-up', 'roost', 'pluck', 'tailwind', 'u-turn', 'air-slash', 'brave-bird', 'shadow-claw', 'defog', 'hone-claws', 'round', 'sky-drop', 'retaliate', 'work-up', 'confide'], 'name': 'rufflet', 'stats': {'hp': 70, 'attack': 83, 'defense': 50, 'special-attack': 37, 'special-defense': 50, 'speed': 60}, 'types': ['normal', 'flying'], 'weight': 105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 190, 'color': 'white', 'shape': 'wings', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ワシボン', 'ko': '수리둥보', 'zh-Hant': '毛頭小鷹', 'fr': 'Furaiglon', 'de': 'Geronimatz', 'es': 'Rufflet', 'it': 'Rufflet', 'en': 'Rufflet', 'ja': 'ワシボン', 'zh-Hans': '毛头小鹰'}, 'genera': {'ja-Hrkt': 'ヒナわしポケモン', 'ko': '새끼독수리포켓몬', 'zh-Hant': '雛鷹寶可夢', 'fr': 'Pokémon Aiglon', 'de': 'Adlerküken', 'es': 'Pokémon Aguilucho', 'it': 'Pokémon Aquilotto', 'en': 'Eaglet Pokémon', 'ja': 'ヒナわしポケモン', 'zh-Hans': '雏鹰宝可梦'}}
	public class SpecieRufflet : PokemonSpecie
	{
#nullable enable
		private static SpecieRufflet? _instance = null;
#nullable restore
        public static SpecieRufflet Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRufflet();
                }
                return _instance;
            }
        }

		public SpecieRufflet() : base(
			"Rufflet",
			70, // HPs
			83, 50, // Attack & Defense
			37, 50, // Special Attack & Defense
			60			
		) {}
	}


	//Rufflet Pokemon Class
	public class Rufflet : Pokemon
	{

		public Rufflet(string nickname, int level) : base(
			627,
			SpecieRufflet.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance, Flying.Instance			
		) {}

		public Rufflet() : base(
			627,
			SpecieRufflet.Instance, // Pokemon Specie
			Normal.Instance, Flying.Instance			
		) {}
	}
}