using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Yveltal Specie to store common natural stats of every {'abilities': ['dark-aura'], 'base_experience': 306, 'height': 58, 'id': 717, 'moves': ['razor-wind', 'cut', 'fly', 'disable', 'hyper-beam', 'toxic', 'psychic', 'double-team', 'dream-eater', 'sky-attack', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'heat-wave', 'torment', 'facade', 'taunt', 'knock-off', 'secret-power', 'hyper-voice', 'aerial-ace', 'block', 'dragon-claw', 'roost', 'tailwind', 'u-turn', 'embargo', 'sucker-punch', 'dark-pulse', 'air-slash', 'dragon-rush', 'focus-blast', 'giga-impact', 'shadow-claw', 'zen-headbutt', 'hone-claws', 'foul-play', 'round', 'sky-drop', 'acrobatics', 'hurricane', 'snarl', 'phantom-force', 'confide', 'oblivion-wing'], 'name': 'yveltal', 'stats': {'hp': 126, 'attack': 131, 'defense': 95, 'special-attack': 131, 'special-defense': 98, 'speed': 99}, 'types': ['dark', 'flying'], 'weight': 2030, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 45, 'color': 'red', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'イベルタル', 'ko': '이벨타르', 'zh-Hant': '伊裴爾塔爾', 'fr': 'Yveltal', 'de': 'Yveltal', 'es': 'Yveltal', 'it': 'Yveltal', 'en': 'Yveltal', 'ja': 'イベルタル', 'zh-Hans': '伊裴尔塔尔'}, 'genera': {'ja-Hrkt': 'はかいポケモン', 'ko': '파괴포켓몬', 'zh-Hant': '破壞寶可夢', 'fr': 'Pokémon Annihilation', 'de': 'Zerstörung', 'es': 'Pokémon Destrucción', 'it': 'Pokémon Distruzione', 'en': 'Destruction Pokémon', 'ja': 'はかいポケモン', 'zh-Hans': '破坏宝可梦'}}
	public class SpecieYveltal : PokemonSpecie
	{
#nullable enable
		private static SpecieYveltal? _instance = null;
#nullable restore
        public static SpecieYveltal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieYveltal();
                }
                return _instance;
            }
        }

		public SpecieYveltal() : base(
			"Yveltal",
			126, // HPs
			131, 95, // Attack & Defense
			131, 98, // Special Attack & Defense
			99			
		) {}
	}


	//Yveltal Pokemon Class
	public class Yveltal : Pokemon
	{

		public Yveltal(string nickname, int level) : base(
			717,
			SpecieYveltal.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Flying.Instance			
		) {}

		public Yveltal() : base(
			717,
			SpecieYveltal.Instance, // Pokemon Specie
			Dark.Instance, Flying.Instance			
		) {}
	}
}