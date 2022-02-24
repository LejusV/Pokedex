using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Persian Specie to store common natural stats of every {'abilities': ['limber', 'technician', 'unnerve'], 'base_experience': 154, 'height': 10, 'id': 53, 'moves': ['pay-day', 'scratch', 'cut', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'bite', 'growl', 'roar', 'water-gun', 'bubble-beam', 'hyper-beam', 'thunderbolt', 'thunder', 'dig', 'toxic', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'bide', 'swift', 'skull-bash', 'dream-eater', 'flash', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'uproar', 'torment', 'facade', 'taunt', 'knock-off', 'snatch', 'secret-power', 'hyper-voice', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'feint', 'u-turn', 'payback', 'assurance', 'embargo', 'last-resort', 'dark-pulse', 'night-slash', 'seed-bomb', 'power-gem', 'switcheroo', 'giga-impact', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'captivate', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'retaliate', 'work-up', 'play-rough', 'confide'], 'name': 'persian', 'stats': {'hp': 65, 'attack': 70, 'defense': 60, 'special-attack': 65, 'special-defense': 65, 'speed': 115}, 'types': ['normal'], 'weight': 320, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ペルシアン', 'roomaji': 'Persian', 'ko': '페르시온', 'zh-Hant': '貓老大', 'fr': 'Persian', 'de': 'Snobilikat', 'es': 'Persian', 'it': 'Persian', 'en': 'Persian', 'ja': 'ペルシアン', 'zh-Hans': '猫老大'}, 'genera': {'ja-Hrkt': 'シャムネコポケモン', 'ko': '샴고양이포켓몬', 'zh-Hant': '暹羅貓寶可夢', 'fr': 'Pokémon Chadeville', 'de': 'Rassekatze', 'es': 'Pokémon Gato Fino', 'it': 'Pokémon Nobilgatto', 'en': 'Classy Cat Pokémon', 'ja': 'シャムネコポケモン', 'zh-Hans': '暹罗猫宝可梦'}}
	public class SpeciePersian : PokemonSpecie
	{
#nullable enable
		private static SpeciePersian? _instance = null;
#nullable restore
        public static SpeciePersian Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePersian();
                }
                return _instance;
            }
        }

		public SpeciePersian() : base(
			"Persian",
			65, // HPs
			70, 60, // Attack & Defense
			65, 65, // Special Attack & Defense
			115			
		) {}
	}


	//Persian Pokemon Class
	public class Persian : Pokemon
	{

		public Persian(string nickname, int level)
		: base(
				53,
				SpeciePersian.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Persian() : base(
			53,
			SpeciePersian.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}