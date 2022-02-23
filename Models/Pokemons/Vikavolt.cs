using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vikavolt Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 225, 'height': 15, 'id': 738, 'moves': ['vice-grip', 'guillotine', 'bite', 'hyper-beam', 'solar-beam', 'string-shot', 'thunderbolt', 'thunder-wave', 'thunder', 'dig', 'toxic', 'agility', 'double-team', 'light-screen', 'rest', 'substitute', 'protect', 'mud-slap', 'zap-cannon', 'swagger', 'spark', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'facade', 'charge', 'roost', 'poison-jab', 'air-slash', 'x-scissor', 'bug-buzz', 'energy-ball', 'giga-impact', 'flash-cannon', 'bug-bite', 'charge-beam', 'round', 'sky-drop', 'acrobatics', 'volt-switch', 'wild-charge', 'confide'], 'name': 'vikavolt', 'stats': {'hp': 77, 'attack': 70, 'defense': 90, 'special-attack': 145, 'special-defense': 75, 'speed': 43}, 'types': ['bug', 'electric'], 'weight': 450, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'armor', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'クワガノン', 'ko': '투구뿌논', 'zh-Hant': '鍬農砲蟲', 'fr': 'Lucanon', 'de': 'Donarion', 'es': 'Vikavolt', 'it': 'Vikavolt', 'en': 'Vikavolt', 'ja': 'クワガノン', 'zh-Hans': '锹农炮虫'}, 'genera': {'ja-Hrkt': 'くわがたポケモン', 'ko': '뿔집게포켓몬', 'zh-Hant': '鍬形蟲寶可夢', 'fr': 'Pokémon Scarabée', 'de': 'Kneifkäfer', 'es': 'Pokémon Escarabajo', 'it': 'Pokémon Cervolante', 'en': 'Stag Beetle Pokémon', 'ja': 'くわがたポケモン', 'zh-Hans': '锹形虫宝可梦'}}
	public class SpecieVikavolt : PokemonSpecie
	{
#nullable enable
		private static SpecieVikavolt? _instance = null;
#nullable restore
        public static SpecieVikavolt Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVikavolt();
                }
                return _instance;
            }
        }

		public SpecieVikavolt() : base(
			"Vikavolt",
			77, // HPs
			70, 90, // Attack & Defense
			145, 75, // Special Attack & Defense
			43			
		) {}
	}


	//Vikavolt Pokemon Class
	public class Vikavolt : Pokemon
	{

		public Vikavolt(string nickname, int level) : base(
			738,
			SpecieVikavolt.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance, Electric.Instance			
		) {}

		public Vikavolt() : base(
			738,
			SpecieVikavolt.Instance, // Pokemon Specie
			Bug.Instance, Electric.Instance			
		) {}
	}
}