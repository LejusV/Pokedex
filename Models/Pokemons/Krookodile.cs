using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Krookodile Specie to store common natural stats of every {'abilities': ['intimidate', 'moxie', 'anger-point'], 'base_experience': 234, 'height': 15, 'id': 553, 'moves': ['cut', 'sand-attack', 'leer', 'bite', 'roar', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'rage', 'double-team', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'spite', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'outrage', 'sandstorm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'crunch', 'rock-smash', 'uproar', 'torment', 'facade', 'focus-punch', 'taunt', 'superpower', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'sand-tomb', 'aerial-ace', 'block', 'dragon-claw', 'bulk-up', 'payback', 'assurance', 'embargo', 'fling', 'dark-pulse', 'aqua-tail', 'dragon-pulse', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'stone-edge', 'stealth-rock', 'grass-knot', 'hone-claws', 'smack-down', 'low-sweep', 'foul-play', 'round', 'incinerate', 'retaliate', 'bulldoze', 'dragon-tail', 'snarl', 'confide', 'power-up-punch', 'power-trip', 'brutal-swing'], 'name': 'krookodile', 'stats': {'hp': 95, 'attack': 117, 'defense': 80, 'special-attack': 65, 'special-defense': 70, 'speed': 92}, 'types': ['ground', 'dark'], 'weight': 963, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'red', 'shape': 'upright', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ワルビアル', 'ko': '악비아르', 'zh-Hant': '流氓鱷', 'fr': 'Crocorible', 'de': 'Rabigator', 'es': 'Krookodile', 'it': 'Krookodile', 'en': 'Krookodile', 'ja': 'ワルビアル', 'zh-Hans': '流氓鳄'}, 'genera': {'ja-Hrkt': 'いかくポケモン', 'ko': '위협포켓몬', 'zh-Hant': '威嚇寶可夢', 'fr': 'Pokémon Intimidation', 'de': 'Abschreckung', 'es': 'Pokémon Amenazador', 'it': 'Pokémon Minaccia', 'en': 'Intimidation Pokémon', 'ja': 'いかくポケモン', 'zh-Hans': '威吓宝可梦'}}
	public class SpecieKrookodile : PokemonSpecie
	{
#nullable enable
		private static SpecieKrookodile? _instance = null;
#nullable restore
        public static SpecieKrookodile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKrookodile();
                }
                return _instance;
            }
        }

		public SpecieKrookodile() : base(
			"Krookodile",
			95, // HPs
			117, 80, // Attack & Defense
			65, 70, // Special Attack & Defense
			92			
		) {}
	}


	//Krookodile Pokemon Class
	public class Krookodile : Pokemon
	{

		public Krookodile(string nickname, int level)
		: base(
				553,
				SpecieKrookodile.Instance, // Pokemon Specie
				nickname, level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Krookodile(int level)
		: base(
				553,
				SpecieKrookodile.Instance, // Pokemon Specie
				"Krookodile", level,
				Ground.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Krookodile() : base(
			553,
			SpecieKrookodile.Instance, // Pokemon Specie
			Ground.Instance, Dark.Instance			
		) {}
	}
}