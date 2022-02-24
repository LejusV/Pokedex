using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Elgyem Specie to store common natural stats of every {'abilities': ['telepathy', 'synchronize', 'analytic'], 'base_experience': 67, 'height': 5, 'id': 605, 'moves': ['headbutt', 'growl', 'disable', 'psybeam', 'thunderbolt', 'thunder-wave', 'toxic', 'confusion', 'psychic', 'teleport', 'double-team', 'recover', 'barrier', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'trick', 'role-play', 'magic-coat', 'recycle', 'skill-swap', 'imprison', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'cosmic-power', 'signal-beam', 'calm-mind', 'shock-wave', 'gravity', 'miracle-eye', 'embargo', 'heal-block', 'power-swap', 'guard-swap', 'dark-pulse', 'energy-ball', 'nasty-plot', 'zen-headbutt', 'trick-room', 'charge-beam', 'guard-split', 'power-split', 'wonder-room', 'psyshock', 'telekinesis', 'synchronoise', 'simple-beam', 'after-you', 'round', 'echoed-voice', 'ally-switch', 'confide'], 'name': 'elgyem', 'stats': {'hp': 55, 'attack': 55, 'defense': 55, 'special-attack': 85, 'special-defense': 55, 'speed': 30}, 'types': ['psychic'], 'weight': 90, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'リグレー', 'ko': '리그레', 'zh-Hant': '小灰怪', 'fr': 'Lewsor', 'de': 'Pygraulon', 'es': 'Elgyem', 'it': 'Elgyem', 'en': 'Elgyem', 'ja': 'リグレー', 'zh-Hans': '小灰怪'}, 'genera': {'ja-Hrkt': 'ブレインポケモン', 'ko': '브레인포켓몬', 'zh-Hant': '腦寶可夢', 'fr': 'Pokémon Cerveau', 'de': 'Grips', 'es': 'Pokémon Cerebro', 'it': 'Pokémon Cervello', 'en': 'Cerebral Pokémon', 'ja': 'ブレインポケモン', 'zh-Hans': '脑宝可梦'}}
	public class SpecieElgyem : PokemonSpecie
	{
#nullable enable
		private static SpecieElgyem? _instance = null;
#nullable restore
        public static SpecieElgyem Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieElgyem();
                }
                return _instance;
            }
        }

		public SpecieElgyem() : base(
			"Elgyem",
			55, // HPs
			55, 55, // Attack & Defense
			85, 55, // Special Attack & Defense
			30			
		) {}
	}


	//Elgyem Pokemon Class
	public class Elgyem : Pokemon
	{

		public Elgyem(string nickname, int level)
		: base(
				605,
				SpecieElgyem.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Elgyem() : base(
			605,
			SpecieElgyem.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}