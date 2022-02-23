using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Mudsdale Specie to store common natural stats of every {'abilities': ['own-tempo', 'stamina', 'inner-focus'], 'base_experience': 175, 'height': 25, 'id': 750, 'moves': ['stomp', 'double-kick', 'mega-kick', 'roar', 'counter', 'earthquake', 'toxic', 'double-team', 'bide', 'rest', 'rock-slide', 'substitute', 'protect', 'mud-slap', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'facade', 'superpower', 'mud-sport', 'rock-tomb', 'iron-defense', 'payback', 'focus-blast', 'giga-impact', 'heavy-slam', 'low-sweep', 'round', 'bulldoze', 'rototiller', 'confide', 'high-horsepower'], 'name': 'mudsdale', 'stats': {'hp': 100, 'attack': 125, 'defense': 100, 'special-attack': 55, 'special-defense': 85, 'speed': 35}, 'types': ['ground'], 'weight': 9200, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バンバドロ', 'ko': '만마드', 'zh-Hant': '重泥挽馬', 'fr': 'Bourrinos', 'de': 'Pampross', 'es': 'Mudsdale', 'it': 'Mudsdale', 'en': 'Mudsdale', 'ja': 'バンバドロ', 'zh-Hans': '重泥挽马'}, 'genera': {'ja-Hrkt': 'ばんばポケモン', 'ko': '만마포켓몬', 'zh-Hant': '挽馬寶可夢', 'fr': 'Pokémon Cheval Trait', 'de': 'Zugpferd', 'es': 'Pokémon Caballo Tiro', 'it': 'Pokémon Fortequino', 'en': 'Draft Horse Pokémon', 'ja': 'ばんばポケモン', 'zh-Hans': '挽马宝可梦'}}
	public class SpecieMudsdale : PokemonSpecie
	{
#nullable enable
		private static SpecieMudsdale? _instance = null;
#nullable restore
        public static SpecieMudsdale Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMudsdale();
                }
                return _instance;
            }
        }

		public SpecieMudsdale() : base(
			"Mudsdale",
			100, // HPs
			125, 100, // Attack & Defense
			55, 85, // Special Attack & Defense
			35			
		) {}
	}


	//Mudsdale Pokemon Class
	public class Mudsdale : Pokemon
	{

		public Mudsdale(string nickname, int level) : base(
			750,
			SpecieMudsdale.Instance, // Pokemon Specie
			nickname, level,
			Ground.Instance			
		) {}

		public Mudsdale() : base(
			750,
			SpecieMudsdale.Instance, // Pokemon Specie
			Ground.Instance			
		) {}
	}
}