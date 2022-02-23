using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Virizion Specie to store common natural stats of every {'abilities': ['justified'], 'base_experience': 261, 'height': 20, 'id': 640, 'moves': ['swords-dance', 'cut', 'double-kick', 'take-down', 'leer', 'roar', 'hyper-beam', 'strength', 'solar-beam', 'toxic', 'quick-attack', 'double-team', 'light-screen', 'reflect', 'flash', 'rest', 'substitute', 'snore', 'protect', 'giga-drain', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'synthesis', 'hidden-power', 'sunny-day', 'psych-up', 'rock-smash', 'facade', 'nature-power', 'taunt', 'helping-hand', 'superpower', 'secret-power', 'aerial-ace', 'block', 'bounce', 'magical-leaf', 'calm-mind', 'leaf-blade', 'close-combat', 'worry-seed', 'seed-bomb', 'x-scissor', 'focus-blast', 'energy-ball', 'giga-impact', 'zen-headbutt', 'stone-edge', 'grass-knot', 'round', 'quick-guard', 'retaliate', 'work-up', 'sacred-sword', 'confide'], 'name': 'virizion', 'stats': {'hp': 91, 'attack': 90, 'defense': 72, 'special-attack': 90, 'special-defense': 129, 'speed': 108}, 'types': ['grass', 'fighting'], 'weight': 2000, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'green', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'ビリジオン', 'ko': '비리디온', 'zh-Hant': '畢力吉翁', 'fr': 'Viridium', 'de': 'Viridium', 'es': 'Virizion', 'it': 'Virizion', 'en': 'Virizion', 'ja': 'ビリジオン', 'zh-Hans': '毕力吉翁'}, 'genera': {'ja-Hrkt': 'そうげんポケモン', 'ko': '초원포켓몬', 'zh-Hant': '草原寶可夢', 'fr': 'Pokémon Plaine Verte', 'de': 'Wiese', 'es': 'Pokémon Prado', 'it': 'Pokémon Prateria', 'en': 'Grassland Pokémon', 'ja': 'そうげんポケモン', 'zh-Hans': '草原宝可梦'}}
	public class SpecieVirizion : PokemonSpecie
	{
#nullable enable
		private static SpecieVirizion? _instance = null;
#nullable restore
        public static SpecieVirizion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieVirizion();
                }
                return _instance;
            }
        }

		public SpecieVirizion() : base(
			"Virizion",
			91, // HPs
			90, 72, // Attack & Defense
			90, 129, // Special Attack & Defense
			108			
		) {}
	}


	//Virizion Pokemon Class
	public class Virizion : Pokemon
	{

		public Virizion(string nickname, int level) : base(
			640,
			SpecieVirizion.Instance, // Pokemon Specie
			nickname, level,
			Grass.Instance, Fighting.Instance			
		) {}

		public Virizion() : base(
			640,
			SpecieVirizion.Instance, // Pokemon Specie
			Grass.Instance, Fighting.Instance			
		) {}
	}
}