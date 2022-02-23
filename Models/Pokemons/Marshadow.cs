using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Marshadow Specie to store common natural stats of every {'abilities': ['technician'], 'base_experience': 270, 'height': 7, 'id': 802, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'jump-kick', 'rolling-kick', 'counter', 'toxic', 'double-team', 'rest', 'rock-slide', 'substitute', 'thief', 'protect', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'psych-up', 'shadow-ball', 'will-o-wisp', 'facade', 'role-play', 'brick-break', 'endeavor', 'rock-tomb', 'shadow-punch', 'bulk-up', 'calm-mind', 'feint', 'close-combat', 'payback', 'assurance', 'fling', 'copycat', 'sucker-punch', 'force-palm', 'poison-jab', 'drain-punch', 'focus-blast', 'giga-impact', 'shadow-claw', 'shadow-sneak', 'stone-edge', 'grass-knot', 'smack-down', 'low-sweep', 'round', 'echoed-voice', 'acrobatics', 'work-up', 'confide', 'laser-focus', 'spectral-thief'], 'name': 'marshadow', 'stats': {'hp': 90, 'attack': 125, 'defense': 80, 'special-attack': 90, 'special-defense': 90, 'speed': 125}, 'types': ['fighting', 'ghost'], 'weight': 222, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'マーシャドー', 'ko': '마샤도', 'zh-Hant': '瑪夏多', 'fr': 'Marshadow', 'de': 'Marshadow', 'es': 'Marshadow', 'it': 'Marshadow', 'en': 'Marshadow', 'ja': 'マーシャドー', 'zh-Hans': '玛夏多'}, 'genera': {'ja-Hrkt': 'かげすみポケモン', 'ko': '그림자살이포켓몬', 'zh-Hant': '棲影寶可夢', 'fr': 'Pokémon Ombrefuge', 'de': 'Dunkelwesen', 'es': 'Pokémon Morasombra', 'it': 'Pokémon Vivinombra', 'en': 'Gloomdweller Pokémon', 'ja': 'かげすみポケモン', 'zh-Hans': '栖影宝可梦'}}
	public class SpecieMarshadow : PokemonSpecie
	{
#nullable enable
		private static SpecieMarshadow? _instance = null;
#nullable restore
        public static SpecieMarshadow Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMarshadow();
                }
                return _instance;
            }
        }

		public SpecieMarshadow() : base(
			"Marshadow",
			90, // HPs
			125, 80, // Attack & Defense
			90, 90, // Special Attack & Defense
			125			
		) {}
	}


	//Marshadow Pokemon Class
	public class Marshadow : Pokemon
	{

		public Marshadow(string nickname, int level) : base(
			802,
			SpecieMarshadow.Instance, // Pokemon Specie
			nickname, level,
			Fighting.Instance, Ghost.Instance			
		) {}

		public Marshadow() : base(
			802,
			SpecieMarshadow.Instance, // Pokemon Specie
			Fighting.Instance, Ghost.Instance			
		) {}
	}
}