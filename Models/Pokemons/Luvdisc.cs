using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Luvdisc Specie to store common natural stats of every {'abilities': ['swift-swim', 'hydration'], 'base_experience': 116, 'height': 6, 'id': 370, 'moves': ['tackle', 'take-down', 'double-edge', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'toxic', 'agility', 'mimic', 'double-team', 'waterfall', 'swift', 'splash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sweet-kiss', 'icy-wind', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'mud-sport', 'bounce', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'lucky-chant', 'aqua-ring', 'captivate', 'aqua-jet', 'soak', 'entrainment', 'round', 'scald', 'heal-pulse', 'heart-stamp', 'draining-kiss', 'confide'], 'name': 'luvdisc', 'stats': {'hp': 43, 'attack': 30, 'defense': 55, 'special-attack': 40, 'special-defense': 65, 'speed': 97}, 'types': ['water'], 'weight': 87, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 225, 'color': 'pink', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'fast', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ラブカス', 'roomaji': 'Lovecus', 'ko': '사랑동이', 'zh-Hant': '愛心魚', 'fr': 'Lovdisc', 'de': 'Liebiskus', 'es': 'Luvdisc', 'it': 'Luvdisc', 'en': 'Luvdisc', 'ja': 'ラブカス', 'zh-Hans': '爱心鱼'}, 'genera': {'ja-Hrkt': 'ランデブーポケモン', 'ko': '랑데부포켓몬', 'zh-Hant': '相隨寶可夢', 'fr': 'Pokémon Rendezvous', 'de': 'Rendezvous', 'es': 'Pokémon Cita', 'it': 'Pokémon Rendezvous', 'en': 'Rendezvous Pokémon', 'ja': 'ランデブーポケモン', 'zh-Hans': '相随宝可梦'}}
	public class SpecieLuvdisc : PokemonSpecie
	{
#nullable enable
		private static SpecieLuvdisc? _instance = null;
#nullable restore
        public static SpecieLuvdisc Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLuvdisc();
                }
                return _instance;
            }
        }

		public SpecieLuvdisc() : base(
			"Luvdisc",
			43, // HPs
			30, 55, // Attack & Defense
			40, 65, // Special Attack & Defense
			97			
		) {}
	}


	//Luvdisc Pokemon Class
	public class Luvdisc : Pokemon
	{

		public Luvdisc(string nickname, int level)
		: base(
				370,
				SpecieLuvdisc.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Luvdisc() : base(
			370,
			SpecieLuvdisc.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}