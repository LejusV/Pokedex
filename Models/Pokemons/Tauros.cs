using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tauros Specie to store common natural stats of every {'abilities': ['intimidate', 'anger-point', 'sheer-force'], 'base_experience': 172, 'height': 14, 'id': 128, 'moves': ['stomp', 'headbutt', 'horn-attack', 'horn-drill', 'tackle', 'body-slam', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'leer', 'flamethrower', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'solar-beam', 'thunderbolt', 'thunder', 'earthquake', 'fissure', 'toxic', 'rage', 'mimic', 'double-team', 'bide', 'fire-blast', 'skull-bash', 'rest', 'rock-slide', 'substitute', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'zap-cannon', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'whirlpool', 'uproar', 'facade', 'helping-hand', 'role-play', 'endeavor', 'secret-power', 'rock-tomb', 'shock-wave', 'water-pulse', 'natural-gift', 'payback', 'giga-impact', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'captivate', 'round', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'confide', 'smart-strike'], 'name': 'tauros', 'stats': {'hp': 75, 'attack': 100, 'defense': 95, 'special-attack': 40, 'special-defense': 70, 'speed': 110}, 'types': ['normal'], 'weight': 884, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 0, 'capture_rate': 45, 'color': 'brown', 'shape': 'quadruped', 'habitat': 'grassland', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ケンタロス', 'roomaji': 'Kentauros', 'ko': '켄타로스', 'zh-Hant': '肯泰羅', 'fr': 'Tauros', 'de': 'Tauros', 'es': 'Tauros', 'it': 'Tauros', 'en': 'Tauros', 'ja': 'ケンタロス', 'zh-Hans': '肯泰罗'}, 'genera': {'ja-Hrkt': 'あばれうしポケモン', 'ko': '성난소포켓몬', 'zh-Hant': '暴牛寶可夢', 'fr': 'Pokémon Buffle', 'de': 'Wildbulle', 'es': 'Pokémon Toro Bravo', 'it': 'Pokémon Torobrado', 'en': 'Wild Bull Pokémon', 'ja': 'あばれうしポケモン', 'zh-Hans': '暴牛宝可梦'}}
	public class SpecieTauros : PokemonSpecie
	{
#nullable enable
		private static SpecieTauros? _instance = null;
#nullable restore
        public static SpecieTauros Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTauros();
                }
                return _instance;
            }
        }

		public SpecieTauros() : base(
			"Tauros",
			75, // HPs
			100, 95, // Attack & Defense
			40, 70, // Special Attack & Defense
			110			
		) {}
	}


	//Tauros Pokemon Class
	public class Tauros : Pokemon
	{

		public Tauros(string nickname, int level)
		: base(
				128,
				SpecieTauros.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Tauros() : base(
			128,
			SpecieTauros.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}