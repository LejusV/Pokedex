using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Malamar Specie to store common natural stats of every {'abilities': ['contrary', 'suction-cups', 'infiltrator'], 'base_experience': 169, 'height': 15, 'id': 687, 'moves': ['cut', 'bind', 'tackle', 'flamethrower', 'psybeam', 'hyper-beam', 'peck', 'thunderbolt', 'toxic', 'psychic', 'hypnosis', 'double-team', 'light-screen', 'reflect', 'constrict', 'flash', 'psywave', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'snore', 'reversal', 'spite', 'protect', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'torment', 'facade', 'taunt', 'role-play', 'superpower', 'knock-off', 'snatch', 'secret-power', 'signal-beam', 'aerial-ace', 'block', 'calm-mind', 'pluck', 'payback', 'embargo', 'fling', 'dark-pulse', 'night-slash', 'switcheroo', 'giga-impact', 'psycho-cut', 'trick-room', 'psyshock', 'foul-play', 'round', 'retaliate', 'topsy-turvy', 'confide', 'brutal-swing'], 'name': 'malamar', 'stats': {'hp': 86, 'attack': 92, 'defense': 88, 'special-attack': 68, 'special-defense': 75, 'speed': 73}, 'types': ['dark', 'psychic'], 'weight': 470, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 80, 'color': 'blue', 'shape': 'blob', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['water1', 'water2'], 'names': {'ja-Hrkt': 'カラマネロ', 'ko': '칼라마네로', 'zh-Hant': '烏賊王', 'fr': 'Sepiatroce', 'de': 'Calamanero', 'es': 'Malamar', 'it': 'Malamar', 'en': 'Malamar', 'ja': 'カラマネロ', 'zh-Hans': '乌贼王'}, 'genera': {'ja-Hrkt': 'ぎゃくてんポケモン', 'ko': '역전포켓몬', 'zh-Hant': '倒轉寶可夢', 'fr': 'Pokémon Révolution', 'de': 'Inversion', 'es': 'Pokémon Revolución', 'it': 'Pokémon Giravolta', 'en': 'Overturning Pokémon', 'ja': 'ぎゃくてんポケモン', 'zh-Hans': '倒转宝可梦'}}
	public class SpecieMalamar : PokemonSpecie
	{
#nullable enable
		private static SpecieMalamar? _instance = null;
#nullable restore
        public static SpecieMalamar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieMalamar();
                }
                return _instance;
            }
        }

		public SpecieMalamar() : base(
			"Malamar",
			86, // HPs
			92, 88, // Attack & Defense
			68, 75, // Special Attack & Defense
			73			
		) {}
	}


	//Malamar Pokemon Class
	public class Malamar : Pokemon
	{

		public Malamar(string nickname, int level) : base(
			687,
			SpecieMalamar.Instance, // Pokemon Specie
			nickname, level,
			Dark.Instance, Psychic.Instance			
		) {}

		public Malamar() : base(
			687,
			SpecieMalamar.Instance, // Pokemon Specie
			Dark.Instance, Psychic.Instance			
		) {}
	}
}