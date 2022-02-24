using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Bruxish Specie to store common natural stats of every {'abilities': ['dazzling', 'strong-jaw', 'wonder-skin'], 'base_experience': 166, 'height': 9, 'id': 779, 'moves': ['swords-dance', 'bite', 'disable', 'water-gun', 'surf', 'ice-beam', 'blizzard', 'toxic', 'confusion', 'psychic', 'rage', 'screech', 'double-team', 'light-screen', 'reflect', 'waterfall', 'dream-eater', 'psywave', 'rest', 'substitute', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'crunch', 'torment', 'facade', 'taunt', 'poison-fang', 'astonish', 'aerial-ace', 'bulk-up', 'calm-mind', 'water-pulse', 'payback', 'embargo', 'fling', 'aqua-tail', 'giga-impact', 'ice-fang', 'trick-room', 'aqua-jet', 'venoshock', 'synchronoise', 'round', 'scald', 'frost-breath', 'confide', 'psychic-fangs'], 'name': 'bruxish', 'stats': {'hp': 68, 'attack': 105, 'defense': 70, 'special-attack': 70, 'special-defense': 70, 'speed': 92}, 'types': ['water', 'psychic'], 'weight': 190, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 80, 'color': 'pink', 'shape': 'fish', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'ハギギシリ', 'ko': '치갈기', 'zh-Hant': '磨牙彩皮魚', 'fr': 'Denticrisse', 'de': 'Knirfish', 'es': 'Bruxish', 'it': 'Bruxish', 'en': 'Bruxish', 'ja': 'ハギギシリ', 'zh-Hans': '磨牙彩皮鱼'}, 'genera': {'ja-Hrkt': 'はぎしりポケモン', 'ko': '이갈기포켓몬', 'zh-Hant': '磨牙寶可夢', 'fr': 'Pokémon Grincedent', 'de': 'Knirschzahn', 'es': 'Pokémon Rechinante', 'it': 'Pokémon Sfregadenti', 'en': 'Gnash Teeth Pokémon', 'ja': 'はぎしりポケモン', 'zh-Hans': '磨牙宝可梦'}}
	public class SpecieBruxish : PokemonSpecie
	{
#nullable enable
		private static SpecieBruxish? _instance = null;
#nullable restore
        public static SpecieBruxish Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBruxish();
                }
                return _instance;
            }
        }

		public SpecieBruxish() : base(
			"Bruxish",
			68, // HPs
			105, 70, // Attack & Defense
			70, 70, // Special Attack & Defense
			92			
		) {}
	}


	//Bruxish Pokemon Class
	public class Bruxish : Pokemon
	{

		public Bruxish(string nickname, int level)
		: base(
				779,
				SpecieBruxish.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Bruxish() : base(
			779,
			SpecieBruxish.Instance, // Pokemon Specie
			Water.Instance, Psychic.Instance			
		) {}
	}
}