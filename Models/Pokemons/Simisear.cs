using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Simisear Specie to store common natural stats of every {'abilities': ['gluttony', 'blaze'], 'base_experience': 174, 'height': 10, 'id': 514, 'moves': ['fire-punch', 'cut', 'leer', 'flamethrower', 'hyper-beam', 'low-kick', 'solar-beam', 'dig', 'toxic', 'double-team', 'lick', 'fire-blast', 'fury-swipes', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'superpower', 'recycle', 'brick-break', 'knock-off', 'endeavor', 'secret-power', 'overheat', 'rock-tomb', 'covet', 'payback', 'fling', 'gastro-acid', 'focus-blast', 'giga-impact', 'shadow-claw', 'gunk-shot', 'grass-knot', 'hone-claws', 'flame-burst', 'flame-charge', 'low-sweep', 'round', 'incinerate', 'acrobatics', 'fire-pledge', 'work-up', 'confide', 'power-up-punch'], 'name': 'simisear', 'stats': {'hp': 75, 'attack': 98, 'defense': 63, 'special-attack': 98, 'special-defense': 63, 'speed': 101}, 'types': ['fire'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 75, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バオッキー', 'ko': '바오키', 'zh-Hant': '爆香猿', 'fr': 'Flamoutan', 'de': 'Grillchita', 'es': 'Simisear', 'it': 'Simisear', 'en': 'Simisear', 'ja': 'バオッキー', 'zh-Hans': '爆香猿'}, 'genera': {'ja-Hrkt': 'ひのこポケモン', 'ko': '불티포켓몬', 'zh-Hant': '火花寶可夢', 'fr': 'Pokémon Braise', 'de': 'Funkenregen', 'es': 'Pokémon Lumbre', 'it': 'Pokémon Sfavillante', 'en': 'Ember Pokémon', 'ja': 'ひのこポケモン', 'zh-Hans': '火花宝可梦'}}
	public class SpecieSimisear : PokemonSpecie
	{
#nullable enable
		private static SpecieSimisear? _instance = null;
#nullable restore
        public static SpecieSimisear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSimisear();
                }
                return _instance;
            }
        }

		public SpecieSimisear() : base(
			"Simisear",
			75, // HPs
			98, 63, // Attack & Defense
			98, 63, // Special Attack & Defense
			101			
		) {}
	}


	//Simisear Pokemon Class
	public class Simisear : Pokemon
	{

		public Simisear(string nickname, int level)
		: base(
				514,
				SpecieSimisear.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Simisear(int level)
		: base(
				514,
				SpecieSimisear.Instance, // Pokemon Specie
				"Simisear", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Simisear() : base(
			514,
			SpecieSimisear.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}