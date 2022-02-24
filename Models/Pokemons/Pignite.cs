using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pignite Specie to store common natural stats of every {'abilities': ['blaze', 'thick-fat'], 'base_experience': 146, 'height': 10, 'id': 499, 'moves': ['fire-punch', 'thunder-punch', 'tackle', 'take-down', 'tail-whip', 'roar', 'ember', 'flamethrower', 'low-kick', 'strength', 'solar-beam', 'toxic', 'double-team', 'defense-curl', 'smog', 'fire-blast', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'rollout', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'arm-thrust', 'overheat', 'odor-sleuth', 'rock-tomb', 'covet', 'gyro-ball', 'assurance', 'fling', 'flare-blitz', 'poison-jab', 'focus-blast', 'zen-headbutt', 'stone-edge', 'grass-knot', 'head-smash', 'flame-charge', 'low-sweep', 'round', 'echoed-voice', 'incinerate', 'fire-pledge', 'bulldoze', 'work-up', 'wild-charge', 'heat-crash', 'confide', 'power-up-punch'], 'name': 'pignite', 'stats': {'hp': 90, 'attack': 93, 'defense': 55, 'special-attack': 70, 'special-defense': 55, 'speed': 55}, 'types': ['fire', 'fighting'], 'weight': 555, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'チャオブー', 'ko': '차오꿀', 'zh-Hant': '炒炒豬', 'fr': 'Grotichon', 'de': 'Ferkokel', 'es': 'Pignite', 'it': 'Pignite', 'en': 'Pignite', 'ja': 'チャオブー', 'zh-Hans': '炒炒猪'}, 'genera': {'ja-Hrkt': 'ひぶたポケモン', 'ko': '불돼지포켓몬', 'zh-Hant': '火豬寶可夢', 'fr': 'Pokémon Cochon Feu', 'de': 'Feuerferkel', 'es': 'Pokémon Cerdo Fuego', 'it': 'Pokémon Suinfuoco', 'en': 'Fire Pig Pokémon', 'ja': 'ひぶたポケモン', 'zh-Hans': '火猪宝可梦'}}
	public class SpeciePignite : PokemonSpecie
	{
#nullable enable
		private static SpeciePignite? _instance = null;
#nullable restore
        public static SpeciePignite Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePignite();
                }
                return _instance;
            }
        }

		public SpeciePignite() : base(
			"Pignite",
			90, // HPs
			93, 55, // Attack & Defense
			70, 55, // Special Attack & Defense
			55			
		) {}
	}


	//Pignite Pokemon Class
	public class Pignite : Pokemon
	{

		public Pignite(string nickname, int level)
		: base(
				499,
				SpeciePignite.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Pignite() : base(
			499,
			SpeciePignite.Instance, // Pokemon Specie
			Fire.Instance, Fighting.Instance			
		) {}
	}
}