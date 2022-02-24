using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Keldeo-Ordinary Specie to store common natural stats of every {'abilities': ['justified'], 'base_experience': 261, 'height': 14, 'id': 647, 'moves': ['swords-dance', 'cut', 'double-kick', 'take-down', 'leer', 'roar', 'hydro-pump', 'surf', 'bubble-beam', 'hyper-beam', 'strength', 'toxic', 'double-team', 'reflect', 'rest', 'substitute', 'snore', 'protect', 'icy-wind', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'psych-up', 'rock-smash', 'hail', 'facade', 'taunt', 'helping-hand', 'superpower', 'endeavor', 'secret-power', 'aerial-ace', 'bounce', 'covet', 'calm-mind', 'water-pulse', 'close-combat', 'last-resort', 'poison-jab', 'aqua-tail', 'x-scissor', 'focus-blast', 'giga-impact', 'stone-edge', 'aqua-jet', 'round', 'quick-guard', 'scald', 'retaliate', 'work-up', 'sacred-sword', 'secret-sword', 'confide'], 'name': 'keldeo-ordinary', 'stats': {'hp': 91, 'attack': 72, 'defense': 90, 'special-attack': 129, 'special-defense': 90, 'speed': 108}, 'types': ['water', 'fighting'], 'weight': 485, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ケルディオ', 'ko': '케르디오', 'zh-Hant': '凱路迪歐', 'fr': 'Keldeo', 'de': 'Keldeo', 'es': 'Keldeo', 'it': 'Keldeo', 'en': 'Keldeo', 'ja': 'ケルディオ', 'zh-Hans': '凯路迪欧'}, 'genera': {'ja-Hrkt': 'わかごまポケモン', 'ko': '망아지포켓몬', 'zh-Hant': '幼馬寶可夢', 'fr': 'Pokémon Poulain', 'de': 'Fohlen', 'es': 'Pokémon Potro', 'it': 'Pokémon Puledro', 'en': 'Colt Pokémon', 'ja': 'わかごまポケモン', 'zh-Hans': '幼马宝可梦'}}
	public class SpecieKeldeoOrdinary : PokemonSpecie
	{
#nullable enable
		private static SpecieKeldeoOrdinary? _instance = null;
#nullable restore
        public static SpecieKeldeoOrdinary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieKeldeoOrdinary();
                }
                return _instance;
            }
        }

		public SpecieKeldeoOrdinary() : base(
			"Keldeo-Ordinary",
			91, // HPs
			72, 90, // Attack & Defense
			129, 90, // Special Attack & Defense
			108			
		) {}
	}


	//Keldeo-Ordinary Pokemon Class
	public class KeldeoOrdinary : Pokemon
	{

		public KeldeoOrdinary(string nickname, int level)
		: base(
				647,
				SpecieKeldeoOrdinary.Instance, // Pokemon Specie
				nickname, level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public KeldeoOrdinary(int level)
		: base(
				647,
				SpecieKeldeoOrdinary.Instance, // Pokemon Specie
				"Keldeo-Ordinary", level,
				Water.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public KeldeoOrdinary() : base(
			647,
			SpecieKeldeoOrdinary.Instance, // Pokemon Specie
			Water.Instance, Fighting.Instance			
		) {}
	}
}