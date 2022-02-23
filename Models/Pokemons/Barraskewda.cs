using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Barraskewda Specie to store common natural stats of every {'abilities': ['swift-swim', 'propeller-tail'], 'base_experience': 172, 'height': 13, 'id': 847, 'moves': [], 'name': 'barraskewda', 'stats': {'hp': 61, 'attack': 123, 'defense': 60, 'special-attack': 60, 'special-defense': 50, 'speed': 136}, 'types': ['water'], 'weight': 300, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'fish', 'habitat': None, 'generation': 'generation-viii', 'growth_rate': 'slow', 'egg_groups': [], 'names': {'ja-Hrkt': 'カマスジョー', 'ko': '꼬치조', 'zh-Hant': '戽斗尖梭', 'fr': 'Hastacuda', 'de': 'Barrakiefa', 'es': 'Barraskewda', 'it': 'Barraskewda', 'en': 'Barraskewda', 'ja': 'カマスジョー', 'zh-Hans': '戽斗尖梭'}, 'genera': {'ja-Hrkt': 'くしざしポケモン', 'ko': '꼬치포켓몬', 'zh-Hant': '穿刺寶可夢', 'fr': 'Pokémon Transperceur', 'de': 'Spieß', 'es': 'Pokémon Ensarta', 'it': 'Pokémon Spiedo', 'en': 'Skewer Pokémon', 'ja': 'くしざしポケモン', 'zh-Hans': '穿刺宝可梦'}}
	public class SpecieBarraskewda : PokemonSpecie
	{
#nullable enable
		private static SpecieBarraskewda? _instance = null;
#nullable restore
        public static SpecieBarraskewda Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBarraskewda();
                }
                return _instance;
            }
        }

		public SpecieBarraskewda() : base(
			"Barraskewda",
			61, // HPs
			123, 60, // Attack & Defense
			60, 50, // Special Attack & Defense
			136			
		) {}
	}


	//Barraskewda Pokemon Class
	public class Barraskewda : Pokemon
	{

		public Barraskewda(string nickname, int level) : base(
			847,
			SpecieBarraskewda.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance			
		) {}

		public Barraskewda() : base(
			847,
			SpecieBarraskewda.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}