using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Golbat Specie to store common natural stats of every {'abilities': ['inner-focus', 'infiltrator'], 'base_experience': 159, 'height': 16, 'id': 42, 'moves': ['razor-wind', 'wing-attack', 'whirlwind', 'fly', 'take-down', 'double-edge', 'bite', 'supersonic', 'hyper-beam', 'absorb', 'mega-drain', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'confuse-ray', 'haze', 'bide', 'swift', 'leech-life', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'curse', 'protect', 'sludge-bomb', 'detect', 'giga-drain', 'endure', 'swagger', 'steel-wing', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'snatch', 'secret-power', 'poison-fang', 'astonish', 'air-cutter', 'aerial-ace', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'payback', 'air-slash', 'giga-impact', 'zen-headbutt', 'defog', 'captivate', 'ominous-wind', 'venoshock', 'round', 'quick-guard', 'acrobatics', 'confide'], 'name': 'golbat', 'stats': {'hp': 75, 'attack': 80, 'defense': 70, 'special-attack': 65, 'special-defense': 75, 'speed': 90}, 'types': ['poison', 'flying'], 'weight': 550, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 90, 'color': 'purple', 'shape': 'wings', 'habitat': 'cave', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'ゴルバット', 'roomaji': 'Golbat', 'ko': '골뱃', 'zh-Hant': '大嘴蝠', 'fr': 'Nosferalto', 'de': 'Golbat', 'es': 'Golbat', 'it': 'Golbat', 'en': 'Golbat', 'ja': 'ゴルバット', 'zh-Hans': '大嘴蝠'}, 'genera': {'ja-Hrkt': 'こうもりポケモン', 'ko': '박쥐포켓몬', 'zh-Hant': '蝙蝠寶可夢', 'fr': 'Pokémon Chovsouris', 'de': 'Fledermaus', 'es': 'Pokémon Murciélago', 'it': 'Pokémon Pipistrello', 'en': 'Bat Pokémon', 'ja': 'こうもりポケモン', 'zh-Hans': '蝙蝠宝可梦'}}
	public class SpecieGolbat : PokemonSpecie
	{
#nullable enable
		private static SpecieGolbat? _instance = null;
#nullable restore
        public static SpecieGolbat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieGolbat();
                }
                return _instance;
            }
        }

		public SpecieGolbat() : base(
			"Golbat",
			75, // HPs
			80, 70, // Attack & Defense
			65, 75, // Special Attack & Defense
			90			
		) {}
	}


	//Golbat Pokemon Class
	public class Golbat : Pokemon
	{

		public Golbat(string nickname, int level) : base(
			42,
			SpecieGolbat.Instance, // Pokemon Specie
			nickname, level,
			Poison.Instance, Flying.Instance			
		) {}

		public Golbat() : base(
			42,
			SpecieGolbat.Instance, // Pokemon Specie
			Poison.Instance, Flying.Instance			
		) {}
	}
}