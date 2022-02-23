using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Staryu Specie to store common natural stats of every {'abilities': ['illuminate', 'natural-cure', 'analytic'], 'base_experience': 68, 'height': 8, 'id': 120, 'moves': ['tackle', 'take-down', 'double-edge', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'rage', 'teleport', 'mimic', 'double-team', 'recover', 'harden', 'minimize', 'confuse-ray', 'barrier', 'light-screen', 'reflect', 'bide', 'waterfall', 'swift', 'skull-bash', 'flash', 'psywave', 'rest', 'tri-attack', 'substitute', 'snore', 'curse', 'protect', 'zap-cannon', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pain-split', 'rapid-spin', 'hidden-power', 'twister', 'rain-dance', 'psych-up', 'whirlpool', 'hail', 'facade', 'magic-coat', 'recycle', 'secret-power', 'dive', 'camouflage', 'cosmic-power', 'signal-beam', 'water-pulse', 'gravity', 'gyro-ball', 'brine', 'natural-gift', 'power-gem', 'flash-cannon', 'round', 'scald', 'reflect-type', 'confide', 'dazzling-gleam'], 'name': 'staryu', 'stats': {'hp': 30, 'attack': 45, 'defense': 55, 'special-attack': 70, 'special-defense': 55, 'speed': 85}, 'types': ['water'], 'weight': 345, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': -1, 'capture_rate': 225, 'color': 'brown', 'shape': 'blob', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'ヒトデマン', 'roomaji': 'Hitodeman', 'ko': '별가사리', 'zh-Hant': '海星星', 'fr': 'Stari', 'de': 'Sterndu', 'es': 'Staryu', 'it': 'Staryu', 'en': 'Staryu', 'ja': 'ヒトデマン', 'zh-Hans': '海星星'}, 'genera': {'ja-Hrkt': 'ほしがたポケモン', 'ko': '별포켓몬', 'zh-Hant': '星形寶可夢', 'fr': 'Pokémon Étoile', 'de': 'Sternform', 'es': 'Pokémon Estrellada', 'it': 'Pokémon Stella', 'en': 'Star Shape Pokémon', 'ja': 'ほしがたポケモン', 'zh-Hans': '星形宝可梦'}}
	public class SpecieStaryu : PokemonSpecie
	{
#nullable enable
		private static SpecieStaryu? _instance = null;
#nullable restore
        public static SpecieStaryu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieStaryu();
                }
                return _instance;
            }
        }

		public SpecieStaryu() : base(
			"Staryu",
			30, // HPs
			45, 55, // Attack & Defense
			70, 55, // Special Attack & Defense
			85			
		) {}
	}


	//Staryu Pokemon Class
	public class Staryu : Pokemon
	{

		public Staryu(string nickname, int level) : base(
			120,
			SpecieStaryu.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Staryu() : base(
			120,
			SpecieStaryu.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}