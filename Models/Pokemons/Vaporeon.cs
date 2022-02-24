using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Vaporeon Specie to store common natural stats of every {'abilities': ['water-absorb', 'hydration'], 'base_experience': 184, 'height': 10, 'id': 134, 'moves': ['sand-attack', 'headbutt', 'tackle', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'roar', 'mist', 'water-gun', 'hydro-pump', 'surf', 'ice-beam', 'blizzard', 'bubble-beam', 'aurora-beam', 'hyper-beam', 'strength', 'dig', 'toxic', 'quick-attack', 'rage', 'mimic', 'double-team', 'haze', 'reflect', 'bide', 'waterfall', 'swift', 'skull-bash', 'acid-armor', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'icy-wind', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'shadow-ball', 'rock-smash', 'whirlpool', 'hail', 'facade', 'helping-hand', 'secret-power', 'dive', 'hyper-voice', 'signal-beam', 'muddy-water', 'covet', 'water-pulse', 'brine', 'natural-gift', 'last-resort', 'aqua-ring', 'aqua-tail', 'giga-impact', 'captivate', 'round', 'echoed-voice', 'scald', 'retaliate', 'work-up', 'confide', 'baby-doll-eyes'], 'name': 'vaporeon', 'stats': {'hp': 130, 'attack': 65, 'defense': 60, 'special-attack': 110, 'special-defense': 95, 'speed': 65}, 'types': ['water'], 'weight': 290, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 35, 'gender_rate': 1, 'capture_rate': 45, 'color': 'blue', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'シャワーズ', 'roomaji': 'Showers', 'ko': '샤미드', 'zh-Hant': '水伊布', 'fr': 'Aquali', 'de': 'Aquana', 'es': 'Vaporeon', 'it': 'Vaporeon', 'en': 'Vaporeon', 'ja': 'シャワーズ', 'zh-Hans': '水伊布'}, 'genera': {'ja-Hrkt': 'あわはきポケモン', 'ko': '거품뿜기포켓몬', 'zh-Hant': '吐泡寶可夢', 'fr': 'Pokémon Bulleur', 'de': 'Blubbblase', 'es': 'Pokémon Burbuja', 'it': 'Pokémon Bollajet', 'en': 'Bubble Jet Pokémon', 'ja': 'あわはきポケモン', 'zh-Hans': '吐泡宝可梦'}}
	public class SpecieVaporeon : PokemonSpecie
	{
#nullable enable
		private static SpecieVaporeon? _instance = null;
#nullable restore
        public static SpecieVaporeon Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVaporeon();
                }
                return _instance;
            }
        }

		public SpecieVaporeon() : base(
			"Vaporeon",
			130, // HPs
			65, 60, // Attack & Defense
			110, 95, // Special Attack & Defense
			65			
		) {}
	}


	//Vaporeon Pokemon Class
	public class Vaporeon : Pokemon
	{

		public Vaporeon(string nickname, int level)
		: base(
				134,
				SpecieVaporeon.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vaporeon(int level)
		: base(
				134,
				SpecieVaporeon.Instance, // Pokemon Specie
				"Vaporeon", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Vaporeon() : base(
			134,
			SpecieVaporeon.Instance, // Pokemon Specie
			Water.Instance			
		) {}
	}
}