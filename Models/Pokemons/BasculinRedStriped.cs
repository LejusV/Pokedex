using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Basculin-Red-Striped Specie to store common natural stats of every {'abilities': ['reckless', 'adaptability', 'mold-breaker'], 'base_experience': 161, 'height': 10, 'id': 550, 'moves': ['cut', 'headbutt', 'tackle', 'take-down', 'thrash', 'double-edge', 'tail-whip', 'bite', 'water-gun', 'surf', 'ice-beam', 'bubble-beam', 'toxic', 'agility', 'rage', 'double-team', 'waterfall', 'swift', 'rest', 'substitute', 'snore', 'flail', 'protect', 'scary-face', 'icy-wind', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'crunch', 'whirlpool', 'uproar', 'hail', 'facade', 'taunt', 'superpower', 'revenge', 'endeavor', 'secret-power', 'dive', 'muddy-water', 'bounce', 'mud-shot', 'brine', 'aqua-tail', 'zen-headbutt', 'aqua-jet', 'head-smash', 'soak', 'round', 'chip-away', 'scald', 'final-gambit', 'confide'], 'name': 'basculin-red-striped', 'stats': {'hp': 70, 'attack': 92, 'defense': 65, 'special-attack': 80, 'special-defense': 55, 'speed': 98}, 'types': ['water'], 'weight': 180, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 40, 'gender_rate': 4, 'capture_rate': 25, 'color': 'green', 'shape': 'fish', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['water2'], 'names': {'ja-Hrkt': 'バスラオ', 'ko': '배쓰나이', 'zh-Hant': '野蠻鱸魚', 'fr': 'Bargantua', 'de': 'Barschuft', 'es': 'Basculin', 'it': 'Basculin', 'en': 'Basculin', 'ja': 'バスラオ', 'zh-Hans': '野蛮鲈鱼'}, 'genera': {'ja-Hrkt': 'らんぼうポケモン', 'ko': '흉포포켓몬', 'zh-Hant': '粗暴寶可夢', 'fr': 'Pokémon Violent', 'de': 'Grobheit', 'es': 'Pokémon Violento', 'it': 'Pokémon Irruenza', 'en': 'Hostile Pokémon', 'ja': 'らんぼうポケモン', 'zh-Hans': '粗暴宝可梦'}}
	public class SpecieBasculinRedStriped : PokemonSpecie
	{
#nullable enable
		private static SpecieBasculinRedStriped? _instance = null;
#nullable restore
        public static SpecieBasculinRedStriped Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieBasculinRedStriped();
                }
                return _instance;
            }
        }

		public SpecieBasculinRedStriped() : base(
			"Basculin-Red-Striped",
			70, // HPs
			92, 65, // Attack & Defense
			80, 55, // Special Attack & Defense
			98			
		) {}
	}


	//Basculin-Red-Striped Pokemon Class
	public class BasculinRedStriped : Pokemon
	{

		public BasculinRedStriped(string nickname, int level)
		: base(
				550,
				SpecieBasculinRedStriped.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public BasculinRedStriped() : base(
			550,
			SpecieBasculinRedStriped.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}