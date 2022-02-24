using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Clobbopus Specie to store common natural stats of every {'abilities': ['limber', 'technician'], 'base_experience': 62, 'height': 6, 'id': 852, 'moves': [], 'name': 'clobbopus', 'stats': {'hp': 50, 'attack': 68, 'defense': 60, 'special-attack': 50, 'special-defense': 50, 'speed': 32}, 'types': ['fighting'], 'weight': 40, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 180, 'color': 'brown', 'shape': 'tentacles', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'タタッコ', 'ko': '때때무노', 'zh-Hant': '拳拳蛸', 'fr': 'Poulpaf', 'de': 'Klopptopus', 'es': 'Clobbopus', 'it': 'Clobbopus', 'en': 'Clobbopus', 'ja': 'タタッコ', 'zh-Hans': '拳拳蛸'}, 'genera': {'ja-Hrkt': 'だだっこポケモン', 'ko': '떼쟁이포켓몬', 'zh-Hant': '纏人寶可夢', 'fr': 'Pokémon Caprice', 'de': 'Balg', 'es': 'Pokémon Malcriado', 'it': 'Pokémon Bizze', 'en': 'Tantrum Pokémon', 'ja': 'だだっこポケモン', 'zh-Hans': '缠人宝可梦'}}
	public class SpecieClobbopus : PokemonSpecie
	{
#nullable enable
		private static SpecieClobbopus? _instance = null;
#nullable restore
        public static SpecieClobbopus Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieClobbopus();
                }
                return _instance;
            }
        }

		public SpecieClobbopus() : base(
			"Clobbopus",
			50, // HPs
			68, 60, // Attack & Defense
			50, 50, // Special Attack & Defense
			32			
		) {}
	}


	//Clobbopus Pokemon Class
	public class Clobbopus : Pokemon
	{

		public Clobbopus(string nickname, int level)
		: base(
				852,
				SpecieClobbopus.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Clobbopus() : base(
			852,
			SpecieClobbopus.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}