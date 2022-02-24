using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Shellder Specie to store common natural stats of every {'abilities': ['shell-armor', 'skill-link', 'overcoat'], 'base_experience': 61, 'height': 3, 'id': 90, 'moves': ['tackle', 'take-down', 'double-edge', 'twineedle', 'leer', 'supersonic', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'toxic', 'rage', 'teleport', 'mimic', 'screech', 'double-team', 'withdraw', 'barrier', 'reflect', 'bide', 'self-destruct', 'clamp', 'swift', 'explosion', 'rest', 'tri-attack', 'substitute', 'snore', 'curse', 'protect', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'rapid-spin', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'secret-power', 'dive', 'icicle-spear', 'iron-defense', 'mud-shot', 'rock-blast', 'water-pulse', 'brine', 'natural-gift', 'payback', 'aqua-ring', 'avalanche', 'ice-shard', 'captivate', 'round', 'shell-smash', 'razor-shell', 'confide'], 'name': 'shellder', 'stats': {'hp': 30, 'attack': 65, 'defense': 100, 'special-attack': 45, 'special-defense': 25, 'speed': 40}, 'types': ['water'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'ball', 'habitat': 'sea', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'シェルダー', 'roomaji': 'Shellder', 'ko': '셀러', 'zh-Hant': '大舌貝', 'fr': 'Kokiyas', 'de': 'Muschas', 'es': 'Shellder', 'it': 'Shellder', 'en': 'Shellder', 'ja': 'シェルダー', 'zh-Hans': '大舌贝'}, 'genera': {'ja-Hrkt': '２まいがいポケモン', 'ko': '두조개포켓몬', 'zh-Hant': '雙殼貝寶可夢', 'fr': 'Pokémon Bivalve', 'de': 'Muschel', 'es': 'Pokémon Bivalvo', 'it': 'Pokémon Bivalve', 'en': 'Bivalve Pokémon', 'ja': '２まいがいポケモン', 'zh-Hans': '双壳贝宝可梦'}}
	public class SpecieShellder : PokemonSpecie
	{
#nullable enable
		private static SpecieShellder? _instance = null;
#nullable restore
        public static SpecieShellder Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieShellder();
                }
                return _instance;
            }
        }

		public SpecieShellder() : base(
			"Shellder",
			30, // HPs
			65, 100, // Attack & Defense
			45, 25, // Special Attack & Defense
			40			
		) {}
	}


	//Shellder Pokemon Class
	public class Shellder : Pokemon
	{

		public Shellder(string nickname, int level)
		: base(
				90,
				SpecieShellder.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Shellder() : base(
			90,
			SpecieShellder.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}