using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Lillipup Specie to store common natural stats of every {'abilities': ['vital-spirit', 'pickup', 'run-away'], 'base_experience': 55, 'height': 4, 'id': 506, 'moves': ['sand-attack', 'tackle', 'take-down', 'leer', 'bite', 'roar', 'thunderbolt', 'thunder-wave', 'dig', 'toxic', 'double-team', 'lick', 'rest', 'substitute', 'snore', 'reversal', 'protect', 'mud-slap', 'endure', 'charm', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'crunch', 'shadow-ball', 'rock-smash', 'uproar', 'facade', 'helping-hand', 'yawn', 'secret-power', 'hyper-voice', 'odor-sleuth', 'rock-tomb', 'aerial-ace', 'howl', 'covet', 'shock-wave', 'last-resort', 'giga-impact', 'thunder-fang', 'ice-fang', 'fire-fang', 'after-you', 'round', 'retaliate', 'work-up', 'wild-charge', 'snarl', 'play-rough', 'confide', 'baby-doll-eyes', 'psychic-fangs'], 'name': 'lillipup', 'stats': {'hp': 45, 'attack': 60, 'defense': 45, 'special-attack': 25, 'special-defense': 45, 'speed': 55}, 'types': ['normal'], 'weight': 41, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 15, 'gender_rate': 4, 'capture_rate': 255, 'color': 'brown', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヨーテリー', 'ko': '요테리', 'zh-Hant': '小約克', 'fr': 'Ponchiot', 'de': 'Yorkleff', 'es': 'Lillipup', 'it': 'Lillipup', 'en': 'Lillipup', 'ja': 'ヨーテリー', 'zh-Hans': '小约克'}, 'genera': {'ja-Hrkt': 'こいぬポケモン', 'ko': '강아지포켓몬', 'zh-Hant': '小狗寶可夢', 'fr': 'Pokémon Chiot', 'de': 'Hund', 'es': 'Pokémon Perrito', 'it': 'Pokémon Cagnolino', 'en': 'Puppy Pokémon', 'ja': 'こいぬポケモン', 'zh-Hans': '小狗宝可梦'}}
	public class SpecieLillipup : PokemonSpecie
	{
#nullable enable
		private static SpecieLillipup? _instance = null;
#nullable restore
        public static SpecieLillipup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieLillipup();
                }
                return _instance;
            }
        }

		public SpecieLillipup() : base(
			"Lillipup",
			45, // HPs
			60, 45, // Attack & Defense
			25, 45, // Special Attack & Defense
			55			
		) {}
	}


	//Lillipup Pokemon Class
	public class Lillipup : Pokemon
	{

		public Lillipup(string nickname, int level)
		: base(
				506,
				SpecieLillipup.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lillipup(int level)
		: base(
				506,
				SpecieLillipup.Instance, // Pokemon Specie
				"Lillipup", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Lillipup() : base(
			506,
			SpecieLillipup.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}