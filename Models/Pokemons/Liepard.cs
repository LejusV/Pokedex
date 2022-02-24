using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Liepard Specie to store common natural stats of every {'abilities': ['limber', 'unburden', 'prankster'], 'base_experience': 156, 'height': 11, 'id': 510, 'moves': ['scratch', 'cut', 'sand-attack', 'growl', 'hyper-beam', 'thunder-wave', 'toxic', 'double-team', 'dream-eater', 'fury-swipes', 'rest', 'slash', 'substitute', 'thief', 'snore', 'spite', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'fake-out', 'torment', 'facade', 'taunt', 'trick', 'role-play', 'assist', 'knock-off', 'snatch', 'secret-power', 'hyper-voice', 'aerial-ace', 'covet', 'u-turn', 'payback', 'assurance', 'embargo', 'sucker-punch', 'dark-pulse', 'night-slash', 'seed-bomb', 'giga-impact', 'nasty-plot', 'shadow-claw', 'gunk-shot', 'grass-knot', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'snarl', 'play-rough', 'confide'], 'name': 'liepard', 'stats': {'hp': 64, 'attack': 88, 'defense': 50, 'special-attack': 88, 'special-defense': 50, 'speed': 106}, 'types': ['dark'], 'weight': 375, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 90, 'color': 'purple', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium', 'egg_groups': ['ground'], 'names': {'zh-Hant': '酷豹', 'ja-Hrkt': 'レパルダス', 'ko': '레파르다스', 'fr': 'Léopardus', 'de': 'Kleoparda', 'es': 'Liepard', 'it': 'Liepard', 'en': 'Liepard', 'ja': 'レパルダス', 'zh-Hans': '酷豹'}, 'genera': {'zh-Hant': '冷酷寶可夢', 'ja-Hrkt': 'れいこくポケモン', 'ko': '냉혹포켓몬', 'fr': 'Pokémon Implacable', 'de': 'Gefühlskälte', 'es': 'Pokémon Calculador', 'it': 'Pokémon Sanguefreddo', 'en': 'Cruel Pokémon', 'ja': 'れいこくポケモン', 'zh-Hans': '冷酷宝可梦'}}
	public class SpecieLiepard : PokemonSpecie
	{
#nullable enable
		private static SpecieLiepard? _instance = null;
#nullable restore
        public static SpecieLiepard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLiepard();
                }
                return _instance;
            }
        }

		public SpecieLiepard() : base(
			"Liepard",
			64, // HPs
			88, 50, // Attack & Defense
			88, 50, // Special Attack & Defense
			106			
		) {}
	}


	//Liepard Pokemon Class
	public class Liepard : Pokemon
	{

		public Liepard(string nickname, int level)
		: base(
				510,
				SpecieLiepard.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Liepard() : base(
			510,
			SpecieLiepard.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}