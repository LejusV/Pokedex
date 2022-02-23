using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Beldum Specie to store common natural stats of every {'abilities': ['clear-body', 'light-metal'], 'base_experience': 60, 'height': 6, 'id': 374, 'moves': ['headbutt', 'take-down', 'iron-defense', 'zen-headbutt', 'iron-head'], 'name': 'beldum', 'stats': {'hp': 40, 'attack': 55, 'defense': 80, 'special-attack': 35, 'special-defense': 60, 'speed': 30}, 'types': ['steel', 'psychic'], 'weight': 952, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'blob', 'habitat': 'rough-terrain', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['mineral'], 'names': {'ja-Hrkt': 'ダンバル', 'roomaji': 'Dumbber', 'ko': '메탕', 'zh-Hant': '鐵啞鈴', 'fr': 'Terhal', 'de': 'Tanhel', 'es': 'Beldum', 'it': 'Beldum', 'en': 'Beldum', 'ja': 'ダンバル', 'zh-Hans': '铁哑铃'}, 'genera': {'ja-Hrkt': 'てっきゅうポケモン', 'ko': '철공포켓몬', 'zh-Hant': '鐵球寶可夢', 'fr': 'Pokémon Boulefer', 'de': 'Eisenkugel', 'es': 'Pokémon Bola Hierro', 'it': 'Pokémon Ferrosfera', 'en': 'Iron Ball Pokémon', 'ja': 'てっきゅうポケモン', 'zh-Hans': '铁球宝可梦'}}
	public class SpecieBeldum : PokemonSpecie
	{
#nullable enable
		private static SpecieBeldum? _instance = null;
#nullable restore
        public static SpecieBeldum Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBeldum();
                }
                return _instance;
            }
        }

		public SpecieBeldum() : base(
			"Beldum",
			40, // HPs
			55, 80, // Attack & Defense
			35, 60, // Special Attack & Defense
			30			
		) {}
	}


	//Beldum Pokemon Class
	public class Beldum : Pokemon
	{

		public Beldum(string nickname, int level) : base(
			374,
			SpecieBeldum.Instance, // Pokemon Specie
			nickname, level,
			Steel.Instance, Psychic.Instance			
		) {}

		public Beldum() : base(
			374,
			SpecieBeldum.Instance, // Pokemon Specie
			Steel.Instance, Psychic.Instance			
		) {}
	}
}