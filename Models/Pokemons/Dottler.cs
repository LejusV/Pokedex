using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Dottler Specie to store common natural stats of every {'abilities': ['swarm', 'compound-eyes', 'telepathy'], 'base_experience': 117, 'height': 4, 'id': 825, 'moves': [], 'name': 'dottler', 'stats': {'hp': 50, 'attack': 35, 'defense': 80, 'special-attack': 50, 'special-defense': 90, 'speed': 30}, 'types': ['bug', 'psychic'], 'weight': 195, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'yellow', 'shape': 'armor', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium', 'egg_groups': [], 'names': {'ja-Hrkt': 'レドームシ', 'ko': '레돔벌레', 'zh-Hant': '天罩蟲', 'fr': 'Coléodôme', 'de': 'Keradar', 'es': 'Dottler', 'it': 'Dottler', 'en': 'Dottler', 'ja': 'レドームシ', 'zh-Hans': '天罩虫'}, 'genera': {'ja-Hrkt': 'レドームポケモン', 'ko': '레이돔포켓몬', 'zh-Hant': '天線罩寶可夢', 'fr': 'Pokémon Radôme', 'de': 'Radarkuppel', 'es': 'Pokémon Radomo', 'it': 'Pokémon Radome', 'en': 'Radome Pokémon', 'ja': 'レドームポケモン', 'zh-Hans': '天线罩宝可梦'}}
	public class SpecieDottler : PokemonSpecie
	{
#nullable enable
		private static SpecieDottler? _instance = null;
#nullable restore
        public static SpecieDottler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDottler();
                }
                return _instance;
            }
        }

		public SpecieDottler() : base(
			"Dottler",
			50, // HPs
			35, 80, // Attack & Defense
			50, 90, // Special Attack & Defense
			30			
		) {}
	}


	//Dottler Pokemon Class
	public class Dottler : Pokemon
	{

		public Dottler(string nickname, int level)
		: base(
				825,
				SpecieDottler.Instance, // Pokemon Specie
				nickname, level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dottler(int level)
		: base(
				825,
				SpecieDottler.Instance, // Pokemon Specie
				"Dottler", level,
				Bug.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Dottler() : base(
			825,
			SpecieDottler.Instance, // Pokemon Specie
			Bug.Instance, Psychic.Instance			
		) {}
	}
}