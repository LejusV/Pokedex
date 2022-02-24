using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Wailord Specie to store common natural stats of every {'abilities': ['water-veil', 'oblivious', 'pressure'], 'base_experience': 175, 'height': 145, 'id': 321, 'moves': ['headbutt', 'body-slam', 'double-edge', 'growl', 'roar', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'self-destruct', 'waterfall', 'amnesia', 'splash', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'hyper-voice', 'astonish', 'rock-tomb', 'water-spout', 'block', 'bounce', 'water-pulse', 'brine', 'natural-gift', 'giga-impact', 'avalanche', 'zen-headbutt', 'iron-head', 'captivate', 'heavy-slam', 'soak', 'round', 'echoed-voice', 'scald', 'bulldoze', 'noble-roar', 'confide'], 'name': 'wailord', 'stats': {'hp': 170, 'attack': 90, 'defense': 45, 'special-attack': 90, 'special-defense': 45, 'speed': 60}, 'types': ['water'], 'weight': 3980, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 60, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['ground', 'water2'], 'names': {'ja-Hrkt': 'ホエルオー', 'roomaji': 'Whaloh', 'ko': '고래왕', 'zh-Hant': '吼鯨王', 'fr': 'Wailord', 'de': 'Wailord', 'es': 'Wailord', 'it': 'Wailord', 'en': 'Wailord', 'ja': 'ホエルオー', 'zh-Hans': '吼鲸王'}, 'genera': {'ja-Hrkt': 'うきくじらポケモン', 'ko': '뜸고래포켓몬', 'zh-Hant': '浮鯨寶可夢', 'fr': 'Pokémon Cachabouée', 'de': 'Flutwal', 'es': 'Pokémon Ballenaflot', 'it': 'Pokémon Megabalena', 'en': 'Float Whale Pokémon', 'ja': 'うきくじらポケモン', 'zh-Hans': '浮鲸宝可梦'}}
	public class SpecieWailord : PokemonSpecie
	{
#nullable enable
		private static SpecieWailord? _instance = null;
#nullable restore
        public static SpecieWailord Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWailord();
                }
                return _instance;
            }
        }

		public SpecieWailord() : base(
			"Wailord",
			170, // HPs
			90, 45, // Attack & Defense
			90, 45, // Special Attack & Defense
			60			
		) {}
	}


	//Wailord Pokemon Class
	public class Wailord : Pokemon
	{

		public Wailord(string nickname, int level)
		: base(
				321,
				SpecieWailord.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wailord(int level)
		: base(
				321,
				SpecieWailord.Instance, // Pokemon Specie
				"Wailord", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Wailord() : base(
			321,
			SpecieWailord.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}