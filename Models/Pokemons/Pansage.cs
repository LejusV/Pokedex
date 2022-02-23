using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pansage Specie to store common natural stats of every {'abilities': ['gluttony', 'overgrow'], 'base_experience': 63, 'height': 6, 'id': 511, 'moves': ['scratch', 'cut', 'vine-whip', 'leer', 'bite', 'low-kick', 'leech-seed', 'solar-beam', 'dig', 'toxic', 'double-team', 'lick', 'flash', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'protect', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'synthesis', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'nature-power', 'taunt', 'helping-hand', 'role-play', 'recycle', 'knock-off', 'endeavor', 'secret-power', 'astonish', 'rock-tomb', 'grass-whistle', 'tickle', 'bullet-seed', 'covet', 'magical-leaf', 'natural-gift', 'payback', 'fling', 'gastro-acid', 'worry-seed', 'seed-bomb', 'energy-ball', 'nasty-plot', 'shadow-claw', 'leaf-storm', 'gunk-shot', 'grass-knot', 'hone-claws', 'low-sweep', 'round', 'acrobatics', 'grass-pledge', 'work-up', 'disarming-voice', 'play-nice', 'confide', 'spiky-shield'], 'name': 'pansage', 'stats': {'hp': 50, 'attack': 53, 'defense': 48, 'special-attack': 53, 'special-defense': 48, 'speed': 64}, 'types': ['grass'], 'weight': 105, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 190, 'color': 'green', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヤナップ', 'ko': '야나프', 'zh-Hant': '花椰猴', 'fr': 'Feuillajou', 'de': 'Vegimak', 'es': 'Pansage', 'it': 'Pansage', 'en': 'Pansage', 'ja': 'ヤナップ', 'zh-Hans': '花椰猴'}, 'genera': {'ja-Hrkt': 'くさざるポケモン', 'ko': '풀원숭이포켓몬', 'zh-Hant': '草猴寶可夢', 'fr': 'Pokémon Singe Herbe', 'de': 'Grasaffe', 'es': 'Pokémon Mono Hierba', 'it': 'Pokémon Scimperba', 'en': 'Grass Monkey Pokémon', 'ja': 'くさざるポケモン', 'zh-Hans': '草猴宝可梦'}}
	public class SpeciePansage : PokemonSpecie
	{
#nullable enable
		private static SpeciePansage? _instance = null;
#nullable restore
        public static SpeciePansage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePansage();
                }
                return _instance;
            }
        }

		public SpeciePansage() : base(
			"Pansage",
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64			
		) {}
	}


	//Pansage Pokemon Class
	public class Pansage : Pokemon
	{

		public Pansage(string nickname, int level) : base(
			511,
			SpeciePansage.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance			
		) {}

		public Pansage() : base(
			511,
			SpeciePansage.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}