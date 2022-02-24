using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Doublade Specie to store common natural stats of every {'abilities': ['no-guard'], 'base_experience': 157, 'height': 8, 'id': 680, 'moves': ['swords-dance', 'cut', 'tackle', 'toxic', 'double-team', 'reflect', 'rest', 'rock-slide', 'slash', 'substitute', 'snore', 'spite', 'protect', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'brick-break', 'secret-power', 'metal-sound', 'aerial-ace', 'iron-defense', 'shock-wave', 'gyro-ball', 'power-trick', 'magnet-rise', 'night-slash', 'shadow-claw', 'shadow-sneak', 'flash-cannon', 'iron-head', 'autotomize', 'after-you', 'retaliate', 'sacred-sword', 'confide', 'brutal-swing'], 'name': 'doublade', 'stats': {'hp': 59, 'attack': 110, 'defense': 150, 'special-attack': 45, 'special-defense': 49, 'speed': 35}, 'types': ['steel', 'ghost'], 'weight': 45, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'brown', 'shape': 'heads', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ニダンギル', 'ko': '쌍검킬', 'zh-Hant': '雙劍鞘', 'fr': 'Dimoclès', 'de': 'Duokles', 'es': 'Doublade', 'it': 'Doublade', 'en': 'Doublade', 'ja': 'ニダンギル', 'zh-Hans': '双剑鞘'}, 'genera': {'ja-Hrkt': 'とうけんポケモン', 'ko': '도검포켓몬', 'zh-Hant': '刀劍寶可夢', 'fr': 'Pokémon Glaive', 'de': 'Klingenkraft', 'es': 'Pokémon Tizona', 'it': 'Pokémon Armabianca', 'en': 'Sword Pokémon', 'ja': 'とうけんポケモン', 'zh-Hans': '刀剑宝可梦'}}
	public class SpecieDoublade : PokemonSpecie
	{
#nullable enable
		private static SpecieDoublade? _instance = null;
#nullable restore
        public static SpecieDoublade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDoublade();
                }
                return _instance;
            }
        }

		public SpecieDoublade() : base(
			"Doublade",
			59, // HPs
			110, 150, // Attack & Defense
			45, 49, // Special Attack & Defense
			35			
		) {}
	}


	//Doublade Pokemon Class
	public class Doublade : Pokemon
	{

		public Doublade(string nickname, int level)
		: base(
				680,
				SpecieDoublade.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Doublade(int level)
		: base(
				680,
				SpecieDoublade.Instance, // Pokemon Specie
				"Doublade", level,
				Steel.Instance, Ghost.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Doublade() : base(
			680,
			SpecieDoublade.Instance, // Pokemon Specie
			Steel.Instance, Ghost.Instance			
		) {}
	}
}