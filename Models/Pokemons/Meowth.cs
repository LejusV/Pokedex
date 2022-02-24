using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Meowth Specie to store common natural stats of every {'abilities': ['pickup', 'technician', 'unnerve'], 'base_experience': 58, 'height': 4, 'id': 52, 'moves': ['pay-day', 'scratch', 'cut', 'headbutt', 'body-slam', 'take-down', 'double-edge', 'tail-whip', 'bite', 'growl', 'water-gun', 'bubble-beam', 'thunderbolt', 'thunder', 'dig', 'toxic', 'hypnosis', 'rage', 'mimic', 'screech', 'double-team', 'defense-curl', 'bide', 'swift', 'skull-bash', 'amnesia', 'dream-eater', 'flash', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'flail', 'spite', 'protect', 'feint-attack', 'mud-slap', 'zap-cannon', 'icy-wind', 'detect', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'fake-out', 'uproar', 'torment', 'facade', 'taunt', 'assist', 'knock-off', 'snatch', 'secret-power', 'hyper-voice', 'odor-sleuth', 'aerial-ace', 'covet', 'shock-wave', 'water-pulse', 'natural-gift', 'feint', 'u-turn', 'payback', 'assurance', 'punishment', 'last-resort', 'dark-pulse', 'night-slash', 'seed-bomb', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'captivate', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'retaliate', 'work-up', 'confide'], 'name': 'meowth', 'stats': {'hp': 40, 'attack': 45, 'defense': 35, 'special-attack': 40, 'special-defense': 40, 'speed': 90}, 'types': ['normal'], 'weight': 42, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 255, 'color': 'yellow', 'shape': 'quadruped', 'habitat': 'urban', 'generation': 'generation-i', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ニャース', 'roomaji': 'Nyarth', 'ko': '나옹', 'zh-Hant': '喵喵', 'fr': 'Miaouss', 'de': 'Mauzi', 'es': 'Meowth', 'it': 'Meowth', 'en': 'Meowth', 'ja': 'ニャース', 'zh-Hans': '喵喵'}, 'genera': {'ja-Hrkt': 'ばけねこポケモン', 'ko': '요괴고양이포켓몬', 'zh-Hant': '妖怪貓寶可夢', 'fr': 'Pokémon Chadégout', 'de': 'Katze', 'es': 'Pokémon Gato Araña', 'it': 'Pokémon Graffimiao', 'en': 'Scratch Cat Pokémon', 'ja': 'ばけねこポケモン', 'zh-Hans': '妖怪猫宝可梦'}}
	public class SpecieMeowth : PokemonSpecie
	{
#nullable enable
		private static SpecieMeowth? _instance = null;
#nullable restore
        public static SpecieMeowth Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMeowth();
                }
                return _instance;
            }
        }

		public SpecieMeowth() : base(
			"Meowth",
			40, // HPs
			45, 35, // Attack & Defense
			40, 40, // Special Attack & Defense
			90			
		) {}
	}


	//Meowth Pokemon Class
	public class Meowth : Pokemon
	{

		public Meowth(string nickname, int level)
		: base(
				52,
				SpecieMeowth.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Meowth() : base(
			52,
			SpecieMeowth.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}