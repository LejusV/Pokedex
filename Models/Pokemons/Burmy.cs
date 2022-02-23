using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Burmy Specie to store common natural stats of every {'abilities': ['shed-skin', 'overcoat'], 'base_experience': 45, 'height': 2, 'id': 412, 'moves': ['tackle', 'string-shot', 'snore', 'protect', 'hidden-power', 'bug-bite', 'electroweb'], 'name': 'burmy', 'stats': {'hp': 40, 'attack': 29, 'defense': 45, 'special-attack': 29, 'special-defense': 45, 'speed': 36}, 'types': ['bug'], 'weight': 34, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 120, 'color': 'green', 'shape': 'blob', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['bug'], 'names': {'ja-Hrkt': 'ミノムッチ', 'roomaji': 'Minomucchi', 'ko': '도롱충이', 'zh-Hant': '結草兒', 'fr': 'Cheniti', 'de': 'Burmy', 'es': 'Burmy', 'it': 'Burmy', 'en': 'Burmy', 'ja': 'ミノムッチ', 'zh-Hans': '结草儿'}, 'genera': {'ja-Hrkt': 'みのむしポケモン', 'ko': '도롱이벌레포켓몬', 'zh-Hant': '蓑衣蟲寶可夢', 'fr': 'Pokémon Ver Caché', 'de': 'Beutelwurm', 'es': 'Pokémon Larva', 'it': 'Pokémon Larva', 'en': 'Bagworm Pokémon', 'ja': 'みのむしポケモン', 'zh-Hans': '蓑衣虫宝可梦'}}
	public class SpecieBurmy : PokemonSpecie
	{
#nullable enable
		private static SpecieBurmy? _instance = null;
#nullable restore
        public static SpecieBurmy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBurmy();
                }
                return _instance;
            }
        }

		public SpecieBurmy() : base(
			"Burmy",
			40, // HPs
			29, 45, // Attack & Defense
			29, 45, // Special Attack & Defense
			36			
		) {}
	}


	//Burmy Pokemon Class
	public class Burmy : Pokemon
	{

		public Burmy(string nickname, int level) : base(
			412,
			SpecieBurmy.Instance, // Pokemon Specie
			nickname, level,
			Bug.Instance			
		) {}

		public Burmy() : base(
			412,
			SpecieBurmy.Instance, // Pokemon Specie
			Bug.Instance			
		) {}
	}
}