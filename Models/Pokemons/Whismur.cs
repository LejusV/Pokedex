using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Whismur Specie to store common natural stats of every {'abilities': ['soundproof', 'rattled'], 'base_experience': 48, 'height': 6, 'id': 293, 'moves': ['pound', 'mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'whirlwind', 'stomp', 'mega-kick', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'roar', 'supersonic', 'flamethrower', 'ice-beam', 'blizzard', 'counter', 'seismic-toss', 'solar-beam', 'toxic', 'mimic', 'screech', 'double-team', 'smokescreen', 'defense-curl', 'fire-blast', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'uproar', 'facade', 'smelling-salts', 'endeavor', 'secret-power', 'hyper-voice', 'astonish', 'fake-tears', 'extrasensory', 'howl', 'shock-wave', 'water-pulse', 'hammer-arm', 'natural-gift', 'fling', 'zen-headbutt', 'captivate', 'synchronoise', 'round', 'echoed-voice', 'circle-throw', 'incinerate', 'retaliate', 'work-up', 'disarming-voice', 'confide'], 'name': 'whismur', 'stats': {'hp': 64, 'attack': 51, 'defense': 23, 'special-attack': 51, 'special-defense': 23, 'speed': 28}, 'types': ['normal'], 'weight': 163, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'pink', 'shape': 'upright', 'habitat': 'cave', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['monster', 'ground'], 'names': {'ja-Hrkt': 'ゴニョニョ', 'roomaji': 'Gonyonyo', 'ko': '소곤룡', 'zh-Hant': '咕妞妞', 'fr': 'Chuchmur', 'de': 'Flurmel', 'es': 'Whismur', 'it': 'Whismur', 'en': 'Whismur', 'ja': 'ゴニョニョ', 'zh-Hans': '咕妞妞'}, 'genera': {'ja-Hrkt': 'ささやきポケモン', 'ko': '속삭임포켓몬', 'zh-Hant': '細語寶可夢', 'fr': 'Pokémon Chuchoteur', 'de': 'Flüster', 'es': 'Pokémon Susurro', 'it': 'Pokémon Sussurro', 'en': 'Whisper Pokémon', 'ja': 'ささやきポケモン', 'zh-Hans': '细语宝可梦'}}
	public class SpecieWhismur : PokemonSpecie
	{
#nullable enable
		private static SpecieWhismur? _instance = null;
#nullable restore
        public static SpecieWhismur Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWhismur();
                }
                return _instance;
            }
        }

		public SpecieWhismur() : base(
			"Whismur",
			64, // HPs
			51, 23, // Attack & Defense
			51, 23, // Special Attack & Defense
			28			
		) {}
	}


	//Whismur Pokemon Class
	public class Whismur : Pokemon
	{

		public Whismur(string nickname, int level)
		: base(
				293,
				SpecieWhismur.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Whismur() : base(
			293,
			SpecieWhismur.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}