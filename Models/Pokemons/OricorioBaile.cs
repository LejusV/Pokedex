using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Oricorio-Baile Specie to store common natural stats of every {'abilities': ['dancer'], 'base_experience': 167, 'height': 6, 'id': 741, 'moves': ['pound', 'double-slap', 'swords-dance', 'fly', 'growl', 'peck', 'toxic', 'agility', 'double-team', 'mirror-move', 'rest', 'substitute', 'protect', 'sandstorm', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'baton-pass', 'hidden-power', 'facade', 'taunt', 'helping-hand', 'feather-dance', 'teeter-dance', 'air-cutter', 'aerial-ace', 'calm-mind', 'roost', 'pluck', 'tailwind', 'u-turn', 'embargo', 'air-slash', 'captivate', 'round', 'quash', 'acrobatics', 'work-up', 'hurricane', 'confide', 'revelation-dance'], 'name': 'oricorio-baile', 'stats': {'hp': 75, 'attack': 70, 'defense': 70, 'special-attack': 98, 'special-defense': 70, 'speed': 93}, 'types': ['fire', 'flying'], 'weight': 34, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 6, 'capture_rate': 45, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'オドリドリ', 'ko': '춤추새', 'zh-Hant': '花舞鳥', 'fr': 'Plumeline', 'de': 'Choreogel', 'es': 'Oricorio', 'it': 'Oricorio', 'en': 'Oricorio', 'ja': 'オドリドリ', 'zh-Hans': '花舞鸟'}, 'genera': {'ja-Hrkt': 'ダンスポケモン', 'ko': '댄스포켓몬', 'zh-Hant': '舞蹈寶可夢', 'fr': 'Pokémon Danse', 'de': 'Tanz', 'es': 'Pokémon Danza', 'it': 'Pokémon Danza', 'en': 'Dancing Pokémon', 'ja': 'ダンスポケモン', 'zh-Hans': '舞蹈宝可梦'}}
	public class SpecieOricorioBaile : PokemonSpecie
	{
#nullable enable
		private static SpecieOricorioBaile? _instance = null;
#nullable restore
        public static SpecieOricorioBaile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOricorioBaile();
                }
                return _instance;
            }
        }

		public SpecieOricorioBaile() : base(
			"Oricorio-Baile",
			75, // HPs
			70, 70, // Attack & Defense
			98, 70, // Special Attack & Defense
			93			
		) {}
	}


	//Oricorio-Baile Pokemon Class
	public class OricorioBaile : Pokemon
	{

		public OricorioBaile(string nickname, int level) : base(
			741,
			SpecieOricorioBaile.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance, Flying.Instance			
		) {}

		public OricorioBaile() : base(
			741,
			SpecieOricorioBaile.Instance, // Pokemon Specie
			Fire.Instance, Flying.Instance			
		) {}
	}
}