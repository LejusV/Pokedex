using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Solosis Specie to store common natural stats of every {'abilities': ['overcoat', 'magic-guard', 'regenerator'], 'base_experience': 58, 'height': 3, 'id': 577, 'moves': ['thunder-wave', 'thunder', 'toxic', 'psychic', 'night-shade', 'double-team', 'recover', 'confuse-ray', 'light-screen', 'reflect', 'dream-eater', 'flash', 'psywave', 'acid-armor', 'explosion', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'charm', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'rain-dance', 'psych-up', 'shadow-ball', 'future-sight', 'facade', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'endeavor', 'skill-swap', 'imprison', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'signal-beam', 'iron-defense', 'calm-mind', 'shock-wave', 'gravity', 'gyro-ball', 'embargo', 'heal-block', 'energy-ball', 'zen-headbutt', 'flash-cannon', 'trick-room', 'wonder-room', 'psyshock', 'telekinesis', 'after-you', 'round', 'confide', 'infestation'], 'name': 'solosis', 'stats': {'hp': 45, 'attack': 30, 'defense': 40, 'special-attack': 105, 'special-defense': 50, 'speed': 20}, 'types': ['psychic'], 'weight': 10, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 200, 'color': 'green', 'shape': 'ball', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'ユニラン', 'ko': '유니란', 'zh-Hant': '單卵細胞球', 'fr': 'Nucléos', 'de': 'Monozyto', 'es': 'Solosis', 'it': 'Solosis', 'en': 'Solosis', 'ja': 'ユニラン', 'zh-Hans': '单卵细胞球'}, 'genera': {'ja-Hrkt': 'さいぼうポケモン', 'ko': '세포포켓몬', 'zh-Hant': '細胞寶可夢', 'fr': 'Pokémon Cellule', 'de': 'Zelle', 'es': 'Pokémon Célula', 'it': 'Pokémon Cellula', 'en': 'Cell Pokémon', 'ja': 'さいぼうポケモン', 'zh-Hans': '细胞宝可梦'}}
	public class SpecieSolosis : PokemonSpecie
	{
#nullable enable
		private static SpecieSolosis? _instance = null;
#nullable restore
        public static SpecieSolosis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSolosis();
                }
                return _instance;
            }
        }

		public SpecieSolosis() : base(
			"Solosis",
			45, // HPs
			30, 40, // Attack & Defense
			105, 50, // Special Attack & Defense
			20			
		) {}
	}


	//Solosis Pokemon Class
	public class Solosis : Pokemon
	{

		public Solosis(string nickname, int level) : base(
			577,
			SpecieSolosis.Instance, // Pokemon Specie
			nickname, level,
			Psychic.Instance			
		) {}

		public Solosis() : base(
			577,
			SpecieSolosis.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}