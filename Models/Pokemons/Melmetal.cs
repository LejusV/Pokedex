using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Melmetal Specie to store common natural stats of every {'abilities': ['iron-fist'], 'base_experience': 270, 'height': 25, 'id': 809, 'moves': [], 'name': 'melmetal', 'stats': {'hp': 135, 'attack': 143, 'defense': 143, 'special-attack': 80, 'special-defense': 65, 'speed': 34}, 'types': ['steel'], 'weight': 8000, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'メルメタル', 'ko': '멜메탈', 'zh-Hant': '美錄梅塔', 'fr': 'Melmetal', 'de': 'Melmetal', 'es': 'Melmetal', 'it': 'Melmetal', 'en': 'Melmetal', 'ja': 'メルメタル', 'zh-Hans': '美录梅塔'}, 'genera': {'ja-Hrkt': 'ナットポケモン', 'ko': '너트포켓몬', 'zh-Hant': '螺帽寶可夢', 'fr': 'Pokémon Écrou', 'de': 'Mutter', 'es': 'Pokémon Tuerca', 'it': 'Pokémon Bullone', 'en': 'Hex Nut Pokémon', 'ja': 'ナットポケモン', 'zh-Hans': '螺帽宝可梦'}}
	public class SpecieMelmetal : PokemonSpecie
	{
#nullable enable
		private static SpecieMelmetal? _instance = null;
#nullable restore
        public static SpecieMelmetal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMelmetal();
                }
                return _instance;
            }
        }

		public SpecieMelmetal() : base(
			"Melmetal",
			135, // HPs
			143, 143, // Attack & Defense
			80, 65, // Special Attack & Defense
			34			
		) {}
	}


	//Melmetal Pokemon Class
	public class Melmetal : Pokemon
	{

		public Melmetal(string nickname, int level)
		: base(
				809,
				SpecieMelmetal.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Melmetal(int level)
		: base(
				809,
				SpecieMelmetal.Instance, // Pokemon Specie
				"Melmetal", level,
				Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Melmetal() : base(
			809,
			SpecieMelmetal.Instance, // Pokemon Specie
			Steel.Instance			
		) {}
	}
}