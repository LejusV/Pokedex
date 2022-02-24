using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Froakie Specie to store common natural stats of every {'abilities': ['torrent', 'protean'], 'base_experience': 63, 'height': 3, 'id': 656, 'moves': ['pound', 'cut', 'growl', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'strength', 'dig', 'toxic', 'quick-attack', 'double-team', 'smokescreen', 'lick', 'waterfall', 'bubble', 'rest', 'rock-slide', 'substitute', 'thief', 'mind-reader', 'snore', 'spite', 'protect', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'facade', 'taunt', 'role-play', 'snatch', 'secret-power', 'dive', 'camouflage', 'mud-sport', 'rock-tomb', 'aerial-ace', 'bounce', 'water-sport', 'water-pulse', 'u-turn', 'fling', 'toxic-spikes', 'grass-knot', 'smack-down', 'round', 'echoed-voice', 'scald', 'acrobatics', 'bestow', 'water-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'froakie', 'stats': {'hp': 41, 'attack': 56, 'defense': 40, 'special-attack': 62, 'special-defense': 44, 'speed': 71}, 'types': ['water'], 'weight': 70, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ケロマツ', 'ko': '개구마르', 'zh-Hant': '呱呱泡蛙', 'fr': 'Grenousse', 'de': 'Froxy', 'es': 'Froakie', 'it': 'Froakie', 'en': 'Froakie', 'ja': 'ケロマツ', 'zh-Hans': '呱呱泡蛙'}, 'genera': {'ja-Hrkt': 'あわがえるポケモン', 'ko': '거품개구리포켓몬', 'zh-Hant': '泡蛙寶可夢', 'fr': 'Pokémon Crapobulle', 'de': 'Blubbfrosch', 'es': 'Pokémon Burburrana', 'it': 'Pokémon Schiumorana', 'en': 'Bubble Frog Pokémon', 'ja': 'あわがえるポケモン', 'zh-Hans': '泡蛙宝可梦'}}
	public class SpecieFroakie : PokemonSpecie
	{
#nullable enable
		private static SpecieFroakie? _instance = null;
#nullable restore
        public static SpecieFroakie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFroakie();
                }
                return _instance;
            }
        }

		public SpecieFroakie() : base(
			"Froakie",
			41, // HPs
			56, 40, // Attack & Defense
			62, 44, // Special Attack & Defense
			71			
		) {}
	}


	//Froakie Pokemon Class
	public class Froakie : Pokemon
	{

		public Froakie(string nickname, int level)
		: base(
				656,
				SpecieFroakie.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Froakie(int level)
		: base(
				656,
				SpecieFroakie.Instance, // Pokemon Specie
				"Froakie", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Froakie() : base(
			656,
			SpecieFroakie.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}