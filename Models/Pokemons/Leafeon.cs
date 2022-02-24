using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Leafeon Specie to store common natural stats of every {'abilities': ['leaf-guard', 'chlorophyll'], 'base_experience': 184, 'height': 10, 'id': 470, 'moves': ['swords-dance', 'sand-attack', 'headbutt', 'tackle', 'tail-whip', 'roar', 'hyper-beam', 'strength', 'razor-leaf', 'solar-beam', 'dig', 'toxic', 'quick-attack', 'double-team', 'swift', 'flash', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'giga-drain', 'endure', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'synthesis', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'facade', 'nature-power', 'helping-hand', 'knock-off', 'secret-power', 'hyper-voice', 'grass-whistle', 'bullet-seed', 'aerial-ace', 'covet', 'magical-leaf', 'leaf-blade', 'natural-gift', 'last-resort', 'worry-seed', 'seed-bomb', 'x-scissor', 'energy-ball', 'giga-impact', 'captivate', 'grass-knot', 'round', 'echoed-voice', 'retaliate', 'work-up', 'confide', 'baby-doll-eyes'], 'name': 'leafeon', 'stats': {'hp': 65, 'attack': 110, 'defense': 130, 'special-attack': 60, 'special-defense': 65, 'speed': 95}, 'types': ['grass'], 'weight': 255, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'リーフィア', 'roomaji': 'Leafia', 'ko': '리피아', 'zh-Hant': '葉伊布', 'fr': 'Phyllali', 'de': 'Folipurba', 'es': 'Leafeon', 'it': 'Leafeon', 'en': 'Leafeon', 'ja': 'リーフィア', 'zh-Hans': '叶伊布'}, 'genera': {'ja-Hrkt': 'しんりょくポケモン', 'ko': '심록포켓몬', 'zh-Hant': '新綠寶可夢', 'fr': 'Pokémon Verdoyant', 'de': 'Unreif', 'es': 'Pokémon Verdor', 'it': 'Pokémon Rigoglioso', 'en': 'Verdant Pokémon', 'ja': 'しんりょくポケモン', 'zh-Hans': '新绿宝可梦'}}
	public class SpecieLeafeon : PokemonSpecie
	{
#nullable enable
		private static SpecieLeafeon? _instance = null;
#nullable restore
        public static SpecieLeafeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLeafeon();
                }
                return _instance;
            }
        }

		public SpecieLeafeon() : base(
			"Leafeon",
			65, // HPs
			110, 130, // Attack & Defense
			60, 65, // Special Attack & Defense
			95			
		) {}
	}


	//Leafeon Pokemon Class
	public class Leafeon : Pokemon
	{

		public Leafeon(string nickname, int level)
		: base(
				470,
				SpecieLeafeon.Instance, // Pokemon Specie
				nickname, level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Leafeon(int level)
		: base(
				470,
				SpecieLeafeon.Instance, // Pokemon Specie
				"Leafeon", level,
				Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Leafeon() : base(
			470,
			SpecieLeafeon.Instance, // Pokemon Specie
			Grass.Instance			
		) {}
	}
}