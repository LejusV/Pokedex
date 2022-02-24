using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Oranguru Specie to store common natural stats of every {'abilities': ['inner-focus', 'telepathy', 'symbiosis'], 'base_experience': 172, 'height': 15, 'id': 765, 'moves': ['thunderbolt', 'thunder', 'earthquake', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'rest', 'rock-slide', 'substitute', 'protect', 'feint-attack', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'facade', 'nature-power', 'taunt', 'brick-break', 'extrasensory', 'calm-mind', 'payback', 'embargo', 'fling', 'focus-blast', 'energy-ball', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'trick-room', 'charge-beam', 'wonder-room', 'psyshock', 'foul-play', 'after-you', 'round', 'stored-power', 'quash', 'bulldoze', 'work-up', 'confide', 'psychic-terrain', 'instruct', 'brutal-swing'], 'name': 'oranguru', 'stats': {'hp': 90, 'attack': 60, 'defense': 80, 'special-attack': 90, 'special-defense': 110, 'speed': 60}, 'types': ['normal', 'psychic'], 'weight': 760, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 45, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'ヤレユータン', 'ko': '하랑우탄', 'zh-Hant': '智揮猩', 'fr': 'Gouroutan', 'de': 'Kommandutan', 'es': 'Oranguru', 'it': 'Oranguru', 'en': 'Oranguru', 'ja': 'ヤレユータン', 'zh-Hans': '智挥猩'}, 'genera': {'ja-Hrkt': 'けんじゃポケモン', 'ko': '현자포켓몬', 'zh-Hant': '賢者寶可夢', 'fr': 'Pokémon Grand Sage', 'de': 'Weisheit', 'es': 'Pokémon Sabio', 'it': 'Pokémon Saggio', 'en': 'Sage Pokémon', 'ja': 'けんじゃポケモン', 'zh-Hans': '贤者宝可梦'}}
	public class SpecieOranguru : PokemonSpecie
	{
#nullable enable
		private static SpecieOranguru? _instance = null;
#nullable restore
        public static SpecieOranguru Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieOranguru();
                }
                return _instance;
            }
        }

		public SpecieOranguru() : base(
			"Oranguru",
			90, // HPs
			60, 80, // Attack & Defense
			90, 110, // Special Attack & Defense
			60			
		) {}
	}


	//Oranguru Pokemon Class
	public class Oranguru : Pokemon
	{

		public Oranguru(string nickname, int level)
		: base(
				765,
				SpecieOranguru.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Oranguru() : base(
			765,
			SpecieOranguru.Instance, // Pokemon Specie
			Normal.Instance, Psychic.Instance			
		) {}
	}
}