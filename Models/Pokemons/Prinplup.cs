using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Prinplup Specie to store common natural stats of every {'abilities': ['torrent', 'defiant'], 'base_experience': 142, 'height': 8, 'id': 394, 'moves': ['cut', 'headbutt', 'fury-attack', 'tackle', 'growl', 'mist', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'peck', 'drill-peck', 'strength', 'dig', 'toxic', 'double-team', 'bide', 'waterfall', 'bubble', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'metal-claw', 'hidden-power', 'rain-dance', 'rock-smash', 'whirlpool', 'hail', 'facade', 'brick-break', 'secret-power', 'dive', 'rock-tomb', 'signal-beam', 'aerial-ace', 'covet', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'pluck', 'fling', 'shadow-claw', 'defog', 'captivate', 'stealth-rock', 'grass-knot', 'hone-claws', 'round', 'echoed-voice', 'scald', 'quash', 'water-pledge', 'work-up', 'confide'], 'name': 'prinplup', 'stats': {'hp': 64, 'attack': 66, 'defense': 68, 'special-attack': 81, 'special-defense': 76, 'speed': 50}, 'types': ['water'], 'weight': 230, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'ja-Hrkt': 'ポッタイシ', 'roomaji': 'Pottaishi', 'ko': '팽태자', 'zh-Hant': '波皇子', 'fr': 'Prinplouf', 'de': 'Pliprin', 'es': 'Prinplup', 'it': 'Prinplup', 'en': 'Prinplup', 'ja': 'ポッタイシ', 'zh-Hans': '波皇子'}, 'genera': {'ja-Hrkt': 'ペンギンポケモン', 'ko': '펭귄포켓몬', 'zh-Hant': '企鵝寶可夢', 'fr': 'Pokémon Pingouin', 'de': 'Pinguin', 'es': 'Pokémon Pingüino', 'it': 'Pokémon Pinguino', 'en': 'Penguin Pokémon', 'ja': 'ペンギンポケモン', 'zh-Hans': '企鹅宝可梦'}}
	public class SpeciePrinplup : PokemonSpecie
	{
#nullable enable
		private static SpeciePrinplup? _instance = null;
#nullable restore
        public static SpeciePrinplup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePrinplup();
                }
                return _instance;
            }
        }

		public SpeciePrinplup() : base(
			"Prinplup",
			64, // HPs
			66, 68, // Attack & Defense
			81, 76, // Special Attack & Defense
			50			
		) {}
	}


	//Prinplup Pokemon Class
	public class Prinplup : Pokemon
	{

		public Prinplup(string nickname, int level)
		: base(
				394,
				SpeciePrinplup.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Prinplup() : base(
			394,
			SpeciePrinplup.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}