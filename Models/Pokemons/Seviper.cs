using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Seviper Specie to store common natural stats of every {'abilities': ['shed-skin', 'infiltrator'], 'base_experience': 160, 'height': 27, 'id': 336, 'moves': ['swords-dance', 'bind', 'headbutt', 'body-slam', 'wrap', 'double-edge', 'bite', 'flamethrower', 'strength', 'earthquake', 'dig', 'toxic', 'mimic', 'screech', 'double-team', 'haze', 'lick', 'swift', 'glare', 'rest', 'substitute', 'thief', 'snore', 'protect', 'scary-face', 'sludge-bomb', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'stockpile', 'spit-up', 'swallow', 'facade', 'taunt', 'knock-off', 'snatch', 'secret-power', 'poison-fang', 'poison-tail', 'natural-gift', 'feint', 'payback', 'assurance', 'wring-out', 'gastro-acid', 'punishment', 'sucker-punch', 'poison-jab', 'dark-pulse', 'night-slash', 'aqua-tail', 'x-scissor', 'switcheroo', 'captivate', 'venoshock', 'sludge-wave', 'coil', 'round', 'retaliate', 'final-gambit', 'bulldoze', 'dragon-tail', 'belch', 'confide', 'venom-drench', 'infestation', 'brutal-swing'], 'name': 'seviper', 'stats': {'hp': 73, 'attack': 100, 'defense': 60, 'special-attack': 100, 'special-defense': 60, 'speed': 65}, 'types': ['poison'], 'weight': 525, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'black', 'shape': 'squiggle', 'habitat': 'grassland', 'generation': 'generation-iii', 'growth_rate': 'fast-then-very-slow', 'egg_groups': ['ground', 'dragon'], 'names': {'ja-Hrkt': 'ハブネーク', 'roomaji': 'Habunake', 'ko': '세비퍼', 'zh-Hant': '飯匙蛇', 'fr': 'Séviper', 'de': 'Vipitis', 'es': 'Seviper', 'it': 'Seviper', 'en': 'Seviper', 'ja': 'ハブネーク', 'zh-Hans': '饭匙蛇'}, 'genera': {'ja-Hrkt': 'キバへびポケモン', 'ko': '송곳뱀포켓몬', 'zh-Hant': '牙蛇寶可夢', 'fr': 'Pokémon Serpacroc', 'de': 'Reißzahn', 'es': 'Pokémon Colmillos', 'it': 'Pokémon Zannaserpe', 'en': 'Fang Snake Pokémon', 'ja': 'キバへびポケモン', 'zh-Hans': '牙蛇宝可梦'}}
	public class SpecieSeviper : PokemonSpecie
	{
#nullable enable
		private static SpecieSeviper? _instance = null;
#nullable restore
        public static SpecieSeviper Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSeviper();
                }
                return _instance;
            }
        }

		public SpecieSeviper() : base(
			"Seviper",
			73, // HPs
			100, 60, // Attack & Defense
			100, 60, // Special Attack & Defense
			65			
		) {}
	}


	//Seviper Pokemon Class
	public class Seviper : Pokemon
	{

		public Seviper(string nickname, int level)
		: base(
				336,
				SpecieSeviper.Instance, // Pokemon Specie
				nickname, level,
				Poison.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Seviper() : base(
			336,
			SpecieSeviper.Instance, // Pokemon Specie
			Poison.Instance			
		) {}
	}
}