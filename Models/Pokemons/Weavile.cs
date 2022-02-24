using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Weavile Specie to store common natural stats of every {'abilities': ['pressure', 'pickpocket'], 'base_experience': 179, 'height': 11, 'id': 461, 'moves': ['ice-punch', 'scratch', 'swords-dance', 'cut', 'headbutt', 'leer', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'low-kick', 'strength', 'dig', 'toxic', 'quick-attack', 'screech', 'double-team', 'reflect', 'swift', 'dream-eater', 'fury-swipes', 'rest', 'substitute', 'thief', 'snore', 'spite', 'protect', 'feint-attack', 'mud-slap', 'icy-wind', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'hail', 'torment', 'facade', 'focus-punch', 'taunt', 'revenge', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'aerial-ace', 'calm-mind', 'natural-gift', 'payback', 'assurance', 'embargo', 'fling', 'punishment', 'poison-jab', 'dark-pulse', 'night-slash', 'x-scissor', 'focus-blast', 'giga-impact', 'nasty-plot', 'avalanche', 'shadow-claw', 'captivate', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'retaliate', 'snarl', 'confide', 'power-up-punch'], 'name': 'weavile', 'stats': {'hp': 70, 'attack': 120, 'defense': 65, 'special-attack': 45, 'special-defense': 85, 'speed': 125}, 'types': ['dark', 'ice'], 'weight': 340, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'black', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'マニューラ', 'roomaji': 'Manyula', 'ko': '포푸니라', 'zh-Hant': '瑪狃拉', 'fr': 'Dimoret', 'de': 'Snibunna', 'es': 'Weavile', 'it': 'Weavile', 'en': 'Weavile', 'ja': 'マニューラ', 'zh-Hans': '玛狃拉'}, 'genera': {'ja-Hrkt': 'かぎづめポケモン', 'ko': '갈고리손톱포켓몬', 'zh-Hant': '鉤爪寶可夢', 'fr': 'Pokémon Grifacérée', 'de': 'Stichklaue', 'es': 'Pokémon Garra Filo', 'it': 'Pokémon Lamartigli', 'en': 'Sharp Claw Pokémon', 'ja': 'かぎづめポケモン', 'zh-Hans': '钩爪宝可梦'}}
	public class SpecieWeavile : PokemonSpecie
	{
#nullable enable
		private static SpecieWeavile? _instance = null;
#nullable restore
        public static SpecieWeavile Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieWeavile();
                }
                return _instance;
            }
        }

		public SpecieWeavile() : base(
			"Weavile",
			70, // HPs
			120, 65, // Attack & Defense
			45, 85, // Special Attack & Defense
			125			
		) {}
	}


	//Weavile Pokemon Class
	public class Weavile : Pokemon
	{

		public Weavile(string nickname, int level)
		: base(
				461,
				SpecieWeavile.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Weavile(int level)
		: base(
				461,
				SpecieWeavile.Instance, // Pokemon Specie
				"Weavile", level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Weavile() : base(
			461,
			SpecieWeavile.Instance, // Pokemon Specie
			Dark.Instance, Ice.Instance			
		) {}
	}
}