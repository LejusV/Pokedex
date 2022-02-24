using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Regigigas Specie to store common natural stats of every {'abilities': ['slow-start'], 'base_experience': 302, 'height': 37, 'id': 486, 'moves': ['mega-punch', 'fire-punch', 'ice-punch', 'thunder-punch', 'stomp', 'headbutt', 'hyper-beam', 'strength', 'thunderbolt', 'thunder-wave', 'thunder', 'earthquake', 'toxic', 'double-team', 'confuse-ray', 'dizzy-punch', 'rock-slide', 'substitute', 'snore', 'mud-slap', 'foresight', 'icy-wind', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'ancient-power', 'rock-smash', 'facade', 'focus-punch', 'nature-power', 'superpower', 'revenge', 'brick-break', 'knock-off', 'secret-power', 'rock-tomb', 'aerial-ace', 'block', 'shock-wave', 'gravity', 'natural-gift', 'payback', 'fling', 'rock-polish', 'drain-punch', 'focus-blast', 'earth-power', 'giga-impact', 'avalanche', 'zen-headbutt', 'rock-climb', 'iron-head', 'stone-edge', 'crush-grip', 'wide-guard', 'smack-down', 'heavy-slam', 'round', 'retaliate', 'bulldoze', 'confide', 'power-up-punch'], 'name': 'regigigas', 'stats': {'hp': 110, 'attack': 160, 'defense': 110, 'special-attack': 80, 'special-defense': 110, 'speed': 100}, 'types': ['normal'], 'weight': 4200, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'white', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-iv', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'レジギガス', 'roomaji': 'Regigigas', 'ko': '레지기가스', 'zh-Hant': '雷吉奇卡斯', 'fr': 'Regigigas', 'de': 'Regigigas', 'es': 'Regigigas', 'it': 'Regigigas', 'en': 'Regigigas', 'ja': 'レジギガス', 'zh-Hans': '雷吉奇卡斯'}, 'genera': {'ja-Hrkt': 'きょだいポケモン', 'ko': '거대포켓몬', 'zh-Hant': '巨大寶可夢', 'fr': 'Pokémon Prodigieux', 'de': 'Kolossal', 'es': 'Pokémon Colosal', 'it': 'Pokémon Colossale', 'en': 'Colossal Pokémon', 'ja': 'きょだいポケモン', 'zh-Hans': '巨大宝可梦'}}
	public class SpecieRegigigas : PokemonSpecie
	{
#nullable enable
		private static SpecieRegigigas? _instance = null;
#nullable restore
        public static SpecieRegigigas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieRegigigas();
                }
                return _instance;
            }
        }

		public SpecieRegigigas() : base(
			"Regigigas",
			110, // HPs
			160, 110, // Attack & Defense
			80, 110, // Special Attack & Defense
			100			
		) {}
	}


	//Regigigas Pokemon Class
	public class Regigigas : Pokemon
	{

		public Regigigas(string nickname, int level)
		: base(
				486,
				SpecieRegigigas.Instance, // Pokemon Specie
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Regigigas() : base(
			486,
			SpecieRegigigas.Instance, // Pokemon Specie
			Normal.Instance			
		) {}
	}
}