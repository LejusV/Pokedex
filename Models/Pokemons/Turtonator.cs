using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Turtonator Specie to store common natural stats of every {'abilities': ['shell-armor'], 'base_experience': 170, 'height': 20, 'id': 776, 'moves': ['tackle', 'body-slam', 'roar', 'ember', 'flamethrower', 'hyper-beam', 'solar-beam', 'fire-spin', 'earthquake', 'toxic', 'double-team', 'smog', 'fire-blast', 'explosion', 'rest', 'substitute', 'flail', 'protect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'sunny-day', 'will-o-wisp', 'facade', 'taunt', 'revenge', 'overheat', 'rock-tomb', 'iron-defense', 'dragon-claw', 'bulk-up', 'payback', 'fling', 'dragon-pulse', 'focus-blast', 'giga-impact', 'flash-cannon', 'draco-meteor', 'stone-edge', 'charge-beam', 'head-smash', 'wide-guard', 'venoshock', 'smack-down', 'flame-charge', 'round', 'shell-smash', 'incinerate', 'bulldoze', 'dragon-tail', 'work-up', 'confide', 'brutal-swing', 'shell-trap'], 'name': 'turtonator', 'stats': {'hp': 60, 'attack': 78, 'defense': 135, 'special-attack': 91, 'special-defense': 85, 'speed': 36}, 'types': ['fire', 'dragon'], 'weight': 2120, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 70, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'バクガメス', 'ko': '폭거북스', 'zh-Hant': '爆焰龜獸', 'fr': 'Boumata', 'de': 'Tortunator', 'es': 'Turtonator', 'it': 'Turtonator', 'en': 'Turtonator', 'ja': 'バクガメス', 'zh-Hans': '爆焰龟兽'}, 'genera': {'ja-Hrkt': 'ばくはつがめポケモン', 'ko': '폭발거북포켓몬', 'zh-Hant': '爆炸龜寶可夢', 'fr': 'Pokémon Tortue Boum', 'de': 'Knallkröte', 'es': 'Pokémon Tortugabomba', 'it': 'Pokémon Tartabomba', 'en': 'Blast Turtle Pokémon', 'ja': 'ばくはつがめポケモン', 'zh-Hans': '爆炸龟宝可梦'}}
	public class SpecieTurtonator : PokemonSpecie
	{
#nullable enable
		private static SpecieTurtonator? _instance = null;
#nullable restore
        public static SpecieTurtonator Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTurtonator();
                }
                return _instance;
            }
        }

		public SpecieTurtonator() : base(
			"Turtonator",
			60, // HPs
			78, 135, // Attack & Defense
			91, 85, // Special Attack & Defense
			36			
		) {}
	}


	//Turtonator Pokemon Class
	public class Turtonator : Pokemon
	{

		public Turtonator(string nickname, int level)
		: base(
				776,
				SpecieTurtonator.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Turtonator() : base(
			776,
			SpecieTurtonator.Instance, // Pokemon Specie
			Fire.Instance, Dragon.Instance			
		) {}
	}
}