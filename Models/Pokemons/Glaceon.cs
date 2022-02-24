using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Glaceon Specie to store common natural stats of every {'abilities': ['snow-cloak', 'ice-body'], 'base_experience': 184, 'height': 8, 'id': 471, 'moves': ['sand-attack', 'headbutt', 'tackle', 'tail-whip', 'bite', 'roar', 'ice-beam', 'blizzard', 'hyper-beam', 'strength', 'dig', 'toxic', 'quick-attack', 'double-team', 'barrier', 'swift', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'mirror-coat', 'shadow-ball', 'rock-smash', 'hail', 'facade', 'helping-hand', 'secret-power', 'hyper-voice', 'signal-beam', 'covet', 'water-pulse', 'natural-gift', 'last-resort', 'aqua-tail', 'giga-impact', 'avalanche', 'ice-shard', 'ice-fang', 'captivate', 'round', 'echoed-voice', 'retaliate', 'frost-breath', 'work-up', 'confide', 'baby-doll-eyes', 'aurora-veil'], 'name': 'glaceon', 'stats': {'hp': 65, 'attack': 60, 'defense': 110, 'special-attack': 130, 'special-defense': 95, 'speed': 65}, 'types': ['ice'], 'weight': 259, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'グレイシア', 'roomaji': 'Glacia', 'ko': '글레이시아', 'zh-Hant': '冰伊布', 'fr': 'Givrali', 'de': 'Glaziola', 'es': 'Glaceon', 'it': 'Glaceon', 'en': 'Glaceon', 'ja': 'グレイシア', 'zh-Hans': '冰伊布'}, 'genera': {'ja-Hrkt': 'しんせつポケモン', 'ko': '신설포켓몬', 'zh-Hant': '新雪寶可夢', 'fr': 'Pokémon Poudreuse', 'de': 'Neuschnee', 'es': 'Pokémon Nieve Fresca', 'it': 'Pokémon Nevefresca', 'en': 'Fresh Snow Pokémon', 'ja': 'しんせつポケモン', 'zh-Hans': '新雪宝可梦'}}
	public class SpecieGlaceon : PokemonSpecie
	{
#nullable enable
		private static SpecieGlaceon? _instance = null;
#nullable restore
        public static SpecieGlaceon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGlaceon();
                }
                return _instance;
            }
        }

		public SpecieGlaceon() : base(
			"Glaceon",
			65, // HPs
			60, 110, // Attack & Defense
			130, 95, // Special Attack & Defense
			65			
		) {}
	}


	//Glaceon Pokemon Class
	public class Glaceon : Pokemon
	{

		public Glaceon(string nickname, int level)
		: base(
				471,
				SpecieGlaceon.Instance, // Pokemon Specie
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Glaceon() : base(
			471,
			SpecieGlaceon.Instance, // Pokemon Specie
			Ice.Instance			
		) {}
	}
}