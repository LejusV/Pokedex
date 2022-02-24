using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Empoleon Specie to store common natural stats of every {'abilities': ['torrent', 'defiant'], 'base_experience': 239, 'height': 17, 'id': 395, 'moves': ['swords-dance', 'cut', 'headbutt', 'fury-attack', 'tackle', 'growl', 'roar', 'mist', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'hyper-beam', 'peck', 'drill-peck', 'strength', 'earthquake', 'dig', 'toxic', 'double-team', 'waterfall', 'bubble', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'fury-cutter', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'brick-break', 'knock-off', 'secret-power', 'dive', 'hydro-cannon', 'rock-tomb', 'signal-beam', 'aerial-ace', 'iron-defense', 'covet', 'water-pulse', 'brine', 'natural-gift', 'pluck', 'fling', 'giga-impact', 'avalanche', 'shadow-claw', 'flash-cannon', 'rock-climb', 'defog', 'captivate', 'stealth-rock', 'grass-knot', 'aqua-jet', 'hone-claws', 'round', 'echoed-voice', 'scald', 'quash', 'water-pledge', 'bulldoze', 'work-up', 'confide'], 'name': 'empoleon', 'stats': {'hp': 84, 'attack': 86, 'defense': 88, 'special-attack': 111, 'special-defense': 101, 'speed': 60}, 'types': ['water', 'steel'], 'weight': 845, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'エンペルト', 'roomaji': 'Emperte', 'ko': '엠페르트', 'zh-Hant': '帝王拿波', 'fr': 'Pingoléon', 'de': 'Impoleon', 'es': 'Empoleon', 'it': 'Empoleon', 'en': 'Empoleon', 'ja': 'エンペルト', 'zh-Hans': '帝王拿波'}, 'genera': {'ja-Hrkt': 'こうていポケモン', 'ko': '황제포켓몬', 'zh-Hant': '皇帝寶可夢', 'fr': 'Pokémon Empereur', 'de': 'Kaiser', 'es': 'Pokémon Emperador', 'it': 'Pokémon Imperatore', 'en': 'Emperor Pokémon', 'ja': 'こうていポケモン', 'zh-Hans': '皇帝宝可梦'}}
	public class SpecieEmpoleon : PokemonSpecie
	{
#nullable enable
		private static SpecieEmpoleon? _instance = null;
#nullable restore
        public static SpecieEmpoleon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieEmpoleon();
                }
                return _instance;
            }
        }

		public SpecieEmpoleon() : base(
			"Empoleon",
			84, // HPs
			86, 88, // Attack & Defense
			111, 101, // Special Attack & Defense
			60			
		) {}
	}


	//Empoleon Pokemon Class
	public class Empoleon : Pokemon
	{

		public Empoleon(string nickname, int level)
		: base(
				395,
				SpecieEmpoleon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Empoleon(int level)
		: base(
				395,
				SpecieEmpoleon.Instance, // Pokemon Specie
				"Empoleon", level,
				Water.Instance, Steel.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Empoleon() : base(
			395,
			SpecieEmpoleon.Instance, // Pokemon Specie
			Water.Instance, Steel.Instance			
		) {}
	}
}