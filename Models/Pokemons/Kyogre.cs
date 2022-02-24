using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kyogre Specie to store common natural stats of every {'abilities': ['drizzle'], 'base_experience': 302, 'height': 45, 'id': 382, 'moves': ['headbutt', 'body-slam', 'double-edge', 'roar', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'waterfall', 'swift', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'scary-face', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'ancient-power', 'rock-smash', 'whirlpool', 'uproar', 'hail', 'facade', 'brick-break', 'secret-power', 'dive', 'rock-tomb', 'water-spout', 'signal-beam', 'sheer-cold', 'muddy-water', 'block', 'calm-mind', 'shock-wave', 'water-pulse', 'brine', 'natural-gift', 'aqua-ring', 'aqua-tail', 'giga-impact', 'avalanche', 'iron-head', 'round', 'scald', 'bulldoze', 'confide', 'origin-pulse'], 'name': 'kyogre', 'stats': {'hp': 100, 'attack': 100, 'defense': 90, 'special-attack': 150, 'special-defense': 140, 'speed': 90}, 'types': ['water'], 'weight': 3520, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'カイオーガ', 'roomaji': 'Kyogre', 'ko': '가이오가', 'zh-Hant': '蓋歐卡', 'fr': 'Kyogre', 'de': 'Kyogre', 'es': 'Kyogre', 'it': 'Kyogre', 'en': 'Kyogre', 'ja': 'カイオーガ', 'zh-Hans': '盖欧卡'}, 'genera': {'ja-Hrkt': 'かいていポケモン', 'ko': '해저포켓몬', 'zh-Hant': '海底寶可夢', 'fr': 'Pokémon Bassinmarin', 'de': 'Seegründler', 'es': 'Pokémon Cuenca Mar', 'it': 'Pokémon Oceano', 'en': 'Sea Basin Pokémon', 'ja': 'かいていポケモン', 'zh-Hans': '海底宝可梦'}}
	public class SpecieKyogre : PokemonSpecie
	{
#nullable enable
		private static SpecieKyogre? _instance = null;
#nullable restore
        public static SpecieKyogre Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKyogre();
                }
                return _instance;
            }
        }

		public SpecieKyogre() : base(
			"Kyogre",
			100, // HPs
			100, 90, // Attack & Defense
			150, 140, // Special Attack & Defense
			90			
		) {}
	}


	//Kyogre Pokemon Class
	public class Kyogre : Pokemon
	{

		public Kyogre(string nickname, int level)
		: base(
				382,
				SpecieKyogre.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kyogre(int level)
		: base(
				382,
				SpecieKyogre.Instance, // Pokemon Specie
				"Kyogre", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kyogre() : base(
			382,
			SpecieKyogre.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}