using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sealeo Specie to store common natural stats of every {'abilities': ['thick-fat', 'ice-body', 'oblivious'], 'base_experience': 144, 'height': 11, 'id': 364, 'moves': ['headbutt', 'body-slam', 'double-edge', 'growl', 'roar', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'aurora-beam', 'strength', 'earthquake', 'toxic', 'mimic', 'double-team', 'defense-curl', 'waterfall', 'rest', 'rock-slide', 'super-fang', 'substitute', 'snore', 'powder-snow', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'encore', 'iron-tail', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'ice-ball', 'rock-tomb', 'signal-beam', 'sheer-cold', 'water-pulse', 'brine', 'natural-gift', 'aqua-tail', 'captivate', 'round', 'echoed-voice', 'bulldoze', 'frost-breath', 'confide'], 'name': 'sealeo', 'stats': {'hp': 90, 'attack': 60, 'defense': 70, 'special-attack': 75, 'special-defense': 70, 'speed': 45}, 'types': ['ice', 'water'], 'weight': 876, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'fish', 'habitat': 'sea', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'トドグラー', 'roomaji': 'Todoggler', 'ko': '씨레오', 'zh-Hant': '海魔獅', 'fr': 'Phogleur', 'de': 'Seejong', 'es': 'Sealeo', 'it': 'Sealeo', 'en': 'Sealeo', 'ja': 'トドグラー', 'zh-Hans': '海魔狮'}, 'genera': {'ja-Hrkt': 'たままわしポケモン', 'ko': '공돌리기포켓몬', 'zh-Hant': '滾球寶可夢', 'fr': 'Pokémon Roule Boule', 'de': 'Spielball', 'es': 'Pokémon Rodabola', 'it': 'Pokémon Rotapalla', 'en': 'Ball Roll Pokémon', 'ja': 'たままわしポケモン', 'zh-Hans': '滚球宝可梦'}}
	public class SpecieSealeo : PokemonSpecie
	{
#nullable enable
		private static SpecieSealeo? _instance = null;
#nullable restore
        public static SpecieSealeo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSealeo();
                }
                return _instance;
            }
        }

		public SpecieSealeo() : base(
			"Sealeo",
			90, // HPs
			60, 70, // Attack & Defense
			75, 70, // Special Attack & Defense
			45			
		) {}
	}


	//Sealeo Pokemon Class
	public class Sealeo : Pokemon
	{

		public Sealeo(string nickname, int level)
		: base(
				364,
				SpecieSealeo.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sealeo(int level)
		: base(
				364,
				SpecieSealeo.Instance, // Pokemon Specie
				"Sealeo", level,
				Ice.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sealeo() : base(
			364,
			SpecieSealeo.Instance, // Pokemon Specie
			Ice.Instance, Water.Instance			
		) {}
	}
}