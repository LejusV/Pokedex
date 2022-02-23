using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Zapdos Specie to store common natural stats of every {'abilities': ['pressure', 'static'], 'base_experience': 261, 'height': 16, 'id': 145, 'moves': ['razor-wind', 'whirlwind', 'fly', 'take-down', 'double-edge', 'roar', 'hyper-beam', 'peck', 'drill-peck', 'thunder-shock', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'agility', 'rage', 'mimic', 'double-team', 'light-screen', 'reflect', 'bide', 'swift', 'sky-attack', 'flash', 'rest', 'substitute', 'snore', 'curse', 'protect', 'mud-slap', 'zap-cannon', 'detect', 'sandstorm', 'endure', 'swagger', 'steel-wing', 'sleep-talk', 'return', 'frustration', 'hidden-power', 'twister', 'rain-dance', 'sunny-day', 'ancient-power', 'rock-smash', 'heat-wave', 'facade', 'charge', 'secret-power', 'air-cutter', 'signal-beam', 'aerial-ace', 'shock-wave', 'roost', 'natural-gift', 'pluck', 'tailwind', 'u-turn', 'giga-impact', 'defog', 'discharge', 'charge-beam', 'ominous-wind', 'round', 'sky-drop', 'volt-switch', 'wild-charge', 'confide', 'magnetic-flux'], 'name': 'zapdos', 'stats': {'hp': 90, 'attack': 90, 'defense': 85, 'special-attack': 125, 'special-defense': 90, 'speed': 100}, 'types': ['electric', 'flying'], 'weight': 526, 'is_baby': False, 'is_legendary': True, 'is_mythical': False, 'hatch_counter': 80, 'gender_rate': -1, 'capture_rate': 3, 'color': 'yellow', 'shape': 'wings', 'habitat': 'rare', 'generation': 'generation-i', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'サンダー', 'roomaji': 'Thunder', 'ko': '썬더', 'zh-Hant': '閃電鳥', 'fr': 'Électhor', 'de': 'Zapdos', 'es': 'Zapdos', 'it': 'Zapdos', 'en': 'Zapdos', 'ja': 'サンダー', 'zh-Hans': '闪电鸟'}, 'genera': {'ja-Hrkt': 'でんげきポケモン', 'ko': '전기포켓몬', 'zh-Hant': '電擊寶可夢', 'fr': 'Pokémon Électrique', 'de': 'Elektro', 'es': 'Pokémon Eléctrico', 'it': 'Pokémon Elettrico', 'en': 'Electric Pokémon', 'ja': 'でんげきポケモン', 'zh-Hans': '电击宝可梦'}}
	public class SpecieZapdos : PokemonSpecie
	{
#nullable enable
		private static SpecieZapdos? _instance = null;
#nullable restore
        public static SpecieZapdos Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieZapdos();
                }
                return _instance;
            }
        }

		public SpecieZapdos() : base(
			"Zapdos",
			90, // HPs
			90, 85, // Attack & Defense
			125, 90, // Special Attack & Defense
			100			
		) {}
	}


	//Zapdos Pokemon Class
	public class Zapdos : Pokemon
	{

		public Zapdos(string nickname, int level) : base(
			145,
			SpecieZapdos.Instance, // Pokemon Specie
			nickname, level,
			Electric.Instance, Flying.Instance			
		) {}

		public Zapdos() : base(
			145,
			SpecieZapdos.Instance, // Pokemon Specie
			Electric.Instance, Flying.Instance			
		) {}
	}
}