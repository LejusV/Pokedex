using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Thwackey Specie to store common natural stats of every {'abilities': ['overgrow', 'grassy-surge'], 'base_experience': 147, 'height': 7, 'id': 811, 'moves': [], 'name': 'thwackey', 'stats': {'hp': 70, 'attack': 85, 'defense': 70, 'special-attack': 55, 'special-defense': 60, 'speed': 80}, 'types': ['grass'], 'weight': 140, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'バチンキー', 'ko': '채키몽', 'zh-Hant': '啪咚猴', 'fr': 'Badabouin', 'de': 'Chimstix', 'es': 'Thwackey', 'it': 'Thwackey', 'en': 'Thwackey', 'ja': 'バチンキー', 'zh-Hans': '啪咚猴'}, 'genera': {'ja-Hrkt': 'ビートポケモン', 'ko': '비트포켓몬', 'zh-Hant': '節拍寶可夢', 'fr': 'Pokémon Percussions', 'de': 'Beat', 'es': 'Pokémon Ritmo', 'it': 'Pokémon Ritmo', 'en': 'Beat Pokémon', 'ja': 'ビートポケモン', 'zh-Hans': '节拍宝可梦'}}
	public class SpecieThwackey : PokemonSpecie
	{
#nullable enable
		private static SpecieThwackey? _instance = null;
#nullable restore
        public static SpecieThwackey Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThwackey();
                }
                return _instance;
            }
        }

		public SpecieThwackey() : base(
			"Thwackey",
			70, // HPs
			85, 70, // Attack & Defense
			55, 60, // Special Attack & Defense
			80			
		) {}
	}


	//Thwackey Pokemon Class
	public class Thwackey : Pokemon
	{

		public Thwackey(string nickname, int level)
		: base(
				811,
				SpecieThwackey.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Thwackey(int level)
		: base(
				811,
				SpecieThwackey.Instance, // Pokemon Specie
				"Thwackey", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Thwackey() : base(
			811,
			SpecieThwackey.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}