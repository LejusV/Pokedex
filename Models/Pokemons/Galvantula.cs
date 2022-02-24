using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Galvantula Specie to store common natural stats of every {'abilities': ['compound-eyes', 'unnerve', 'swarm'], 'base_experience': 165, 'height': 8, 'id': 596, 'moves': ['cut', 'hyper-beam', 'absorb', 'string-shot', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'screech', 'double-team', 'light-screen', 'leech-life', 'flash', 'rest', 'slash', 'substitute', 'thief', 'spider-web', 'snore', 'protect', 'giga-drain', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'facade', 'secret-power', 'signal-beam', 'bounce', 'shock-wave', 'gastro-acid', 'sucker-punch', 'magnet-rise', 'poison-jab', 'x-scissor', 'bug-buzz', 'energy-ball', 'giga-impact', 'discharge', 'bug-bite', 'charge-beam', 'electro-ball', 'round', 'volt-switch', 'struggle-bug', 'electroweb', 'wild-charge', 'sticky-web', 'confide', 'infestation'], 'name': 'galvantula', 'stats': {'hp': 70, 'attack': 77, 'defense': 60, 'special-attack': 97, 'special-defense': 60, 'speed': 108}, 'types': ['bug', 'electric'], 'weight': 143, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 75, 'color': 'yellow', 'shape': 'armor', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'デンチュラ', 'ko': '전툴라', 'zh-Hant': '電蜘蛛', 'fr': 'Mygavolt', 'de': 'Voltula', 'es': 'Galvantula', 'it': 'Galvantula', 'en': 'Galvantula', 'ja': 'デンチュラ', 'zh-Hans': '电蜘蛛'}, 'genera': {'ja-Hrkt': 'でんきグモポケモン', 'ko': '전기거미포켓몬', 'zh-Hant': '電蜘蛛寶可夢', 'fr': 'Pokémon Araclectrik', 'de': 'Stromspinne', 'es': 'Pokémon Electroaraña', 'it': 'Pokémon Elettroragno', 'en': 'EleSpider Pokémon', 'ja': 'でんきグモポケモン', 'zh-Hans': '电蜘蛛宝可梦'}}
	public class SpecieGalvantula : PokemonSpecie
	{
#nullable enable
		private static SpecieGalvantula? _instance = null;
#nullable restore
        public static SpecieGalvantula Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGalvantula();
                }
                return _instance;
            }
        }

		public SpecieGalvantula() : base(
			"Galvantula",
			70, // HPs
			77, 60, // Attack & Defense
			97, 60, // Special Attack & Defense
			108			
		) {}
	}


	//Galvantula Pokemon Class
	public class Galvantula : Pokemon
	{

		public Galvantula(string nickname, int level)
		: base(
				596,
				SpecieGalvantula.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Galvantula(int level)
		: base(
				596,
				SpecieGalvantula.Instance, // Pokemon Specie
				"Galvantula", level,
				Bug.Instance, Electric.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Galvantula() : base(
			596,
			SpecieGalvantula.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
	}
}