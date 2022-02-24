using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Beheeyem Specie to store common natural stats of every {'abilities': ['telepathy', 'synchronize', 'analytic'], 'base_experience': 170, 'height': 10, 'id': 606, 'moves': ['headbutt', 'growl', 'psybeam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'double-team', 'recover', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'trick', 'role-play', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'snatch', 'secret-power', 'rock-tomb', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'miracle-eye', 'embargo', 'heal-block', 'dark-pulse', 'energy-ball', 'giga-impact', 'zen-headbutt', 'trick-room', 'charge-beam', 'guard-split', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'synchronoise', 'simple-beam', 'after-you', 'round', 'echoed-voice', 'ally-switch', 'confide', 'psychic-terrain'], 'name': 'beheeyem', 'stats': {'hp': 75, 'attack': 75, 'defense': 75, 'special-attack': 125, 'special-defense': 95, 'speed': 40}, 'types': ['psychic'], 'weight': 345, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'オーベム', 'ko': '벰크', 'zh-Hant': '大宇怪', 'fr': 'Neitram', 'de': 'Megalon', 'es': 'Beheeyem', 'it': 'Beheeyem', 'en': 'Beheeyem', 'ja': 'オーベム', 'zh-Hans': '大宇怪'}, 'genera': {'ja-Hrkt': 'ブレインポケモン', 'ko': '브레인포켓몬', 'zh-Hant': '腦寶可夢', 'fr': 'Pokémon Cerveau', 'de': 'Grips', 'es': 'Pokémon Cerebro', 'it': 'Pokémon Cervello', 'en': 'Cerebral Pokémon', 'ja': 'ブレインポケモン', 'zh-Hans': '脑宝可梦'}}
	public class SpecieBeheeyem : PokemonSpecie
	{
#nullable enable
		private static SpecieBeheeyem? _instance = null;
#nullable restore
        public static SpecieBeheeyem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeheeyem();
                }
                return _instance;
            }
        }

		public SpecieBeheeyem() : base(
			"Beheeyem",
			75, // HPs
			75, 75, // Attack & Defense
			125, 95, // Special Attack & Defense
			40			
		) {}
	}


	//Beheeyem Pokemon Class
	public class Beheeyem : Pokemon
	{

		public Beheeyem(string nickname, int level)
		: base(
				606,
				SpecieBeheeyem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Beheeyem() : base(
			606,
			SpecieBeheeyem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}