using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dewgong Specie to store common natural stats of every {'abilities': ['thick-fat', 'hydration', 'ice-body'], 'base_experience': 166, 'height': 17, 'id': 87, 'moves': ['pay-day', 'headbutt', 'horn-drill', 'body-slam', 'take-down', 'double-edge', 'growl', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'strength', 'toxic', 'rage', 'mimic', 'double-team', 'bide', 'waterfall', 'skull-bash', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'signal-beam', 'sheer-cold', 'water-pulse', 'brine', 'natural-gift', 'fling', 'aqua-ring', 'aqua-tail', 'giga-impact', 'avalanche', 'ice-shard', 'captivate', 'aqua-jet', 'round', 'echoed-voice', 'frost-breath', 'drill-run', 'confide', 'smart-strike'], 'name': 'dewgong', 'stats': {'hp': 90, 'attack': 70, 'defense': 80, 'special-attack': 70, 'special-defense': 95, 'speed': 70}, 'types': ['water', 'ice'], 'weight': 1200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'white', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ジュゴン', 'roomaji': 'Jugon', 'ko': '쥬레곤', 'zh-Hant': '白海獅', 'fr': 'Lamantine', 'de': 'Jugong', 'es': 'Dewgong', 'it': 'Dewgong', 'en': 'Dewgong', 'ja': 'ジュゴン', 'zh-Hans': '白海狮'}, 'genera': {'ja-Hrkt': 'あしかポケモン', 'ko': '강치포켓몬', 'zh-Hant': '海獅寶可夢', 'fr': 'Pokémon Otarie', 'de': 'Seehund', 'es': 'Pokémon León Marino', 'it': 'Pokémon Otaria', 'en': 'Sea Lion Pokémon', 'ja': 'あしかポケモン', 'zh-Hans': '海狮宝可梦'}}
	public class SpecieDewgong : PokemonSpecie
	{
#nullable enable
		private static SpecieDewgong? _instance = null;
#nullable restore
        public static SpecieDewgong Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDewgong();
                }
                return _instance;
            }
        }

		public SpecieDewgong() : base(
			"Dewgong",
			90, // HPs
			70, 80, // Attack & Defense
			70, 95, // Special Attack & Defense
			70			
		) {}
	}


	//Dewgong Pokemon Class
	public class Dewgong : Pokemon
	{

		public Dewgong(string nickname, int level)
		: base(
				87,
				SpecieDewgong.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dewgong(int level)
		: base(
				87,
				SpecieDewgong.Instance, // Pokemon Specie
				"Dewgong", level,
				Water.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dewgong() : base(
			87,
			SpecieDewgong.Instance, // Pokemon Specie
			Water.Instance, Ice.Instance			
		) {}
	}
}