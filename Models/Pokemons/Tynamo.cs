using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tynamo Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 55, 'height': 2, 'id': 602, 'moves': ['tackle', 'thunder-wave', 'spark', 'magnet-rise', 'charge-beam'], 'name': 'tynamo', 'stats': {'hp': 35, 'attack': 55, 'defense': 40, 'special-attack': 45, 'special-defense': 40, 'speed': 60}, 'types': ['electric'], 'weight': 3, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'white', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['indeterminate'], 'names': {'ja-Hrkt': 'シビシラス', 'ko': '저리어', 'zh-Hant': '麻麻小魚', 'fr': 'Anchwatt', 'de': 'Zapplardin', 'es': 'Tynamo', 'it': 'Tynamo', 'en': 'Tynamo', 'ja': 'シビシラス', 'zh-Hans': '麻麻小鱼'}, 'genera': {'ja-Hrkt': 'でんきうおポケモン', 'ko': '전기물고기포켓몬', 'zh-Hant': '電魚寶可夢', 'fr': 'Pokémon Électrophore', 'de': 'Stromfisch', 'es': 'Pokémon Electropez', 'it': 'Pokémon Elettropesce', 'en': 'EleFish Pokémon', 'ja': 'でんきうおポケモン', 'zh-Hans': '电鱼宝可梦'}}
	public class SpecieTynamo : PokemonSpecie
	{
#nullable enable
		private static SpecieTynamo? _instance = null;
#nullable restore
        public static SpecieTynamo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTynamo();
                }
                return _instance;
            }
        }

		public SpecieTynamo() : base(
			"Tynamo",
			35, // HPs
			55, 40, // Attack & Defense
			45, 40, // Special Attack & Defense
			60			
		) {}
	}


	//Tynamo Pokemon Class
	public class Tynamo : Pokemon
	{

		public Tynamo(string nickname, int level) : base(
			602,
			SpecieTynamo.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance			
		) {}

		public Tynamo() : base(
			602,
			SpecieTynamo.Instance, // Pokemon Specie
			Electric.Instance			
		) {}
	}
}