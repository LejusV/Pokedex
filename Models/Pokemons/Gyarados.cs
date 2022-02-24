using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Gyarados Specie to store common natural stats of every {'abilities': ['intimidate', 'moxie'], 'base_experience': 189, 'height': 65, 'id': 130, 'moves': ['headbutt', 'tackle', 'body-slam', 'take-down', 'thrash', 'double-edge', 'leer', 'bite', 'roar', 'flamethrower', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'strength', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'rage', 'mimic', 'double-team', 'reflect', 'bide', 'fire-blast', 'waterfall', 'skull-bash', 'rest', 'substitute', 'snore', 'curse', 'spite', 'protect', 'scary-face', 'zap-cannon', 'icy-wind', 'outrage', 'sandstorm', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dragon-breath', 'iron-tail', 'hidden-power', 'twister', 'rain-dance', 'crunch', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'torment', 'facade', 'taunt', 'secret-power', 'dive', 'bounce', 'dragon-dance', 'water-pulse', 'brine', 'natural-gift', 'payback', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'giga-impact', 'avalanche', 'ice-fang', 'iron-head', 'stone-edge', 'captivate', 'round', 'scald', 'incinerate', 'bulldoze', 'dragon-tail', 'hurricane', 'confide', 'brutal-swing'], 'name': 'gyarados', 'stats': {'hp': 95, 'attack': 125, 'defense': 79, 'special-attack': 60, 'special-defense': 100, 'speed': 81}, 'types': ['water', 'flying'], 'weight': 2350, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 5, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'squiggle', 'habitat': 'waters-edge', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water2', 'dragon'], 'names': {'ja-Hrkt': 'ギャラドス', 'roomaji': 'Gyarados', 'ko': '갸라도스', 'zh-Hant': '暴鯉龍', 'fr': 'Léviator', 'de': 'Garados', 'es': 'Gyarados', 'it': 'Gyarados', 'en': 'Gyarados', 'ja': 'ギャラドス', 'zh-Hans': '暴鲤龙'}, 'genera': {'ja-Hrkt': 'きょうあくポケモン', 'ko': '흉악포켓몬', 'zh-Hant': '凶惡寶可夢', 'fr': 'Pokémon Terrifiant', 'de': 'Grausam', 'es': 'Pokémon Atrocidad', 'it': 'Pokémon Atroce', 'en': 'Atrocious Pokémon', 'ja': 'きょうあくポケモン', 'zh-Hans': '凶恶宝可梦'}}
	public class SpecieGyarados : PokemonSpecie
	{
#nullable enable
		private static SpecieGyarados? _instance = null;
#nullable restore
        public static SpecieGyarados Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGyarados();
                }
                return _instance;
            }
        }

		public SpecieGyarados() : base(
			"Gyarados",
			95, // HPs
			125, 79, // Attack & Defense
			60, 100, // Special Attack & Defense
			81			
		) {}
	}


	//Gyarados Pokemon Class
	public class Gyarados : Pokemon
	{

		public Gyarados(string nickname, int level)
		: base(
				130,
				SpecieGyarados.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Gyarados() : base(
			130,
			SpecieGyarados.Instance, // Pokemon Specie
			Water.Instance, Flying.Instance			
		) {}
	}
}