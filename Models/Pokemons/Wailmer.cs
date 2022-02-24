using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wailmer Specie to store common natural stats of every {'abilities': ['water-veil', 'oblivious', 'pressure'], 'base_experience': 80, 'height': 20, 'id': 320, 'moves': ['headbutt', 'body-slam', 'thrash', 'double-edge', 'growl', 'roar', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'strength', 'earthquake', 'fissure', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'waterfall', 'amnesia', 'splash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'hyper-voice', 'astonish', 'rock-tomb', 'tickle', 'water-spout', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'aqua-ring', 'avalanche', 'zen-headbutt', 'captivate', 'heavy-slam', 'soak', 'round', 'echoed-voice', 'clear-smog', 'scald', 'bulldoze', 'confide'], 'name': 'wailmer', 'stats': {'hp': 130, 'attack': 70, 'defense': 35, 'special-attack': 70, 'special-defense': 35, 'speed': 60}, 'types': ['water'], 'weight': 1300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 125, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['ground', 'water2'], 'names': {'ja-Hrkt': 'ホエルコ', 'roomaji': 'Whalko', 'ko': '고래왕자', 'zh-Hant': '吼吼鯨', 'fr': 'Wailmer', 'de': 'Wailmer', 'es': 'Wailmer', 'it': 'Wailmer', 'en': 'Wailmer', 'ja': 'ホエルコ', 'zh-Hans': '吼吼鲸'}, 'genera': {'ja-Hrkt': 'たまくじらポケモン', 'ko': '둥근고래포켓몬', 'zh-Hant': '球鯨寶可夢', 'fr': 'Pokémon Baleinboule', 'de': 'Kugelwal', 'es': 'Pokémon Ballenabola', 'it': 'Pokémon Balenottero', 'en': 'Ball Whale Pokémon', 'ja': 'たまくじらポケモン', 'zh-Hans': '球鲸宝可梦'}}
	public class SpecieWailmer : PokemonSpecie
	{
#nullable enable
		private static SpecieWailmer? _instance = null;
#nullable restore
        public static SpecieWailmer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWailmer();
                }
                return _instance;
            }
        }

		public SpecieWailmer() : base(
			"Wailmer",
			130, // HPs
			70, 35, // Attack & Defense
			70, 35, // Special Attack & Defense
			60			
		) {}
	}


	//Wailmer Pokemon Class
	public class Wailmer : Pokemon
	{

		public Wailmer(string nickname, int level)
		: base(
				320,
				SpecieWailmer.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wailmer() : base(
			320,
			SpecieWailmer.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}