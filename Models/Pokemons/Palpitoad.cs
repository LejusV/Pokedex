using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Palpitoad Specie to store common natural stats of every {'abilities': ['swift-swim', 'hydration', 'water-absorb'], 'base_experience': 134, 'height': 8, 'id': 536, 'moves': ['growl', 'supersonic', 'hydro-pump', 'surf', 'bubble-beam', 'toxic', 'double-team', 'bubble', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'uproar', 'hail', 'facade', 'focus-punch', 'endeavor', 'secret-power', 'hyper-voice', 'muddy-water', 'bounce', 'mud-shot', 'water-pulse', 'gastro-acid', 'aqua-ring', 'earth-power', 'stealth-rock', 'sludge-wave', 'after-you', 'round', 'echoed-voice', 'scald', 'bulldoze', 'confide', 'infestation'], 'name': 'palpitoad', 'stats': {'hp': 75, 'attack': 65, 'defense': 55, 'special-attack': 65, 'special-defense': 55, 'speed': 69}, 'types': ['water', 'ground'], 'weight': 170, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ガマガル', 'ko': '두까비', 'zh-Hant': '藍蟾蜍', 'fr': 'Batracné', 'de': 'Mebrana', 'es': 'Palpitoad', 'it': 'Palpitoad', 'en': 'Palpitoad', 'ja': 'ガマガル', 'zh-Hans': '蓝蟾蜍'}, 'genera': {'ja-Hrkt': 'しんどうポケモン', 'ko': '진동포켓몬', 'zh-Hant': '震動寶可夢', 'fr': 'Pokémon Vibration', 'de': 'Vibration', 'es': 'Pokémon Vibrante', 'it': 'Pokémon Vibrazione', 'en': 'Vibration Pokémon', 'ja': 'しんどうポケモン', 'zh-Hans': '振动宝可梦'}}
	public class SpeciePalpitoad : PokemonSpecie
	{
#nullable enable
		private static SpeciePalpitoad? _instance = null;
#nullable restore
        public static SpeciePalpitoad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePalpitoad();
                }
                return _instance;
            }
        }

		public SpeciePalpitoad() : base(
			"Palpitoad",
			75, // HPs
			65, 55, // Attack & Defense
			65, 55, // Special Attack & Defense
			69			
		) {}
	}


	//Palpitoad Pokemon Class
	public class Palpitoad : Pokemon
	{

		public Palpitoad(string nickname, int level) : base(
			536,
			SpeciePalpitoad.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ground.Instance			
		) {}

		public Palpitoad() : base(
			536,
			SpeciePalpitoad.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}