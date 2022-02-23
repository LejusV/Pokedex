using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Tepig Specie to store common natural stats of every {'abilities': ['blaze', 'thick-fat'], 'base_experience': 62, 'height': 5, 'id': 498, 'moves': ['tackle', 'body-slam', 'take-down', 'thrash', 'tail-whip', 'roar', 'ember', 'flamethrower', 'strength', 'solar-beam', 'toxic', 'double-team', 'defense-curl', 'smog', 'fire-blast', 'rest', 'substitute', 'snore', 'curse', 'protect', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'magnitude', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'helping-hand', 'superpower', 'yawn', 'endeavor', 'secret-power', 'overheat', 'odor-sleuth', 'rock-tomb', 'covet', 'gyro-ball', 'assurance', 'sucker-punch', 'flare-blitz', 'zen-headbutt', 'grass-knot', 'head-smash', 'heavy-slam', 'flame-charge', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'work-up', 'wild-charge', 'heat-crash', 'confide', 'burn-up'], 'name': 'tepig', 'stats': {'hp': 65, 'attack': 63, 'defense': 45, 'special-attack': 45, 'special-defense': 45, 'speed': 45}, 'types': ['fire'], 'weight': 99, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ポカブ', 'ko': '뚜꾸리', 'zh-Hant': '暖暖豬', 'fr': 'Gruikui', 'de': 'Floink', 'es': 'Tepig', 'it': 'Tepig', 'en': 'Tepig', 'ja': 'ポカブ', 'zh-Hans': '暖暖猪'}, 'genera': {'ja-Hrkt': 'ひぶたポケモン', 'ko': '불돼지포켓몬', 'zh-Hant': '火豬寶可夢', 'fr': 'Pokémon Cochon Feu', 'de': 'Feuerferkel', 'es': 'Pokémon Cerdo Fuego', 'it': 'Pokémon Suinfuoco', 'en': 'Fire Pig Pokémon', 'ja': 'ひぶたポケモン', 'zh-Hans': '火猪宝可梦'}}
	public class SpecieTepig : PokemonSpecie
	{
#nullable enable
		private static SpecieTepig? _instance = null;
#nullable restore
        public static SpecieTepig Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTepig();
                }
                return _instance;
            }
        }

		public SpecieTepig() : base(
			"Tepig",
			65, // HPs
			63, 45, // Attack & Defense
			45, 45, // Special Attack & Defense
			45			
		) {}
	}


	//Tepig Pokemon Class
	public class Tepig : Pokemon
	{

		public Tepig(string nickname, int level) : base(
			498,
			SpecieTepig.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Tepig() : base(
			498,
			SpecieTepig.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}