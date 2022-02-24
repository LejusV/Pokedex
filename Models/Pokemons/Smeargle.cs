using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Smeargle Specie to store common natural stats of every {'abilities': ['own-tempo', 'technician', 'moody'], 'base_experience': 88, 'height': 12, 'id': 235, 'moves': ['sketch'], 'name': 'smeargle', 'stats': {'hp': 55, 'attack': 20, 'defense': 35, 'special-attack': 20, 'special-defense': 45, 'speed': 75}, 'types': ['normal'], 'weight': 580, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'upright', 'habitat': 'urban', 'generation': 'generation-ii', 'growth_rate': 'fast', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ドーブル', 'roomaji': 'Doble', 'ko': '루브도', 'zh-Hant': '圖圖犬', 'fr': 'Queulorior', 'de': 'Farbeagle', 'es': 'Smeargle', 'it': 'Smeargle', 'en': 'Smeargle', 'ja': 'ドーブル', 'zh-Hans': '图图犬'}, 'genera': {'ja-Hrkt': 'えかきポケモン', 'ko': '그림장이포켓몬', 'zh-Hant': '畫畫寶可夢', 'fr': 'Pokémon Peintre', 'de': 'Maler', 'es': 'Pokémon Pintor', 'it': 'Pokémon Pittore', 'en': 'Painter Pokémon', 'ja': 'えかきポケモン', 'zh-Hans': '画画宝可梦'}}
	public class SpecieSmeargle : PokemonSpecie
	{
#nullable enable
		private static SpecieSmeargle? _instance = null;
#nullable restore
        public static SpecieSmeargle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSmeargle();
                }
                return _instance;
            }
        }

		public SpecieSmeargle() : base(
			"Smeargle",
			55, // HPs
			20, 35, // Attack & Defense
			20, 45, // Special Attack & Defense
			75			
		) {}
	}


	//Smeargle Pokemon Class
	public class Smeargle : Pokemon
	{

		public Smeargle(string nickname, int level)
		: base(
				235,
				SpecieSmeargle.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Smeargle() : base(
			235,
			SpecieSmeargle.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}