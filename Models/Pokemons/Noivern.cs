using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Noivern Specie to store common natural stats of every {'abilities': ['frisk', 'infiltrator', 'telepathy'], 'base_experience': 187, 'height': 15, 'id': 715, 'moves': ['razor-wind', 'cut', 'gust', 'wing-attack', 'whirlwind', 'fly', 'tackle', 'bite', 'supersonic', 'flamethrower', 'hyper-beam', 'absorb', 'solar-beam', 'toxic', 'psychic', 'agility', 'screech', 'double-team', 'dream-eater', 'leech-life', 'sky-attack', 'rest', 'super-fang', 'substitute', 'thief', 'snore', 'protect', 'outrage', 'swagger', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'moonlight', 'hidden-power', 'sunny-day', 'shadow-ball', 'uproar', 'heat-wave', 'torment', 'facade', 'taunt', 'brick-break', 'snatch', 'secret-power', 'hyper-voice', 'air-cutter', 'aerial-ace', 'dragon-claw', 'water-pulse', 'roost', 'tailwind', 'u-turn', 'dark-pulse', 'air-slash', 'x-scissor', 'dragon-pulse', 'focus-blast', 'giga-impact', 'shadow-claw', 'draco-meteor', 'hone-claws', 'round', 'echoed-voice', 'acrobatics', 'wild-charge', 'hurricane', 'boomburst', 'confide'], 'name': 'noivern', 'stats': {'hp': 85, 'attack': 70, 'defense': 80, 'special-attack': 97, 'special-defense': 80, 'speed': 123}, 'types': ['flying', 'dragon'], 'weight': 850, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'purple', 'shape': 'wings', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['flying'], 'names': {'ja-Hrkt': 'オンバーン', 'ko': '음번', 'zh-Hant': '音波龍', 'fr': 'Bruyverne', 'de': 'UHaFnir', 'es': 'Noivern', 'it': 'Noivern', 'en': 'Noivern', 'ja': 'オンバーン', 'zh-Hans': '音波龙'}, 'genera': {'ja-Hrkt': 'おんぱポケモン', 'ko': '음파포켓몬', 'zh-Hant': '音波寶可夢', 'fr': 'Pokémon Ondes', 'de': 'Schallwellen', 'es': 'Pokémon Onda Sónica', 'it': 'Pokémon Ondasonora', 'en': 'Sound Wave Pokémon', 'ja': 'おんぱポケモン', 'zh-Hans': '音波宝可梦'}}
	public class SpecieNoivern : PokemonSpecie
	{
#nullable enable
		private static SpecieNoivern? _instance = null;
#nullable restore
        public static SpecieNoivern Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieNoivern();
                }
                return _instance;
            }
        }

		public SpecieNoivern() : base(
			"Noivern",
			85, // HPs
			70, 80, // Attack & Defense
			97, 80, // Special Attack & Defense
			123			
		) {}
	}


	//Noivern Pokemon Class
	public class Noivern : Pokemon
	{

		public Noivern(string nickname, int level)
		: base(
				715,
				SpecieNoivern.Instance, // Pokemon Specie
				nickname, level,
				Flying.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Noivern() : base(
			715,
			SpecieNoivern.Instance, // Pokemon Specie
			Flying.Instance, Dragon.Instance			
		) {}
	}
}