using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zubat Specie to store common natural stats of every {'abilities': ['inner-focus', 'infiltrator'], 'base_experience': 49, 'height': 8, 'id': 41, 'moves': ['razor-wind', 'gust', 'wing-attack', 'whirlwind', 'fly', 'take-down', 'double-edge', 'bite', 'supersonic', 'absorb', 'mega-drain', 'toxic', 'hypnosis', 'quick-attack', 'rage', 'mimic', 'double-team', 'confuse-ray', 'haze', 'bide', 'swift', 'leech-life', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'feint-attack', 'sludge-bomb', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'snatch', 'secret-power', 'poison-fang', 'astonish', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'payback', 'air-slash', 'brave-bird', 'nasty-plot', 'zen-headbutt', 'defog', 'captivate', 'ominous-wind', 'venoshock', 'round', 'quick-guard', 'acrobatics', 'confide', 'venom-drench'], 'name': 'zubat', 'stats': {'hp': 40, 'attack': 45, 'defense': 35, 'special-attack': 30, 'special-defense': 40, 'speed': 55}, 'types': ['poison', 'flying'], 'weight': 75, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'purple', 'shape': 'wings', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ズバット', 'roomaji': 'Zubat', 'ko': '주뱃', 'zh-Hant': '超音蝠', 'fr': 'Nosferapti', 'de': 'Zubat', 'es': 'Zubat', 'it': 'Zubat', 'en': 'Zubat', 'ja': 'ズバット', 'zh-Hans': '超音蝠'}, 'genera': {'ja-Hrkt': 'こうもりポケモン', 'ko': '박쥐포켓몬', 'zh-Hant': '蝙蝠寶可夢', 'fr': 'Pokémon Chovsouris', 'de': 'Fledermaus', 'es': 'Pokémon Murciélago', 'it': 'Pokémon Pipistrello', 'en': 'Bat Pokémon', 'ja': 'こうもりポケモン', 'zh-Hans': '蝙蝠宝可梦'}}
	public class SpecieZubat : PokemonSpecie
	{
#nullable enable
		private static SpecieZubat? _instance = null;
#nullable restore
        public static SpecieZubat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZubat();
                }
                return _instance;
            }
        }

		public SpecieZubat() : base(
			"Zubat",
			40, // HPs
			45, 35, // Attack & Defense
			30, 40, // Special Attack & Defense
			55			
		) {}
	}


	//Zubat Pokemon Class
	public class Zubat : Pokemon
	{

		public Zubat(string nickname, int level) : base(
			41,
			SpecieZubat.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Flying.Instance			
		) {}

		public Zubat() : base(
			41,
			SpecieZubat.Instance, // Pokemon Specie
			Poison.Instance, Flying.Instance			
		) {}
	}
}