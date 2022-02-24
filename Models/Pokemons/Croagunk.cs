using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Croagunk Specie to store common natural stats of every {'abilities': ['anticipation', 'dry-skin', 'poison-touch'], 'base_experience': 60, 'height': 7, 'id': 453, 'moves': ['ice-punch', 'thunder-punch', 'headbutt', 'poison-sting', 'low-kick', 'counter', 'strength', 'earthquake', 'dig', 'toxic', 'meditate', 'double-team', 'rest', 'rock-slide', 'super-fang', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'sludge-bomb', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'hidden-power', 'cross-chop', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'fake-out', 'torment', 'flatter', 'facade', 'focus-punch', 'smelling-salts', 'taunt', 'helping-hand', 'role-play', 'revenge', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'astonish', 'rock-tomb', 'bulk-up', 'bounce', 'wake-up-slap', 'natural-gift', 'feint', 'acupressure', 'payback', 'embargo', 'fling', 'me-first', 'sucker-punch', 'poison-jab', 'dark-pulse', 'x-scissor', 'drain-punch', 'vacuum-wave', 'focus-blast', 'nasty-plot', 'bullet-punch', 'mud-bomb', 'rock-climb', 'gunk-shot', 'captivate', 'venoshock', 'sludge-wave', 'low-sweep', 'foul-play', 'round', 'quick-guard', 'retaliate', 'bulldoze', 'work-up', 'dual-chop', 'belch', 'confide', 'power-up-punch'], 'name': 'croagunk', 'stats': {'hp': 48, 'attack': 61, 'defense': 40, 'special-attack': 61, 'special-defense': 40, 'speed': 50}, 'types': ['poison', 'fighting'], 'weight': 230, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 10, 'gender_rate': 4, 'capture_rate': 140, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['humanshape'], 'names': {'ja-Hrkt': 'グレッグル', 'roomaji': 'Gureggru', 'ko': '삐딱구리', 'zh-Hant': '不良蛙', 'fr': 'Cradopaud', 'de': 'Glibunkel', 'es': 'Croagunk', 'it': 'Croagunk', 'en': 'Croagunk', 'ja': 'グレッグル', 'zh-Hans': '不良蛙'}, 'genera': {'ja-Hrkt': 'どくづきポケモン', 'ko': '독설포켓몬', 'zh-Hant': '毒擊寶可夢', 'fr': 'Pokémon Toxique', 'de': 'Giftmund', 'es': 'Pokémon Boca Tóxica', 'it': 'Pokémon Inveieleno', 'en': 'Toxic Mouth Pokémon', 'ja': 'どくづきポケモン', 'zh-Hans': '毒击宝可梦'}}
	public class SpecieCroagunk : PokemonSpecie
	{
#nullable enable
		private static SpecieCroagunk? _instance = null;
#nullable restore
        public static SpecieCroagunk Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCroagunk();
                }
                return _instance;
            }
        }

		public SpecieCroagunk() : base(
			"Croagunk",
			48, // HPs
			61, 40, // Attack & Defense
			61, 40, // Special Attack & Defense
			50			
		) {}
	}


	//Croagunk Pokemon Class
	public class Croagunk : Pokemon
	{

		public Croagunk(string nickname, int level)
		: base(
				453,
				SpecieCroagunk.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Croagunk(int level)
		: base(
				453,
				SpecieCroagunk.Instance, // Pokemon Specie
				"Croagunk", level,
				Poison.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Croagunk() : base(
			453,
			SpecieCroagunk.Instance, // Pokemon Specie
			Poison.Instance, Fighting.Instance			
		) {}
	}
}