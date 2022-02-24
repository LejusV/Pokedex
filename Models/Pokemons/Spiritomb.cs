using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Spiritomb Specie to store common natural stats of every {'abilities': ['pressure', 'infiltrator'], 'base_experience': 170, 'height': 10, 'id': 442, 'moves': ['disable', 'hyper-beam', 'toxic', 'psychic', 'hypnosis', 'double-team', 'smokescreen', 'confuse-ray', 'dream-eater', 'flash', 'rest', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'destiny-bond', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'torment', 'will-o-wisp', 'memento', 'facade', 'taunt', 'trick', 'imprison', 'grudge', 'snatch', 'secret-power', 'rock-tomb', 'silver-wind', 'calm-mind', 'shock-wave', 'water-pulse', 'natural-gift', 'embargo', 'sucker-punch', 'dark-pulse', 'giga-impact', 'nasty-plot', 'shadow-sneak', 'captivate', 'ominous-wind', 'wonder-room', 'telekinesis', 'foul-play', 'round', 'quash', 'retaliate', 'snarl', 'confide', 'infestation'], 'name': 'spiritomb', 'stats': {'hp': 50, 'attack': 92, 'defense': 108, 'special-attack': 92, 'special-defense': 108, 'speed': 35}, 'types': ['ghost', 'dark'], 'weight': 1080, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 30, 'gender_rate': 4, 'capture_rate': 100, 'color': 'purple', 'shape': 'blob', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ミカルゲ', 'roomaji': 'Mikaruge', 'ko': '화강돌', 'zh-Hant': '花岩怪', 'fr': 'Spiritomb', 'de': 'Kryppuk', 'es': 'Spiritomb', 'it': 'Spiritomb', 'en': 'Spiritomb', 'ja': 'ミカルゲ', 'zh-Hans': '花岩怪'}, 'genera': {'ja-Hrkt': 'ふういんポケモン', 'ko': '봉인포켓몬', 'zh-Hant': '封印寶可夢', 'fr': 'Pokémon Interdit', 'de': 'Verboten', 'es': 'Pokémon Prohibido', 'it': 'Pokémon Proibito', 'en': 'Forbidden Pokémon', 'ja': 'ふういんポケモン', 'zh-Hans': '封印宝可梦'}}
	public class SpecieSpiritomb : PokemonSpecie
	{
#nullable enable
		private static SpecieSpiritomb? _instance = null;
#nullable restore
        public static SpecieSpiritomb Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSpiritomb();
                }
                return _instance;
            }
        }

		public SpecieSpiritomb() : base(
			"Spiritomb",
			50, // HPs
			92, 108, // Attack & Defense
			92, 108, // Special Attack & Defense
			35			
		) {}
	}


	//Spiritomb Pokemon Class
	public class Spiritomb : Pokemon
	{

		public Spiritomb(string nickname, int level)
		: base(
				442,
				SpecieSpiritomb.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spiritomb(int level)
		: base(
				442,
				SpecieSpiritomb.Instance, // Pokemon Specie
				"Spiritomb", level,
				Ghost.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Spiritomb() : base(
			442,
			SpecieSpiritomb.Instance, // Pokemon Specie
			Ghost.Instance, Dark.Instance			
		) {}
	}
}