using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Litleo Specie to store common natural stats of every {'abilities': ['rivalry', 'unnerve', 'moxie'], 'base_experience': 74, 'height': 6, 'id': 667, 'moves': ['headbutt', 'tackle', 'take-down', 'leer', 'roar', 'ember', 'flamethrower', 'strength', 'solar-beam', 'fire-spin', 'dig', 'toxic', 'double-team', 'fire-blast', 'rest', 'substitute', 'thief', 'snore', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'rock-smash', 'heat-wave', 'will-o-wisp', 'facade', 'taunt', 'helping-hand', 'yawn', 'endeavor', 'snatch', 'secret-power', 'hyper-voice', 'overheat', 'payback', 'flare-blitz', 'dark-pulse', 'fire-fang', 'flame-charge', 'entrainment', 'round', 'echoed-voice', 'incinerate', 'retaliate', 'bulldoze', 'work-up', 'wild-charge', 'snarl', 'noble-roar', 'confide'], 'name': 'litleo', 'stats': {'hp': 62, 'attack': 50, 'defense': 58, 'special-attack': 73, 'special-defense': 54, 'speed': 72}, 'types': ['fire', 'normal'], 'weight': 135, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 7, 'capture_rate': 220, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'シシコ', 'ko': '레오꼬', 'zh-Hant': '小獅獅', 'fr': 'Hélionceau', 'de': 'Leufeo', 'es': 'Litleo', 'it': 'Litleo', 'en': 'Litleo', 'ja': 'シシコ', 'zh-Hans': '小狮狮'}, 'genera': {'ja-Hrkt': 'わかじしポケモン', 'ko': '어린사자포켓몬', 'zh-Hant': '幼獅寶可夢', 'fr': 'Pokémon Lionceau', 'de': 'Junglöwe', 'es': 'Pokémon Leoncito', 'it': 'Pokémon Leoncino', 'en': 'Lion Cub Pokémon', 'ja': 'わかじしポケモン', 'zh-Hans': '幼狮宝可梦'}}
	public class SpecieLitleo : PokemonSpecie
	{
#nullable enable
		private static SpecieLitleo? _instance = null;
#nullable restore
        public static SpecieLitleo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLitleo();
                }
                return _instance;
            }
        }

		public SpecieLitleo() : base(
			"Litleo",
			62, // HPs
			50, 58, // Attack & Defense
			73, 54, // Special Attack & Defense
			72			
		) {}
	}


	//Litleo Pokemon Class
	public class Litleo : Pokemon
	{

		public Litleo(string nickname, int level)
		: base(
				667,
				SpecieLitleo.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Litleo(int level)
		: base(
				667,
				SpecieLitleo.Instance, // Pokemon Specie
				"Litleo", level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Litleo() : base(
			667,
			SpecieLitleo.Instance, // Pokemon Specie
			Fire.Instance, Normal.Instance			
		) {}
	}
}