using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Azelf Specie to store common natural stats of every {'abilities': ['levitate'], 'base_experience': 261, 'height': 3, 'id': 482, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'headbutt', 'flamethrower', 'hyper-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'confusion', 'psychic', 'double-team', 'light-screen', 'reflect', 'fire-blast', 'swift', 'dream-eater', 'flash', 'explosion', 'rest', 'substitute', 'snore', 'protect', 'mud-slap', 'detect', 'sandstorm', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'iron-tail', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'future-sight', 'uproar', 'torment', 'facade', 'taunt', 'helping-hand', 'trick', 'role-play', 'magic-coat', 'recycle', 'knock-off', 'skill-swap', 'imprison', 'secret-power', 'signal-beam', 'extrasensory', 'calm-mind', 'shock-wave', 'water-pulse', 'natural-gift', 'u-turn', 'payback', 'fling', 'last-resort', 'energy-ball', 'giga-impact', 'nasty-plot', 'zen-headbutt', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'magic-room', 'round', 'incinerate', 'acrobatics', 'confide', 'dazzling-gleam', 'power-up-punch'], 'name': 'azelf', 'stats': {'hp': 75, 'attack': 125, 'defense': 70, 'special-attack': 125, 'special-defense': 70, 'speed': 115}, 'types': ['psychic'], 'weight': 3, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'blue', 'shape': 'upright', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'アグノム', 'roomaji': 'Agnome', 'ko': '아그놈', 'zh-Hant': '亞克諾姆', 'fr': 'Créfadet', 'de': 'Tobutz', 'es': 'Azelf', 'it': 'Azelf', 'en': 'Azelf', 'ja': 'アグノム', 'zh-Hans': '亚克诺姆'}, 'genera': {'ja-Hrkt': 'いしポケモン', 'ko': '의지포켓몬', 'zh-Hant': '意志寶可夢', 'fr': 'Pokémon Volonté', 'de': 'Willenskraft', 'es': 'Pokémon Voluntad', 'it': 'Pokémon Volontà', 'en': 'Willpower Pokémon', 'ja': 'いしポケモン', 'zh-Hans': '意志宝可梦'}}
	public class SpecieAzelf : PokemonSpecie
	{
#nullable enable
		private static SpecieAzelf? _instance = null;
#nullable restore
        public static SpecieAzelf Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAzelf();
                }
                return _instance;
            }
        }

		public SpecieAzelf() : base(
			"Azelf",
			75, // HPs
			125, 70, // Attack & Defense
			125, 70, // Special Attack & Defense
			115			
		) {}
	}


	//Azelf Pokemon Class
	public class Azelf : Pokemon
	{

		public Azelf(string nickname, int level)
		: base(
				482,
				SpecieAzelf.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Azelf() : base(
			482,
			SpecieAzelf.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}