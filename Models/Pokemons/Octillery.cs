using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Octillery Specie to store common natural stats of every {'abilities': ['suction-cups', 'sniper', 'moody'], 'base_experience': 168, 'height': 9, 'id': 224, 'moves': ['bind', 'double-edge', 'flamethrower', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'psybeam', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'seismic-toss', 'string-shot', 'thunder-wave', 'toxic', 'psychic', 'mimic', 'double-team', 'defense-curl', 'focus-energy', 'fire-blast', 'waterfall', 'swift', 'constrict', 'rest', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'mud-slap', 'octazooka', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'whirlpool', 'facade', 'secret-power', 'dive', 'signal-beam', 'bullet-seed', 'bounce', 'rock-blast', 'water-pulse', 'brine', 'natural-gift', 'payback', 'wring-out', 'seed-bomb', 'energy-ball', 'giga-impact', 'flash-cannon', 'gunk-shot', 'captivate', 'charge-beam', 'smack-down', 'sludge-wave', 'soak', 'round', 'scald', 'incinerate', 'confide'], 'name': 'octillery', 'stats': {'hp': 75, 'attack': 105, 'defense': 75, 'special-attack': 105, 'special-defense': 75, 'speed': 45}, 'types': ['water'], 'weight': 285, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'red', 'shape': 'tentacles', 'habitat': 'sea', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water2'], 'names': {'ja-Hrkt': 'オクタン', 'roomaji': 'Okutank', 'ko': '대포무노', 'zh-Hant': '章魚桶', 'fr': 'Octillery', 'de': 'Octillery', 'es': 'Octillery', 'it': 'Octillery', 'en': 'Octillery', 'ja': 'オクタン', 'zh-Hans': '章鱼桶'}, 'genera': {'ja-Hrkt': 'ふんしゃポケモン', 'ko': '분사포켓몬', 'zh-Hant': '噴射寶可夢', 'fr': 'Pokémon Jet', 'de': 'Hochdruck', 'es': 'Pokémon Reactor', 'it': 'Pokémon Jet', 'en': 'Jet Pokémon', 'ja': 'ふんしゃポケモン', 'zh-Hans': '喷射宝可梦'}}
	public class SpecieOctillery : PokemonSpecie
	{
#nullable enable
		private static SpecieOctillery? _instance = null;
#nullable restore
        public static SpecieOctillery Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOctillery();
                }
                return _instance;
            }
        }

		public SpecieOctillery() : base(
			"Octillery",
			75, // HPs
			105, 75, // Attack & Defense
			105, 75, // Special Attack & Defense
			45			
		) {}
	}


	//Octillery Pokemon Class
	public class Octillery : Pokemon
	{

		public Octillery(string nickname, int level)
		: base(
				224,
				SpecieOctillery.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Octillery(int level)
		: base(
				224,
				SpecieOctillery.Instance, // Pokemon Specie
				"Octillery", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Octillery() : base(
			224,
			SpecieOctillery.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}