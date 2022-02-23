using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seismitoad Specie to store common natural stats of every {'abilities': ['swift-swim', 'poison-touch', 'water-absorb'], 'base_experience': 229, 'height': 15, 'id': 537, 'moves': ['ice-punch', 'growl', 'supersonic', 'acid', 'hydro-pump', 'surf', 'bubble-beam', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'bubble', 'rest', 'rock-slide', 'substitute', 'snore', 'flail', 'protect', 'sludge-bomb', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'rock-smash', 'uproar', 'hail', 'facade', 'focus-punch', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'hyper-voice', 'rock-tomb', 'muddy-water', 'bounce', 'mud-shot', 'water-pulse', 'payback', 'fling', 'gastro-acid', 'aqua-ring', 'poison-jab', 'drain-punch', 'focus-blast', 'earth-power', 'giga-impact', 'stealth-rock', 'grass-knot', 'venoshock', 'sludge-wave', 'after-you', 'round', 'echoed-voice', 'scald', 'bulldoze', 'confide', 'infestation', 'power-up-punch'], 'name': 'seismitoad', 'stats': {'hp': 105, 'attack': 95, 'defense': 75, 'special-attack': 85, 'special-defense': 75, 'speed': 74}, 'types': ['water', 'ground'], 'weight': 620, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['water1'], 'names': {'ja-Hrkt': 'ガマゲロゲ', 'ko': '두빅굴', 'zh-Hant': '蟾蜍王', 'fr': 'Crapustule', 'de': 'Branawarz', 'es': 'Seismitoad', 'it': 'Seismitoad', 'en': 'Seismitoad', 'ja': 'ガマゲロゲ', 'zh-Hans': '蟾蜍王'}, 'genera': {'ja-Hrkt': 'しんどうポケモン', 'ko': '진동포켓몬', 'zh-Hant': '震動寶可夢', 'fr': 'Pokémon Vibration', 'de': 'Vibration', 'es': 'Pokémon Vibrante', 'it': 'Pokémon Vibrazione', 'en': 'Vibration Pokémon', 'ja': 'しんどうポケモン', 'zh-Hans': '振动宝可梦'}}
	public class SpecieSeismitoad : PokemonSpecie
	{
#nullable enable
		private static SpecieSeismitoad? _instance = null;
#nullable restore
        public static SpecieSeismitoad Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeismitoad();
                }
                return _instance;
            }
        }

		public SpecieSeismitoad() : base(
			"Seismitoad",
			105, // HPs
			95, 75, // Attack & Defense
			85, 75, // Special Attack & Defense
			74			
		) {}
	}


	//Seismitoad Pokemon Class
	public class Seismitoad : Pokemon
	{

		public Seismitoad(string nickname, int level) : base(
			537,
			SpecieSeismitoad.Instance, // Pokemon Specie
			nickname, level,
			Water.Instance, Ground.Instance			
		) {}

		public Seismitoad() : base(
			537,
			SpecieSeismitoad.Instance, // Pokemon Specie
			Water.Instance, Ground.Instance			
		) {}
	}
}