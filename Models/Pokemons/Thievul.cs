using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Thievul Specie to store common natural stats of every {'abilities': ['run-away', 'unburden', 'stakeout'], 'base_experience': 159, 'height': 12, 'id': 828, 'moves': [], 'name': 'thievul', 'stats': {'hp': 70, 'attack': 58, 'defense': 58, 'special-attack': 87, 'special-defense': 92, 'speed': 90}, 'types': ['dark'], 'weight': 199, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 127, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'fast', 'egg_groups': [], 'names': {'ja-Hrkt': 'フォクスライ', 'ko': '폭슬라이', 'zh-Hant': '狐大盜', 'fr': 'Roublenard', 'de': 'Gaunux', 'es': 'Thievul', 'it': 'Thievul', 'en': 'Thievul', 'ja': 'フォクスライ', 'zh-Hans': '狐大盗'}, 'genera': {'ja-Hrkt': 'きつねポケモン', 'ko': '여우포켓몬', 'zh-Hant': '狐狸寶可夢', 'fr': 'Pokémon Renard', 'de': 'Fuchs', 'es': 'Pokémon Zorro', 'it': 'Pokémon Volpe', 'en': 'Fox Pokémon', 'ja': 'きつねポケモン', 'zh-Hans': '狐狸宝可梦'}}
	public class SpecieThievul : PokemonSpecie
	{
#nullable enable
		private static SpecieThievul? _instance = null;
#nullable restore
        public static SpecieThievul Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieThievul();
                }
                return _instance;
            }
        }

		public SpecieThievul() : base(
			"Thievul",
			70, // HPs
			58, 58, // Attack & Defense
			87, 92, // Special Attack & Defense
			90			
		) {}
	}


	//Thievul Pokemon Class
	public class Thievul : Pokemon
	{

		public Thievul(string nickname, int level)
		: base(
				828,
				SpecieThievul.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Thievul() : base(
			828,
			SpecieThievul.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}