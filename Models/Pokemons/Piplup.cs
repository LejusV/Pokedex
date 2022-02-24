using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Piplup Specie to store common natural stats of every {'abilities': ['torrent', 'defiant'], 'base_experience': 63, 'height': 4, 'id': 393, 'moves': ['pound', 'cut', 'headbutt', 'fury-attack', 'growl', 'supersonic', 'mist', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'peck', 'drill-peck', 'dig', 'toxic', 'agility', 'double-team', 'bide', 'waterfall', 'bubble', 'rest', 'substitute', 'snore', 'flail', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'whirlpool', 'hail', 'facade', 'brick-break', 'yawn', 'secret-power', 'dive', 'feather-dance', 'mud-sport', 'rock-tomb', 'signal-beam', 'aerial-ace', 'covet', 'water-sport', 'water-pulse', 'brine', 'natural-gift', 'pluck', 'fling', 'aqua-ring', 'defog', 'captivate', 'stealth-rock', 'grass-knot', 'double-hit', 'round', 'echoed-voice', 'scald', 'quash', 'water-pledge', 'work-up', 'confide', 'power-trip'], 'name': 'piplup', 'stats': {'hp': 53, 'attack': 51, 'defense': 53, 'special-attack': 61, 'special-defense': 56, 'speed': 40}, 'types': ['water'], 'weight': 52, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['water1', 'ground'], 'names': {'it': 'Piplup', 'ja-Hrkt': 'ポッチャマ', 'roomaji': 'Pochama', 'ko': '팽도리', 'zh-Hant': '波加曼', 'fr': 'Tiplouf', 'de': 'Plinfa', 'es': 'Piplup', 'en': 'Piplup', 'ja': 'ポッチャマ', 'zh-Hans': '波加曼'}, 'genera': {'it': 'Pokémon Pinguino', 'ja-Hrkt': 'ペンギンポケモン', 'ko': '펭귄포켓몬', 'zh-Hant': '企鵝寶可夢', 'fr': 'Pokémon Pingouin', 'de': 'Pinguin', 'es': 'Pokémon Pingüino', 'en': 'Penguin Pokémon', 'ja': 'ペンギンポケモン', 'zh-Hans': '企鹅宝可梦'}}
	public class SpeciePiplup : PokemonSpecie
	{
#nullable enable
		private static SpeciePiplup? _instance = null;
#nullable restore
        public static SpeciePiplup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePiplup();
                }
                return _instance;
            }
        }

		public SpeciePiplup() : base(
			"Piplup",
			53, // HPs
			51, 53, // Attack & Defense
			61, 56, // Special Attack & Defense
			40			
		) {}
	}


	//Piplup Pokemon Class
	public class Piplup : Pokemon
	{

		public Piplup(string nickname, int level)
		: base(
				393,
				SpeciePiplup.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Piplup(int level)
		: base(
				393,
				SpeciePiplup.Instance, // Pokemon Specie
				"Piplup", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Piplup() : base(
			393,
			SpeciePiplup.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}