using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Terrakion Specie to store common natural stats of every {'abilities': ['justified'], 'base_experience': 261, 'height': 19, 'id': 639, 'moves': ['swords-dance', 'cut', 'double-kick', 'take-down', 'leer', 'roar', 'hyper-beam', 'strength', 'earthquake', 'toxic', 'quick-attack', 'double-team', 'reflect', 'rest', 'rock-slide', 'substitute', 'snore', 'protect', 'sandstorm', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'psych-up', 'rock-smash', 'facade', 'taunt', 'helping-hand', 'superpower', 'secret-power', 'rock-tomb', 'aerial-ace', 'block', 'calm-mind', 'close-combat', 'rock-polish', 'poison-jab', 'x-scissor', 'focus-blast', 'earth-power', 'giga-impact', 'zen-headbutt', 'iron-head', 'stone-edge', 'stealth-rock', 'smack-down', 'round', 'quick-guard', 'retaliate', 'bulldoze', 'work-up', 'sacred-sword', 'confide'], 'name': 'terrakion', 'stats': {'hp': 91, 'attack': 129, 'defense': 90, 'special-attack': 72, 'special-defense': 90, 'speed': 108}, 'types': ['rock', 'fighting'], 'weight': 2600, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'gray', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'テラキオン', 'ko': '테라키온', 'zh-Hant': '代拉基翁', 'fr': 'Terrakium', 'de': 'Terrakium', 'es': 'Terrakion', 'it': 'Terrakion', 'en': 'Terrakion', 'ja': 'テラキオン', 'zh-Hans': '代拉基翁'}, 'genera': {'ja-Hrkt': 'がんくつポケモン', 'ko': '암굴포켓몬', 'zh-Hant': '岩窟寶可夢', 'fr': 'Pokémon Grotte', 'de': 'Felsenhöhle', 'es': 'Pokémon Gruta', 'it': 'Pokémon Caverna', 'en': 'Cavern Pokémon', 'ja': 'がんくつポケモン', 'zh-Hans': '岩窟宝可梦'}}
	public class SpecieTerrakion : PokemonSpecie
	{
#nullable enable
		private static SpecieTerrakion? _instance = null;
#nullable restore
        public static SpecieTerrakion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieTerrakion();
                }
                return _instance;
            }
        }

		public SpecieTerrakion() : base(
			"Terrakion",
			91, // HPs
			129, 90, // Attack & Defense
			72, 90, // Special Attack & Defense
			108			
		) {}
	}


	//Terrakion Pokemon Class
	public class Terrakion : Pokemon
	{

		public Terrakion(string nickname, int level)
		: base(
				639,
				SpecieTerrakion.Instance, // Pokemon Specie
				nickname, level,
				Rock.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Terrakion(int level)
		: base(
				639,
				SpecieTerrakion.Instance, // Pokemon Specie
				"Terrakion", level,
				Rock.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Terrakion() : base(
			639,
			SpecieTerrakion.Instance, // Pokemon Specie
			Rock.Instance, Fighting.Instance			
		) {}
	}
}