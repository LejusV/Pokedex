using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cinccino Specie to store common natural stats of every {'abilities': ['cute-charm', 'technician', 'skill-link'], 'base_experience': 165, 'height': 5, 'id': 573, 'moves': ['sing', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'double-team', 'light-screen', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'uproar', 'facade', 'helping-hand', 'knock-off', 'secret-power', 'hyper-voice', 'tickle', 'bullet-seed', 'covet', 'calm-mind', 'rock-blast', 'shock-wave', 'u-turn', 'fling', 'last-resort', 'aqua-tail', 'seed-bomb', 'focus-blast', 'giga-impact', 'gunk-shot', 'grass-knot', 'after-you', 'round', 'echoed-voice', 'retaliate', 'work-up', 'tail-slap', 'confide', 'dazzling-gleam'], 'name': 'cinccino', 'stats': {'hp': 75, 'attack': 95, 'defense': 60, 'special-attack': 65, 'special-defense': 60, 'speed': 115}, 'types': ['normal'], 'weight': 75, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 6, 'capture_rate': 60, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'チラチーノ', 'ko': '치라치노', 'zh-Hant': '奇諾栗鼠', 'fr': 'Pashmilla', 'de': 'Chillabell', 'es': 'Cinccino', 'it': 'Cinccino', 'en': 'Cinccino', 'ja': 'チラチーノ', 'zh-Hans': '奇诺栗鼠'}, 'genera': {'ja-Hrkt': 'スカーフポケモン', 'ko': '스카프포켓몬', 'zh-Hant': '圍巾寶可夢', 'fr': 'Pokémon Écharpe', 'de': 'Schal', 'es': 'Pokémon Estola', 'it': 'Pokémon Sciarpa', 'en': 'Scarf Pokémon', 'ja': 'スカーフポケモン', 'zh-Hans': '围巾宝可梦'}}
	public class SpecieCinccino : PokemonSpecie
	{
#nullable enable
		private static SpecieCinccino? _instance = null;
#nullable restore
        public static SpecieCinccino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCinccino();
                }
                return _instance;
            }
        }

		public SpecieCinccino() : base(
			"Cinccino",
			75, // HPs
			95, 60, // Attack & Defense
			65, 60, // Special Attack & Defense
			115			
		) {}
	}


	//Cinccino Pokemon Class
	public class Cinccino : Pokemon
	{

		public Cinccino(string nickname, int level)
		: base(
				573,
				SpecieCinccino.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cinccino(int level)
		: base(
				573,
				SpecieCinccino.Instance, // Pokemon Specie
				"Cinccino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cinccino() : base(
			573,
			SpecieCinccino.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}