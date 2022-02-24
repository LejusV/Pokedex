using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Kubfu Specie to store common natural stats of every {'abilities': ['inner-focus'], 'base_experience': 77, 'height': 6, 'id': 891, 'moves': [], 'name': 'kubfu', 'stats': {'hp': 60, 'attack': 90, 'defense': 60, 'special-attack': 53, 'special-defense': 50, 'speed': 72}, 'types': ['fighting'], 'weight': 120, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': 1, 'capture_rate': 3, 'color': 'gray', 'shape': 'upright', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'ダクマ', 'ko': '치고마', 'zh-Hant': '熊徒弟', 'fr': 'Wushours', 'de': 'Dakuma', 'es': 'Kubfu', 'it': 'Kubfu', 'en': 'Kubfu', 'ja': 'ダクマ', 'zh-Hans': '熊徒弟'}, 'genera': {'ja-Hrkt': 'けんぽうポケモン', 'ko': '권법포켓몬', 'zh-Hant': '拳法寶可夢', 'fr': 'Pokémon Kung-fu', 'de': 'Kung-Fu', 'es': 'Pokémon Kung-fu', 'it': 'Pokémon Kung Fu', 'en': 'Wushu Pokémon', 'ja': 'けんぽうポケモン', 'zh-Hans': '拳法宝可梦'}}
	public class SpecieKubfu : PokemonSpecie
	{
#nullable enable
		private static SpecieKubfu? _instance = null;
#nullable restore
        public static SpecieKubfu Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKubfu();
                }
                return _instance;
            }
        }

		public SpecieKubfu() : base(
			"Kubfu",
			60, // HPs
			90, 60, // Attack & Defense
			53, 50, // Special Attack & Defense
			72			
		) {}
	}


	//Kubfu Pokemon Class
	public class Kubfu : Pokemon
	{

		public Kubfu(string nickname, int level)
		: base(
				891,
				SpecieKubfu.Instance, // Pokemon Specie
				nickname, level,
				Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Kubfu() : base(
			891,
			SpecieKubfu.Instance, // Pokemon Specie
			Fighting.Instance			
		) {}
	}
}