using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Sneasel Specie to store common natural stats of every {'abilities': ['inner-focus', 'keen-eye', 'pickpocket'], 'base_experience': 86, 'height': 9, 'id': 215, 'moves': ['ice-punch', 'scratch', 'swords-dance', 'cut', 'headbutt', 'double-edge', 'leer', 'bite', 'surf', 'ice-beam', 'blizzard', 'low-kick', 'counter', 'strength', 'dig', 'toxic', 'agility', 'quick-attack', 'mimic', 'screech', 'double-team', 'defense-curl', 'reflect', 'swift', 'dream-eater', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'mud-slap', 'foresight', 'icy-wind', 'detect', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'attract', 'sleep-talk', 'return', 'frustration', 'dynamic-punch', 'pursuit', 'iron-tail', 'metal-claw', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'whirlpool', 'beat-up', 'fake-out', 'hail', 'torment', 'facade', 'focus-punch', 'taunt', 'assist', 'brick-break', 'knock-off', 'snatch', 'secret-power', 'crush-claw', 'aerial-ace', 'calm-mind', 'natural-gift', 'feint', 'payback', 'embargo', 'fling', 'punishment', 'poison-jab', 'dark-pulse', 'x-scissor', 'avalanche', 'ice-shard', 'shadow-claw', 'captivate', 'double-hit', 'hone-claws', 'low-sweep', 'foul-play', 'round', 'retaliate', 'snarl', 'icicle-crash', 'confide', 'power-up-punch', 'throat-chop'], 'name': 'sneasel', 'stats': {'hp': 55, 'attack': 95, 'defense': 55, 'special-attack': 35, 'special-defense': 75, 'speed': 115}, 'types': ['dark', 'ice'], 'weight': 280, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 60, 'color': 'black', 'shape': 'upright', 'habitat': 'forest', 'generation': 'generation-ii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニューラ', 'roomaji': 'Nyula', 'ko': '포푸니', 'zh-Hant': '狃拉', 'fr': 'Farfuret', 'de': 'Sniebel', 'es': 'Sneasel', 'it': 'Sneasel', 'en': 'Sneasel', 'ja': 'ニューラ', 'zh-Hans': '狃拉'}, 'genera': {'ja-Hrkt': 'かぎづめポケモン', 'ko': '갈고리손톱포켓몬', 'zh-Hant': '鉤爪寶可夢', 'fr': 'Pokémon Grifacérée', 'de': 'Stichklaue', 'es': 'Pokémon Garra Filo', 'it': 'Pokémon Lamartigli', 'en': 'Sharp Claw Pokémon', 'ja': 'かぎづめポケモン', 'zh-Hans': '钩爪宝可梦'}}
	public class SpecieSneasel : PokemonSpecie
	{
#nullable enable
		private static SpecieSneasel? _instance = null;
#nullable restore
        public static SpecieSneasel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieSneasel();
                }
                return _instance;
            }
        }

		public SpecieSneasel() : base(
			"Sneasel",
			55, // HPs
			95, 55, // Attack & Defense
			35, 75, // Special Attack & Defense
			115			
		) {}
	}


	//Sneasel Pokemon Class
	public class Sneasel : Pokemon
	{

		public Sneasel(string nickname, int level)
		: base(
				215,
				SpecieSneasel.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance, Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Sneasel() : base(
			215,
			SpecieSneasel.Instance, // Pokemon Specie
			Dark.Instance, Ice.Instance			
		) {}
	}
}