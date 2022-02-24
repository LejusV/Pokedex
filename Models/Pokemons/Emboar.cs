using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Emboar Specie to store common natural stats of every {'abilities': ['blaze', 'reckless'], 'base_experience': 238, 'height': 16, 'id': 500, 'moves': ['fire-punch', 'thunder-punch', 'tackle', 'take-down', 'tail-whip', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'low-kick', 'strength', 'solar-beam', 'earthquake', 'toxic', 'double-team', 'defense-curl', 'smog', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'arm-thrust', 'blast-burn', 'overheat', 'odor-sleuth', 'rock-tomb', 'block', 'bulk-up', 'covet', 'hammer-arm', 'gyro-ball', 'assurance', 'fling', 'flare-blitz', 'poison-jab', 'focus-blast', 'giga-impact', 'zen-headbutt', 'iron-head', 'stone-edge', 'grass-knot', 'head-smash', 'smack-down', 'flame-charge', 'low-sweep', 'round', 'echoed-voice', 'scald', 'incinerate', 'fire-pledge', 'bulldoze', 'work-up', 'wild-charge', 'heat-crash', 'confide', 'power-up-punch'], 'name': 'emboar', 'stats': {'hp': 110, 'attack': 123, 'defense': 65, 'special-attack': 100, 'special-defense': 65, 'speed': 65}, 'types': ['fire', 'fighting'], 'weight': 1500, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'エンブオー', 'ko': '염무왕', 'zh-Hant': '炎武王', 'fr': 'Roitiflam', 'de': 'Flambirex', 'es': 'Emboar', 'it': 'Emboar', 'en': 'Emboar', 'ja': 'エンブオー', 'zh-Hans': '炎武王'}, 'genera': {'ja-Hrkt': 'おおひぶたポケモン', 'ko': '큰불돼지포켓몬', 'zh-Hant': '大火豬寶可夢', 'fr': 'Pokémon Grochon Feu', 'de': 'Feuerschwein', 'es': 'Pokémon Cerdo Ígneo', 'it': 'Pokémon Suincendio', 'en': 'Mega Fire Pig Pokémon', 'ja': 'おおひぶたポケモン', 'zh-Hans': '大火猪宝可梦'}}
	public class SpecieEmboar : PokemonSpecie
	{
#nullable enable
		private static SpecieEmboar? _instance = null;
#nullable restore
        public static SpecieEmboar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEmboar();
                }
                return _instance;
            }
        }

		public SpecieEmboar() : base(
			"Emboar",
			110, // HPs
			123, 65, // Attack & Defense
			100, 65, // Special Attack & Defense
			65			
		) {}
	}


	//Emboar Pokemon Class
	public class Emboar : Pokemon
	{

		public Emboar(string nickname, int level)
		: base(
				500,
				SpecieEmboar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Emboar() : base(
			500,
			SpecieEmboar.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
	}
}