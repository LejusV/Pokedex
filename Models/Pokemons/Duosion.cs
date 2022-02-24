using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Duosion Specie to store common natural stats of every {'abilities': ['overcoat', 'magic-guard', 'regenerator'], 'base_experience': 130, 'height': 6, 'id': 578, 'moves': ['thunder-wave', 'thunder', 'toxic', 'psychic', 'double-team', 'recover', 'light-screen', 'reflect', 'dream-eater', 'flash', 'psywave', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'facade', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'endeavor', 'skill-swap', 'snatch', 'secret-power', 'rock-tomb', 'signal-beam', 'iron-defense', 'calm-mind', 'shock-wave', 'gravity', 'gyro-ball', 'embargo', 'heal-block', 'energy-ball', 'zen-headbutt', 'flash-cannon', 'trick-room', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'confide', 'infestation'], 'name': 'duosion', 'stats': {'hp': 65, 'attack': 40, 'defense': 50, 'special-attack': 125, 'special-defense': 60, 'speed': 30}, 'types': ['psychic'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 100, 'color': 'green', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ダブラン', 'ko': '듀란', 'zh-Hant': '雙卵細胞球', 'fr': 'Méios', 'de': 'Mitodos', 'es': 'Duosion', 'it': 'Duosion', 'en': 'Duosion', 'ja': 'ダブラン', 'zh-Hans': '双卵细胞球'}, 'genera': {'ja-Hrkt': 'ぶんかつポケモン', 'ko': '분할포켓몬', 'zh-Hant': '分割寶可夢', 'fr': 'Pokémon Divisé', 'de': 'Zellteilung', 'es': 'Pokémon Mitosis', 'it': 'Pokémon Scissione', 'en': 'Mitosis Pokémon', 'ja': 'ぶんかつポケモン', 'zh-Hans': '分割宝可梦'}}
	public class SpecieDuosion : PokemonSpecie
	{
#nullable enable
		private static SpecieDuosion? _instance = null;
#nullable restore
        public static SpecieDuosion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDuosion();
                }
                return _instance;
            }
        }

		public SpecieDuosion() : base(
			"Duosion",
			65, // HPs
			40, 50, // Attack & Defense
			125, 60, // Special Attack & Defense
			30			
		) {}
	}


	//Duosion Pokemon Class
	public class Duosion : Pokemon
	{

		public Duosion(string nickname, int level)
		: base(
				578,
				SpecieDuosion.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Duosion(int level)
		: base(
				578,
				SpecieDuosion.Instance, // Pokemon Specie
				"Duosion", level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Duosion() : base(
			578,
			SpecieDuosion.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}