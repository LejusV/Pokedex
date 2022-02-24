using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Absol Specie to store common natural stats of every {'abilities': ['pressure', 'super-luck', 'justified'], 'base_experience': 163, 'height': 12, 'id': 359, 'moves': ['scratch', 'razor-wind', 'swords-dance', 'cut', 'headbutt', 'body-slam', 'double-edge', 'leer', 'bite', 'flamethrower', 'ice-beam', 'blizzard', 'hyper-beam', 'counter', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'quick-attack', 'mimic', 'double-team', 'fire-blast', 'swift', 'dream-eater', 'flash', 'rest', 'rock-slide', 'slash', 'substitute', 'thief', 'nightmare', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'mud-slap', 'perish-song', 'icy-wind', 'detect', 'sandstorm', 'endure', 'false-swipe', 'swagger', 'fury-cutter', 'mean-look', 'attract', 'sleep-talk', 'return', 'frustration', 'megahorn', 'baton-pass', 'pursuit', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'rock-smash', 'hail', 'torment', 'will-o-wisp', 'facade', 'taunt', 'role-play', 'superpower', 'magic-coat', 'knock-off', 'snatch', 'secret-power', 'rock-tomb', 'aerial-ace', 'bounce', 'calm-mind', 'shock-wave', 'water-pulse', 'natural-gift', 'feint', 'payback', 'assurance', 'me-first', 'punishment', 'sucker-punch', 'dark-pulse', 'night-slash', 'x-scissor', 'giga-impact', 'shadow-claw', 'psycho-cut', 'zen-headbutt', 'stone-edge', 'captivate', 'charge-beam', 'hone-claws', 'foul-play', 'round', 'echoed-voice', 'hex', 'incinerate', 'retaliate', 'snarl', 'play-rough', 'confide', 'brutal-swing'], 'name': 'absol', 'stats': {'hp': 65, 'attack': 130, 'defense': 60, 'special-attack': 75, 'special-defense': 60, 'speed': 75}, 'types': ['dark'], 'weight': 470, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 25, 'gender_rate': 4, 'capture_rate': 30, 'color': 'white', 'shape': 'quadruped', 'habitat': 'mountain', 'generation': 'generation-iii', 'growth_rate': 'medium-slow', 'egg_groups': ['ground'], 'names': {'ja-Hrkt': 'アブソル', 'roomaji': 'Absol', 'ko': '앱솔', 'zh-Hant': '阿勃梭魯', 'fr': 'Absol', 'de': 'Absol', 'es': 'Absol', 'it': 'Absol', 'en': 'Absol', 'ja': 'アブソル', 'zh-Hans': '阿勃梭鲁'}, 'genera': {'ja-Hrkt': 'わざわいポケモン', 'ko': '재난포켓몬', 'zh-Hant': '災禍寶可夢', 'fr': 'Pokémon Désastre', 'de': 'Desaster', 'es': 'Pokémon Catástrofe', 'it': 'Pokémon Catastrofe', 'en': 'Disaster Pokémon', 'ja': 'わざわいポケモン', 'zh-Hans': '灾祸宝可梦'}}
	public class SpecieAbsol : PokemonSpecie
	{
#nullable enable
		private static SpecieAbsol? _instance = null;
#nullable restore
        public static SpecieAbsol Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAbsol();
                }
                return _instance;
            }
        }

		public SpecieAbsol() : base(
			"Absol",
			65, // HPs
			130, 60, // Attack & Defense
			75, 60, // Special Attack & Defense
			75			
		) {}
	}


	//Absol Pokemon Class
	public class Absol : Pokemon
	{

		public Absol(string nickname, int level)
		: base(
				359,
				SpecieAbsol.Instance, // Pokemon Specie
				nickname, level,
				Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Absol() : base(
			359,
			SpecieAbsol.Instance, // Pokemon Specie
			Dark.Instance			
		) {}
	}
}