using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Houndour Specie to store common natural stats of every {'abilities': ['early-bird', 'flash-fire', 'unnerve'], 'base_experience': 66, 'height': 6, 'id': 228, 'moves': ['headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'roar', 'ember', 'flamethrower', 'counter', 'solar-beam', 'fire-spin', 'toxic', 'rage', 'mimic', 'double-team', 'smog', 'fire-blast', 'swift', 'dream-eater', 'rest', 'super-fang', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'reversal', 'spite', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'destiny-bond', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'beat-up', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'taunt', 'role-play', 'snatch', 'secret-power', 'hyper-voice', 'overheat', 'odor-sleuth', 'howl', 'natural-gift', 'feint', 'payback', 'embargo', 'punishment', 'sucker-punch', 'dark-pulse', 'nasty-plot', 'thunder-fang', 'fire-fang', 'captivate', 'flame-charge', 'foul-play', 'round', 'incinerate', 'retaliate', 'inferno', 'snarl', 'confide'], 'name': 'houndour', 'stats': {'hp': 45, 'attack': 60, 'defense': 30, 'special-attack': 80, 'special-defense': 50, 'speed': 65}, 'types': ['dark', 'fire'], 'weight': 108, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'black', 'shape': 'quadruped', 'habitat': 'rough-terrain', 'generation': 'generation-ii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'デルビル', 'roomaji': 'Delvil', 'ko': '델빌', 'zh-Hant': '戴魯比', 'fr': 'Malosse', 'de': 'Hunduster', 'es': 'Houndour', 'it': 'Houndour', 'en': 'Houndour', 'ja': 'デルビル', 'zh-Hans': '戴鲁比'}, 'genera': {'ja-Hrkt': 'ダークポケモン', 'ko': '다크포켓몬', 'zh-Hant': '陰暗寶可夢', 'fr': 'Pokémon Sombre', 'de': 'Hades', 'es': 'Pokémon Siniestro', 'it': 'Pokémon Buio', 'en': 'Dark Pokémon', 'ja': 'ダークポケモン', 'zh-Hans': '阴暗宝可梦'}}
	public class SpecieHoundour : PokemonSpecie
	{
#nullable enable
		private static SpecieHoundour? _instance = null;
#nullable restore
        public static SpecieHoundour Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieHoundour();
                }
                return _instance;
            }
        }

		public SpecieHoundour() : base(
			"Houndour",
			45, // HPs
			60, 30, // Attack & Defense
			80, 50, // Special Attack & Defense
			65			
		) {}
	}


	//Houndour Pokemon Class
	public class Houndour : Pokemon
	{

		public Houndour(string nickname, int level) : base(
			228,
			SpecieHoundour.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Fire.Instance			
		) {}

		public Houndour() : base(
			228,
			SpecieHoundour.Instance, // Pokemon Specie
			Dark.Instance, Fire.Instance			
		) {}
	}
}