using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Loudred Specie to store common natural stats of every {'abilities': ['soundproof', 'scrappy'], 'base_experience': 126, 'height': 10, 'id': 294, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'double-edge', 'bite', 'roar', 'supersonic', 'flamethrower', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'seismic-toss', 'strength', 'solar-beam', 'earthquake', 'toxic', 'mimic', 'screech', 'double-team', 'defense-curl', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'uproar', 'torment', 'facade', 'taunt', 'brick-break', 'endeavor', 'secret-power', 'hyper-voice', 'astonish', 'overheat', 'rock-tomb', 'howl', 'shock-wave', 'water-pulse', 'natural-gift', 'fling', 'zen-headbutt', 'captivate', 'smack-down', 'synchronoise', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'confide', 'power-up-punch'], 'name': 'loudred', 'stats': {'hp': 84, 'attack': 71, 'defense': 43, 'special-attack': 71, 'special-defense': 43, 'speed': 48}, 'types': ['normal'], 'weight': 405, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'upright', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ドゴーム', 'roomaji': 'Dogohmb', 'ko': '노공룡', 'zh-Hant': '吼爆彈', 'fr': 'Ramboum', 'de': 'Krakeelo', 'es': 'Loudred', 'it': 'Loudred', 'en': 'Loudred', 'ja': 'ドゴーム', 'zh-Hans': '吼爆弹'}, 'genera': {'ja-Hrkt': 'おおごえポケモン', 'ko': '큰목소리포켓몬', 'zh-Hant': '大聲寶可夢', 'fr': 'Pokémon Grosse Voix', 'de': 'Lauthals', 'es': 'Pokémon Chillón', 'it': 'Pokémon Vocione', 'en': 'Big Voice Pokémon', 'ja': 'おおごえポケモン', 'zh-Hans': '大声宝可梦'}}
	public class SpecieLoudred : PokemonSpecie
	{
#nullable enable
		private static SpecieLoudred? _instance = null;
#nullable restore
        public static SpecieLoudred Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLoudred();
                }
                return _instance;
            }
        }

		public SpecieLoudred() : base(
			"Loudred",
			84, // HPs
			71, 43, // Attack & Defense
			71, 43, // Special Attack & Defense
			48			
		) {}
	}


	//Loudred Pokemon Class
	public class Loudred : Pokemon
	{

		public Loudred(string nickname, int level)
		: base(
				294,
				SpecieLoudred.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Loudred(int level)
		: base(
				294,
				SpecieLoudred.Instance, // Pokemon Specie
				"Loudred", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Loudred() : base(
			294,
			SpecieLoudred.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}