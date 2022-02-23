using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pansear Specie to store common natural stats of every {'abilities': ['gluttony', 'blaze'], 'base_experience': 63, 'height': 6, 'id': 513, 'moves': ['fire-punch', 'scratch', 'cut', 'leer', 'bite', 'flamethrower', 'low-kick', 'solar-beam', 'fire-spin', 'dig', 'toxic', 'double-team', 'lick', 'fire-blast', 'amnesia', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'crunch', 'rock-smash', 'uproar', 'heat-wave', 'torment', 'will-o-wisp', 'facade', 'focus-punch', 'taunt', 'helping-hand', 'role-play', 'recycle', 'yawn', 'knock-off', 'endeavor', 'secret-power', 'astonish', 'overheat', 'rock-tomb', 'tickle', 'covet', 'natural-gift', 'payback', 'fling', 'gastro-acid', 'flare-blitz', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'grass-knot', 'hone-claws', 'flame-burst', 'flame-charge', 'low-sweep', 'round', 'incinerate', 'acrobatics', 'fire-pledge', 'work-up', 'belch', 'disarming-voice', 'play-nice', 'confide'], 'name': 'pansear', 'stats': {'hp': 50, 'attack': 53, 'defense': 48, 'special-attack': 53, 'special-defense': 48, 'speed': 64}, 'types': ['fire'], 'weight': 110, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 190, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'バオップ', 'ko': '바오프', 'zh-Hant': '爆香猴', 'fr': 'Flamajou', 'de': 'Grillmak', 'es': 'Pansear', 'it': 'Pansear', 'en': 'Pansear', 'ja': 'バオップ', 'zh-Hans': '爆香猴'}, 'genera': {'ja-Hrkt': 'こうおんポケモン', 'ko': '고온포켓몬', 'zh-Hant': '高溫寶可夢', 'fr': 'Pokémon Brûlant', 'de': 'Hitze', 'es': 'Pokémon Ardiente', 'it': 'Pokémon Testacalda', 'en': 'High Temp Pokémon', 'ja': 'こうおんポケモン', 'zh-Hans': '高温宝可梦'}}
	public class SpeciePansear : PokemonSpecie
	{
#nullable enable
		private static SpeciePansear? _instance = null;
#nullable restore
        public static SpeciePansear Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePansear();
                }
                return _instance;
            }
        }

		public SpeciePansear() : base(
			"Pansear",
			50, // HPs
			53, 48, // Attack & Defense
			53, 48, // Special Attack & Defense
			64			
		) {}
	}


	//Pansear Pokemon Class
	public class Pansear : Pokemon
	{

		public Pansear(string nickname, int level) : base(
			513,
			SpeciePansear.Instance, // Pokemon Specie
			nickname, level,
			Fire.Instance			
		) {}

		public Pansear() : base(
			513,
			SpeciePansear.Instance, // Pokemon Specie
			Fire.Instance			
		) {}
	}
}