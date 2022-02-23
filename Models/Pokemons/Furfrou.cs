using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Furfrou Specie to store common natural stats of every {'abilities': ['fur-coat'], 'base_experience': 165, 'height': 12, 'id': 676, 'moves': ['sand-attack', 'headbutt', 'tackle', 'take-down', 'tail-whip', 'bite', 'growl', 'roar', 'surf', 'thunder-wave', 'dig', 'toxic', 'mimic', 'double-team', 'flash', 'rest', 'substitute', 'snore', 'protect', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'rock-smash', 'uproar', 'facade', 'helping-hand', 'role-play', 'endeavor', 'refresh', 'secret-power', 'hyper-voice', 'odor-sleuth', 'u-turn', 'last-resort', 'sucker-punch', 'dark-pulse', 'giga-impact', 'zen-headbutt', 'captivate', 'grass-knot', 'charge-beam', 'round', 'echoed-voice', 'retaliate', 'work-up', 'wild-charge', 'cotton-guard', 'snarl', 'confide', 'baby-doll-eyes'], 'name': 'furfrou', 'stats': {'hp': 75, 'attack': 80, 'defense': 60, 'special-attack': 65, 'special-defense': 90, 'speed': 102}, 'types': ['normal'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 160, 'color': 'white', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'トリミアン', 'ko': '트리미앙', 'zh-Hant': '多麗米亞', 'fr': 'Couafarel', 'de': 'Coiffwaff', 'es': 'Furfrou', 'it': 'Furfrou', 'en': 'Furfrou', 'ja': 'トリミアン', 'zh-Hans': '多丽米亚'}, 'genera': {'ja-Hrkt': 'プードルポケモン', 'ko': '푸들포켓몬', 'zh-Hant': '貴賓犬寶可夢', 'fr': 'Pokémon Caniche', 'de': 'Pudel', 'es': 'Pokémon Caniche', 'it': 'Pokémon Barboncino', 'en': 'Poodle Pokémon', 'ja': 'プードルポケモン', 'zh-Hans': '贵宾犬宝可梦'}}
	public class SpecieFurfrou : PokemonSpecie
	{
#nullable enable
		private static SpecieFurfrou? _instance = null;
#nullable restore
        public static SpecieFurfrou Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieFurfrou();
                }
                return _instance;
            }
        }

		public SpecieFurfrou() : base(
			"Furfrou",
			75, // HPs
			80, 60, // Attack & Defense
			65, 90, // Special Attack & Defense
			102			
		) {}
	}


	//Furfrou Pokemon Class
	public class Furfrou : Pokemon
	{

		public Furfrou(string nickname, int level) : base(
			676,
			SpecieFurfrou.Instance, // Pokemon Specie
			nickname, level,
			Normal.Instance			
		) {}

		public Furfrou() : base(
			676,
			SpecieFurfrou.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}