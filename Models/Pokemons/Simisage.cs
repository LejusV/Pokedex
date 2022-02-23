using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Simisage Specie to store common natural stats of every {'abilities': ['gluttony', 'overgrow'], 'base_experience': 174, 'height': 11, 'id': 512, 'moves': ['cut', 'leer', 'hyper-beam', 'low-kick', 'solar-beam', 'dig', 'toxic', 'double-team', 'lick', 'flash', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'role-play', 'superpower', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'rock-tomb', 'covet', 'payback', 'fling', 'gastro-acid', 'worry-seed', 'seed-bomb', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-claw', 'gunk-shot', 'grass-knot', 'hone-claws', 'low-sweep', 'round', 'acrobatics', 'grass-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'simisage', 'stats': {'hp': 75, 'attack': 98, 'defense': 63, 'special-attack': 98, 'special-defense': 63, 'speed': 101}, 'types': ['grass'], 'weight': 305, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 75, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヤナッキー', 'ko': '야나키', 'zh-Hant': '花椰猿', 'fr': 'Feuiloutan', 'de': 'Vegichita', 'es': 'Simisage', 'it': 'Simisage', 'en': 'Simisage', 'ja': 'ヤナッキー', 'zh-Hans': '花椰猿'}, 'genera': {'ja-Hrkt': 'とげざるポケモン', 'ko': '가시원숭이포켓몬', 'zh-Hant': '刺猴寶可夢', 'fr': 'Pokémon Singépine', 'de': 'Stachelaffe', 'es': 'Pokémon Mono Pincho', 'it': 'Pokémon Spinpanzé', 'en': 'Thorn Monkey Pokémon', 'ja': 'とげざるポケモン', 'zh-Hans': '刺猴宝可梦'}}
	public class SpecieSimisage : PokemonSpecie
	{
#nullable enable
		private static SpecieSimisage? _instance = null;
#nullable restore
        public static SpecieSimisage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSimisage();
                }
                return _instance;
            }
        }

		public SpecieSimisage() : base(
			"Simisage",
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101			
		) {}
	}


	//Simisage Pokemon Class
	public class Simisage : Pokemon
	{

		public Simisage(string nickname, int level) : base(
			512,
			SpecieSimisage.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Simisage() : base(
			512,
			SpecieSimisage.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}