using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Urshifu-Single-Strike Specie to store common natural stats of every {'abilities': ['unseen-fist'], 'base_experience': 275, 'height': 19, 'id': 892, 'moves': [], 'name': 'urshifu-single-strike', 'stats': {'hp': 100, 'attack': 130, 'defense': 100, 'special-attack': 63, 'special-defense': 60, 'speed': 97}, 'types': ['fighting', 'dark'], 'weight': 1050, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 1, 'capture_rate': 3, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ウーラオス', 'ko': '우라오스', 'zh-Hant': '武道熊師', 'fr': 'Shifours', 'de': 'Wulaosu', 'es': 'Urshifu', 'it': 'Urshifu', 'en': 'Urshifu', 'ja': 'ウーラオス', 'zh-Hans': '武道熊师'}, 'genera': {'ja-Hrkt': 'けんぽうポケモン', 'ko': '권법포켓몬', 'zh-Hant': '拳法寶可夢', 'fr': 'Pokémon Kung-fu', 'de': 'Kung-Fu', 'es': 'Pokémon Kung-fu', 'it': 'Pokémon Kung Fu', 'en': 'Wushu Pokémon', 'ja': 'けんぽうポケモン', 'zh-Hans': '拳法宝可梦'}}
	public class SpecieUrshifuSingleStrike : PokemonSpecie
	{
#nullable enable
		private static SpecieUrshifuSingleStrike? _instance = null;
#nullable restore
        public static SpecieUrshifuSingleStrike Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUrshifuSingleStrike();
                }
                return _instance;
            }
        }

		public SpecieUrshifuSingleStrike() : base(
			"Urshifu-Single-Strike",
			100, // HPs
			130, 100, // Attack & Defense
			63, 60, // Special Attack & Defense
			97			
		) {}
	}


	//Urshifu-Single-Strike Pokemon Class
	public class UrshifuSingleStrike : Pokemon
	{

		public UrshifuSingleStrike(string nickname, int level)
		: base(
				892,
				SpecieUrshifuSingleStrike.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public UrshifuSingleStrike() : base(
			892,
			SpecieUrshifuSingleStrike.Instance, // Pokemon Specie
			Fighting.Instance, Dark.Instance			
		) {}
	}
}