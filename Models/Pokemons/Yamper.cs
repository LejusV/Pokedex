using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yamper Specie to store common natural stats of every {'abilities': ['ball-fetch', 'rattled'], 'base_experience': 54, 'height': 3, 'id': 835, 'moves': [], 'name': 'yamper', 'stats': {'hp': 59, 'attack': 45, 'defense': 50, 'special-attack': 40, 'special-defense': 50, 'speed': 26}, 'types': ['electric'], 'weight': 135, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'yellow', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'ワンパチ', 'ko': '멍파치', 'zh-Hant': '來電汪', 'fr': 'Voltoutou', 'de': 'Voldi', 'es': 'Yamper', 'it': 'Yamper', 'en': 'Yamper', 'ja': 'ワンパチ', 'zh-Hans': '来电汪'}, 'genera': {'ja-Hrkt': 'こいぬポケモン', 'ko': '강아지포켓몬', 'zh-Hant': '小狗寶可夢', 'fr': 'Pokémon Chiot', 'de': 'Welpe', 'es': 'Pokémon Perrito', 'it': 'Pokémon Cagnolino', 'en': 'Puppy Pokémon', 'ja': 'こいぬポケモン', 'zh-Hans': '小狗宝可梦'}}
	public class SpecieYamper : PokemonSpecie
	{
#nullable enable
		private static SpecieYamper? _instance = null;
#nullable restore
        public static SpecieYamper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYamper();
                }
                return _instance;
            }
        }

		public SpecieYamper() : base(
			"Yamper",
			59, // HPs
			45, 50, // Attack & Defense
			40, 50, // Special Attack & Defense
			26			
		) {}
	}


	//Yamper Pokemon Class
	public class Yamper : Pokemon
	{

		public Yamper(string nickname, int level) : base(
			835,
			SpecieYamper.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Yamper() : base(
			835,
			SpecieYamper.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}