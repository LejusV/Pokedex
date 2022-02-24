using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Honedge Specie to store common natural stats of every {'abilities': ['no-guard'], 'base_experience': 65, 'height': 8, 'id': 679, 'moves': ['swords-dance', 'cut', 'tackle', 'toxic', 'double-team', 'reflect', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'spite', 'protect', 'destiny-bond', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'metal-sound', 'aerial-ace', 'iron-defense', 'shock-wave', 'gyro-ball', 'power-trick', 'magnet-rise', 'night-slash', 'shadow-claw', 'shadow-sneak', 'flash-cannon', 'iron-head', 'wide-guard', 'autotomize', 'after-you', 'retaliate', 'sacred-sword', 'confide', 'brutal-swing'], 'name': 'honedge', 'stats': {'hp': 45, 'attack': 80, 'defense': 100, 'special-attack': 35, 'special-defense': 37, 'speed': 28}, 'types': ['steel', 'ghost'], 'weight': 20, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 180, 'color': 'brown', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ヒトツキ', 'ko': '단칼빙', 'zh-Hant': '獨劍鞘', 'fr': 'Monorpale', 'de': 'Gramokles', 'es': 'Honedge', 'it': 'Honedge', 'en': 'Honedge', 'ja': 'ヒトツキ', 'zh-Hans': '独剑鞘'}, 'genera': {'ja-Hrkt': 'とうけんポケモン', 'ko': '도검포켓몬', 'zh-Hant': '刀劍寶可夢', 'fr': 'Pokémon Glaive', 'de': 'Klingenkraft', 'es': 'Pokémon Tizona', 'it': 'Pokémon Armabianca', 'en': 'Sword Pokémon', 'ja': 'とうけんポケモン', 'zh-Hans': '刀剑宝可梦'}}
	public class SpecieHonedge : PokemonSpecie
	{
#nullable enable
		private static SpecieHonedge? _instance = null;
#nullable restore
        public static SpecieHonedge Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHonedge();
                }
                return _instance;
            }
        }

		public SpecieHonedge() : base(
			"Honedge",
			45, // HPs
			80, 100, // Attack & Defense
			35, 37, // Special Attack & Defense
			28			
		) {}
	}


	//Honedge Pokemon Class
	public class Honedge : Pokemon
	{

		public Honedge(string nickname, int level)
		: base(
				679,
				SpecieHonedge.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Honedge() : base(
			679,
			SpecieHonedge.Instance, // Pokemon Specie
			Steel.Instance, Ghost.Instance			
		) {}
	}
}