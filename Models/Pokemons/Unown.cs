using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Unown Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 118, 'height': 5, 'id': 201, 'moves': ['hidden-power'], 'name': 'unown', 'stats': {'hp': 48, 'attack': 72, 'defense': 48, 'special-attack': 72, 'special-defense': 48, 'speed': 48}, 'types': ['psychic'], 'weight': 50, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': -1, 'capture_rate': 225, 'color': 'black', 'shape': 'ball', 'habitat': 'rare', 'generation': 'generation-ii', 'growth_rate': 'medium', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'アンノーン', 'roomaji': 'Unknown', 'ko': '안농', 'zh-Hant': '未知圖騰', 'fr': 'Zarbi', 'de': 'Icognito', 'es': 'Unown', 'it': 'Unown', 'en': 'Unown', 'ja': 'アンノーン', 'zh-Hans': '未知图腾'}, 'genera': {'ja-Hrkt': 'シンボルポケモン', 'ko': '심볼포켓몬', 'zh-Hant': '象徵寶可夢', 'fr': 'Pokémon Symbolique', 'de': 'Symbol', 'es': 'Pokémon Símbolo', 'it': 'Pokémon Simbolo', 'en': 'Symbol Pokémon', 'ja': 'シンボルポケモン', 'zh-Hans': '象征宝可梦'}}
	public class SpecieUnown : PokemonSpecie
	{
#nullable enable
		private static SpecieUnown? _instance = null;
#nullable restore
        public static SpecieUnown Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieUnown();
                }
                return _instance;
            }
        }

		public SpecieUnown() : base(
			"Unown",
			48, // HPs
			72, 48, // Attack & Defense
			72, 48, // Special Attack & Defense
			48			
		) {}
	}


	//Unown Pokemon Class
	public class Unown : Pokemon
	{

		public Unown(string nickname, int level)
		: base(
				201,
				SpecieUnown.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Unown() : base(
			201,
			SpecieUnown.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}