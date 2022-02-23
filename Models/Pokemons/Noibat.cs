using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Noibat Specie to store common natural stats of every {'abilities': ['frisk', 'infiltrator', 'telepathy'], 'base_experience': 49, 'height': 5, 'id': 714, 'moves': ['razor-wind', 'cut', 'gust', 'wing-attack', 'whirlwind', 'fly', 'tackle', 'bite', 'supersonic', 'absorb', 'solar-beam', 'toxic', 'psychic', 'agility', 'screech', 'double-team', 'dream-eater', 'leech-life', 'sky-attack', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'protect', 'outrage', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'sunny-day', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'brick-break', 'snatch', 'secret-power', 'hyper-voice', 'air-cutter', 'aerial-ace', 'water-pulse', 'roost', 'tailwind', 'u-turn', 'dark-pulse', 'air-slash', 'x-scissor', 'dragon-pulse', 'switcheroo', 'shadow-claw', 'draco-meteor', 'round', 'echoed-voice', 'acrobatics', 'wild-charge', 'hurricane', 'confide'], 'name': 'noibat', 'stats': {'hp': 40, 'attack': 30, 'defense': 35, 'special-attack': 45, 'special-defense': 40, 'speed': 55}, 'types': ['flying', 'dragon'], 'weight': 80, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 190, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'オンバット', 'ko': '음뱃', 'zh-Hant': '嗡蝠', 'fr': 'Sonistrelle', 'de': 'eF-eM', 'es': 'Noibat', 'it': 'Noibat', 'en': 'Noibat', 'ja': 'オンバット', 'zh-Hans': '嗡蝠'}, 'genera': {'ja-Hrkt': 'おんぱポケモン', 'ko': '음파포켓몬', 'zh-Hant': '音波寶可夢', 'fr': 'Pokémon Ondes', 'de': 'Schallwellen', 'es': 'Pokémon Onda Sónica', 'it': 'Pokémon Ondasonora', 'en': 'Sound Wave Pokémon', 'ja': 'おんぱポケモン', 'zh-Hans': '音波宝可梦'}}
	public class SpecieNoibat : PokemonSpecie
	{
#nullable enable
		private static SpecieNoibat? _instance = null;
#nullable restore
        public static SpecieNoibat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNoibat();
                }
                return _instance;
            }
        }

		public SpecieNoibat() : base(
			"Noibat",
			40, // HPs
			30, 35, // Attack & Defense
			45, 40, // Special Attack & Defense
			55			
		) {}
	}


	//Noibat Pokemon Class
	public class Noibat : Pokemon
	{

		public Noibat(string nickname, int level) : base(
			714,
			SpecieNoibat.Instance, // Pokemon Specie
			nickname, level,
			Flying.Instance, Dragon.Instance			
		) {}

		public Noibat() : base(
			714,
			SpecieNoibat.Instance, // Pokemon Specie
			Flying.Instance, Dragon.Instance			
		) {}
	}
}