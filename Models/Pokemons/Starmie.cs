using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Starmie Specie to store common natural stats of every {'abilities': ['illuminate', 'natural-cure', 'analytic'], 'base_experience': 182, 'height': 11, 'id': 121, 'moves': ['tackle', 'take-down', 'double-edge', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'recover', 'harden', 'confuse-ray', 'light-screen', 'reflect', 'bide', 'waterfall', 'swift', 'skull-bash', 'dream-eater', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'nightmare', 'snore', 'curse', 'protect', 'zap-cannon', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'rapid-spin', 'hidden-power', 'twister', 'rain-dance', 'psych-up', 'whirlpool', 'hail', 'facade', 'trick', 'magic-coat', 'recycle', 'skill-swap', 'secret-power', 'dive', 'signal-beam', 'water-pulse', 'gravity', 'gyro-ball', 'brine', 'natural-gift', 'giga-impact', 'avalanche', 'flash-cannon', 'trick-room', 'grass-knot', 'wonder-room', 'psyshock', 'telekinesis', 'round', 'scald', 'confide', 'dazzling-gleam', 'spotlight'], 'name': 'starmie', 'stats': {'hp': 60, 'attack': 75, 'defense': 85, 'special-attack': 100, 'special-defense': 85, 'speed': 115}, 'types': ['water', 'psychic'], 'weight': 800, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 60, 'color': 'purple', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'スターミー', 'roomaji': 'Starmie', 'ko': '아쿠스타', 'zh-Hant': '寶石海星', 'fr': 'Staross', 'de': 'Starmie', 'es': 'Starmie', 'it': 'Starmie', 'en': 'Starmie', 'ja': 'スターミー', 'zh-Hans': '宝石海星'}, 'genera': {'ja-Hrkt': 'なぞのポケモン', 'ko': '수수께끼포켓몬', 'zh-Hant': '謎寶可夢', 'fr': 'Pokémon Mystérieux', 'de': 'Mysteriös', 'es': 'Pokémon Misterioso', 'it': 'Pokémon Misterioso', 'en': 'Mysterious Pokémon', 'ja': 'なぞのポケモン', 'zh-Hans': '谜宝可梦'}}
	public class SpecieStarmie : PokemonSpecie
	{
#nullable enable
		private static SpecieStarmie? _instance = null;
#nullable restore
        public static SpecieStarmie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStarmie();
                }
                return _instance;
            }
        }

		public SpecieStarmie() : base(
			"Starmie",
			60, // HPs
			75, 85, // Attack & Defense
			100, 85, // Special Attack & Defense
			115			
		) {}
	}


	//Starmie Pokemon Class
	public class Starmie : Pokemon
	{

		public Starmie(string nickname, int level) : base(
			121,
			SpecieStarmie.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Psychic.Instance			
		) {}

		public Starmie() : base(
			121,
			SpecieStarmie.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
	}
}