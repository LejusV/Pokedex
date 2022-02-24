using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Barbaracle Specie to store common natural stats of every {'abilities': ['tough-claws', 'sniper', 'pickpocket'], 'base_experience': 175, 'height': 13, 'id': 689, 'moves': ['scratch', 'swords-dance', 'cut', 'sand-attack', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'withdraw', 'clamp', 'skull-bash', 'fury-swipes', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'protect', 'sludge-bomb', 'mud-slap', 'icy-wind', 'sandstorm', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'cross-chop', 'rain-dance', 'ancient-power', 'rock-smash', 'torment', 'facade', 'nature-power', 'taunt', 'helping-hand', 'superpower', 'brick-break', 'endeavor', 'secret-power', 'rock-tomb', 'aerial-ace', 'iron-defense', 'dragon-claw', 'bulk-up', 'water-pulse', 'payback', 'embargo', 'fling', 'rock-polish', 'poison-jab', 'night-slash', 'x-scissor', 'focus-blast', 'earth-power', 'giga-impact', 'shadow-claw', 'stone-edge', 'stealth-rock', 'grass-knot', 'hone-claws', 'smack-down', 'sludge-wave', 'round', 'scald', 'shell-smash', 'bulldoze', 'dual-chop', 'razor-shell', 'confide', 'infestation', 'power-up-punch', 'brutal-swing'], 'name': 'barbaracle', 'stats': {'hp': 72, 'attack': 105, 'defense': 115, 'special-attack': 54, 'special-defense': 86, 'speed': 68}, 'types': ['rock', 'water'], 'weight': 960, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'brown', 'shape': 'heads', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['water3'], 'names': {'ja-Hrkt': 'ガメノデス', 'ko': '거북손데스', 'zh-Hant': '龜足巨鎧', 'fr': 'Golgopathe', 'de': 'Thanathora', 'es': 'Barbaracle', 'it': 'Barbaracle', 'en': 'Barbaracle', 'ja': 'ガメノデス', 'zh-Hans': '龟足巨铠'}, 'genera': {'ja-Hrkt': 'しゅうごうポケモン', 'ko': '집합포켓몬', 'zh-Hant': '集合寶可夢', 'fr': 'Pokémon Assemblage', 'de': 'Ballung', 'es': 'Pokémon Combinación', 'it': 'Pokémon Aggregato', 'en': 'Collective Pokémon', 'ja': 'しゅうごうポケモン', 'zh-Hans': '集合宝可梦'}}
	public class SpecieBarbaracle : PokemonSpecie
	{
#nullable enable
		private static SpecieBarbaracle? _instance = null;
#nullable restore
        public static SpecieBarbaracle Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBarbaracle();
                }
                return _instance;
            }
        }

		public SpecieBarbaracle() : base(
			"Barbaracle",
			72, // HPs
			105, 115, // Attack & Defense
			54, 86, // Special Attack & Defense
			68			
		) {}
	}


	//Barbaracle Pokemon Class
	public class Barbaracle : Pokemon
	{

		public Barbaracle(string nickname, int level)
		: base(
				689,
				SpecieBarbaracle.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Barbaracle(int level)
		: base(
				689,
				SpecieBarbaracle.Instance, // Pokemon Specie
				"Barbaracle", level,
				Rock.Instance, Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Barbaracle() : base(
			689,
			SpecieBarbaracle.Instance, // Pokemon Specie
			Rock.Instance, Water.Instance			
		) {}
	}
}