using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Toxtricity-Amped Specie to store common natural stats of every {'abilities': ['punk-rock', 'plus', 'technician'], 'base_experience': 176, 'height': 16, 'id': 849, 'moves': [], 'name': 'toxtricity-amped', 'stats': {'hp': 75, 'attack': 98, 'defense': 70, 'special-attack': 114, 'special-defense': 70, 'speed': 75}, 'types': ['electric', 'poison'], 'weight': 400, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'medium-slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ストリンダー', 'ko': '스트린더', 'zh-Hant': '顫弦蠑螈', 'fr': 'Salarsen', 'de': 'Riffex', 'es': 'Toxtricity', 'it': 'Toxtricity', 'en': 'Toxtricity', 'ja': 'ストリンダー', 'zh-Hans': '颤弦蝾螈'}, 'genera': {'ja-Hrkt': 'パンクポケモン', 'ko': '펑크포켓몬', 'zh-Hant': '龐克寶可夢', 'fr': 'Pokémon Punk', 'de': 'Punk', 'es': 'Pokémon Punki', 'it': 'Pokémon Punk', 'en': 'Punk Pokémon', 'ja': 'パンクポケモン', 'zh-Hans': '庞克宝可梦'}}
	public class SpecieToxtricityAmped : PokemonSpecie
	{
#nullable enable
		private static SpecieToxtricityAmped? _instance = null;
#nullable restore
        public static SpecieToxtricityAmped Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieToxtricityAmped();
                }
                return _instance;
            }
        }

		public SpecieToxtricityAmped() : base(
			"Toxtricity-Amped",
			75, // HPs
			98, 70, // Attack & Defense
			114, 70, // Special Attack & Defense
			75			
		) {}
	}


	//Toxtricity-Amped Pokemon Class
	public class ToxtricityAmped : Pokemon
	{

		public ToxtricityAmped(string nickname, int level)
		: base(
				849,
				SpecieToxtricityAmped.Instance, // Pokemon Specie
				nickname, level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public ToxtricityAmped(int level)
		: base(
				849,
				SpecieToxtricityAmped.Instance, // Pokemon Specie
				"Toxtricity-Amped", level,
				Electric.Instance, Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public ToxtricityAmped() : base(
			849,
			SpecieToxtricityAmped.Instance, // Pokemon Specie
			Electric.Instance, Poison.Instance			
		) {}
	}
}