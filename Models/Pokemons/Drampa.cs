using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Drampa Specie to store common natural stats of every {'abilities': ['berserk', 'sap-sipper', 'cloud-nine'], 'base_experience': 170, 'height': 30, 'id': 780, 'moves': ['razor-wind', 'fly', 'roar', 'flamethrower', 'mist', 'surf', 'ice-beam', 'blizzard', 'hyper-beam', 'solar-beam', 'dragon-rage', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'double-team', 'light-screen', 'fire-blast', 'glare', 'rest', 'rock-slide', 'substitute', 'protect', 'outrage', 'steel-wing', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'dragon-breath', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'facade', 'nature-power', 'hyper-voice', 'extrasensory', 'dragon-claw', 'calm-mind', 'roost', 'natural-gift', 'fling', 'dragon-pulse', 'dragon-rush', 'focus-blast', 'energy-ball', 'giga-impact', 'shadow-claw', 'draco-meteor', 'grass-knot', 'round', 'echoed-voice', 'bulldoze', 'dragon-tail', 'work-up', 'hurricane', 'snarl', 'play-rough', 'play-nice', 'confide'], 'name': 'drampa', 'stats': {'hp': 78, 'attack': 60, 'defense': 85, 'special-attack': 135, 'special-defense': 91, 'speed': 36}, 'types': ['normal', 'dragon'], 'weight': 1850, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 70, 'color': 'white', 'shape': 'squiggle', 'habitat': None, 'generation': 'generation-vii', 'growth_rate': 'medium', 'egg_groups': ['monster', 'dragon'], 'names': {'ja-Hrkt': 'ジジーロン', 'ko': '할비롱', 'zh-Hant': '老翁龍', 'fr': 'Draïeul', 'de': 'Sen-Long', 'es': 'Drampa', 'it': 'Drampa', 'en': 'Drampa', 'ja': 'ジジーロン', 'zh-Hans': '老翁龙'}, 'genera': {'ja-Hrkt': 'ゆうゆうポケモン', 'ko': '느긋누긋포켓몬', 'zh-Hant': '悠遊寶可夢', 'fr': 'Pokémon Nonchalant', 'de': 'Gelassenheit', 'es': 'Pokémon Sosiego', 'it': 'Pokémon Tuttacalma', 'en': 'Placid Pokémon', 'ja': 'ゆうゆうポケモン', 'zh-Hans': '悠游宝可梦'}}
	public class SpecieDrampa : PokemonSpecie
	{
#nullable enable
		private static SpecieDrampa? _instance = null;
#nullable restore
        public static SpecieDrampa Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDrampa();
                }
                return _instance;
            }
        }

		public SpecieDrampa() : base(
			"Drampa",
			78, // HPs
			60, 85, // Attack & Defense
			135, 91, // Special Attack & Defense
			36			
		) {}
	}


	//Drampa Pokemon Class
	public class Drampa : Pokemon
	{

		public Drampa(string nickname, int level)
		: base(
				780,
				SpecieDrampa.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance, Dragon.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Drampa() : base(
			780,
			SpecieDrampa.Instance, // Pokemon Specie
			Normal.Instance, Dragon.Instance			
		) {}
	}
}