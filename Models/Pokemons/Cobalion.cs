using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Cobalion Specie to store common natural stats of every {'abilities': ['justified'], 'base_experience': 261, 'height': 21, 'id': 638, 'moves': ['swords-dance', 'cut', 'double-kick', 'take-down', 'leer', 'roar', 'hyper-beam', 'strength', 'thunder-wave', 'toxic', 'quick-attack', 'double-team', 'reflect', 'rest', 'substitute', 'snore', 'protect', 'sandstorm', 'false-swipe', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'metal-claw', 'hidden-power', 'psych-up', 'rock-smash', 'facade', 'taunt', 'helping-hand', 'superpower', 'secret-power', 'aerial-ace', 'iron-defense', 'block', 'bounce', 'calm-mind', 'metal-burst', 'close-combat', 'magnet-rise', 'rock-polish', 'poison-jab', 'x-scissor', 'focus-blast', 'giga-impact', 'zen-headbutt', 'flash-cannon', 'iron-head', 'stone-edge', 'stealth-rock', 'hone-claws', 'round', 'quick-guard', 'retaliate', 'volt-switch', 'work-up', 'sacred-sword', 'confide'], 'name': 'cobalion', 'stats': {'hp': 91, 'attack': 90, 'defense': 129, 'special-attack': 90, 'special-defense': 72, 'speed': 108}, 'types': ['steel', 'fighting'], 'weight': 2500, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'quadruped', 'habitat': None, 'generation': 'generation-v', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'コバルオン', 'ko': '코바르온', 'zh-Hant': '勾帕路翁', 'fr': 'Cobaltium', 'de': 'Kobalium', 'es': 'Cobalion', 'it': 'Cobalion', 'en': 'Cobalion', 'ja': 'コバルオン', 'zh-Hans': '勾帕路翁'}, 'genera': {'ja-Hrkt': 'てっしんポケモン', 'ko': '철심포켓몬', 'zh-Hant': '鐵心寶可夢', 'fr': 'Pokémon Cœur de Fer', 'de': 'Eisenkern', 'es': 'Pokémon Tesón Acero', 'it': 'Pokémon Metalcuore', 'en': 'Iron Will Pokémon', 'ja': 'てっしんポケモン', 'zh-Hans': '铁心宝可梦'}}
	public class SpecieCobalion : PokemonSpecie
	{
#nullable enable
		private static SpecieCobalion? _instance = null;
#nullable restore
        public static SpecieCobalion Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieCobalion();
                }
                return _instance;
            }
        }

		public SpecieCobalion() : base(
			"Cobalion",
			91, // HPs
			90, 129, // Attack & Defense
			90, 72, // Special Attack & Defense
			108			
		) {}
	}


	//Cobalion Pokemon Class
	public class Cobalion : Pokemon
	{

		public Cobalion(string nickname, int level)
		: base(
				638,
				SpecieCobalion.Instance, // Pokemon Specie
				nickname, level,
				Steel.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Cobalion() : base(
			638,
			SpecieCobalion.Instance, // Pokemon Specie
			Steel.Instance, Fighting.Instance			
		) {}
	}
}